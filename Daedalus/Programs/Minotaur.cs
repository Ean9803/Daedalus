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
        private Knossos KnossosForm;
        private PointF Pos;
        private float[] Angles;
        private int LastRes;

        private Map minotaurMap;

        public Minotaur(Knossos KnossosForm)
        {
            this.KnossosForm = KnossosForm;
            CalculateRes();
            minotaurMap = new Map(25);
        }

        public float getRadius()
        {
            return Knossos.KnossosUI.Settings.Mino_Radius;
        }

        public void WipeMemory()
        {
            minotaurMap.ClearMemory();
        }

        public void RefreshMap()
        {
            minotaurMap.RefreshChunks();
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
            minotaurMap.ImportMapData(Data, getRadius() + Knossos.KnossosUI.Settings.ExpansionBias);
        }

        public void Update()
        {
            if (LastRes != (int)Knossos.KnossosUI.Settings.RayCount)
            {
                CalculateRes();
                LastRes = (int)Knossos.KnossosUI.Settings.RayCount;
            }

            KnossosForm.WallDetectAngle(Pos, Angles, Knossos.KnossosUI.Settings.Mino_ViewDist, out List<Lclass.CollisionPoint> Hits);
            minotaurMap.CreateBuffer(Hits, getPosition());
        }

        public void ConstantUpdate()
        {
            minotaurMap.DisplayMap(getPosition(), (int)Knossos.KnossosUI.Settings.ObjectRadius_Show, (int)Knossos.KnossosUI.Settings.ChunkRadius_Show);
            KnossosForm.MinoRefresh();
            KnossosForm.MinoEndUpdate();
        }

        private void CalculateRes()
        {
            Angles = new float[(int)Knossos.KnossosUI.Settings.RayCount + 1];
            for (int i = 0; i <= (int)Knossos.KnossosUI.Settings.RayCount; i++)
            {
                Angles[i] = ((float)i / (int)Knossos.KnossosUI.Settings.RayCount) * 360;
            }
        }
    }
}
