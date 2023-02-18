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
        private float Radius;
        private float bias;
        private int Res;
        private int LastRes;
        private Knossos KnossosForm;
        private PointF Pos;
        private float[] Angles;
        private float ViewDist;

        private List<PointF> Map = new List<PointF>();
        private Map minotaurMap;

        public Minotaur(Knossos KnossosForm, float Size, float ViewDist = 100, int Resolution = 10, float bias = 1)
        {
            this.KnossosForm = KnossosForm;
            Radius = Size;
            this.bias = bias;
            this.ViewDist = ViewDist;
            LastRes = Res = Resolution;
            CalculateRes();
            minotaurMap = new Map();
        }

        public float getRadius()
        {
            return Radius;
        }

        public PointF getPosition()
        {
            return Pos;
        }

        public void SetPosition(PointF Point)
        {
            Pos = Point;
        }

        public void Update()
        {
            if (LastRes != Res)
            {
                CalculateRes();
                LastRes = Res;
            }

            if (KnossosForm.WallDetectAngle(Pos, Angles, ViewDist, out List<PointF?> Hits))
            {
                //Add Point to list
                foreach (PointF? item in Hits)
                {
                    if (item != null)
                        Map.Add((PointF)item);
                }
            }

            foreach (PointF item in Map)
            {
                //Add to draw
                KnossosForm.AddPoint(item, Color.Red);
            }

            minotaurMap.CreateBuffer(Map, getPosition(), Radius + bias);
            Map.Clear();

            KnossosForm.MinoEndUpdate();
        }

        private void CalculateRes()
        {
            Angles = new float[Res + 1];
            for (int i = 0; i <= Res; i++)
            {
                Angles[i] = ((float)i / Res) * 360;
            }
        }
    }
}
