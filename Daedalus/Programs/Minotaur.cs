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
            if (minotaurMap.CreateBuffer(Hits, getPosition()))
            {
                Queue = minotaurMap.RoamTargets(getPosition());
            }

            if (Queue.Count > 0)
            {
                if (InRange(getPosition(), Queue[0], getRadius() / 2))
                {
                    Queue.RemoveAt(0);
                }
            }
            if (Queue.Count == 0)
            {
                Queue = minotaurMap.RoamTargets(getPosition());
            }

            if (Mode == Knossos.mapPenMode.Target)
            {
                Master_Bait = UserTarget;
            }
            else if (Queue.Count > 0)
            {
                Master_Bait = Queue[0];
            }
            else
            {
                if (Random.NextDouble() > 0.8)
                    Master_Bait = new PointF(getPosition().X + (float)((Random.NextDouble() - 0.5) * 2), getPosition().Y + (float)((Random.NextDouble() - 0.5) * 2));
            }

            AStarPaths = minotaurMap.Astar(getPosition(), Master_Bait);
            AStarPath = minotaurMap.AstarPath(AStarPaths);

            Color col = Map.HSL2RGB(Clock, 0.5, 0.5);

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
                            Type = Knossos.TargetPoint.DrawType.Square
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
                                ViewWidth = 1
                            });
                            LastPoint = node.Point;
                            node = node.parent;
                        }
                        i++;
                    }
                }
            }

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
                        Type = Knossos.TargetPoint.DrawType.Square
                    });
                }
                Map.AStarNode node = AStarPath;
                PointF LastPoint = AStarPath.Point;
                LastPointIndex = 0;
                while (node != null)
                {
                    if (Knossos.KnossosUI.Settings.Path_Show)
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
                            ViewWidth = 2
                        });
                    }
                    LastPoint = node.Point;
                    Map.AStarNode ParentNode = node;
                    int ParentCount = 0;
                    while (ParentNode != null && ParentCount < PathPortion.Length)
                    {
                        ParentCount++;
                        ParentNode = ParentNode.parent;
                    }
                    if (ParentCount > LastPointIndex)
                    {
                        LastPointIndex = ParentCount;
                    }
                    for (int i = 0; i < ParentCount; i++)
                    {
                        PathPortion[i] = node.Point;
                    }

                    node = node.parent;
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

            if (Knossos.KnossosUI.Settings.UserTarget_Show)
            {
                KnossosForm.AddPoint(new Knossos.TargetPoint()
                {
                    Point = minotaurMap.GetClosestPoint(UserTarget),
                    color = col,
                    Diameter = KnossosForm.Settings.Mino_Radius * (1.0f / (Clock + 1)),
                    Scale = true,
                    Type = Knossos.TargetPoint.DrawType.Cross
                });
                KnossosForm.AddPoint(new Knossos.TargetPoint()
                {
                    Point = minotaurMap.GetClosestPoint(UserTarget),
                    color = col,
                    Diameter = KnossosForm.Settings.Mino_Radius * (1.0f / (Clock + 1)),
                    Scale = true,
                    Type = Knossos.TargetPoint.DrawType.Square
                });
            }

            if (Knossos.KnossosUI.Settings.RoamTargets_Show && Queue.Count > 0)
            {
                KnossosForm.AddPoint(new Knossos.TargetPoint()
                {
                    Point = minotaurMap.GetClosestPoint(Queue[0]),
                    color = col,
                    Diameter = KnossosForm.Settings.Mino_Radius * (1.0f / (Clock + 1)),
                    Scale = true,
                    Type = Knossos.TargetPoint.DrawType.Diamond
                });
                for (int i = 1; i < Queue.Count; i++)
                {
                    Color col1 = Map.HSL2RGB((double)i / (double)AStarPaths.Count, 0.5, 0.5);
                    KnossosForm.AddPoint(new Knossos.TargetPoint()
                    {
                        Point = Queue[i],
                        color = col1,
                        Diameter = KnossosForm.Settings.Mino_Radius,
                        Scale = true,
                        Type = Knossos.TargetPoint.DrawType.Diamond
                    });
                }
            }

            MovePath();
        }

        private void MovePath()
        {
            if (FollowPath == null || RefreshLocation)
            {
                RefreshLocation = false;
                RemakePath();
            }
            if (setMasterTarget(FollowPath[CurrentPositionIndex], getRadius() / 3))
            {
                if (++CurrentPositionIndex >= FollowPath.Length)
                {
                    CurrentPositionIndex = FollowPath.Length - 1;
                    RemakePath();
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
                        Type = Knossos.TargetPoint.DrawType.Diamond
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
            if (xs1.Length >= 2)
            {
                // Use cubic interpolation to smooth the original data
                (double[] xs2, double[] ys2) = Cubic.InterpolateXY(xs1, ys1, LastPointIndex * 3);
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
                        Changed = true;
                    }
                }
            }
            if (Changed)
            {
                CurrentPositionIndex = 0;
                double Dist = double.MaxValue;
                double D = 0;
                for (int i = 0; i < FollowPath.Length; i++)
                {
                    D = DistSqr(FollowPath[i], getPosition());
                    if (D < Dist && i > CurrentPositionIndex)
                    {
                        CurrentPositionIndex = i;
                        Dist = D;
                    }
                }
            }
            return Changed;
        }

        public void ConstantUpdate()
        {
            minotaurMap.DisplayMap(getPosition(), (int)Knossos.KnossosUI.Settings.ObjectRadius_Show, (int)Knossos.KnossosUI.Settings.ChunkRadius_Show);
            KnossosForm.MinoRefresh();
            KnossosForm.MinoEndUpdate();

            Clock += Knossos.KnossosUI.DeltaTime * 0.05f;
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
                Type = Knossos.TargetPoint.DrawType.Diamond
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
        //master_bait
        public bool setMasterTarget(PointF masterTarget, float threshold)
        {
            if (InRange(masterTarget, Pos, threshold))
            { 
                return true;
            }
            Pos.X += (masterTarget.X - Pos.X) * Knossos.KnossosUI.Settings.Mino_Speed * Knossos.KnossosUI.DeltaTime;
            Pos.Y += (masterTarget.Y - Pos.Y) * Knossos.KnossosUI.Settings.Mino_Speed * Knossos.KnossosUI.DeltaTime;
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
