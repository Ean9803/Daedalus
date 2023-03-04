using Daedalus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

public class Map
{
    float brickWidth = 0;
    List<Lclass.Brick> bricks = new List<Lclass.Brick>();

    public Map(float brickWidth = 3)
    {
        this.brickWidth = brickWidth;
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

    public void CreateBuffer(List<PointF> collisionPoints, PointF location, float Radius)
    {
        //test();
        //return;

        // Sorting Points
        SortedDictionary<double, PointF> orderedList = new SortedDictionary<double, PointF>();
        double angle;
        for (int i = 0; i < collisionPoints.Count; i++)
        {
            angle = getAngleRad(location, collisionPoints[i]);
            if (!orderedList.ContainsKey(angle))
                orderedList.Add(angle, collisionPoints[i]);
        }
        int index = 0;
        int prevIndex = 0;

        // Connecting points
        List<Lclass.Line> preBuffers = new List<Lclass.Line>();
        PointF? PrevSlope = null;
        List<KeyValuePair<double, PointF>> currentPoints = orderedList.ToList();
        for (int i = 1; i < currentPoints.Count; i++)
        {
            prevIndex = i - 1;
            index = i % currentPoints.Count;

            // Check to see if we have reached the end of the list
            float currentSlopeX = currentPoints[index].Value.X - currentPoints[prevIndex].Value.X;
            float currentSlopeY = currentPoints[index].Value.Y - currentPoints[prevIndex].Value.Y;
            float normalizedSlopeX = currentSlopeX / MathF.Max(currentSlopeX, currentSlopeY);
            float normalizedSlopeY = currentSlopeY / MathF.Max(currentSlopeX, currentSlopeY);
            currentSlopeX = normalizedSlopeX;
            currentSlopeY = normalizedSlopeY;

            if (ruleCheck(currentPoints[index].Value, currentPoints[prevIndex].Value, Radius))
            {
                if (PrevSlope == null)
                {
                    PrevSlope = new PointF(currentSlopeX, currentSlopeY);
                    preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex].Value, P2 = currentPoints[index].Value, Width = 2 });
                }
                else
                {
                    bool match = InRange(((PointF)(PrevSlope)).X, currentSlopeX, 0.1f) && InRange(((PointF)(PrevSlope)).Y, currentSlopeY, 0.1f);
                    if (match)
                    {
                        Lclass.Line existingLine = preBuffers[preBuffers.Count - 1];
                        existingLine.P2 = currentPoints[index].Value;
                    }
                    else
                    {
                        PrevSlope = new PointF(currentSlopeX, currentSlopeY);
                        preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex].Value, P2 = currentPoints[index].Value, Width = 2 });
                    }
                }
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

        double ValI = 0;
        foreach (Lclass.Line item in preBuffers)
        {
            Knossos.KnossosUI.addLine(item, HSL2RGB(ValI, 0.5, 0.5));
            ValI += 0.25;
            if (ValI >= 1)
                ValI = 0;
        }
    }

    private struct sledgeHammer
    {
        public Lclass.Brick intersectingBrick;
        public float slope;
        public enum point {p1, p2, both }
        public point ouioui;
    }

    private void processPreBuffers(List<Lclass.Line> preBuffers)
    {
        if(preBuffers.Count == 0)
        {
            return;
        }

        List<sledgeHammer> wreckingBall = new List<sledgeHammer>();

        foreach (Lclass.Brick item in bricks)
        {

            float point1 = PointDistanceToLine(item, preBuffers[0].P1);
            float point2 = PointDistanceToLine(item, preBuffers[0].P2);
            
            if (point1 != float.MaxValue ^ point2 != float.MaxValue)
            {
                bool state1 = false;
                bool state2 = false;
                if(MathF.Abs(point1) < brickWidth)
                {
                    state1 = true;
                }
                if(MathF.Abs(point2) < brickWidth)
                {
                    state2 = true;
                }
                if ((!(!state1 && !state2)) && InRange(preBuffers[0].getSlope(), item.getSlope(), 0.01f))
                {
                    wreckingBall.Add(new sledgeHammer()
                    {
                        intersectingBrick = item,
                        slope = item.getSlope(),
                        ouioui = (state1 && state2 ? sledgeHammer.point.both:(state1 ? sledgeHammer.point.p1 : sledgeHammer.point.p2))
                    });
                }
            }
        }
        if(wreckingBall.Count == 0)
        {
            bricks.Add(new Lclass.Brick() { P1 = preBuffers[0].P1, P2 = preBuffers[0].P2, Width = brickWidth });
        }
        else
        {
            foreach(sledgeHammer item in wreckingBall)
            {
                switch (item.ouioui)
                {
                    case sledgeHammer.point.p1:

                        break;
                    case sledgeHammer.point.p2:
                        break;
                    case sledgeHammer.point.both:
                        break;
                    default:
                        break;
                }

            }
        }
        preBuffers.RemoveAt(0);
        processPreBuffers(preBuffers);
    }

    public void Refresh(float Radius)
    {

    }

    private bool ruleCheck(PointF P1, PointF P2, float radius)
    {
        float xDiff = P2.X - P1.X;
        float yDiff = P2.Y - P1.Y;

        return (MathF.Pow(xDiff, 2)+MathF.Pow(yDiff, 2) <= radius*radius);
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
        if (Dist(Mid, Point) <= Dist(Mid, Item.P1))
        {
            float num = MathF.Abs((Item.P2.X - Item.P1.X) * (Item.P1.Y - Point.Y) - (Item.P1.X - Point.X) * (Item.P2.Y - Item.P1.Y));
            float dom = MathF.Sqrt(MathF.Pow((Item.P2.X - Item.P1.X), 2) + MathF.Pow((Item.P2.Y - Item.P1.Y), 2));
            return num / dom;
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