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

public class Map
{
    private float brickWidth = 0;
    private List<Lclass.Brick> bricks = new List<Lclass.Brick>();
    private Dictionary<PointF, List<List<Lclass.Brick>>> Sortedbricks = new Dictionary<PointF, List<List<Lclass.Brick>>>();
    private bool CanClear = false;
    private bool Clear = false;
    public bool ClearMem = false;
    private double[] AngleOffset = new double[10];
    private double ScanSpeed = 1;
    public bool ForceRefresh = false;
    private bool CanSort = true;
    private bool RefreshSort = false;
    private bool IsDrawing = false;
    private int CurrentSweep = 0;
    private double Clock = 0;
    private float GridSize;
    private const float MaxSlopeDiff = 0.5f;

    public Map(float brickWidth = 3, double ScanSpeed = 1, float GridSize = 100)
    {
        this.brickWidth = brickWidth;
        this.ScanSpeed = ScanSpeed;
        this.GridSize = GridSize;

        for (int i = 0; i < AngleOffset.Length; i++)
        {
            AngleOffset[i] = ((float)i / AngleOffset.Length) * 360.0f;
        }
    }

    public string ExportMapData()
    {
        string output = "";
        foreach (List<List<Lclass.Brick>> item in Sortedbricks.Values)
        {
            foreach (List<Lclass.Brick> Group in item)
            {
                foreach (Lclass.Brick brick in Group)
                {
                    output += brick.P1.X + "/" + brick.P1.Y + "#" + brick.P2.X + "/" + brick.P2.Y + "#" + brick.Width + "___";
                }
            }
        }
        return output;
    }

    public void ImportMapData(string Data, float Diameter)
    {
        bricks.Clear();
        string[] delimeters = { "___", "#", "/" };
        string[] coordinates = Data.Split(delimeters, StringSplitOptions.None);

        // Four coordinates per line
        float x1, y1, x2, y2, width;
        for (int i = 0; i < coordinates.Length - 4; i += 5)
        {
            x1 = float.Parse(coordinates[i]);
            y1 = float.Parse(coordinates[i + 1]);
            x2 = float.Parse(coordinates[i + 2]);
            y2 = float.Parse(coordinates[i + 3]);
            width = float.Parse(coordinates[i + 4]);

            bricks.Add(new Lclass.Brick() { P1 = new PointF(x1, y1), P2 = new PointF(x2, y2), Width = width });
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
                foreach (List<Lclass.Brick> bricks in Sortedbricks[item])
                {
                    foreach (Lclass.Brick brick in bricks)
                    {
                        if (!Overlap.Contains(brick))
                            Overlap.Add(brick);
                    }
                }
            }
        }
        return Overlap;
    }

    private List<PointF> AddBrick(Lclass.Brick item, float Diameter)
    {
        List<PointF> Coords = LineCoords(item.P1, item.P2);
        bool Added = false;
        bool Same = false;
        bool NewRegions = true;
        item.AddRegions(Coords);
        while (NewRegions)
        {
            foreach (PointF Point in Coords)
            {
                if (Sortedbricks.ContainsKey(Point))
                {
                    for (int i = Sortedbricks[Point].Count - 1; i >= 0 && !Added && !Same; i--)
                    {
                        Lclass.Brick Buff = MaxDist(Sortedbricks[Point][i]);
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
                                        Sortedbricks[Point][i].Add(item);
                                        List<Lclass.Brick> Collection = new List<Lclass.Brick>(Sortedbricks[Point][i]);
                                        foreach (Lclass.Brick Brick in Collection)
                                        {
                                            item.AddRegions(Brick.AddToParent(item));
                                            Brick.RemoveFromParent();
                                        }
                                        Added = true;
                                    }
                                    else if (Encaps(item, Buff))
                                    {
                                        item.AddRegions(Buff.Regions);
                                        Sortedbricks[Point][i].Add(item);
                                        List<Lclass.Brick> Collection = new List<Lclass.Brick>(Sortedbricks[Point][i]);
                                        foreach (Lclass.Brick Brick in Collection)
                                        {
                                            item.AddRegions(Brick.AddToParent(item));
                                            Brick.RemoveFromParent();
                                        }
                                        Added = true;
                                    }
                                    else
                                    {
                                        if (Touching(Buff, item) || MinDistance(Buff, item) < Diameter)
                                        {
                                            Added = true;
                                            List<Lclass.Brick> NewGroup = new List<Lclass.Brick>(Sortedbricks[Point][i]);
                                            NewGroup.Add(item);
                                            Lclass.Brick NewBuff = MaxDist(NewGroup);
                                            
                                            if (LineCoords(NewBuff.P1, NewBuff.P2).Contains(Point))
                                            {
                                                item.AddRegions(Buff.Regions);
                                                item.P1 = NewBuff.P1;
                                                item.P2 = NewBuff.P2;
                                                Sortedbricks[Point][i].Add(item);

                                                List<Lclass.Brick> Collection = new List<Lclass.Brick>(Sortedbricks[Point][i]);
                                                foreach (Lclass.Brick Brick in Collection)
                                                {
                                                    item.AddRegions(Brick.AddToParent(item));
                                                    Brick.RemoveFromParent();
                                                }
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
                    if (!Added && !Same)
                    {
                        List<Lclass.Brick> Collection = new List<Lclass.Brick>();
                        item.AddRegion(Point).AddParent(Collection, Point);
                        Collection.Add(item);
                        Sortedbricks[Point].Add(Collection);
                        Added = true;
                    }
                }
                else
                {
                    List<List<Lclass.Brick>> Group = new List<List<Lclass.Brick>>();
                    List<Lclass.Brick> Collection =  new List<Lclass.Brick>();
                    item.AddRegion(Point).AddParent(Collection, Point);
                    Group.Add(Collection);
                    Collection.Add(item);
                    Sortedbricks.Add(Point, Group);
                }
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

    private bool Encaps(Lclass.Brick Outter, Lclass.Brick Inner)
    {
        float P1 = PointDistanceToLine(Outter, Inner.P1);
        float P2 = PointDistanceToLine(Outter, Inner.P2);

        return P1 != float.MaxValue && P2 != float.MaxValue;
    }

    private bool Touching(Lclass.Brick Outter, Lclass.Brick Inner)
    {
        float P1 = PointDistanceToLine(Outter, Inner.P1);
        float P2 = PointDistanceToLine(Outter, Inner.P2);

        return P1 != float.MaxValue ^ P2 != float.MaxValue;
    }

    private bool RemoveBrick(Lclass.Brick Brick)
    {
        List<PointF> Coords = LineCoords(Brick.P1, Brick.P2);
        bool removed = false;
        foreach (PointF Point in Coords)
        {
            if (Sortedbricks.ContainsKey(Point))
            {
                for (int i = Sortedbricks[Point].Count - 1; i >= 0; i--)
                {
                    for (int j = Sortedbricks[Point][i].Count - 1; j >= 0; j--)
                    {
                        if (SimilarSlope(Sortedbricks[Point][i][j].getSlope(), Brick.getSlope(), MaxSlopeDiff))
                        {
                            if (LineDistance(Sortedbricks[Point][i][j], Brick.P1) < brickWidth / 2 && LineDistance(Sortedbricks[Point][i][j], Brick.P2) < brickWidth / 2)
                            {
                                if (Encaps(Sortedbricks[Point][i][j], Brick))
                                {
                                    removed = true;
                                    //Split
                                }
                                else if (Encaps(Brick, Sortedbricks[Point][i][j]))
                                {
                                    removed = true;
                                    Sortedbricks[Point][i].RemoveAt(j);
                                }
                                else
                                {
                                    if (Touching(Sortedbricks[Point][i][j], Brick))
                                    {
                                        removed = true;
                                        //Trim
                                    }
                                }
                            }
                        }
                    }
                }
            }
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
        ValidateLines(items);
        ForceRefresh = true;
    }

    private void ValidateLines(List<PointF> items)
    {
        for (int h = items.Count - 1; h >= 0; h--)
        {
            for (int i = Sortedbricks[items[h]].Count - 1; i >= 0; i--)
            {
                for (int j = Sortedbricks[items[h]][i].Count - 1; j >= 0; j--)
                {
                    List<PointF> Coords = LineCoords(Sortedbricks[items[h]][i][j].P1, Sortedbricks[items[h]][i][j].P2);
                    if (!Coords.Contains(items[h]))
                    {
                        Sortedbricks[items[h]][i].RemoveAt(j);
                    }
                }
                if (Sortedbricks[items[h]][i].Count == 0)
                {
                    Sortedbricks[items[h]].RemoveAt(i);
                }
            }
            if (Sortedbricks[items[h]].Count == 0)
            {
                Sortedbricks.Remove(items[h]);
            }
        }
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

    private List<PointF> LineCoords(PointF P1, PointF P2)
    {
        List<PointF> GridCorrdinates = new List<PointF>();

        float Increment = (GridSize * 2);

        PointF mP1, mP2;
        mP1 = Snap(P1);
        mP2 = Snap(P2);
        
        float i, error, errorprev, ddy, ddx;
        float y = mP1.Y, x = mP1.X;
        float dx = (mP2.X - mP1.X) / Increment;
        float dy = (mP2.Y - mP1.Y) / Increment;
        GridCorrdinates.Add(mP1);

        float ystep = Math.Sign(dy) * Increment;
        float xstep = Math.Sign(dx) * Increment;
        dy = Math.Abs(dy);
        dx = Math.Abs(dx);
        ddy = 2 * dy;
        ddx = 2 * dx;

        if (ddx >= ddy)
        {
            errorprev = error = dx;
            for (i = 0; i < dx; i++)
            {
                x += xstep;
                error += ddy;
                if (error > ddx)
                {
                    y += ystep;
                    error -= ddx;
                    if (error + errorprev < ddx)
                        GridCorrdinates.Add(new PointF(x, y - ystep));
                    else if (error + errorprev > ddx)
                        GridCorrdinates.Add(new PointF(x - xstep, y));
                    else
                    {
                        GridCorrdinates.Add(new PointF(x, y - ystep));
                        GridCorrdinates.Add(new PointF(x - xstep, y));
                    }
                }
                GridCorrdinates.Add(new PointF(x, y));
                errorprev = error;
            }
        }
        else
        {
            errorprev = error = dy;
            for (i = 0; i < dy; i++)
            {
                y += ystep;
                error += ddx;
                if (error > ddy)
                {
                    x += xstep;
                    error -= ddy;
                    if (error + errorprev < ddy)
                        GridCorrdinates.Add(new PointF(x - xstep, y));
                    else if (error + errorprev > ddy)
                        GridCorrdinates.Add(new PointF(x, y - ystep));
                    else
                    {
                        GridCorrdinates.Add(new PointF(x - xstep, y));
                        GridCorrdinates.Add(new PointF(x, y - ystep));
                    }
                }
                GridCorrdinates.Add(new PointF(x, y));
                errorprev = error;
            }
        }

        return GridCorrdinates;
    }

    public void ClearMemory()
    {
        if (CanClear)
        {
            bricks.Clear();
            Sortedbricks.Clear();
        }
        else
            Clear = true;
        ClearMem = true;
    }

    //public void test()
    //{
    //    PointF[] currentPoints = new PointF[5] {new PointF(2.85f*20, 0), new PointF(2.2f*20, 1.6f*20), new PointF(-0.7f*20, 2*20), new PointF(-1.84f*20, 0.4f*20), new PointF(-2.2f*20, -3.06f*20) };

    //    List<Lclass.Line> preBuffers = new List<Lclass.Line>();

    //    for (int i = 1; i < currentPoints.Length; i++)
    //    {
    //        int prevIndex = i - 1;
    //        int index = i % currentPoints.Length;

    //        // Check to see if we have reached the end of the list


    //        if (ruleCheck(currentPoints[index], currentPoints[prevIndex], 40))
    //        {

    //            preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex], P2 = currentPoints[index], Width = 2 });

    //        }
    //    }

    //    double ValI = 0;
    //    foreach (Lclass.Line item in preBuffers)
    //    {
    //        Knossos.KnossosUI.addLine(item, HSL2RGB(ValI, 0.5, 0.5));
    //        ValI += 0.25;
    //        if (ValI >= 1)
    //            ValI = 0;
    //    }
    //}
    public bool CreateBuffer(List<PointF> collisionPoints, PointF location, float Diameter)
    {
        //test();
        //return;

        // Sorting Points
        SortedDictionary<double, PointF> orderedList = new SortedDictionary<double, PointF>();
        double angle;
        double Key;
        for (int i = 0; i < collisionPoints.Count; i++)
        {
            angle = (getAngleRad(location, collisionPoints[i]));
            Key = (angle + AngleOffset[CurrentSweep]) % 360.0f;
            if (!orderedList.ContainsKey(Key))
            {
                orderedList.Add(Key, collisionPoints[i]);

                Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
                {
                    Point = collisionPoints[i],
                    color = HSL2RGB(((angle + Clock) % 360.0f) / 360.0f, 0.5, 0.5),
                    Type = Knossos.TargetPoint.DrawType.Dot,
                    Diameter = 5
                });
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
        //PointF? PrevSlope = null;
        //float PrevSlope = float.NaN;
        List<KeyValuePair<double, PointF>> currentPoints = orderedList.ToList();
        for (int i = 1; i < currentPoints.Count; i++)
        {
            prevIndex = i - 1;
            index = i % currentPoints.Count;

            if (Dist(currentPoints[index].Value, currentPoints[prevIndex].Value) < Diameter)
            {
                preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex].Value, P2 = currentPoints[index].Value, Width = 2 });
                /*
                // Check to see if we have reached the end of the list
                
                //float currentSlopeX = currentPoints[index].Value.X - currentPoints[prevIndex].Value.X;
                //float currentSlopeY = currentPoints[index].Value.Y - currentPoints[prevIndex].Value.Y;
                //float normalizedSlopeX = currentSlopeX / MathF.Max(currentSlopeX, currentSlopeY);
                //float normalizedSlopeY = currentSlopeY / MathF.Max(currentSlopeX, currentSlopeY);
                //currentSlopeX = normalizedSlopeX;
                //currentSlopeY = normalizedSlopeY;
                

                float currentSlopeX = currentPoints[index].Value.X - currentPoints[prevIndex].Value.X;
                float currentSlopeY = currentPoints[index].Value.Y - currentPoints[prevIndex].Value.Y;
                float Slope = (currentSlopeY / currentSlopeX);

                //if (ruleCheck(currentPoints[index].Value, currentPoints[prevIndex].Value, Radius))
                {
                    if (PrevSlope == float.NaN)

                    {
                        //PrevSlope = new PointF(currentSlopeX, currentSlopeY);
                        PrevSlope = Slope;
                        preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex].Value, P2 = currentPoints[index].Value, Width = 2 });
                    }

                    else
                    {
                        //bool match = InRange(((PointF)(PrevSlope)).X, currentSlopeX, 0.1f) && InRange(((PointF)(PrevSlope)).Y, currentSlopeY, 0.1f);
                        bool match = InRange(PrevSlope, Slope, 0.1f);
                        if (match)
                        {
                            Lclass.Line existingLine = preBuffers[preBuffers.Count - 1];
                            existingLine.P2 = currentPoints[index].Value;
                        }
                        else
                        {
                            //PrevSlope = new PointF(currentSlopeX, currentSlopeY);
                            PrevSlope = Slope;
                            preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex].Value, P2 = currentPoints[index].Value, Width = 2 });
                        }
                    }

                }
                */
            }
        }

        //foreach(Lclass.Brick item in bricks)
        //{
        //    foreach (Lclass.Line anotherWord in preBuffers)
        //    {
        //        float point1 = PointDistanceToLine(item, anotherWord.P1);
        //        float point2 = PointDistanceToLine(item, anotherWord.P2);
        //        if (point1 != float.MaxValue || point2 != float.MaxValue)
        //        {

        //        }
        //        else
        //        {

        //        }
        //    }
        //}
        /*
        double ValI = 0;
        foreach (Lclass.Line item in preBuffers)
        {
            Knossos.KnossosUI.addLine(item, HSL2RGB(ValI, 0.5, 0.5));
            ValI += 0.25;
            if (ValI >= 1)
                ValI = 0;
        }
        */
        CanClear = false;
        List<PointF> NewData = new List<PointF>();
        bool Changed = ForceRefresh;
        if (!IsDrawing)
        {
            processPreBuffers(Diameter, preBuffers, ref NewData);
            if (NewData.Count > 0 || ForceRefresh)
            {
                Refresh(Changed ? Sortedbricks.Keys.ToList() : NewData);
                Changed |= true;
            }
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

    public void DisplayMap(PointF Focus, int DisplayRadius, float Diameter)
    {
        /*
        foreach (Lclass.Brick item in bricks)
        {
            Knossos.KnossosUI.addLine(item, HSL2RGB(3, 0.5, 0.5));
        }
        */

        if (Clear)
        {
            ClearMemory();
            Clear = false;
        }

        CanClear = false;

        if (RefreshSort)
        {
            RefreshSort = false;
            RefreshSortedBricks(Diameter);
        }

        CanSort = false;
        IsDrawing = true;
        List<PointF> Focuses = SnapCoords(Focus, DisplayRadius);
        PointF NewF = Snap(Focus);
        bool Covered = false;
        bool Rendered = false;
        float TotalSquares = MathF.Pow((DisplayRadius * 2) + 1, 2);
        float I = 0;
        foreach (PointF item in Sortedbricks.Keys)
        {
            Rendered = false;
            foreach (PointF FocusPoint in Focuses)
            {
                if (item.X == FocusPoint.X && item.Y == FocusPoint.Y)
                {
                    foreach (List<Lclass.Brick> Group in Sortedbricks[item])
                    {
                        foreach (Lclass.Brick wall in Group)
                        {
                            Knossos.KnossosUI.addLine(new Knossos.TargetLine()
                            {
                                Line = wall,
                                color = HSL2RGB((I / TotalSquares), 0.5, 0.5),
                                Type = Knossos.TargetLine.DrawType.Outline
                            });
                        }
                    }
                    Rendered = true;
                    break;
                }
            }

            Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
            {
                Point = item,
                color = (Rendered ? HSL2RGB((I / TotalSquares), 0.5, 0.5) : Color.DarkOrange),
                Type = Knossos.TargetPoint.DrawType.Square,
                Diameter = GridSize - ((item.X == NewF.X && item.Y == NewF.Y) ? 10 : (Rendered ? 5 : 0)),
                Scale = true
            });

            if (item.X == NewF.X && item.Y == NewF.Y)
            {
                Covered = true;
            }

            if (Rendered)
                I++;
        }
        if (!Covered)
        {
            Knossos.KnossosUI.AddPoint(new Knossos.TargetPoint()
            {
                Point = NewF,
                color = Color.Blue,
                Type = Knossos.TargetPoint.DrawType.Square,
                Diameter = GridSize - (Sortedbricks.Count > 0 ? 10 : 0),
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

    private void processPreBuffers(float Diameter, List<Lclass.Line> preBuffers, ref List<PointF> Regions)
    {
        if(preBuffers.Count == 0)
        {
            return;
        }
        List<PointF> Changed = new List<PointF>();
        List<sledgeHammer> wreckingBall = new List<sledgeHammer>();

        bool FoundIntercection = false;
        foreach (Lclass.Brick item in GetBricksAt(LineCoords(preBuffers[0].P1, preBuffers[0].P2)))
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
                Changed.AddRange(AddBrick(new Lclass.Brick() { P1 = preBuffers[0].P1, P2 = preBuffers[0].P2, Width = brickWidth }, Diameter));
            }
        }
        else
        {
            Changed.AddRange(AddBrick(processBricks(wreckingBall), Diameter));
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

            double DistInner_1 = Dist(Inner, Object.P1);
            double DistInner_2 = Dist(Inner, Object.P2);

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
                double DistOuter_1 = Dist(Outer, Object.P1);
                double DistOuter_2 = Dist(Outer, Object.P2);
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

    private void Refresh(List<PointF> RegionsChanged)
    {
        
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
                double D = Dist(Points[i], Points[j]);
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
        double P11 = Dist(L1.P1, L2.P1);
        double P12 = Dist(L1.P1, L2.P2);
        double P21 = Dist(L1.P2, L2.P1);
        double P22 = Dist(L1.P2, L2.P2);

        return Math.Sqrt(Math.Min(P11, Math.Min(P12, Math.Min(P21, P22))));
    }

    private double Dist(PointF P1, PointF P2)
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
        if (Dist(Mid, Point) <= (Dist(Mid, Item.P1)))
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