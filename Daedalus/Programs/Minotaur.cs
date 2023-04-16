using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Daedalus.Daedalus.Programs
{
    public class Minotaur
    {
        private Knossos KnossosForm;
        private PointF Pos;
        private float[] Angles;
        private int LastRes;

        private Map minotaurMap;
        private List<Map.AStarNode> AStarPaths;
        private Map.AStarNode AStarPath;
        private float Clock = 0;
        private float TimeLimit = 3;
        private float TimeAttempt = 0;
        private List<PointF> Queue = new List<PointF>();
        private PointF Master_Bait;
        private PointF UserTarget;
        private PointF[] PathPortion = new PointF[10];
        private PointF[] PastPathPortion = new PointF[10];
        private PointF[] FollowPath;
        private int LastPointIndex;
        private int CurrentPositionIndex = 0;
        private bool RefreshLocation = false;
        private Random Random = new Random();
        private Map.AStarNode CollapsedAStarPath;
        private PointF LastPosition;
        private bool Escaped = false;
        private bool GoalChange = false;

        public Minotaur(Knossos KnossosForm)
        {
            this.KnossosForm = KnossosForm;
            CalculateRes();
            minotaurMap = new Map(25);
        }

        public float getRadius()
        {
            return Knossos.KnossosUI.Settings.Mino_Radius;
        }

        public void WipeMemory()
        {
            minotaurMap.ClearMemory();
        }

        public void RefreshMap()
        {
            minotaurMap.RefreshChunks();
        }

        public PointF getPosition()
        {
            return Pos;
        }

        public void SetPosition(PointF Point)
        {
            Pos = Point;
        }
        
        public void setUserTarget(PointF Point)
        {
            UserTarget = Point;
        }

        public string ExportMapData()
        {
            return minotaurMap.ExportMapData();
        }

        public void ImportMapData(string Data)
        {
            minotaurMap.ImportMapData(Data, getRadius() + Knossos.KnossosUI.Settings.ExpansionBias);
        }

        public void Update(Knossos.mapPenMode Mode)
        {
            if (LastRes != (int)Knossos.KnossosUI.Settings.RayCount)
            {
                CalculateRes();
                LastRes = (int)Knossos.KnossosUI.Settings.RayCount;
            }
            
            KnossosForm.WallDetectAngle(Pos, Angles, Knossos.KnossosUI.Settings.Mino_ViewDist, out List<Lclass.CollisionPoint> Hits);
            bool ForceRefresh = minotaurMap.CreateBuffer(Hits, getPosition()) || GoalChange;// || Mode == Knossos.mapPenMode.Target;
            GoalChange = false;
            CalculateAStar(ForceRefresh);
            GrabPoints();
            DisplayData(Map.HSL2RGB(Clock, 0.5, 0.5), Mode);
            
            PostProcessTarget(Mode);

            if (AStarPath != null)
                MovePath(ForceRefresh);
        }

        private void CalculateAStar(bool ForceRefresh)
        {
            AStarPaths = minotaurMap.Astar(getPosition(), Master_Bait, getRadius() / 2, (int)Knossos.KnossosUI.Settings.AStar);
            CollapsedAStarPath = minotaurMap.AstarPath(AStarPaths, Knossos.KnossosUI.Settings.ExpansionBias / 2);
            if (CollapsedAStarPath == null)
                return;
            if (AStarPath == null)
                AStarPath = CollapsedAStarPath;
            if (ForceRefresh)
            {
                AStarPath = CollapsedAStarPath;
            }
        }

        private void PostProcessTarget(Knossos.mapPenMode Mode)
        {
            if (Mode == Knossos.mapPenMode.Target)
            {
                SetMaster(UserTarget);
            }
            else if (Queue.Count > 0 && AStarPath != null)
            {
                SetMaster(Queue[0]);

                if (TimeAttempt >= TimeLimit || InRange(getPosition(), Master_Bait, getRadius()))
                {
                    Queue.RemoveAt(0);
                    TimeAttempt = 0;
                }
            }
            else
            {
                if (TimeAttempt >= TimeLimit)
                {
                    Master_Bait = new PointF(getPosition().X + (float)((Random.NextDouble() - 0.5) * getRadius() * 2), getPosition().Y + (float)((Random.NextDouble() - 0.5) * getRadius() * 2));
                    Queue = minotaurMap.RoamTargets(getPosition());
                }
            }

            if (minotaurMap.InsideWall(getPosition(), 2))
            {
                Escaped = true;
            }

            if (Escaped)
            {
                PointF FallBack = minotaurMap.GetClosestPoint(getPosition(), 0);
                if (!InRange(getPosition(), FallBack, getRadius()))
                {
                    SetMaster(FallBack);
                }
                else
                {
                    Escaped = false;
                }
            }

            if (TimeAttempt >= TimeLimit)
            {
                TimeAttempt = 0;
            }
        }

        private void SetMaster(PointF Bait)
        {
            /*
            double CurrentDist = DistSqr(Master_Bait, getPosition());
            double NewDist = DistSqr(Bait, getPosition());

            double Closest = Math.Min(CurrentDist, NewDist);
            double Furthest = Math.Max(CurrentDist, NewDist);

            double Pick = 0;
            double TooClose = getRadius() * 1.1;
            if (Closest < TooClose)
            {
                Pick = Furthest;
            }
            else if (Closest > TooClose)
            {
                Pick = Closest;
            }
            */
            if (Bait != Master_Bait)
            {
                Master_Bait = Bait;
                GoalChange = true;
            }
            //Master_Bait = Pick == CurrentDist ? Master_Bait : Bait;
        }

        private bool IsStanding()
        {
            if (InRange(getPosition(), LastPosition, getRadius() / 2))
                return true;
            LastPosition = getPosition();
            return false;
        }

        private void GrabPoints()
        {
            if (AStarPath != null)
            {
                Map.AStarNode node = AStarPath;
                LastPointIndex = 0;
                while (node != null)
                {
                    Map.AStarNode ParentNode = node;
                    int IndexCount = 0;
                    while (ParentNode != null && IndexCount < PathPortion.Length)
                    {
                        IndexCount++;
                        ParentNode = ParentNode.parent;
                    }
                    if (IndexCount > LastPointIndex)
                    {
                        LastPointIndex = IndexCount;
                    }
                    for (int i = 0; i < IndexCount; i++)
                    {
                        PathPortion[i] = node.Point;
                    }

                    node = node.parent;
                }
            }
            else
            {
                for (int i = 0; i < PathPortion.Length; i++)
                {
                    PathPortion[i] = getPosition();
                }
            }

            for (int i = 0; i < PathPortion.Length; i++)
            {
                if (!InRange(PathPortion[i], PastPathPortion[i], getRadius()))
                {
                    PastPathPortion[i] = PathPortion[i];
                    RefreshLocation = true;
                }
            }
        }

        private void DisplayData(Color col, Knossos.mapPenMode Mode)
        {

            if (AStarPath != null)
            {
                if (Knossos.KnossosUI.Settings.Path_Show)
                {
                    Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
                    {
                        Point = AStarPath.Point,
                        color = col,
                        Diameter = KnossosForm.Settings.Mino_Radius,
                        Scale = false,
                        Type = Knossos.TargetPoint.DrawType.Square,
                        DisplayWindow = Knossos.Window.Map
                    });

                    Map.AStarNode node = AStarPath.parent;
                    PointF LastPoint = AStarPath.Point;

                    while (node != null)
                    {
                        Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                        {
                            color = col,
                            Line = new Lclass.Line()
                            {
                                P1 = node.Point,
                                P2 = LastPoint
                            },
                            Type = Knossos.TargetLine.DrawType.Solid,
                            ViewWidth = 2,
                            DisplayWindow = Knossos.Window.Map
                        });
                        LastPoint = node.Point;
                        node = node.parent;
                    }
                }
            }

            if (Knossos.KnossosUI.Settings.Path_Show)
            {
                if (AStarPaths != null)
                {
                    int i = 0;
                    foreach (Map.AStarNode item in AStarPaths)
                    {
                        Color col1 = Map.HSL2RGB((double)i / (double)AStarPaths.Count, 0.5, 0.5);
                        Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
                        {
                            Point = item.Point,
                            color = col1,
                            Diameter = KnossosForm.Settings.Mino_Radius / 2,
                            Scale = true,
                            Type = Knossos.TargetPoint.DrawType.Square,
                            DisplayWindow = Knossos.Window.Map
                        });
                        Map.AStarNode node = item.parent;
                        PointF LastPoint = item.Point;
                        while (node != null)
                        {
                            Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                            {
                                color = col1,
                                Line = new Lclass.Line()
                                {
                                    P1 = node.Point,
                                    P2 = LastPoint
                                },
                                Type = Knossos.TargetLine.DrawType.Solid,
                                ViewWidth = 1,
                                DisplayWindow = Knossos.Window.Map
                            });
                            LastPoint = node.Point;
                            node = node.parent;
                        }
                        i++;
                    }
                }
            }

            if (Queue != null)
            {
                if (Knossos.KnossosUI.Settings.RoamTargets_Show && Queue.Count > 0 && Mode == Knossos.mapPenMode.Roam)
                {
                    for (int i = 1; i < Queue.Count; i++)
                    {
                        Color col1 = Map.HSL2RGB((double)i / (double)AStarPaths.Count, 0.5, 0.5);
                        KnossosForm.AddPoint(new Knossos.TargetPoint()
                        {
                            Point = Queue[i],
                            color = col1,
                            Diameter = KnossosForm.Settings.Mino_Radius,
                            Scale = true,
                            Type = Knossos.TargetPoint.DrawType.Diamond,
                            DisplayWindow = Knossos.Window.Map
                        });
                    }
                }
            }

            KnossosForm.AddPoint(new Knossos.TargetPoint()
            {
                Point = Master_Bait,
                color = col,
                Diameter = KnossosForm.Settings.Mino_Radius * (1.0f / (Clock + 1)),
                Scale = true,
                Type = Knossos.TargetPoint.DrawType.Cross,
                DisplayWindow = Knossos.Window.Map
            });
            KnossosForm.AddPoint(new Knossos.TargetPoint()
            {
                Point = Master_Bait,
                color = col,
                Diameter = KnossosForm.Settings.Mino_Radius * (1.0f / (Clock + 1)),
                Scale = true,
                Type = Knossos.TargetPoint.DrawType.Square,
                DisplayWindow = Knossos.Window.Map
            });
        }

        private void MovePath(bool ForceRefresh)
        {
            if (FollowPath == null || RefreshLocation || ForceRefresh)
            {
                RefreshLocation = false;
                RemakePath();
            }
            if (FollowPath != null)
            {
                if (setMasterTarget(FollowPath[CurrentPositionIndex], getRadius() / 2))
                {
                    if (++CurrentPositionIndex >= FollowPath.Length)
                    {
                        CurrentPositionIndex = FollowPath.Length - 1;
                        AStarPath = CollapsedAStarPath;
                        RemakePath();
                    }
                }
            }

            if (Knossos.KnossosUI.Settings.Path_Show)
            {
                for (int i = 0; i < FollowPath.Length; i++)
                {
                    KnossosForm.AddPoint(new Knossos.TargetPoint()
                    {
                        Point = FollowPath[i],
                        color = Color.GreenYellow,
                        Diameter = KnossosForm.Settings.Mino_Radius / 2,
                        Scale = true,
                        Type = Knossos.TargetPoint.DrawType.Diamond,
                        DisplayWindow = Knossos.Window.Map
                    });
                }
            }
        }

        private bool RemakePath()
        {
            int Length = LastPointIndex;
            double[] xs1 = new double[Length];
            double[] ys1 = new double[Length];
            for (int i = 0; i < Length; i++)
            {
                PointF Point = PathPortion[i];
                xs1[i] = Point.X;
                ys1[i] = Point.Y;
            }
            bool Changed = false;
            PointF CurrentPoint = PointF.Empty;
            if (FollowPath != null)
            {
                CurrentPoint = FollowPath[CurrentPositionIndex];
            }
            if (xs1.Length >= 3)
            {
                // Use cubic interpolation to smooth the original data
                (double[] xs2, double[] ys2) = Cubic.InterpolateXY(xs1, ys1, LastPointIndex + (int)Knossos.KnossosUI.Settings.PathSmoothing);
                if (FollowPath == null)
                    FollowPath = new PointF[xs2.Length];
                if (FollowPath.Length != xs2.Length)
                    FollowPath = new PointF[xs2.Length];
                for (int i = 0; i < FollowPath.Length; i++)
                {
                    PointF NewPoint = new PointF((float)xs2[i], (float)ys2[i]);
                    if (!FollowPath[i].Equals(NewPoint))
                    {
                        FollowPath[i] = NewPoint;
                    }
                }
            }
            else
            {
                if (FollowPath == null)
                    FollowPath = new PointF[xs1.Length];
                if (FollowPath.Length != xs1.Length)
                    FollowPath = new PointF[xs1.Length];
                for (int i = 0; i < FollowPath.Length; i++)
                {
                    PointF NewPoint = new PointF((float)xs1[i], (float)ys1[i]);
                    if (!FollowPath[i].Equals(NewPoint))
                    {
                        FollowPath[i] = NewPoint;
                    }
                }
            }

            if (CurrentPositionIndex >= FollowPath.Length)
            {
                Changed = true;
            }
            else
            {
                Changed = FollowPath[CurrentPositionIndex] != CurrentPoint;
            }

            if (Changed)
            {
                CurrentPositionIndex = 0;
                double Dist = double.MaxValue;
                double D = 0;
                for (int i = 1; i < FollowPath.Length; i++)
                {
                    D = DistSqr(midpoint(FollowPath[i], FollowPath[i - 1]), getPosition());
                    if (D < Dist)
                    {
                        CurrentPositionIndex = i;
                        Dist = D;
                    }
                }
            }

            return Changed;
        }

        private PointF midpoint(PointF A, PointF B)
        {
            PointF ret = new PointF();
            ret.X = (A.X + B.X) / 2;
            ret.Y = (A.Y + B.Y) / 2;
            return ret;
        }

        public void ConstantUpdate()
        {
            minotaurMap.DisplayMap(getPosition(), (int)Knossos.KnossosUI.Settings.ObjectRadius_Show, (int)Knossos.KnossosUI.Settings.ChunkRadius_Show);
            KnossosForm.MinoRefresh();
            KnossosForm.MinoEndUpdate();

            Clock += Knossos.KnossosUI.DeltaTime * 0.05f;
            if (IsStanding())
                TimeAttempt += Knossos.KnossosUI.DeltaTime;
            else
                TimeAttempt = 0;

            if (Clock >= 1)
            {
                Clock = 0;
            }

            Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
            {
                Point = UserTarget,
                color = Knossos.KnossosUI.Settings.Mino_Color,
                Scale = false,
                Diameter = Knossos.KnossosUI.Settings.Mino_Radius * (1.0f / (Clock + 1)),
                Type = Knossos.TargetPoint.DrawType.Diamond,
                DisplayWindow = Knossos.Window.Both
            });
        }

        private void CalculateRes()
        {
            Angles = new float[(int)Knossos.KnossosUI.Settings.RayCount + 1];
            for (int i = 0; i <= (int)Knossos.KnossosUI.Settings.RayCount; i++)
            {
                Angles[i] = ((float)i / (int)Knossos.KnossosUI.Settings.RayCount) * 360;
            }
        }
        
        public bool setMasterTarget(PointF masterTarget, float threshold)
        {
            if (InRange(masterTarget, Pos, threshold))
            { 
                return true;
            }
            PointF Direction = new PointF((masterTarget.X - Pos.X), (masterTarget.Y - Pos.Y));
            float distance = (float)Math.Sqrt(Math.Pow((Direction.X), 2) + Math.Pow((Direction.Y), 2));
            
            float Xc = (Direction.X / distance) * Knossos.KnossosUI.Settings.Mino_Speed * Knossos.KnossosUI.DeltaTime;
            float Yc = (Direction.Y / distance) * Knossos.KnossosUI.Settings.Mino_Speed * Knossos.KnossosUI.DeltaTime;

            Pos.X += Xc;
            Pos.Y += Yc;

            return false;
        }

        private bool InRange(float Val1, float Val2, float Thres)
        {
            return MathF.Abs(Val1 - Val2) <= Thres;
        }

        private bool InRange(PointF Val1, PointF Val2, float Thres)
        {
            return InRange(Val1.X, Val2.X, Thres) && InRange(Val1.Y, Val2.Y, Thres);
        }

        private double DistSqr(PointF P1, PointF P2)
        {
            float num = P1.X - P2.X;
            float num2 = P1.Y - P2.Y;
            return (num * num + num2 * num2);
        }
    }
}
