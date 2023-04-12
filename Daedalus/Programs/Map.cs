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
using EarClipperLib;
using System.Runtime.CompilerServices;
using Microsoft.SolverFoundation.Common;
using System.Security.Cryptography;
using System.Numerics;
using System.Drawing.Design;
using System.Threading;
using System.Security.Cryptography.Xml;
using System.Linq.Expressions;
using System.Xml.Linq;
using System.Diagnostics.CodeAnalysis;

public class Map
{
    private float brickWidth { get { return Knossos.KnossosUI.Settings.Mino_Radius + (2 * Knossos.KnossosUI.Settings.ExpansionBias); } }
    private List<Lclass.Brick> bricks = new List<Lclass.Brick>();
    private Dictionary<PointF, List<Lclass.Brick>> SortedBricks = new Dictionary<PointF, List<Lclass.Brick>>();
    private Dictionary<PointF, PathsD> SortedChunks = new Dictionary<PointF, PathsD>();
    private Dictionary<PointF, PathsD> SortedWalls = new Dictionary<PointF, PathsD>();
    private Dictionary<PointF, Dictionary<PointF, List<PointF>>> SortedNet = new Dictionary<PointF, Dictionary<PointF, List<PointF>>>();
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
    public bool CanRefresh = true;
    private float GridSize { get { return Knossos.KnossosUI.Settings.GridRadius; } }
    private float Diameter { get { return Knossos.KnossosUI.Settings.Mino_Radius + Knossos.KnossosUI.Settings.ExpansionBias; } }

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
        foreach (List<Lclass.Brick> Group in SortedBricks.Values)
        {
            foreach (Lclass.Brick brick in Group)
            {
                if (!bricks.Contains(brick))
                {
                    bricks.Add(brick);
                    if (brick.Length() != 0)
                    {
                        output += brick.P1.X + "/" + brick.P1.Y + "#" + brick.P2.X + "/" + brick.P2.Y + "#" + brick.Width + "___";
                    }
                }
            }
        }
        output += ";";
        foreach (PointF Point in SortedChunks.Keys)
        {
            output += Point.X + "|" + Point.Y + "|";
        }
        output += ";" + GridSize + ";";
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

        if (Sections.Length >= 3)
        {
            PointF Coord;
            coordinates = Sections[1].Split('|', StringSplitOptions.None);
            for (int i = 0; i < coordinates.Length - 1; i += 2)
            {
                x1 = float.Parse(coordinates[i]);
                y1 = float.Parse(coordinates[i + 1]);
                Coord = new PointF(x1, y1);
                if (!SortedChunks.ContainsKey(Coord))
                {
                    SortedChunks.Add(Coord, ChunkShape(Coord));
                }
            }
        }

        if (Sections.Length >= 3)
        {
            Knossos.KnossosUI.Settings.GridRadius = float.Parse(Sections[2]);
        }

        if (CanSort)
            RefreshSortedBricks();
        else
            RefreshSort = true;
        ForceRefresh = true;
        ClearMem = true;
    }

    public PointF GetClosestPoint(PointF Location, int StartRange = 0)
    {
        if (SortedNet.Count == 0)
            return Snap(Location);
        int Range = StartRange;
        List<PointF> Chunks;
        bool Check = true;
        List<PointF> Can = new List<PointF>();
        while (Check)
        {
            Chunks = SnapCoords(Location, Range, true);
            foreach (PointF item in Chunks)
            {
                if (SortedNet.ContainsKey(item))
                {
                    if (SortedNet[item].Keys.Count > 0)
                    {
                        foreach (PointF PointCon in SortedNet[item].Keys)
                        {
                            GetConnections(PointCon, out bool Contains);
                            if (Contains)
                            {
                                Check = false;
                                Can.Add(item);
                                break;
                            }
                        }
                    }
                }
            }
            Range++;
        }

        double Dist = double.MaxValue;
        double D = 0;
        PointF Chunk = Snap(Location);
        foreach (PointF item in Can)
        {
            D = DistSqr(item, Location);
            if (D < Dist)
            {
                Dist = D;
                Chunk = item;
            }
        }

        Dist = double.MaxValue;
        PointF Vertex = Chunk;
        foreach (PointF item in SortedNet[Chunk].Keys)
        {
            D = DistSqr(item, Location);
            if (D < Dist)
            {
                Dist = D;
                Vertex = item;
            }
        }
        return Vertex;
    }

    private List<PointF> GetConnections(PointF Point, out bool ContainsChunks, float Thres = 0.1f, int Radius = 1)
    {
        List<PointF> Avalable = new List<PointF>();
        List<PointF> Chunks = SnapCoords(Point, Radius, true);
        bool InChunk = false;

        bool Possible = true;
        PathsD Line = new PathsD();
        PathsD Intersection;
        Lclass.Line RaySegment;
        Lclass.Line[] PossibleSegment = new Lclass.Line[4];

        foreach (PointF item in Chunks)
        {
            if (SortedNet.ContainsKey(item))
            {
                if (SortedNet[item].ContainsKey(Point))
                {
                    InChunk = true;
                    Avalable.AddRange(SortedNet[item][Point]);
                }
            }
        }
        
        PointF Current = Snap(Point);
        bool[] Edges = new bool[4];
        PointF[] EdgeChunks = new PointF[4];
        Edges[0] = InRange(Point.X, Current.X + GridSize, Thres);
        Edges[1] = InRange(Point.X, Current.X - GridSize, Thres);
        Edges[2] = InRange(Point.Y, Current.Y + GridSize, Thres);
        Edges[3] = InRange(Point.Y, Current.Y - GridSize, Thres);

        EdgeChunks[0] = Snap(new PointF(Current.X + GridSize * 2, Current.Y));
        EdgeChunks[1] = Snap(new PointF(Current.X - GridSize * 2, Current.Y));
        EdgeChunks[2] = Snap(new PointF(Current.X, Current.Y + GridSize * 2));
        EdgeChunks[3] = Snap(new PointF(Current.X, Current.Y - GridSize * 2));
        ContainsChunks = false;
        for (int i = 0; i < 4; i++)
        {
            if (Edges[i] || !InChunk)
            {
                Possible = true;
                if (SortedWalls.ContainsKey(EdgeChunks[i]))
                {
                    Line.Clear();
                    RaySegment = new Line()
                    {
                        P1 = EdgeChunks[i],
                        P2 = Point,
                        Width = 1
                    };
                    PossibleSegment = RaySegment.GenerateRec();
                    Line.Add(Clipper.MakePath(new double[] {PossibleSegment[0].P1.X, PossibleSegment[0].P1.Y,
                                                                PossibleSegment[0].P2.X, PossibleSegment[0].P2.Y,
                                                                PossibleSegment[1].P2.X, PossibleSegment[1].P2.Y,
                                                                PossibleSegment[1].P1.X, PossibleSegment[1].P1.Y}));
                    int Prev = SortedWalls[EdgeChunks[i]].Count;
                    Intersection = Clipper.BooleanOp(ClipType.Union, SortedWalls[EdgeChunks[i]], Line, FillRule.NonZero);

                    if (Intersection.Count == Prev)
                    {
                        Possible = false;
                    }
                }
                if (Possible)
                {
                    Avalable.Add(EdgeChunks[i]);
                    ContainsChunks = true;
                }
            }
        }
        
        return Avalable;
    }

    public class AStarNode : IEquatable<AStarNode>
    {
        public PointF Point;
        public double fCost { get { return gCost + hCost; } }
        public double gCost;
        public double hCost;
        public AStarNode parent;

        public bool Equals([AllowNull] AStarNode other)
        {
            if (other != null)
                return this.Point.Equals(other.Point);
            return false;
        }
    }

    public List<AStarNode> Astar(PointF Location, PointF Target, float Radius, int Iterations = 100)
    {
        AStarNode Ret = null;
        if (SortedNet.Count == 0)
            return null;
        double Dist = DistSqr(Location, Target);
        AStarNode startNode = new AStarNode() { Point = GetClosestPoint(Location), gCost = 0, hCost = Dist };
        AStarNode targetNode = new AStarNode() { Point = GetClosestPoint(Target), hCost = 0, gCost = Dist };

        List<AStarNode> openSet = new List<AStarNode>();
        List<AStarNode> closeSet = new List<AStarNode>();
        openSet.Add(startNode);
        int Iteration = 0;
        while (openSet.Count > 0 && Iteration++ < Iterations)
        {
            AStarNode node = openSet[0];
            for (int i = 1; i < openSet.Count; i++)
            {
                if (openSet[i].fCost < node.fCost || openSet[i].fCost == node.fCost)
                {
                    if (openSet[i].hCost < node.hCost)
                        node = openSet[i];
                }
            }

            openSet.Remove(node);
            closeSet.Add(node);

            if (node.Point == targetNode.Point)
            {
                Ret = node;
                
                if (!InsideWall(Target, Radius))
                {
                    Ret = new AStarNode() { Point = Target, parent = Ret };
                }
                return new List<AStarNode>() { Ret };
            }

            foreach (PointF Con in GetConnections(node.Point, out bool Chunks))
            {
                AStarNode neighbour = new AStarNode() { Point = Con, gCost = DistSqr(Con, Location), hCost = DistSqr(Con, Target) };
                if (!closeSet.Contains(neighbour))
                {
                    double newCostToNeighbour = node.gCost + DistSqr(node.Point, neighbour.Point);
                    if (newCostToNeighbour < neighbour.gCost || !openSet.Contains(neighbour))
                    {
                        neighbour.gCost = newCostToNeighbour;
                        neighbour.hCost = DistSqr(neighbour.Point, targetNode.Point);
                        neighbour.parent = node;
                        if (!openSet.Contains(neighbour))
                            openSet.Add(neighbour);
                    }
                }
            }
        }
        return openSet;
    }

    public bool InsideWall(PointF Point, double Radius)
    {
        bool Inside = false;
        PointF ChunkPoint = Snap(Point);
        if (SortedWalls.ContainsKey(ChunkPoint))
        {
            if (SortedWalls[ChunkPoint] != null)
            {
                PathsD Object = ChunkShape(Point, Radius);
                PathsD Intersection = Clipper.BooleanOp(ClipType.Intersection, SortedWalls[ChunkPoint], Object, FillRule.NonZero);

                if (Intersection.Count != 0)
                {
                    Inside = true;
                }
            }
        }
        return Inside;
    }

    public AStarNode AstarPath(List<AStarNode> Options, double Radius)
    {
        AStarNode ret = null;
        if (Options == null)
            return ret;
        double COST = double.MaxValue;
        double cost = 0;
        Radius = Radius * Radius;
        foreach (AStarNode item in Options)
        {
            cost = item.hCost;
            if (cost < COST)
            {
                ret = item;
                COST = cost;
            }
        }

        if (ret != null)
        {
            AStarNode Node = ret.parent;
            AStarNode Anchor = ret;
            while (Node != null)
            {
                if (DistSqr(Node.Point, Anchor.Point) > Radius)
                {
                    Anchor = Node;
                }
                else
                {
                    Anchor.parent = Node;
                }
                Node = Node.parent;
            }
        }

        return ret;
    }

    public List<PointF> RoamTargets(PointF Location, int StartRange = 2)
    {
        if (SortedNet.Count == 0)
            return new List<PointF>() { Location };
        int Range = StartRange;
        List<PointF> Chunks = new List<PointF>();
        bool Check = true;
        List<PointF> Can = new List<PointF>();
        while (Check)
        {
            Chunks = SnapCoords(Location, Range, true);
            foreach (PointF item in Chunks)
            {
                if (!SortedNet.ContainsKey(item))
                {
                    Can.Add(item);
                    Check = false;
                }
            }
            Range++;
        }

        if (Can.Count == 0)
            Can.Add(Location);
        
        return Can;
    }

    private List<Lclass.Brick> GetBricksAt(List<PointF> GridCoords)
    {
        List<Lclass.Brick> Overlap = new List<Lclass.Brick>();
        foreach (PointF item in GridCoords)
        {
            if (SortedBricks.ContainsKey(item))
            {
                for (int i = SortedBricks[item].Count - 1; i >= 0; i--)
                {
                    if (!Overlap.Contains(SortedBricks[item][i]))
                    {
                        Overlap.Add(SortedBricks[item][i]);
                    }
                }
            }
        }
        return Overlap;
    }

    private List<PointF> AddBrick(Lclass.Brick item, float Diameter)
    {
        List<PointF> Coords = BrickCoords(item);
        bool NewRegions = true;
        item.AddRegions(Coords);
        PathsD WallPoly = new PathsD();
        Lclass.Line[] lines;
        while (NewRegions)
        {
            foreach (PointF Point in Coords)
            {
                if (SortedBricks.ContainsKey(Point))
                {
                    item.AddRegion(Point);
                    if (!SortedBricks[Point].Contains(item))
                        SortedBricks[Point].Add(item);
                }
                else
                {
                    List<Lclass.Brick> Collection = new List<Lclass.Brick>();
                    item.AddRegion(Point);
                    Collection.Add(item);
                    SortedBricks.Add(Point, Collection);
                }

                lines = item.GenerateRec(true);
                if (lines.Length == 0)
                    continue;
                // Adding brick to empty brick polygon
                WallPoly.Add(Clipper.MakePath(new double[] { lines[0].P1.X, lines[0].P1.Y,
                                                                     lines[0].P2.X, lines[0].P2.Y,
                                                                     lines[1].P2.X, lines[1].P2.Y,
                                                                     lines[1].P1.X, lines[1].P1.Y}));

                if (SortedWalls.ContainsKey(Point))
                {
                    SortedWalls[Point] = Clipper.BooleanOp(ClipType.Union, SortedWalls[Point], WallPoly, FillRule.NonZero);
                }
                else
                {
                    SortedWalls.Add(Point, new PathsD(WallPoly));
                }
                WallPoly.Clear();
                SortedWalls[Point] = Clipper.BooleanOp(ClipType.Intersection, SortedWalls[Point], ChunkShape(Point), FillRule.NonZero);
                SortedWalls[Point] = Clipper.SimplifyPaths(SortedWalls[Point], 0.1f);
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
            item.AddRegions(Brick.AddToParent(item, ref SortedBricks));
            Brick.RemoveFromParent(ref SortedBricks);
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
            lines = Brick.GenerateRec(true);
            if (lines.Length != 0)
            {
                // Adding brick to empty brick polygon
                WallPoly.Add(Clipper.MakePath(new double[] { lines[0].P1.X, lines[0].P1.Y,
                                                                     lines[0].P2.X, lines[0].P2.Y,
                                                                     lines[1].P2.X, lines[1].P2.Y,
                                                                     lines[1].P1.X, lines[1].P1.Y}));

                if (SortedWalls.ContainsKey(Point))
                {
                    SortedWalls[Point] = Clipper.BooleanOp(ClipType.Difference, SortedWalls[Point], WallPoly, FillRule.NonZero);
                    if (SortedWalls[Point].Count != 0)
                    {
                        bool Empty = true;
                        foreach (PathD item in SortedWalls[Point])
                        {
                            if (item.Count != 0)
                            {
                                Empty = false;
                                break;
                            }
                        }

                        if (!Empty)
                        {
                            for (int i = SortedBricks[Point].Count - 1; i >= 0; i--)
                            {
                                WallPoly.Clear();
                                lines = SortedBricks[Point][i].GenerateRec();
                                if (lines.Length > 0)
                                {
                                    WallPoly.Add(Clipper.MakePath(new double[] { lines[0].P1.X, lines[0].P1.Y,
                                                                     lines[0].P2.X, lines[0].P2.Y,
                                                                     lines[1].P2.X, lines[1].P2.Y,
                                                                     lines[1].P1.X, lines[1].P1.Y}));
                                    PathsD Overlap = Clipper.BooleanOp(ClipType.Intersection, WallPoly, SortedWalls[Point], FillRule.NonZero);
                                    if (Overlap.Count == 0)
                                    {
                                        SortedBricks[Point].RemoveAt(i);
                                    }
                                }
                                else
                                {
                                    SortedBricks[Point].RemoveAt(i);
                                }
                            }
                        }
                        else
                        {
                            SortedBricks[Point].Clear();
                        }
                    }
                    else
                    {
                        if (SortedBricks.ContainsKey(Point))
                            SortedBricks[Point].Clear();
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
            lines = item.GenerateRec(true);
            if (lines.Length != 0)
            {
                WallPoly.Clear();
                WallPoly.Add(Clipper.MakePath(new double[] { lines[0].P1.X, lines[0].P1.Y,
                                                                     lines[0].P2.X, lines[0].P2.Y,
                                                                     lines[1].P2.X, lines[1].P2.Y,
                                                                     lines[1].P1.X, lines[1].P1.Y}));
                foreach (PointF Point in BrickCoord)
                {
                    SortedWalls[Point] = Clipper.BooleanOp(ClipType.Difference, SortedWalls[Point], WallPoly, FillRule.NonZero);
                }
            }

            removed.AddRange(BrickCoord);

            item.Width = 0;
            item.P1 = new PointF(0, 0);
            item.P2 = new PointF(0, 0);
        }
        return removed;
    }

    private void RefreshSortedBricks()
    {
        SortedBricks.Clear();
        foreach (Lclass.Brick item in bricks)
        {
            AddBrick(item, Diameter);
        }
        List<PointF> items = SortedBricks.Keys.ToList();
        Refresh(items);
        ForceRefresh = true;
        CanRefresh = true;
    }

    private PointF Snap(PointF Point)
    {
        return new PointF(
            MathF.Floor((Point.X + GridSize) / (GridSize * 2)) * (GridSize * 2),
            MathF.Floor((Point.Y + GridSize) / (GridSize * 2)) * (GridSize * 2)
            );
    }

    private List<PointF> SnapCoords(PointF Point, int Radius, bool Hollow = false)
    {
        List<PointF> Coords = new List<PointF>();

        PointF Center = Snap(Point);
        Coords.Add(Center);
        for (int i = -Radius; i <= Radius; i++)
        {
            for (int j = -Radius; j <= Radius; j++)
            {
                if (!Hollow || ((i == -Radius || i == Radius) || (j == -Radius || j == Radius)))
                {
                    PointF Chunk = Snap(new PointF(Center.X - (GridSize * 2 * i), Center.Y - (GridSize * 2 * j)));
                    if (!Coords.Contains(Chunk))
                        Coords.Add(Chunk);
                }
            }
        }
        List<PointF> Ring = new List<PointF>();
        if (Hollow)
        {
            Ring.Add(Coords[0]);
            while(Ring.Count != Coords.Count)
            {
                double Dist = double.MaxValue;
                double D = 0;
                PointF Close = Ring[Ring.Count - 1];
                foreach (PointF item in Coords)
                {
                    if (!Ring.Contains(item))
                    {
                        D = DistSqr(Ring[Ring.Count - 1], item);
                        if (D < Dist)
                        {
                            Dist = D;
                            Close = item;
                        }
                    }
                }
                Ring.Add(Close);
            }
            Coords = Ring;
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
            SortedBricks.Clear();
            SortedWalls.Clear();
            SortedChunks.Clear();
            SortedNet.Clear();
        }
        else
            Clear = true;
        ClearMem = true;
    }

    public void RefreshChunks()
    {
        if (CanClear)
        {
            bricks.Clear();
            foreach (List<Lclass.Brick> item in SortedBricks.Values)
            {
                foreach (Lclass.Brick Wall in item)
                {
                    if (!bricks.Contains(Wall))
                    {
                        Wall.Width = brickWidth;
                        Wall.Regions.Clear();
                        bricks.Add(Wall);
                    }
                }
            }
            SortedBricks.Clear();
            SortedWalls.Clear();
            SortedChunks.Clear();
            SortedNet.Clear();
            RefreshSortedBricks();
        }
        else
            ClearChunks = true;
        ClearMem = true;
    }

    public bool CreateBuffer(List<Lclass.CollisionPoint> collisionPoints, PointF location)
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
                        Diameter = 5,
                        DisplayWindow = Knossos.Window.Map
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
                            Width = 2
                        },
                        Type = Knossos.TargetLine.DrawType.Solid,
                        DisplayWindow = Knossos.Window.Map
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
        bool UnHit = true;
        foreach (PointF item in uncollidedPoints.Values)
        {
            UnHit = true;
            List<PointF> Regions = LineCoords(item, location);
            foreach (PointF Region in Regions)
            {
                if (SortedBricks.ContainsKey(Region))
                {
                    foreach (Brick Barrier in SortedBricks[Region])
                    {
                        PointF Ray = new PointF(item.X - location.X, item.Y - location.Y);
                        PointF WallLine = new PointF(Barrier.P2.X - Barrier.P1.X, Barrier.P2.Y - Barrier.P1.Y);
                        float t = (((Barrier.P1.X - location.X) * WallLine.Y) - ((Barrier.P1.Y - location.Y) * WallLine.X)) / (Ray.X * WallLine.Y - Ray.Y * WallLine.X);
                        float u = (((location.X - Barrier.P1.X) * Ray.Y) - ((location.Y - Barrier.P1.Y) * Ray.X)) / (WallLine.X * Ray.Y - WallLine.Y * Ray.X);
                        if (u >= 0 && u <= 1 && t >= 0 && t <= 1)
                        {
                            if (t < 1)
                            {
                                UnHit = false;
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
                                        Diameter = 2.5f,
                                        DisplayWindow = Knossos.Window.Map
                                    });
                                }
                                if (Knossos.KnossosUI.Settings.NonRayHit_Show)
                                {
                                    Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                                    {
                                        color = Knossos.KnossosUI.Settings.NonPointColor,
                                        Line = new Line()
                                        {
                                            P1 = DeletePoint,
                                            P2 = location,
                                            Width = 2
                                        },
                                        Type = Knossos.TargetLine.DrawType.Solid,
                                        DisplayWindow = Knossos.Window.Map
                                    });
                                }
                            }
                        }
                    }
                }
            }
            if (UnHit)
            {
                if (Knossos.KnossosUI.Settings.Uncollided_Show)
                {
                    Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
                    {
                        Point = item,
                        color = Knossos.KnossosUI.Settings.NonPointColor,
                        Type = Knossos.TargetPoint.DrawType.Diamond,
                        Diameter = 2.5f,
                        DisplayWindow = Knossos.Window.Map
                    });
                }
                if (Knossos.KnossosUI.Settings.NonRayHit_Show)
                {
                    Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                    {
                        color = Knossos.KnossosUI.Settings.NonPointColor,
                        Line = new Line()
                        {
                            P1 = item,
                            P2 = location,
                            Width = 2
                        },
                        Type = Knossos.TargetLine.DrawType.Solid,
                        DisplayWindow = Knossos.Window.Map
                    });
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
                Refresh(Changed ? SortedBricks.Keys.ToList() : NewData);
                Changed |= true;
            }

            Changed |= Refresh(SnapCoords(location, 1));
        }
        CanClear = true;

        if (Clear)
        {
            ClearMemory();
            Clear = false;
            Changed |= true;
        }
        if (ClearChunks)
        {
            RefreshChunks();
            ClearChunks = false;
            Changed |= true;
        }
        ForceRefresh = false;
        return Changed;
    }
    // DISPLAY STUFF!!!
    public void DisplayMap(PointF Focus, int DisplayRadius, int UnRenderedRadius)
    {
        if (Clear)
        {
            ClearMemory();
            Clear = false;
        }
        if (ClearChunks)
        {
            RefreshChunks();
            ClearChunks = false;
        }

        CanClear = false;

        if (RefreshSort)
        {
            RefreshSort = false;
            if (ClearChunks)
            {
                SortedBricks.Clear();
                SortedWalls.Clear();
                SortedChunks.Clear();
                SortedNet.Clear();
            }
            ClearChunks = false;
            RefreshSortedBricks();
        }

        CanSort = false;
        IsDrawing = true;
        PointF NewF = Snap(Focus);
        bool Covered = false;
        float I = 0;
        PointF[] Keys = SortedNet.Keys.ToArray();
        List<PointF> Drawn = new List<PointF>();
        foreach (PointF item in Keys)
        {
            Drawn.Clear();
            if (DistSqr(item, Focus) < Math.Pow((GridSize * (DisplayRadius)) + ((DisplayRadius * 2) * GridSize), 2))
            {
                int LinesPerChunk = 20;
                int LineDrawn = 0;
                foreach (KeyValuePair<PointF, List<PointF>> Connection in SortedNet[item])
                {
                    if (LineDrawn > LinesPerChunk)
                        break;
                    foreach (PointF EndPoint in Connection.Value)
                    {
                        if (!Drawn.Contains(EndPoint))
                        {
                            Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                            {
                                color = Knossos.KnossosUI.Settings.Chunk_Color,
                                Line = new Line()
                                {
                                    P1 = Connection.Key,
                                    P2 = EndPoint,
                                    Width = 1
                                },
                                Type = Knossos.TargetLine.DrawType.Solid,
                                DisplayWindow = Knossos.Window.Map
                            });
                            if (LineDrawn++ > LinesPerChunk)
                                break;
                        }
                    }
                    Drawn.Add(Connection.Key);
                }

                if (SortedChunks.ContainsKey(item))
                {
                    foreach (PathD sections in SortedChunks[item])
                    {
                        for (int i = 1; i < sections.Count + 1; i++)
                        {
                            int CurrentIndex = i % sections.Count;
                            int LastIndex = i - 1;
                            PointF Current = new PointF((float)sections[CurrentIndex].x, (float)sections[CurrentIndex].y);
                            PointF Last = new PointF((float)sections[LastIndex].x, (float)sections[LastIndex].y);
                            bool Boarder = (Current.X == item.X + GridSize || Current.X == item.X - GridSize) || (Current.Y == item.Y + GridSize || Current.Y == item.Y - GridSize);
                            Boarder = Boarder && ((Last.X == item.X + GridSize || Last.X == item.X - GridSize) || (Last.Y == item.Y + GridSize || Last.Y == item.Y - GridSize));
                            if (!Boarder)
                            {
                                PointF MidPoint = midpoint(Current, Last);
                                Boarder = Boarder && ((MidPoint.X == item.X + GridSize || MidPoint.X == item.X - GridSize) || (MidPoint.Y == item.Y + GridSize || MidPoint.Y == item.Y - GridSize));
                                if (!Boarder)
                                {
                                    Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                                    {
                                        color = Knossos.KnossosUI.Settings.Object_Color,
                                        Line = new Line() { P1 = Current, P2 = Last, Width = 1 },
                                        Type = Knossos.TargetLine.DrawType.Solid,
                                        DisplayWindow = Knossos.Window.Map
                                    });
                                }
                            }
                        }
                    }
                }

                if (Knossos.KnossosUI.Settings.Walls_Show && SortedBricks.ContainsKey(item))
                {
                    foreach (Lclass.Brick Wall in SortedBricks[item])
                    {
                        Knossos.KnossosUI.AddLine(new Knossos.TargetLine()
                        {
                            color = Knossos.KnossosUI.Settings.Wall_Color,
                            Line = Wall,
                            Type = Knossos.TargetLine.DrawType.Outline,
                            DisplayWindow = Knossos.Window.Map
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
                    Scale = true,
                    DisplayWindow = Knossos.Window.Map
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
                Diameter = GridSize - (SortedChunks.Count > 0 ? 10 : 0),
                Scale = true,
                DisplayWindow = Knossos.Window.Map
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

    private PathsD ChunkShape(PointF item, double Radius)
    {
        PathsD chunk = new PathsD();
        chunk.Add(Clipper.MakePath(new double[] { item.X + Radius, item.Y + Radius,
                                                  item.X + Radius, item.Y - Radius,
                                                  item.X - Radius, item.Y - Radius,
                                                  item.X - Radius, item.Y + Radius}));
        return chunk;
    }

    private PathsD ChunkShape(PointF item)
    {
        return ChunkShape(item, GridSize);
    }

    private bool Refresh(List<PointF> RegionsChanged)
    {
        bool Ret = false;
        foreach (PointF item in RegionsChanged)
        {
            if (SortedWalls.ContainsKey(item))
            {   // Create chunk to cut bricks out of
                PathsD chunk = Clipper.BooleanOp(ClipType.Difference, ChunkShape(item), SortedWalls[item], FillRule.NonZero);
                chunk = Clipper.SimplifyPaths(chunk, 0.01f);
                if (!SortedChunks.ContainsKey(item))
                {
                    SortedChunks.Add(item, chunk);
                }
                else
                {
                    SortedChunks[item] = chunk;
                }
            }
            else
            {
                SortedWalls.Add(item, new PathsD());
                if (!SortedChunks.ContainsKey(item))
                {
                    SortedChunks.Add(item, ChunkShape(item));
                    Ret = true;
                }
            }
        }
        foreach (PointF item in RegionsChanged)
        {            
            List<List<Vector3m>> polygons = new List<List<Vector3m>>();
            List<List<Vector3m>> holes = new List<List<Vector3m>>();
            foreach (PathD rings in SortedChunks[item])
            {   
                // Adds solid polygons to solid polygons list
                if (Clipper.IsPositive(rings))
                {
                    List<Vector3m> coordinates = new List<Vector3m>();
                    foreach (PointD vertex in rings)
                    {
                        coordinates.Add(new Vector3m(vertex.x, vertex.y, 0));
                    }
                    // Add to list of solid polygons
                    polygons.Add(coordinates);
                }
                // Adds holes to nemosis (holes list)
                else
                {
                    List<Vector3m> nemo = new List<Vector3m>();
                    foreach (PointD vertex in rings)
                    {
                        nemo.Add(new Vector3m(vertex.x, vertex.y, 0));
                    }
                    // Add to list of holes
                    holes.Add(nemo);
                }
            }
            // EARCLIPPING!!!!
            EarClipping earClipper;   //hiheywydnmcool;):)//
            List<Vector3m> result;
            PointF[] KeyPoints = new PointF[3];
            PointF KeyPoint;
            PointF ConnectionPoint;
            PointF LastConnectionPoint;
            foreach (List<Vector3m> dori_the_polygon in polygons)
            {
                earClipper = new EarClipping();
                earClipper.SetPoints(dori_the_polygon, holes);
                earClipper.Triangulate();
                result = earClipper.Result;
                Dictionary<PointF, List<PointF>> Connections = new Dictionary<PointF, List<PointF>>();
                for (int Group = 0; Group < result.Count; Group += 3)
                {
                    KeyPoints[0] = new PointF((float)result[Group].X.ToDouble(), (float)result[Group].Y.ToDouble());
                    KeyPoints[1] = new PointF((float)result[Group + 1].X.ToDouble(), (float)result[Group + 1].Y.ToDouble());
                    KeyPoints[2] = new PointF((float)result[Group + 2].X.ToDouble(), (float)result[Group + 2].Y.ToDouble());
                    for (int i = 0; i < 3; i++)
                    {
                        KeyPoint = KeyPoints[i];
                        ConnectionPoint = KeyPoints[(i + 1) % 3];
                        LastConnectionPoint = KeyPoints[(i + 2) % 3];

                        if (Connections.ContainsKey(KeyPoint))
                        {
                            if (!Connections[KeyPoint].Contains(ConnectionPoint))
                                Connections[KeyPoint].Add(ConnectionPoint);
                            if (!Connections[KeyPoint].Contains(LastConnectionPoint))
                                Connections[KeyPoint].Add(LastConnectionPoint);
                        }
                        else
                        {
                            Connections.Add(KeyPoint, new List<PointF>() { ConnectionPoint, LastConnectionPoint });
                        }
                    }
                }

                // Adding new chunk to the sorted net
                if (!SortedNet.ContainsKey(item))
                {
                    SortedNet.Add(item, Connections);
                }
                // Already prcoessed this chunk
                else
                {
                    SortedNet[item] = Connections;
                }
            }
        }
        return Ret;
    }

    bool InPolygon(PointF point, PathD polygon)
    {
        int n = polygon.Count;
        bool isIn = false;
        double x = point.X;
        double y = point.Y;
        double x1, x2, y1, y2;

        x1 = polygon[n - 1].x;
        y1 = polygon[n - 1].y;

        for (int i = 0; i < n; ++i)
        {
            x2 = polygon[i].x;
            y2 = polygon[i].y;

            if (y < y1 != y < y2 && x < (x2 - x1) * (y - y1) / (y2 - y1) + x1)
            {
                isIn = !isIn;
            }
            x1 = x2;
            y1 = y2;
        }

        return isIn;
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
    private Vector3m midpoint(Vector3m A, Vector3m B)
    {
        Vector3m ret = new Vector3m((A.X + B.Y) / 2, (A.Y + B.Y) / 2, 0);
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