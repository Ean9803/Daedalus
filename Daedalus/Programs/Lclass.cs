/**
 * Lclass.cs
 * 
 * This file conatins the basic building blocks for map creation and wall
 * detection. This includes both map construction using the Line class and
 * navigation net construction.
 * 
 * Last Modifier: Fillip Cannard
 * Last Modified: 4/25/2023
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

/**
 * Contains all the basic building blocks for creating and storing maps and 
 * walls. Also used for detecting and drawing walls.
 */
public static class Lclass
{
    /**
     * Contains line data to create rectangular walls on the map
     */
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
        private float LastWidth = float.NaN;

        /**
         * Sets the highlight property of a line to be highlighted or not
         */
        public void SetHighlight(bool Val)
        {
            Highlight = Val;
        }

        /**
         * Updates and calculates all the different properties of a line object.
         * It also stores previous measurments of the line to recalculate the
         * dimensions while the user pans or zooms into the map.
         * 
         * While this might seem unintuitive to have most calculations in one 
         * fucntion, it allows for all the values to be updated in the correct
         * order and prevents dependent values from being uncalculated or not 
         * updated if the points of the line have changed.
         */
        private void UpdateLineProperties()
        {
            if (LastP1 != P1 || LastP2 != P2 || LastSlope == float.NaN || LastDistance == float.NaN || LastWidth != Width)
            {
                LastWidth = Width;

                PointF Direction = new PointF();
                Direction.X = P1.X - P2.X;
                Direction.Y = P1.Y - P2.Y;

                LastP1 = P1;
                LastP2 = P2;

                // Calculate distance
                float distance = (float)Math.Sqrt(Math.Pow((Direction.X), 2) + Math.Pow((Direction.Y), 2));

                // Calculate slope
                float YSlope = (Direction.Y / distance);
                float XSlope = (Direction.X / distance);

                // Assign calculated values
                LastDistance = distance;
                Slope = new PointF(XSlope, YSlope);
                LastSlope = YSlope / XSlope;
            }
        }

        /**
         * Updates the line properties and then returns the slope of the line
         */
        public PointF getSlope()
        {
            UpdateLineProperties();
            return Slope;
        }

        /**
         * Updates the line properties and then returns the last slope of the line
         */
        public float getSlopeValue()
        {
            UpdateLineProperties();
            return LastSlope;
        }

        /**
         * Updates the line properties and then returns the length of the line
         */
        public float Length()
        {
            UpdateLineProperties();
            return LastDistance;
        }

        /**
         * Creates a rectangle stored as 4 lines around the given line with the 
         * width of the rectangle defined in the line object
         */
        public Line[] GenerateRec(bool EqualExtensions = false)
        {
            UpdateLineProperties();

            if (LastDistance == 0)
                return new Line[0];

            Line[] Ret = new Line[4];
            PointF PP1 = P1;
            PointF PP2 = P2;
            float RectWidth = Width;

            float YSlope = Slope.Y;
            float XSlope = Slope.X;

            for (int i = 0; i < Ret.Length; i++)
            {
                Ret[i] = new Line();
                Ret[i].SetHighlight(Highlight);
                Ret[i].Width = 0;
                Ret[i].P1.X = PP1.X;
                Ret[i].P1.Y = PP1.Y;
                Ret[i].P2.X = PP2.X;
                Ret[i].P2.Y = PP2.Y;

                if (EqualExtensions)
                {
                    Ret[i].P1.X += (XSlope * RectWidth);
                    Ret[i].P1.Y += (YSlope * RectWidth);
                    Ret[i].P2.X -= (XSlope * RectWidth);
                    Ret[i].P2.Y -= (YSlope * RectWidth);
                }
            }

            Ret[0].P1.X += (YSlope * RectWidth);
            Ret[0].P1.Y -= (XSlope * RectWidth);

            Ret[0].P2.X += (YSlope * RectWidth);
            Ret[0].P2.Y -= (XSlope * RectWidth);

            Ret[1].P1.X -= (YSlope * RectWidth);
            Ret[1].P1.Y += (XSlope * RectWidth);

            Ret[1].P2.X -= (YSlope * RectWidth);
            Ret[1].P2.Y += (XSlope * RectWidth);

            Ret[2].P1 = Ret[0].P1;
            Ret[2].P2 = Ret[1].P1;
            Ret[3].P1 = Ret[0].P2;
            Ret[3].P2 = Ret[1].P2;

            return Ret;
        }

        /**
         * Creates a rectangle stored as 4 lines around the given line, but
         * is calculated based on the zoom ratio and panning distance
         */
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

    /**
     * Bricks are a type of line that allows for them to be connected
     * to one another. This is primarily used for wall detection by the
     * minotaur and connects lines to the Bricks, extending them. They
     * are essentially the building blocks of the navnet for the minotaur.
     */
    public class Brick : Line
    {
        public Brick LeftBrick;
        public Brick RightBrick;
        public List<PointF> Regions = new List<PointF>();

        /**
         * Extends an already existing brick by adding a point that is
         * close enough to the Brick, but does not already exist in the brick
         */
        public Brick AddRegion(PointF Region)
        {
            if (!Regions.Contains(Region))
                Regions.Add(Region);
            return this;
        }

        /**
         * Extends a brick by adding multiple points
         */
        public Brick AddRegions(List<PointF> Region)
        {
            foreach (PointF item in Region)
            {
                AddRegion(item);
            }
            return this;
        }

        /**
         * Connects differnt Bricks that are close enough together
         */
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

        /**
         * Disconnects Bricks if new information that is gathered causes the
         * minotaur to think there are two independent Bricks rather than one
         * large one
         */
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

    /**
     * Contains collision point information
     */
    public class CollisionPoint
    {
        public PointF Point;
        public bool Hit;
    }
}
