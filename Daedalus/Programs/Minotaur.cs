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
        private int Res;
        private int LastRes;
        private DaedalusForm Form;
        private PointF Pos;
        private float[] Angles;
        private float ViewDist;

        private List<PointF> Map = new List<PointF>();

        public Minotaur(DaedalusForm Form, float Size, float ViewDist = 100, int Resolution = 10)
        {
            this.Form = Form;
            Radius = Size;
            this.ViewDist = ViewDist;
            LastRes = Res = Resolution;
            CalculateRes();
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
            
            for (int i = 0; i < Angles.Length; i++)
            {
                if (Form.WallDetectAngle(Pos, Angles[i], ViewDist, out PointF Hit))
                {
                    //Add Point to list
                    if (!Map.Contains(Hit))
                        Map.Add(Hit);
                }
            }

            foreach (PointF item in Map)
            {
                //Add to draw
                Form.AddPoint(item);
                
            }

            Map.Clear();
            
            Form.MinoEndUpdate();
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
