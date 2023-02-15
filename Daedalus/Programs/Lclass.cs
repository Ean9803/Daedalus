using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

public static class Lclass
{
    public class Line
    {
        public PointF P1 = new PointF(0, 0);
        public PointF P2 = new PointF(0, 0);
        public float Width = 1;
        public bool Highlight;

        public void SetHighlight(bool Val)
        {
            Highlight = Val;
        }

        public Line[] GenerateRec()
        {
            Line[] Ret = new Line[4];
            PointF PP1 = P1;
            PointF PP2 = P2;

            for (int i = 0; i < Ret.Length; i++)
            {
                Ret[i] = new Line();
                Ret[i].SetHighlight(Highlight);
                Ret[i].Width = 0;
                Ret[i].P1.X = PP1.X;
                Ret[i].P1.Y = PP1.Y;
                Ret[i].P2.X = PP2.X;
                Ret[i].P2.Y = PP2.Y;
            }

            PointF Direction = new PointF();
            Direction.X = P1.X - P2.X;
            Direction.Y = P1.Y - P2.Y;

            float distance = (float)Math.Sqrt(Math.Pow((Direction.X), 2) + Math.Pow((Direction.Y), 2));

            float YSlope = (Direction.Y / distance);
            float XSlope = (Direction.X / distance);
            Ret[0].P1.X += (YSlope * Width);
            Ret[0].P1.Y += (XSlope * Width);
            Ret[0].P2.X += (YSlope * Width);
            Ret[0].P2.Y += (XSlope * Width);
            Ret[1].P1.X -= (YSlope * Width);
            Ret[1].P1.Y -= (XSlope * Width);
            Ret[1].P2.X -= (YSlope * Width);
            Ret[1].P2.Y -= (XSlope * Width);

            Ret[2].P1 = Ret[0].P1;
            Ret[2].P2 = Ret[1].P1;
            Ret[3].P1 = Ret[0].P2;
            Ret[3].P2 = Ret[1].P2;


            return Ret;
        }

        public Line[] GenerateRec(PointF Origin, float ZoomAmount)
        {
            Line[] Ret = new Line[4];
            PointF PP1 = P1;
            PP1.X /= ZoomAmount;
            PP1.Y /= ZoomAmount;
            PointF PP2 = P2;
            PP2.X /= ZoomAmount;
            PP2.Y /= ZoomAmount;

            float RectWidth = Width / ZoomAmount;

            for (int i = 0; i < Ret.Length; i++)
            {
                Ret[i] = new Line();
                Ret[i].SetHighlight(Highlight);
                Ret[i].Width = 0;
                Ret[i].P1.X = (int)((PP1.X + Origin.X));
                Ret[i].P1.Y = (int)((-PP1.Y + Origin.Y));
                Ret[i].P2.X = (int)((PP2.X + Origin.X));
                Ret[i].P2.Y = (int)((-PP2.Y + Origin.Y));
            }

            PointF Direction = new PointF();
            Direction.X = P1.X - P2.X;
            Direction.Y = P1.Y - P2.Y;

            float distance = (float)Math.Sqrt(Math.Pow((Direction.X), 2) + Math.Pow((Direction.Y), 2));

            float YSlope = (Direction.Y / distance);
            float XSlope = (Direction.X / distance);
            Ret[0].P1.X += (YSlope * RectWidth);
            Ret[0].P1.Y += (XSlope * RectWidth);
            Ret[0].P2.X += (YSlope * RectWidth);
            Ret[0].P2.Y += (XSlope * RectWidth);
            Ret[1].P1.X -= (YSlope * RectWidth);
            Ret[1].P1.Y -= (XSlope * RectWidth);
            Ret[1].P2.X -= (YSlope * RectWidth);
            Ret[1].P2.Y -= (XSlope * RectWidth);

            Ret[2].P1 = Ret[0].P1;
            Ret[2].P2 = Ret[1].P1;
            Ret[3].P1 = Ret[0].P2;
            Ret[3].P2 = Ret[1].P2;


            return Ret;
        }
    }

    public class Brick : Line
    {
        public Brick LeftBrick;
        public Brick RightBrick;
    }
}
