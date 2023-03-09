using Daedalus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

public class Map
{
    private float brickWidth = 0;
    private List<Lclass.Brick> bricks = new List<Lclass.Brick>();
    private bool CanClear = false;
    private bool Clear = false;
    public bool ClearMem = false;
    private double[] AngleOffset = new double[10];
    private double ScanSpeed = 1;
    public bool ForceRefresh = false;
    private int CurrentSweep = 0;
    private double Clock = 0;

    public Map(float brickWidth = 3, double ScanSpeed = 1)
    {
        this.brickWidth = brickWidth;
        this.ScanSpeed = ScanSpeed;

        for (int i = 0; i < AngleOffset.Length; i++)
        {
            AngleOffset[i] = ((float)i / AngleOffset.Length) * 360.0f;
        }
    }

    public string ExportMapData()
    {
        string output = "";
        foreach (Lclass.Brick item in bricks)
        {
            output += item.P1.X + "/" + item.P1.Y + "#" + item.P2.X + "/" + item.P2.Y + "#" + item.Width + "___";
        }
        return output;
    }

    public void ImportMapData(string Data)
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
        ForceRefresh = true;
        ClearMem = true;
    }

    public void ClearMemory()
    {
        if (CanClear)
            bricks.Clear();
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
    public bool CreateBuffer(List<PointF> collisionPoints, PointF location, float Radius)
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

            if (Dist(currentPoints[index].Value, currentPoints[prevIndex].Value) < Radius)
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
        bool NewData = processPreBuffers(preBuffers) || ForceRefresh;
        if (NewData)
        {
            Refresh(Radius);
        }
        CanClear = true;

        if (Clear)
        {
            ClearMemory();
            Clear = false;
            NewData = true;
        }
        ForceRefresh = false;
        return NewData;
    }

    public void DisplayMap()
    {
        CanClear = false;
        foreach (Lclass.Brick item in bricks)
        {
            Knossos.KnossosUI.addLine(item, HSL2RGB(3, 0.5, 0.5));
        }
        CanClear = true;
        ClearMem = false;
    }

    private struct sledgeHammer
    {
        public Lclass.Brick intersectingBrick;
        public float slope;
        public enum point {p1, p2, both }
        public point ouioui;
        public PointF Target;

        public void setTarget (point Point, PointF Target)
        {
            this.Target = Target;
            ouioui = Point;
        }
    }

    private bool processPreBuffers(List<Lclass.Line> preBuffers)
    {
        if(preBuffers.Count == 0)
        {
            return false;
        }

        List<sledgeHammer> wreckingBall = new List<sledgeHammer>();

        bool FoundIntercection = false;
        foreach (Lclass.Brick item in bricks)
        {
            FoundIntercection = processIntersection(item, preBuffers[0],
            (sledgeHammer.point pull, PointF Outer) =>
            {
                wreckingBall.Add(new sledgeHammer()
                {
                    intersectingBrick = item,
                    slope = item.getSlope(),
                    ouioui = pull,
                    Target = Outer
                });
            });
            if (FoundIntercection)
                break;
        }

        bool Changed = false;
        if (wreckingBall.Count == 0)
        {
            if (!FoundIntercection)
            {
                Changed = true;
                bricks.Add(new Lclass.Brick() { P1 = preBuffers[0].P1, P2 = preBuffers[0].P2, Width = brickWidth });
            }
        }
        else
        {
            Changed = true;
            bricks.Add(processBricks(wreckingBall));
        }

        preBuffers.RemoveAt(0);
        if (preBuffers.Count == 0)
        {
            return Changed;
        }
        else
        {
            return Changed || processPreBuffers(preBuffers);
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
        bricks.Remove(CurrentBrick.intersectingBrick);
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

            if (pull != sledgeHammer.point.both && InRange(MathF.Abs(Subject.getSlope()), MathF.Abs(Object.getSlope()), 0.1f) && action != null)
            {
                action(pull, Outer);
            }
        }
        return FoundIntercection;
    }

    private void Refresh(float Radius)
    {
    }

    private double Dist(PointF P1, PointF P2)
    {
        float num = P1.X - P2.X;
        float num2 = P1.Y - P2.Y;
        return Math.Sqrt(num * num + num2 * num2);
    }

    private PointF midpoint(PointF A, PointF B)
    {
        PointF ret = new PointF();
        ret.X = (A.X + B.X) / 2;
        ret.Y = (A.Y + B.Y) / 2;
        return ret;
    }

    private float PointDistanceToLine(Lclass.Brick Item, PointF Point)
    {
        PointF Mid = midpoint(Item.P1, Item.P2);
        if (Dist(Mid, Point) <= (Dist(Mid, Item.P1)))
        {
            float num = MathF.Abs((Item.P2.X - Item.P1.X) * (Item.P1.Y - Point.Y) - (Item.P1.X - Point.X) * (Item.P2.Y - Item.P1.Y));
            float dom = MathF.Sqrt(MathF.Pow((Item.P2.X - Item.P1.X), 2) + MathF.Pow((Item.P2.Y - Item.P1.Y), 2));
            float distance = num / dom;
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