using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

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

        public string ExportMapData()
        {
            return minotaurMap.ExportMapData();
        }

        public void ImportMapData(string Data)
        {
            minotaurMap.ImportMapData(Data, getRadius() + Knossos.KnossosUI.Settings.ExpansionBias);
        }

        public void Update(Knossos.mapPenMode Mode, PointF Target)
        {
            if (LastRes != (int)Knossos.KnossosUI.Settings.RayCount)
            {
                CalculateRes();
                LastRes = (int)Knossos.KnossosUI.Settings.RayCount;
            }

            KnossosForm.WallDetectAngle(Pos, Angles, Knossos.KnossosUI.Settings.Mino_ViewDist, out List<Lclass.CollisionPoint> Hits);
            bool UpdatePath = true;
            if (minotaurMap.CreateBuffer(Hits, getPosition()))
            {
                UpdatePath = true;
            }
            else if (AStarPath != null)
            {
                if (InRange(Pos.X, AStarPath.Point.X, getRadius() / 2) && InRange(Pos.Y, AStarPath.Point.Y, getRadius() / 2))
                {
                    UpdatePath = true;
                }
            }

            if (UpdatePath)
            {
                if (Mode == Knossos.mapPenMode.Target)
                {
                    AStarPaths = minotaurMap.Astar(Pos, Target);
                    AStarPath = minotaurMap.AstarPath(AStarPaths, Target);
                }
            }

            if (AStarPaths != null)
            {
                int i = 0;
                foreach (Map.AStarNode item in AStarPaths)
                {
                    Color col = Map.HSL2RGB((double)i / (double)AStarPaths.Count, 0.5, 0.5);
                    Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
                    {
                        Point = item.Point,
                        color = col,
                        Diameter = KnossosForm.Settings.Mino_Radius / 2,
                        Scale = false,
                        Type = Knossos.TargetPoint.DrawType.Square
                    });
                    Map.AStarNode node = item.parent;
                    PointF LastPoint = item.Point;
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
                            ViewWidth = 1
                        });
                        LastPoint = node.Point;
                        node = node.parent;
                    }
                    i++;
                }
            }

            if (AStarPath != null)
            {
                Color col = Map.HSL2RGB(Clock, 0.5, 0.5);
                Clock += Knossos.KnossosUI.DeltaTime;
                if (Clock >= 1)
                {
                    Clock = 0;
                }
                Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
                {
                    Point = AStarPath.Point,
                    color = col,
                    Diameter = KnossosForm.Settings.Mino_Radius,
                    Scale = false,
                    Type = Knossos.TargetPoint.DrawType.Square
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
                        ViewWidth = 2
                    });
                    LastPoint = node.Point;
                    node = node.parent;
                }
            }
        }

        public void ConstantUpdate()
        {
            minotaurMap.DisplayMap(getPosition(), (int)Knossos.KnossosUI.Settings.ObjectRadius_Show, (int)Knossos.KnossosUI.Settings.ChunkRadius_Show);
            KnossosForm.MinoRefresh();
            KnossosForm.MinoEndUpdate();
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
            if (InRange(masterTarget.X, Pos.X, threshold) && InRange(masterTarget.Y, Pos.Y, threshold))
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
    }
}
