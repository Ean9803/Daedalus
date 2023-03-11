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
        private float Diameter;
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
            Diameter = Size;
            this.bias = bias;
            this.ViewDist = ViewDist;
            LastRes = Res = Resolution;
            CalculateRes();
            minotaurMap = new Map(Size + (bias * 2), 25, 25);
        }

        public float getRadius()
        {
            return Diameter;
        }

        public void WipeMemory()
        {
            minotaurMap.ClearMemory();
        }

        public PointF getPosition()
        {
            return Pos;
        }

        public void SetPosition(PointF Point)
        {
            Pos = Point;
        }

        public string ExportMapData()
        {
            return minotaurMap.ExportMapData();
        }

        public void ImportMapData(string Data)
        {
            minotaurMap.ImportMapData(Data, Diameter + bias);
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

            minotaurMap.CreateBuffer(Map, getPosition(), Diameter + bias);
            Map.Clear();
        }

        public void ConstantUpdate()
        {
            minotaurMap.DisplayMap(getPosition(), 1, Diameter + bias);
            KnossosForm.MinoRefresh();
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
