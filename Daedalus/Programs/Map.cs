using Daedalus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

public class Map
{
    public Map()
    {

    }

    public void CreateBuffer(List<PointF> collisionPoints, PointF location, float Radius)
    {
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
        for (int i = 1; i < currentPoints.Count + 1; i++)
        {
            prevIndex = i - 1;
            index = i % orderedList.Count;

            // Check to see if we have reached the end of the list
            float currentSlopeX = currentPoints[index].Value.X - currentPoints[prevIndex].Value.X;
            float currentSlopeY = currentPoints[index].Value.Y - currentPoints[prevIndex].Value.Y;
            float normalizedSlopeX = currentSlopeX / MathF.Max(currentSlopeX, currentSlopeY);
            float normalizedSlopeY = currentSlopeY / MathF.Max(currentSlopeX, currentSlopeY);
            currentSlopeX = normalizedSlopeX;
            currentSlopeY = normalizedSlopeY;
            if (PrevSlope == null)
            {
                PrevSlope = new PointF(currentSlopeX, currentSlopeY);
                preBuffers.Add(new Lclass.Line() { P1 = currentPoints[prevIndex].Value, P2 = currentPoints[index].Value, Width = 2 });
            }
            else
            {
                if (ruleCheck(currentPoints[index].Value, currentPoints[prevIndex].Value, Radius))
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

        double ValI = 0;
        foreach (Lclass.Line item in preBuffers)
        {
            Knossos.KnossosUI.addLine(item, HSL2RGB(ValI, 0.5, 0.5));
            ValI += 0.25;
            if (ValI >= 1)
                ValI = 0;
        }
    }

    public void Refresh(float Radius)
    {

    }

    private bool ruleCheck(PointF P1, PointF P2, float radius)
    {
        float xDiff = P2.X - P1.X;
        float yDiff = P2.Y - P1.Y;

        return (xDiff <= radius) && (yDiff <= radius);
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