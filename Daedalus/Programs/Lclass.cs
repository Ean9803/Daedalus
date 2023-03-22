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

        private float LastSlope = float.NaN;
        private float LastDistance = float.NaN;
        private PointF LastP1 = Point.Empty;
        private PointF LastP2 = Point.Empty;
        private PointF Slope = Point.Empty;

        public void SetHighlight(bool Val)
        {
            Highlight = Val;
        }

        private void UpdateLineProperties()
        {
            if (LastP1 != P1 || LastP2 != P2 || LastSlope == float.NaN || LastDistance == float.NaN)
            {
                PointF Direction = new PointF();
                Direction.X = P1.X - P2.X;
                Direction.Y = P1.Y - P2.Y;

                LastP1 = P1;
                LastP2 = P2;

                float distance = (float)Math.Sqrt(Math.Pow((Direction.X), 2) + Math.Pow((Direction.Y), 2));

                float YSlope = (Direction.Y / distance);
                float XSlope = (Direction.X / distance);

                LastDistance = distance;
                Slope = new PointF(XSlope, YSlope);
                LastSlope = YSlope / XSlope;
            }
        }

        public PointF getSlope()
        {
            UpdateLineProperties();
            return Slope;
        }

        public float getSlopeValue()
        {
            UpdateLineProperties();
            return LastSlope;
        }

        public float Length()
        {
            UpdateLineProperties();
            return LastDistance;
        }

        public Line[] GenerateRec()
        {
            UpdateLineProperties();

            if (LastDistance == 0)
                return new Line[0];

            Line[] Ret = new Line[4];
            PointF PP1 = P1;
            PointF PP2 = P2;
            float RectWidth = Width;

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

            float YSlope = Slope.Y;
            float XSlope = Slope.X;

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

        public Line[] GenerateRec(PointF Origin, float ZoomAmount)
        {
            UpdateLineProperties();

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

            float YSlope = Slope.Y;
            float XSlope = Slope.X;

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
        public List<PointF> Regions = new List<PointF>();
        private Map parentMap;

        public Brick AddRegion(PointF Region)
        {
            if (!Regions.Contains(Region))
                Regions.Add(Region);
            return this;
        }

        public Brick AddRegions(List<PointF> Region)
        {
            foreach (PointF item in Region)
            {
                AddRegion(item);
            }
            return this;
        }

        public List<PointF> AddToParent(Brick NewBrick, ref Dictionary<PointF, List<Brick>> Dict)
        {
            List<PointF> Affected = new List<PointF>();
            foreach (PointF item in Regions)
            {
                if (Dict.ContainsKey(item))
                {
                    Dict[item].Add(NewBrick);
                    Affected.Add(item);
                }
            }
            return Affected;
        }

        public void RemoveFromParent(ref Dictionary<PointF, List<Brick>> Dict)
        {
            foreach (PointF item in Regions)
            {
                if (Dict.ContainsKey(item))
                {
                    Dict[item].Remove(this);
                }
            }
            Regions.Clear();
        }
    }

    public class CollisionPoint
    {
        public PointF Point;
        public bool Hit;
    }
}
