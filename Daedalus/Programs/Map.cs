using Daedalus;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using static Lclass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Clipper2Lib;
using System.Runtime.CompilerServices;

public class Map
{
    private float brickWidth { get { return Knossos.KnossosUI.Settings.Mino_Radius + (2 * Knossos.KnossosUI.Settings.ExpansionBias); } }
    private List<Lclass.Brick> bricks = new List<Lclass.Brick>();
    private Dictionary<PointF, List<Lclass.Brick>> Sortedbricks = new Dictionary<PointF, List<Lclass.Brick>>();
    private Dictionary<PointF, PathsD> Sortedchunks = new Dictionary<PointF, PathsD>();
    private Dictionary<PointF, PathsD> Sortedwalls = new Dictionary<PointF, PathsD>();
    private bool CanClear = false;
    private bool Clear = false;
    private bool ClearChunks = false;
    public bool ClearMem = false;
    private double[] AngleOffset = new double[10];
    private double ScanSpeed = 1;
    public bool ForceRefresh = false;
    private bool CanSort = true;
    private bool RefreshSort = false;
    private bool IsDrawing = false;
    private int CurrentSweep = 0;
    private double Clock = 0;
    private float GridSize { get { return Knossos.KnossosUI.Settings.GridRadius; } }
    private const float MaxSlopeDiff = 0.5f;

    public Map(double ScanSpeed = 1)
    {
        this.ScanSpeed = ScanSpeed;

        for (int i = 0; i < AngleOffset.Length; i++)
        {
            AngleOffset[i] = ((float)i / AngleOffset.Length) * 360.0f;
        }
    }

    public string ExportMapData()
    {
        string output = "";
        foreach (List<Lclass.Brick> Group in Sortedbricks.Values)
        {
            foreach (Lclass.Brick brick in Group)
            {
                if (brick.Length() != 0)
                    output += brick.P1.X + "/" + brick.P1.Y + "#" + brick.P2.X + "/" + brick.P2.Y + "#" + brick.Width + "___";
            }
        }
        output += ";";
        foreach (PointF Point in Sortedchunks.Keys)
        {
            output += Point.X + "|" + Point.Y + "|";
        }
        return output;
    }

    public void ImportMapData(string Data, float Diameter)
    {
        bricks.Clear();
        string[] Sections = Data.Split(';');

        string[] delimeters = { "___", "#", "/" };
        string[] coordinates = Sections[0].Split(delimeters, StringSplitOptions.None);

        // Four coordinates per line
        float x1, y1, x2, y2, width;
        for (int i = 0; i < coordinates.Length - 4; i += 5)
        {
            x1 = float.Parse(coordinates[i]);
            y1 = float.Parse(coordinates[i + 1]);
            x2 = float.Parse(coordinates[i + 2]);
            y2 = float.Parse(coordinates[i + 3]);
            width = float.Parse(coordinates[i + 4]);
            Lclass.Brick NewBrick = new Lclass.Brick() { P1 = new PointF(x1, y1), P2 = new PointF(x2, y2), Width = width };
            if (NewBrick.Length() != 0)
                bricks.Add(NewBrick);
        }

        if (Sections.Length >= 2)
        {
            PointF Coord;
            coordinates = Sections[1].Split('|', StringSplitOptions.None);
            for (int i = 0; i < coordinates.Length - 1; i += 2)
            {
                x1 = float.Parse(coordinates[i]);
                y1 = float.Parse(coordinates[i + 1]);
                Coord = new PointF(x1, y1);
                if (!Sortedchunks.ContainsKey(Coord))
                {
                    Sortedchunks.Add(Coord, ChunkShape(Coord));
                }
            }
        }

        if (CanSort)
            RefreshSortedBricks(Diameter);
        else
            RefreshSort = true;
        ForceRefresh = true;
        ClearMem = true;
    }
    
    private List<Lclass.Brick> GetBricksAt(List<PointF> GridCoords)
    {
        List<Lclass.Brick> Overlap = new List<Lclass.Brick>();
        foreach (PointF item in GridCoords)
        {
            if (Sortedbricks.ContainsKey(item))
            {
                for (int i = Sortedbricks[item].Count - 1; i >= 0; i--)
                {
                    if (!Overlap.Contains(Sortedbricks[item][i]))
                    {
                        Overlap.Add(Sortedbricks[item][i]);
                    }
                }
            }
        }
        return Overlap;
    }

    private List<PointF> AddBrick(Lclass.Brick item, float Diameter)
    {
        List<PointF> Coords = BrickCoords(item);
        bool Added = false;
        bool Same = false;
        bool NewRegions = true;
        item.AddRegions(Coords);
        PathsD WallPoly = new PathsD();
        Lclass.Line[] lines;
        while (NewRegions)
        {
            foreach (PointF Point in Coords)
            {
                if (Sortedbricks.ContainsKey(Point))
                {
                    /*
                    for (int i = Sortedbricks[Point].Count - 1; i >= 0 && !Added && !Same; i--)
                    {
                        Lclass.Brick Buff = (Sortedbricks[Point][i]);
                        if (Buff.P1 != item.P1 && Buff.P2 != item.P2)
                        {
                            if (SimilarSlope(Buff.getSlope(), item.getSlope(), MaxSlopeDiff))
                            {
                                if (LineDistance(Buff, item.P1) < brickWidth / 2 && LineDistance(Buff, item.P2) < brickWidth / 2)
                                {
                                    if (Encaps(Buff, item))
                                    {
                                        item.AddRegions(Buff.Regions);
                                        item.P1 = Buff.P1;
                                        item.P2 = Buff.P2;

                                        AddToChunkList(Sortedbricks, item, Buff, Point);

                                        Added = true;
                                    }
                                    else if (Encaps(item, Buff))
                                    {
                                        item.AddRegions(Buff.Regions);

                                        AddToChunkList(Sortedbricks, item, Buff, Point);

                                        Added = true;
                                    }
                                    else
                                    {
                                        if (Touching(Buff, item, out sledgeHammer.point Inner) || MinDistance(Buff, item) < Diameter)
                                        {
                                            Added = true;
                                            List<Lclass.Brick> NewGroup = new List<Lclass.Brick>();
                                            NewGroup.Add(item);
                                            NewGroup.Add(Sortedbricks[Point][i]);
                                            Lclass.Brick NewBuff = MaxDist(NewGroup);

                                            if (BrickCoords(NewBuff).Contains(Point))
                                            {
                                                item.AddRegions(Buff.Regions);
                                                item.P1 = NewBuff.P1;
                                                item.P2 = NewBuff.P2;

                                                AddToChunkList(Sortedbricks, item, Buff, Point);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Same = true;
                            Added = false;
                        }
                    }
                    */
                    item.AddRegion(Point);
                    if (!Sortedbricks[Point].Contains(item))
                        Sortedbricks[Point].Add(item);
                    Added = true;
                }
                else
                {
                    List<Lclass.Brick> Collection = new List<Lclass.Brick>();
                    item.AddRegion(Point);
                    Collection.Add(item);
                    Sortedbricks.Add(Point, Collection);
                }

                lines = item.GenerateRec();
                if (lines.Length == 0)
                    continue;
                // Adding brick to empty brick polygon
                WallPoly.Add(Clipper.MakePath(new double[] { lines[0].P1.X, lines[0].P1.Y,
                                                                     lines[0].P2.X, lines[0].P2.Y,
                                                                     lines[1].P2.X, lines[1].P2.Y,
                                                                     lines[1].P1.X, lines[1].P1.Y}));

                if (Sortedwalls.ContainsKey(Point))
                {
                    Sortedwalls[Point] = Clipper.BooleanOp(ClipType.Union, Sortedwalls[Point], WallPoly, FillRule.NonZero);
                }
                else
                {
                    Sortedwalls.Add(Point, new PathsD(WallPoly));
                }
                WallPoly.Clear();
                Sortedwalls[Point] = Clipper.BooleanOp(ClipType.Intersection, Sortedwalls[Point], ChunkShape(Point), FillRule.NonZero);
            }
            if (item.Regions.Count != Coords.Count)
            {
                Coords = item.Regions;
            }
            else
            {
                NewRegions = false;
            }
        }
        return Coords;
    }

    private void AddToChunkList(Dictionary<PointF, List<Lclass.Brick>> Collection, Lclass.Brick item, Lclass.Brick Buff, PointF Point)
    {
        Collection[Point].Add(item);
        List<Lclass.Brick> Collections = new List<Lclass.Brick>(Collection[Point]);
        foreach (Lclass.Brick Brick in Collections)
        {
            item.AddRegions(Brick.AddToParent(item, ref Sortedbricks));
            Brick.RemoveFromParent(ref Sortedbricks);
        }
        foreach (PointF Regions in item.Regions)
        {
            if (Collection.ContainsKey(Regions))
            {
                if (!Collection[Regions].Contains(item))
                    Collection[Regions].Add(item);
            }
            else
            {
                List<Lclass.Brick> Group = new List<Lclass.Brick>();
                item.AddRegion(Regions);
                Group.Add(item);
                Collection.Add(Regions, Group);
            }
        }
        Collection[Point].Remove(Buff);
    }

    private bool Encaps(Lclass.Brick Outter, Lclass.Brick Inner)
    {
        float P1 = PointDistanceToLine(Outter, Inner.P1);
        float P2 = PointDistanceToLine(Outter, Inner.P2);

        return P1 != float.MaxValue && P2 != float.MaxValue;
    }

    private bool Touching(Lclass.Brick Outter, Lclass.Brick Inner, out sledgeHammer.point InnerPoint)
    {
        float P1 = PointDistanceToLine(Outter, Inner.P1);
        float P2 = PointDistanceToLine(Outter, Inner.P2);

        bool P1In = P1 != float.MaxValue;
        bool P2In = P2 != float.MaxValue;

        if (P1In && P2In)
            InnerPoint = sledgeHammer.point.both;
        else if (P1In)
            InnerPoint = sledgeHammer.point.p1;
        else
            InnerPoint = sledgeHammer.point.p2;

        return P1In ^ P2In;
    }

    private List<PointF> RemoveBrick(Lclass.Brick Brick, float Diameter)
    {
        List<PointF> Coords = BrickCoords(Brick);
        List<PointF> removed = new List<PointF>(Coords);
        bool Del = true;
        PathsD WallPoly = new PathsD();
        Lclass.Line[] lines;

        foreach (PointF Point in Coords)
        {
            lines = Brick.GenerateRec();
            if (lines.Length != 0)
            {
                // Adding brick to empty brick polygon
                WallPoly.Add(Clipper.MakePath(new double[] { lines[0].P1.X, lines[0].P1.Y,
                                                                     lines[0].P2.X, lines[0].P2.Y,
                                                                     lines[1].P2.X, lines[1].P2.Y,
                                                                     lines[1].P1.X, lines[1].P1.Y}));

                if (Sortedwalls.ContainsKey(Point))
                {
                    Sortedwalls[Point] = Clipper.BooleanOp(ClipType.Difference, Sortedwalls[Point], WallPoly, FillRule.NonZero);
                    if (Sortedwalls[Point].Count != 0)
                    {
                        bool Empty = true;
                        foreach (PathD item in Sortedwalls[Point])
                        {
                            if (item.Count != 0)
                            {
                                Empty = false;
                                break;
                            }
                        }

                        if (!Empty)
                        {
                            for (int i = Sortedbricks[Point].Count - 1; i >= 0; i--)
                            {
                                WallPoly.Clear();
                                lines = Sortedbricks[Point][i].GenerateRec();
                                if (lines.Length > 0)
                                {
                                    WallPoly.Add(Clipper.MakePath(new double[] { lines[0].P1.X, lines[0].P1.Y,
                                                                     lines[0].P2.X, lines[0].P2.Y,
                                                                     lines[1].P2.X, lines[1].P2.Y,
                                                                     lines[1].P1.X, lines[1].P1.Y}));
                                    PathsD Overlap = Clipper.BooleanOp(ClipType.Intersection, WallPoly, Sortedwalls[Point], FillRule.NonZero);
                                    if (Overlap.Count == 0)
                                    {
                                        Sortedbricks[Point].RemoveAt(i);
                                    }
                                }
                                else
                                {
                                    Sortedbricks[Point].RemoveAt(i);
                                }
                            }
                        }
                        else
                        {
                            Sortedbricks[Point].Clear();
                        }
                    }
                    else
                    {
                        if (Sortedbricks.ContainsKey(Point))
                            Sortedbricks[Point].Clear();
                    }
                }
                WallPoly.Clear();
            }
        }
        
        return removed;
    }

    private List<PointF> RemoveBuffers(ref List<Lclass.Brick> Buffers)
    {
        List<PointF> removed = new List<PointF>();
        List<PointF> BrickCoord = new List<PointF>();
        PathsD WallPoly = new PathsD();
        Lclass.Line[] lines;

        foreach (Lclass.Brick item in Buffers)
        {
            BrickCoord.Clear();
            BrickCoord.AddRange(item.Regions);
            BrickCoord.AddRange(BrickCoords(item));
            lines = item.GenerateRec();
            if (lines.Length != 0)
            {
                WallPoly.Clear();
                WallPoly.Add(Clipper.MakePath(new double[] { lines[0].P1.X, lines[0].P1.Y,
                                                                     lines[0].P2.X, lines[0].P2.Y,
                                                                     lines[1].P2.X, lines[1].P2.Y,
                                                                     lines[1].P1.X, lines[1].P1.Y}));
                foreach (PointF Point in BrickCoord)
                {
                    Sortedwalls[Point] = Clipper.BooleanOp(ClipType.Difference, Sortedwalls[Point], WallPoly, FillRule.NonZero);
                }
            }

            removed.AddRange(BrickCoord);

            item.Width = 0;
            item.P1 = new PointF(0, 0);
            item.P2 = new PointF(0, 0);
        }
        return removed;
    }

    private void RefreshSortedBricks(float Diameter)
    {
        Sortedbricks.Clear();
        foreach (Lclass.Brick item in bricks)
        {
            AddBrick(item, Diameter);
        }
        List<PointF> items = Sortedbricks.Keys.ToList();
        Refresh(items);
        ForceRefresh = true;
    }

    private PointF Snap(PointF Point)
    {
        return new PointF(
            ((MathF.Floor((Point.X + (GridSize)) / (GridSize * 2))) * (GridSize * 2)),
            ((MathF.Floor((Point.Y + (GridSize)) / (GridSize * 2))) * (GridSize * 2))
            );
    }

    private List<PointF> SnapCoords(PointF Point, int Radius)
    {
        List<PointF> Coords = new List<PointF>();

        PointF Center = Snap(Point);

        for (int i = -Radius; i <= Radius; i++)
        {
            for (int j = -Radius; j <= Radius; j++)
            {
                Coords.Add(Snap(new PointF(Center.X - (GridSize * 2 * i), Center.Y - (GridSize * 2 * j))));
            }
        }

        return Coords;
    }

    private List<PointF> BrickCoords(Lclass.Line Wall)
    {
        List<PointF> GridCorrdinates = LineCoords(Wall.P1, Wall.P2);
        //return GridCorrdinates;
        foreach (Lclass.Line item in Wall.GenerateRec())
        {
            GridCorrdinates.AddRange(LineCoords(item.P1, item.P2));
        }
        return GridCorrdinates;
    }

    private List<PointF> LineCoords(PointF P1, PointF P2)
    {
        List<PointF> GridCorrdinates = new List<PointF>();

        // Raduis of chunk
        float Increment = (GridSize * 2);

        PointF mP1, mP2;
        mP1 = Snap(P1);
        mP2 = Snap(P2);
        
        float i, error, errorprev, ddy, ddx, loop;
        float a, b, astep, bstep, dda, ddb;
        float dx = (mP2.X - mP1.X) / Increment;
        float dy = (mP2.Y - mP1.Y) / Increment;
        GridCorrdinates.Add(mP1);

        float ystep = Math.Sign(dy) * Increment;
        float xstep = Math.Sign(dx) * Increment;
        dy = Math.Abs(dy);
        dx = Math.Abs(dx);
        ddy = 2 * dy;
        ddx = 2 * dx;
        bool ByX = ddx >= ddy;

        a = (ByX ? mP1.X : mP2.Y);
        b = (ByX ? mP1.Y : mP2.X);
        loop = errorprev = error = (ByX ? dx : dy);
        astep = (ByX ? xstep : ystep);
        bstep = (ByX ? ystep : xstep);
        dda = (ByX ? ddx : ddy);
        ddb = (ByX ? ddy : ddx);

        for (i = 0; i < loop; i++)
        {
            a += astep;
            error += ddb;
            if (error > dda)
            {
                b += bstep;
                error -= dda;
                if (error + errorprev < dda)
                    GridCorrdinates.Add(new PointF(a - (astep * (ByX ? 0 : 1)), b - (bstep * (ByX ? 1 : 0))));
                else if (error + errorprev > dda)
                    GridCorrdinates.Add(new PointF(a - (astep * (ByX ? 1 : 0)), b - (bstep * (ByX ? 0 : 1))));
                else
                {
                    GridCorrdinates.Add(new PointF(a - (astep * (ByX ? 0 : 1)), b - (bstep * (ByX ? 1 : 0))));
                    GridCorrdinates.Add(new PointF(a - (astep * (ByX ? 1 : 0)), b - (bstep * (ByX ? 0 : 1))));
                }
            }
            GridCorrdinates.Add(new PointF(a, b));
            errorprev = error;
        }

        return GridCorrdinates;
    }

    public void ClearMemory()
    {
        if (CanClear)
        {
            bricks.Clear();
            Sortedbricks.Clear();
            Sortedwalls.Clear();
            Sortedchunks.Clear();
        }
        else
            Clear = true;
        ClearMem = true;
    }

    public void RefreshChunks()
    {
        if (CanClear)
        {
            Sortedbricks.Clear();
            Sortedwalls.Clear();
            Sortedchunks.Clear();
        }
        else
            ClearChunks = true;
        ClearMem = true;
    }

    public bool CreateBuffer(List<Lclass.CollisionPoint> collisionPoints, PointF location, float Diameter)
    {

        // Sorting Points
        SortedDictionary<double, PointF> orderedList = new SortedDictionary<double, PointF>();
        SortedDictionary<double, PointF> uncollidedPoints = new SortedDictionary<double, PointF>();
        double angle;
        double Key;
        double MaxDist = double.MaxValue;
        for (int i = 0; i < collisionPoints.Count; i++)
        {
            angle = (getAngleRad(location, collisionPoints[i].Point));
            Key = (angle + AngleOffset[CurrentSweep]) % 360.0f;

            if (!collisionPoints[i].Hit)
            {
                if (!uncollidedPoints.ContainsKey(Key))
                {
                    if (MaxDist == double.MaxValue)
                        MaxDist = Math.Sqrt(DistSqr(collisionPoints[i].Point, location));
                    uncollidedPoints.Add(Key, collisionPoints[i].Point);
                }
                continue;
            }
            if (!orderedList.ContainsKey(Key))
            {
                orderedList.Add(Key, collisionPoints[i].Point);
                if (Knossos.KnossosUI.Settings.Collided_Show)
                {
                    Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
                    {
                        Point = collisionPoints[i].Point,
                        color = HSL2RGB(((angle + Clock) % 360.0f) / 360.0f, 0.5, 0.5),
                        Type = Knossos.TargetPoint.DrawType.Dot,
                        Diameter = 5
                    });
                }
                if (Knossos.KnossosUI.Settings.RayHit_Show)
                {
                    Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                    {
                        color = Knossos.KnossosUI.Settings.RayColor,
                        Line = new Line()
                        {
                            P1 = collisionPoints[i].Point,
                            P2 = location,
                            Width = 1
                        },
                        Type = Knossos.TargetLine.DrawType.Solid
                    });
                }
            }       
        }
        Clock += 0.1f;
        if (Clock > 360)
        {
            Clock = 0;
        }
        if (++CurrentSweep >= AngleOffset.Length)
        {
            CurrentSweep = 0;
        }

        AngleOffset[CurrentSweep] += ScanSpeed * (CurrentSweep % 2 == 0 ? 1 : -1);
        if (AngleOffset[CurrentSweep] > 360)
        {
            AngleOffset[CurrentSweep] = 0;
        }

        int index = 0;
        int prevIndex = 0;

        // Connecting points
        List<Lclass.Line> preBuffers = new List<Lclass.Line>();
        List<KeyValuePair<double, PointF>> currentPoints = orderedList.ToList();
        for (int i = 1; i < currentPoints.Count; i++)
        {
            prevIndex = i - 1;
            index = i % currentPoints.Count;

            if (DistSqr(currentPoints[index].Value, currentPoints[prevIndex].Value) < Diameter)
            {
                preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex].Value, P2 = currentPoints[index].Value, Width = 2 });
            }
        }

        List<Lclass.Line> DeleteWalls = new List<Lclass.Line>();
        List<Lclass.Brick> DeleteBricks = new List<Lclass.Brick>();
        foreach (PointF item in uncollidedPoints.Values)
        {
            List<PointF> Regions = LineCoords(item, location);
            foreach (PointF Region in Regions)
            {
                if (Sortedbricks.ContainsKey(Region))
                {
                    foreach (Brick Barrier in Sortedbricks[Region])
                    {
                        PointF Ray = new PointF(item.X - location.X, item.Y - location.Y);
                        PointF WallLine = new PointF(Barrier.P2.X - Barrier.P1.X, Barrier.P2.Y - Barrier.P1.Y);
                        float t = (((Barrier.P1.X - location.X) * WallLine.Y) - ((Barrier.P1.Y - location.Y) * WallLine.X)) / (Ray.X * WallLine.Y - Ray.Y * WallLine.X);
                        float u = (((location.X - Barrier.P1.X) * Ray.Y) - ((location.Y - Barrier.P1.Y) * Ray.X)) / (WallLine.X * Ray.Y - WallLine.Y * Ray.X);
                        if (u >= 0 && u <= 1 && t >= 0 && t <= 1)
                        {
                            if (t < 1)
                            {
                                DeleteBricks.Add(Barrier);
                                PointF DeletePoint = new PointF(Barrier.P1.X + ((Barrier.P2.X - Barrier.P1.X) * u), Barrier.P1.Y + ((Barrier.P2.Y - Barrier.P1.Y) * u));
                                DeleteWalls.Add(new Lclass.Line() { P1 = new PointF(DeletePoint.X + brickWidth * 1.5f, DeletePoint.Y), P2 = new PointF(DeletePoint.X - brickWidth * 1.5f, DeletePoint.Y), Width = brickWidth * 1.5f });
                                if (Knossos.KnossosUI.Settings.Uncollided_Show)
                                {
                                    Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
                                    {
                                        Point = DeletePoint,
                                        color = Knossos.KnossosUI.Settings.NonPointColor,
                                        Type = Knossos.TargetPoint.DrawType.Diamond,
                                        Diameter = 2.5f
                                    });
                                }
                                if (Knossos.KnossosUI.Settings.NonRayHit_Show)
                                {
                                    Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                                    {
                                        color = Knossos.KnossosUI.Settings.RayColor,
                                        Line = new Line()
                                        {
                                            P1 = DeletePoint,
                                            P2 = location,
                                            Width = 1
                                        },
                                        Type = Knossos.TargetLine.DrawType.Solid
                                    });
                                }
                            }
                        }
                    }
                }
            }
        }

        CanClear = false;
        List<PointF> NewData = new List<PointF>();
        bool Changed = ForceRefresh;
        if (!IsDrawing)
        {
            processPreBuffers(Diameter, preBuffers, ref NewData);
            processDeletion(Diameter, DeleteWalls, ref NewData);
            RemoveBuffers(ref DeleteBricks);
            if (NewData.Count > 0 || ForceRefresh)
            {
                Refresh(Changed ? Sortedbricks.Keys.ToList() : NewData);
                Changed |= true;
            }

            Refresh(new List<PointF>() { Snap(location) });
        }
        CanClear = true;

        if (Clear)
        {
            ClearMemory();
            Clear = false;
            Changed |= true;
        }
        ForceRefresh = false;
        return Changed;
    }

    public void DisplayMap(PointF Focus, int DisplayRadius, int UnRenderedRadius, float Diameter)
    {
        if (Clear)
        {
            ClearMemory();
            Clear = false;
        }

        CanClear = false;

        if (RefreshSort || ClearChunks)
        {
            RefreshSort = false;
            ClearChunks = false;
            RefreshSortedBricks(Diameter);
        }

        CanSort = false;
        IsDrawing = true;
        PointF NewF = Snap(Focus);
        bool Covered = false;
        float I = 0;
        PointF[] Keys = Sortedchunks.Keys.ToArray();
        foreach (PointF item in Keys)
        {
            if (DistSqr(item, Focus) < Math.Pow((GridSize * (DisplayRadius)) + ((DisplayRadius * 2) * GridSize), 2))
            {
                foreach (PathD sections in Sortedchunks[item])
                {
                    for (int i = 1; i < sections.Count + 1; i++)
                    {
                        int CurrentIndex = i % sections.Count;
                        int LastIndex = i - 1;
                        PointF Current = new PointF((float)sections[CurrentIndex].x, (float)sections[CurrentIndex].y);
                        PointF Last = new PointF((float)sections[LastIndex].x, (float)sections[LastIndex].y);

                        Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                        {
                            color = Knossos.KnossosUI.Settings.Object_Color,
                            Line = new Line() { P1 = Current, P2 = Last, Width = 1 },
                            Type = Knossos.TargetLine.DrawType.Solid
                        });
                    }
                }

                if (Knossos.KnossosUI.Settings.Walls_Show && Sortedbricks.ContainsKey(item))
                {
                    foreach (Lclass.Brick Wall in Sortedbricks[item])
                    {
                        Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                        {
                            color = Knossos.KnossosUI.Settings.Wall_Color,
                            Line = Wall,
                            Type = Knossos.TargetLine.DrawType.Outline
                        });
                    }
                }
            }
            else if (DistSqr(item, Focus) < Math.Pow((GridSize * (DisplayRadius + UnRenderedRadius)) + ((DisplayRadius * 2) * GridSize), 2))
            {
                Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
                {
                    Point = item,
                    color = Knossos.KnossosUI.Settings.Chunk_Color,
                    Type = Knossos.TargetPoint.DrawType.Square,
                    Diameter = GridSize,
                    Scale = true
                });
            }

            if (item.X == NewF.X && item.Y == NewF.Y)
            {
                Covered = true;
            }
            I++;
        }
        if (!Covered)
        {
            Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
            {
                Point = NewF,
                color = Knossos.KnossosUI.Settings.Mino_Color,
                Type = Knossos.TargetPoint.DrawType.Square,
                Diameter = GridSize - (Sortedchunks.Count > 0 ? 10 : 0),
                Scale = true
            });
        }
        IsDrawing = false;
        CanClear = true;
        CanSort = true;
        ClearMem = false;
    }

    private struct sledgeHammer
    {
        public Lclass.Brick intersectingBrick;
        public enum point {p1, p2, both }
        public point ouioui;
        public PointF Target;

        public void setTarget (point Point, PointF Target)
        {
            this.Target = Target;
            ouioui = Point;
        }
    }

    private void processDeletion(float Diameter, List<Lclass.Line> preBuffers, ref List<PointF> Regions)
    {
        if (preBuffers.Count == 0)
        {
            return;
        }
        Regions.AddRange(RemoveBrick(new Lclass.Brick() { P1 = preBuffers[0].P1, P2 = preBuffers[0].P2, Width = brickWidth }, Diameter));
        preBuffers.RemoveAt(0);
        if (preBuffers.Count == 0)
        {
            return;
        }
        else
        {
            processDeletion(Diameter, preBuffers, ref Regions);
        }
    }

    private void processPreBuffers(float Diameter, List<Lclass.Line> preBuffers, ref List<PointF> Regions)
    {
        if (preBuffers.Count == 0)
        {
            return;
        }
        List<sledgeHammer> wreckingBall = new List<sledgeHammer>();

        bool FoundIntercection = false;
        foreach (Lclass.Brick item in GetBricksAt(BrickCoords(preBuffers[0])))
        {
            FoundIntercection = processIntersection(item, preBuffers[0],
            (sledgeHammer.point pull, PointF Outer) =>
            {
                wreckingBall.Add(new sledgeHammer()
                {
                    intersectingBrick = item,
                    ouioui = pull,
                    Target = Outer
                });
            });
            if (FoundIntercection)
                break;
        }

        //bool Changed = false;
        if (wreckingBall.Count == 0)
        {
            if (!FoundIntercection)
            {
                Regions.AddRange(AddBrick(new Lclass.Brick() { P1 = preBuffers[0].P1, P2 = preBuffers[0].P2, Width = brickWidth }, Diameter));
            }
        }
        else
        {
            Regions.AddRange(AddBrick(processBricks(wreckingBall), Diameter));
        }

        preBuffers.RemoveAt(0);
        if (preBuffers.Count == 0)
        {
            return;
        }
        else
        {
            processPreBuffers(Diameter, preBuffers, ref Regions);
        }
    }

    private Lclass.Brick processBricks(List<sledgeHammer> preBricks)
    {
        switch (preBricks[0].ouioui)
        {
            case sledgeHammer.point.p1:
                preBricks[0].intersectingBrick.P1 = preBricks[0].Target;
                break;
            case sledgeHammer.point.p2:
                preBricks[0].intersectingBrick.P2 = preBricks[0].Target;
                break;
            case sledgeHammer.point.both:
                break;
            default:
                break;
        }

        sledgeHammer CurrentBrick = preBricks[0];
        preBricks.RemoveAt(0);
        if(preBricks.Count == 0)
        {
            return CurrentBrick.intersectingBrick;
        }
        else
        {
            foreach (sledgeHammer item in preBricks)
            {
                processIntersection(item.intersectingBrick, CurrentBrick.intersectingBrick,
                (sledgeHammer.point pull, PointF Outer) =>
                {
                    item.setTarget(pull, Outer);
                });
            }
            return processBricks(preBricks);
        }
    }

    private delegate void IntersectionAction(sledgeHammer.point Point, PointF Target);

    private bool processIntersection(Lclass.Brick Object, Lclass.Line Subject, IntersectionAction action)
    {
        float point1 = PointDistanceToLine(Object, Subject.P1);
        float point2 = PointDistanceToLine(Object, Subject.P2);
        bool FoundIntercection = false;

        if (point1 != float.MaxValue || point2 != float.MaxValue)
        {
            FoundIntercection = true;
        }

        if (point1 != float.MaxValue ^ point2 != float.MaxValue)
        {
            sledgeHammer.point pull = sledgeHammer.point.both;

            PointF Inner = point1 != float.MaxValue ? Subject.P1 : Subject.P2;
            PointF Outer = point1 != float.MaxValue ? Subject.P2 : Subject.P1;

            double DistInner_1 = DistSqr(Inner, Object.P1);
            double DistInner_2 = DistSqr(Inner, Object.P2);

            if (DistInner_1 < DistInner_2)
            {
                pull = sledgeHammer.point.p1;
            }
            else if (DistInner_2 < DistInner_1)
            {
                pull = sledgeHammer.point.p2;
            }
            else
            {
                double DistOuter_1 = DistSqr(Outer, Object.P1);
                double DistOuter_2 = DistSqr(Outer, Object.P2);
                if (DistOuter_1 < DistOuter_2)
                {
                    pull = sledgeHammer.point.p1;
                }
                else if (DistOuter_2 < DistOuter_1)
                {
                    pull = sledgeHammer.point.p2;
                }
            }

            if (pull != sledgeHammer.point.both && SimilarSlope(Subject.getSlope(), Object.getSlope(), 0.1f) && action != null)
            {
                action(pull, Outer);
            }
        }
        return FoundIntercection;
    }

    private bool SimilarSlope(PointF Slope1, PointF Slope2, float Thres)
    {
        return (InRange(MathF.Abs(Slope1.X), MathF.Abs(Slope2.X), Thres)) && (InRange(MathF.Abs(Slope1.Y), MathF.Abs(Slope2.Y), Thres));
    }

    private PathsD ChunkShape(PointF item)
    {
        PathsD chunk = new PathsD();
        chunk.Add(Clipper.MakePath(new double[] { item.X + GridSize, item.Y + GridSize,
                                                  item.X + GridSize, item.Y - GridSize,
                                                  item.X - GridSize, item.Y - GridSize,
                                                  item.X - GridSize, item.Y + GridSize}));
        return chunk;
    }

    private void Refresh(List<PointF> RegionsChanged)
    {
        foreach (PointF item in RegionsChanged)
        {
            if (Sortedwalls.ContainsKey(item))
            {   // Create chunk to cut bricks out of
                PathsD chunk = Clipper.BooleanOp(ClipType.Difference, ChunkShape(item), Sortedwalls[item], FillRule.NonZero);
                if (!Sortedchunks.ContainsKey(item))
                {
                    Sortedchunks.Add(item, chunk);
                }
                else
                {
                    Sortedchunks[item] = chunk;
                }
            }
            else
            {
                Sortedwalls.Add(item, new PathsD());
                if (!Sortedchunks.ContainsKey(item))
                {
                    Sortedchunks.Add(item, ChunkShape(item));
                }
            }
        }
    }


    private Lclass.Brick MaxDist(List<Lclass.Brick> Group)
    {
        PointF Max = new Point(0, 0);
        PointF Min = new Point(0, 0);
        double Distance = 0;
        List<PointF> Points = new List<PointF>();
        Lclass.Brick Ret = new Lclass.Brick();
        for (int i = 0; i < Group.Count; i++)
        {
            Points.Add(Group[i].P1);
            Points.Add(Group[i].P2);
            Ret.AddRegions(Group[i].Regions);
        }
        for (int i = 0; i < Points.Count; i++)
        {
            for (int j = i + 1; j < Points.Count; j++)
            {
                double D = DistSqr(Points[i], Points[j]);
                if (D > Distance)
                {
                    Distance = D;
                    Max = Points[i];
                    Min = Points[j];
                }
            }
        }

        Ret.P1 = Max;
        Ret.P2 = Min;
        Ret.Width = brickWidth;

        return Ret;
    }

    private double MinDistance(Lclass.Line L1, Lclass.Line L2)
    {
        double P11 = DistSqr(L1.P1, L2.P1);
        double P12 = DistSqr(L1.P1, L2.P2);
        double P21 = DistSqr(L1.P2, L2.P1);
        double P22 = DistSqr(L1.P2, L2.P2);

        return Math.Sqrt(Math.Min(P11, Math.Min(P12, Math.Min(P21, P22))));
    }

    private double DistSqr(PointF P1, PointF P2)
    {
        float num = P1.X - P2.X;
        float num2 = P1.Y - P2.Y;
        return (num * num + num2 * num2);
    }

    private PointF midpoint(PointF A, PointF B)
    {
        PointF ret = new PointF();
        ret.X = (A.X + B.X) / 2;
        ret.Y = (A.Y + B.Y) / 2;
        return ret;
    }

    private float LineDistance(Lclass.Brick Item, PointF Point)
    {
        float num = MathF.Abs((Item.P2.X - Item.P1.X) * (Item.P1.Y - Point.Y) - (Item.P1.X - Point.X) * (Item.P2.Y - Item.P1.Y));
        float dom = MathF.Sqrt(MathF.Pow((Item.P2.X - Item.P1.X), 2) + MathF.Pow((Item.P2.Y - Item.P1.Y), 2));
        float distance = num / dom;
        return distance;
    }


    private float PointDistanceToLine(Lclass.Brick Item, PointF Point)
    {
        if ((Item.P1 == Point || Item.P2 == Point))
            return 0;
        PointF Mid = midpoint(Item.P1, Item.P2);
        if (DistSqr(Mid, Point) <= (DistSqr(Mid, Item.P1)))
        {
            float distance = LineDistance(Item, Point);
            if (distance < Item.Width)
            {
                return distance;
            }
        }
        return float.MaxValue;
    }

    private bool InRange(float Val1, float Val2, float Thres)
    {
        return MathF.Abs(Val1 - Val2) <= Thres;
    }

    private double getAngleRad(PointF p1, PointF p2)
    {
        // returns the angle between 2 points in radians
        // p1 = {x: 1, y: 2};
        // p2 = {x: 3, y: 4};
        return ((MathF.Atan2(p2.Y - p1.Y, p2.X - p1.X)) * (180 / MathF.PI)) + 180;
    }


    public struct ColorRGB
    {
        public byte R;
        public byte G;
        public byte B;

        public ColorRGB(Color value)
        {
            this.R = value.R;
            this.G = value.G;
            this.B = value.B;
        }

        public static implicit operator Color(ColorRGB rgb)
        {
            Color c = Color.FromArgb(rgb.R, rgb.G, rgb.B);
            return c;
        }
        public static explicit operator ColorRGB(Color c)
        {
            return new ColorRGB(c);
        }
    }

    public static ColorRGB HSL2RGB(double h, double sl, double l)
    {
        double v;
        double r, g, b;

        r = l;   // default to gray
        g = l;
        b = l;
        v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);

        if (v > 0)
        {
            double m;
            double sv;
            int sextant;
            double fract, vsf, mid1, mid2;

            m = l + l - v;
            sv = (v - m) / v;
            h *= 6.0;

            sextant = (int)h;
            fract = h - sextant;
            vsf = v * sv * fract;
            mid1 = m + vsf;
            mid2 = v - vsf;

            switch (sextant)
            {
                case 0:
                    r = v;
                    g = mid1;
                    b = m;
                    break;
                case 1:
                    r = mid2;
                    g = v;
                    b = m;
                    break;
                case 2:
                    r = m;
                    g = v;
                    b = mid1;
                    break;
                case 3:
                    r = m;
                    g = mid2;
                    b = v;
                    break;
                case 4:
                    r = mid1;
                    g = m;
                    b = v;
                    break;
                case 5:
                    r = v;
                    g = m;
                    b = mid2;
                    break;
            }
        }

        ColorRGB rgb;
        rgb.R = Convert.ToByte(r * 255.0f);
        rgb.G = Convert.ToByte(g * 255.0f);
        rgb.B = Convert.ToByte(b * 255.0f);

        return rgb;
    }
}