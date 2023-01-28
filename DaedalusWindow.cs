using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Daedalus.DaedalusForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using Daedalus.Daedalus.Programs;

namespace Daedalus
{
    public partial class DaedalusForm : Form
    {
        Minotaur Mino;
        public DaedalusForm()
        {
            InitializeComponent();
            Mino = new Minotaur(this, 1);
        }

        public delegate void SceneDel(DaedalusForm Form);
        SceneDel RefreshSceneWindows;

        System.Drawing.SolidBrush BrushColor = new System.Drawing.SolidBrush(Color.Wheat);
        Random random = new Random();

        private Dictionary<string, string> LogOuput = new Dictionary<string, string>();
        private Dictionary<string, string> MapLogOuput = new Dictionary<string, string>();

        private const float LineWidth = 10;
        private float ZoomAmount;

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

        public PointF CalculateViewPosition(PointF In)
        {
            return new PointF((In.X / ZoomAmount) + Origin.X, -(In.Y / ZoomAmount) + Origin.Y);
        }

        public List<Line> Walls = new List<Line>();
        public List<Line> EraseWalls = new List<Line>();
        public List<PointF> MapPoints = new List<PointF>();

        private void DaedalusForm_Load(object sender, EventArgs e)
        {
            SetLabPenMode(labPenMode.Draw);
            SetMapMode(mapPenMode.Roam);
            SetMinoState(MinoMode.Off);
            StartWorkers();
            RefreshSceneWindows = RefreshScene;
            ScreenOrigin = new PointF(labyrinthScene.Width / 2, labyrinthScene.Height / 2);
            ZoomAmount = (zoomSlider.Maximum - zoomSlider.Value) + 1;
        }

        int WorkersOpen = 0;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MinotaurWorker.IsBusy || LabyrinthUpdate.IsBusy)
            {
                UpdateFrames = false;
                SetMinoState(MinoMode.Off);
                MinotaurWorker.CancelAsync();
                LabyrinthUpdate.CancelAsync();
                e.Cancel = true;
                this.Enabled = false;
                return;
            }
            base.OnFormClosing(e);
        }

        private void DaedalusForm_Close(object sender, FormClosingEventArgs e)
        {
            DisposeWorkers();
            Dispose(true);
        }

        private void StartWorkers()
        {
            UpdateFrames = true;
            WorkersOpen = 2;
            MinotaurWorker.RunWorkerAsync(this);
            LabyrinthUpdate.RunWorkerAsync(this);
        }

        private void DisposeWorkers()
        {
            MinotaurWorker.Dispose();
            LabyrinthUpdate.Dispose();
        }

        private void backgroundWorker_End(object sender, RunWorkerCompletedEventArgs e)
        {
            WorkersOpen--;
            if (WorkersOpen <= 0) this.Close();
        }

        #region PenControls

        public enum labPenMode { Draw, Erase }
        public enum mapPenMode { Roam, Target }
        private labPenMode labPen = labPenMode.Draw;
        private mapPenMode mapPen = mapPenMode.Roam;

        private void UpdateLabToolBar()
        {
            labyrinthTool.Text = "Pen Mode: " + labPen.ToString();
        }

        private void UpdateMapToolBar()
        {
            mapMode.Text = "Mode: " + mapPen.ToString();
        }

        public void SetLabPenMode(labPenMode Mode)
        {
            labPen = Mode;
            UpdateLabToolBar();
        }

        public void SetMapMode(mapPenMode Mode)
        {
            mapPen = Mode;
            UpdateMapToolBar();
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            SetLabPenMode(labPenMode.Draw);
        }

        private void eraseBtn_Click(object sender, EventArgs e)
        {
            SetLabPenMode(labPenMode.Erase);
        }

        private void roamBtn_Click(object sender, EventArgs e)
        {
            SetMapMode(mapPenMode.Roam);
        }

        private void targetBtn_Click(object sender, EventArgs e)
        {
            SetMapMode(mapPenMode.Target);
        }

        #endregion

        #region FileHandling

        private static string FileExtension = ".blueprint";
        private static string FilterDialog = FileExtension + " files (*" + FileExtension + ") | *" + FileExtension;

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveMapFile.Title = "Save Labyrinth File";
            saveMapFile.AddExtension = false;
            saveMapFile.Filter = FilterDialog;
            saveMapFile.DefaultExt = FileExtension;
            saveMapFile.FileName = "New_Blueprint";
            saveMapFile.ShowDialog();
        }

        private void saveMapFile_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                ProcessSaveFile(saveMapFile.FileName);
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            openMapFile.Title = "Load Labyrinth File";
            openMapFile.Multiselect = false;
            openMapFile.DefaultExt = FileExtension;
            openMapFile.Filter = FilterDialog;
            openMapFile.ShowDialog(Owner);
        }

        private void openMapFile_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                ProcessLoadFile(openMapFile.FileName);
            }
        }

        private void ProcessSaveFile(string FilePath)
        {
            string output = "";
            foreach (Line item in Walls)
            {
                output += item.P1.X + "/" + item.P1.Y + "#" + item.P2.X + "/" + item.P2.Y + "___";
            }
            File.WriteAllText(FilePath, output);
        }

        private void ProcessLoadFile(string FilePath)
        {
            Walls.Clear();
            string input;
            input = File.ReadAllText(FilePath);
            System.Diagnostics.Debug.WriteLine(input);

            // Split all lines into individual coordinates
            string[] delimeters = {"___", "#", "/"};
            string[] coordinates = input.Split(delimeters, StringSplitOptions.None);

            // Four coordinates per line
            float x1, y1, x2, y2;
            for (int i = 0; i < coordinates.Length - 3; i += 4)
            {
                x1 = float.Parse(coordinates[i]);
                y1 = float.Parse(coordinates[i + 1]);
                x2 = float.Parse(coordinates[i + 2]);
                y2 = float.Parse(coordinates[i + 3]);

                Walls.Add(new Line() { P1 = new PointF(x1, y1), P2 = new PointF(x2, y2) });
            }

        }

        #endregion

        #region DisplayControl

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Walls.Clear();
        }

        private void zoomSlider_Scroll(object sender, EventArgs e)
        {
            ZoomAmount = (zoomSlider.Maximum - zoomSlider.Value) + 1;
        }

        private void UpdateOrigin()
        {
            ScreenOrigin.X = labyrinthScene.Width / 2;
            ScreenOrigin.Y = labyrinthScene.Height / 2;
            Origin.X = ScreenOrigin.X + (OriginOffset.X / ZoomAmount);
            Origin.Y = ScreenOrigin.Y + (OriginOffset.Y / ZoomAmount);
        }

        private PointF MouseLocation;
        private PointF MouseLocationMap;
        private bool Pan = false;
        private PointF OriginOffset;
        private PointF Origin;
        private PointF ScreenOrigin;
        private PointF MouseLocationLab;

        private PointF StartLine;
        private bool CreatingLine;
        private Line TempLine = new Line() { P1 = new PointF() { X = 0, Y = 1 }, P2 = new PointF() { X = 1, Y = 1 }, Width = 1 };

        private void labyrinthScene_Mouse(object sender, MouseEventArgs e)
        {
            PointF Current = new PointF();
            Current.X = (int)(e.Location.X);
            Current.Y = (int)(e.Location.Y);
            if (Pan)
            {
                float DiffX = Current.X - MouseLocation.X;
                float DiffY = Current.Y - MouseLocation.Y;
                OriginOffset.X += DiffX * ZoomAmount;
                OriginOffset.Y += DiffY * ZoomAmount;
            }
            MouseLocation = Current;
            MouseLocationLab.X = (MouseLocation.X - (ScreenOrigin.X + (OriginOffset.X / ZoomAmount))) * ZoomAmount;
            MouseLocationLab.Y = -((MouseLocation.Y - (ScreenOrigin.Y + (OriginOffset.Y / ZoomAmount))) * ZoomAmount);

            if (CreatingLine && labPen == labPenMode.Draw)
            {
                TempLine.Width = LineWidth;
                TempLine.P1 = StartLine;
                TempLine.P2 = MouseLocationLab;
            }

            if (labPen == labPenMode.Erase)
            {
                EraseWalls.Clear();
                for (int i = 0; i < Walls.Count; i++)
                {
                    Walls[i].SetHighlight(false);
                    foreach (Line item in Walls[i].GenerateRec(Origin, ZoomAmount))
                    {
                        if (Dist(item.P1, MouseLocation) <= 20 || Dist(item.P2, MouseLocation) <= 20 || PointDistanceToLine(item, MouseLocation) <= 20)
                        {
                            Walls[i].SetHighlight(true);
                            if (!EraseWalls.Contains(Walls[i]))
                            {
                                EraseWalls.Add(Walls[i]);
                            }
                        }
                    }

                    continue;
                }
            }
        }

        private PointF midpoint(PointF A, PointF B)
        {
            PointF ret = new PointF();
            ret.X = (A.X + B.X) / 2;
            ret.Y = (A.Y + B.Y) / 2;
            return ret;
        }

        private float PointDistanceToLine(Line Item, PointF Point)
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

        private void labyrinthScene_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Pan = true;
            }
            if (labPen == labPenMode.Draw)
            {
                if (e.Button == MouseButtons.Left)
                {
                    StartLine = MouseLocationLab;
                    TempLine.Width = LineWidth;
                    TempLine.P1 = StartLine;
                    TempLine.P2 = MouseLocationLab;
                    CreatingLine = true;
                }
            }
            else if (labPen == labPenMode.Erase)
            {
                if (e.Button == MouseButtons.Left)
                {
                    foreach (Line item in EraseWalls)
                    {
                        Walls.Remove(item);
                    }
                }
            }
        }

        private double Dist(PointF P1, PointF P2)
        {
            float num = P1.X - P2.X;
            float num2 = P1.Y - P2.Y;
            return Math.Sqrt(num * num + num2 * num2);
        }

        private PointF Add(PointF P1, PointF P2)
        {
            return new PointF(P1.X + P2.X, P1.Y + P2.Y);
        }

        private void labyrinthScene_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Pan = false;
            }
            if (labPen == labPenMode.Draw)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (CreatingLine)
                    {
                        CreatingLine = false;
                        AddLine(StartLine, MouseLocationLab);
                    }
                }
            }
        }

        private void labyrinthScene_MouseLeave(object sender, EventArgs e)
        {
            if (CreatingLine)
            {
                CreatingLine = false;
                AddLine(StartLine, MouseLocationLab);
            }
            Pan = false;
        }

        private void AddLine(PointF P1, PointF P2)
        {
            if (Dist(TempLine.P1, TempLine.P2) > 0.1f)
            {
                Walls.Add(new Line()
                {
                    P1 = P1,
                    P2 = P2,
                    Width = LineWidth
                });
            }
        }

        private void mapScene_Mouse(object sender, MouseEventArgs e)
        {
            PointF Current = new PointF();
            Current.X = (int)(e.Location.X);
            Current.Y = (int)(e.Location.Y);
            MouseLocationMap.X = (Current.X - Origin.X) * ZoomAmount;
            MouseLocationMap.Y = (-(Current.Y - Origin.Y)) * ZoomAmount;
        }

        public bool UpdateFrames = true;

        private void LabyrinthUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            while (UpdateFrames)
            {
                Thread.Sleep(5);
                this.Invoke(RefreshSceneWindows, e.Argument);
            }
        }

        private static void RefreshScene(DaedalusForm Form) { Form.PaintWindows(); }

        public void PaintWindows()
        {
            labyrinthScene.Refresh();
            mapScene.Refresh();
        }

        public void DebugLog(string Key, string Message, bool LabScene = true)
        {
            Dictionary<string, string> Dic = (LabScene ? LogOuput : MapLogOuput);
            if (string.IsNullOrEmpty(Message) && Dic.ContainsKey(Key))
            {
                Dic.Remove(Key);
            }
            else
            {
                if (Dic.ContainsKey(Key))
                    Dic[Key] = Message;
                else
                    Dic.Add(Key, Message);
            }
        }

        private void EraseDebugLog(string Key, bool LabScene = true)
        {
            Dictionary<string, string> Dic = (LabScene ? LogOuput : MapLogOuput);
            if (!string.IsNullOrEmpty(Key) && Dic.ContainsKey(Key))
            {
                Dic.Remove(Key);
            }
        }

        private void PrintMessages(Graphics window, Dictionary<string, string> Dic)
        {
            float i = 0;
            string[] items = Dic.Values.ToArray();
            foreach (string item in items)
            {
                window.DrawString(item, DefaultFont, BrushColor, 0, i);
                i += (0.2f + DefaultFont.Height);
            }
        }

        private void labyrinthScene_Paint(object sender, PaintEventArgs e)
        {
            Pen DrawPen = new Pen(Color.White, 2);
            Pen RedPen = new Pen(Color.Red, 2);
            Pen FillPen = new Pen(Color.Blue, 1);
            Graphics window = e.Graphics;
            UpdateOrigin();
            //TODO
            foreach (Line item in Walls)
            {
                foreach (Line Wall in item.GenerateRec(Origin, ZoomAmount))
                {
                    window.DrawLine(Wall.Highlight ? RedPen : DrawPen, Wall.P1, Wall.P2);
                }
            }

            window.DrawEllipse(DrawPen, Origin.X, Origin.Y, 1, 1);

            /*Debug to screen test*/
            DebugLog("Mouse Location - Lab", "Pen Location: " + MouseLocationLab.X.ToString() + " : " + MouseLocationLab.Y.ToString());
            DebugLog("Origin Location - Lab", "Origin Location: " + Origin.X.ToString() + " : " + Origin.Y.ToString());


            DrawPen = new Pen(Color.Green, 2);
            if (CreatingLine && labPen == labPenMode.Draw)
            {
                if (Dist(TempLine.P1, TempLine.P2) > 0.1f)
                {
                    foreach (Line Wall in TempLine.GenerateRec(Origin, ZoomAmount))
                    {
                        window.DrawLine(DrawPen, Wall.P1, Wall.P2);
                    }
                }
            }
            window.DrawEllipse(DrawPen, ScreenOrigin.X, ScreenOrigin.Y, 1, 1);

            PrintMessages(window, LogOuput);
            DrawPen.Dispose();
        }
        
        private void mapScene_Paint(object sender, PaintEventArgs e)
        {
            Pen DrawPen = new Pen(Color.White, 2);
            Graphics window = e.Graphics;
            
            int Count = MapPoints.Count;
            int StopCount = Count;
            PointF[] CopyMapPoints = new PointF[Count];
            for (int i = 0; i < Count; i++)
            {
                if (i < MapPoints.Count)
                {
                    CopyMapPoints[i] = MapPoints[i];
                }
            }

            window.DrawEllipse(DrawPen, Origin.X, Origin.Y, 1, 1);
            DebugLog("Mouse Location - Map", "Marker Location: " + MouseLocationMap.X.ToString() + " : " + MouseLocationMap.Y.ToString(), false);

            for (int i = 0; i < StopCount; i++)
            {
                window.DrawEllipse(DrawPen, CopyMapPoints[i].X, CopyMapPoints[i].Y, 1, 1);
            }

            if (Frame)
            {
                Frame = false;
                MapPoints.Clear();
            }

            PrintMessages(window, MapLogOuput);
            DrawPen.Dispose();
        }

        #endregion

        #region Minotaur

        public enum MinoMode { On, Off }
        private MinoMode MinoState;

        private void UpdateMinoControlBar()
        {
            stopBtn.Visible = MinoState == MinoMode.On;
            playBtn.Visible = MinoState == MinoMode.Off;
            mapToolStrip.Refresh();
        }

        public void SetMinoState(MinoMode Mode)
        {
            MinoState = Mode;
            UpdateMinoControlBar();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            SetMinoState(MinoMode.Off);
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            SetMinoState(MinoMode.On);
        }

        private void MinotaurWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (UpdateFrames)
            {
                if (MinoState == MinoMode.On)
                {
                    //TODO
                    DebugLog("Mino Status", "Mino Active", false);
                    Mino.Update();
                }
                else
                {
                    //TODO
                    DebugLog("Mino Status", "Mino Disabled", false);
                }
            }
        }

        public bool WallDetectAngle(PointF Origin, float Angle, float Dist, out PointF Hit)
        {
            return WallDetect(Origin, new PointF(MathF.Cos(Angle), MathF.Sin(Angle)), Dist, out Hit);
        }

        public bool WallDetect(PointF Origin, PointF Slope, float Dist, out PointF Hit)
        {
            PointF Max = Origin;

            float distance = (float)Math.Sqrt(Math.Pow((Slope.X), 2) + Math.Pow((Slope.Y), 2));

            float YSlope = (Slope.Y / distance);
            float XSlope = (Slope.X / distance);

            Max.X += XSlope * Dist;
            Max.Y += YSlope * Dist;

            PointF Ray = new PointF(Max.X - Origin.X, Max.Y - Origin.Y);
            float Per = 1;
            Hit = Max;
            foreach (Line Wall in Walls)
            {
                foreach (Line Face in Wall.GenerateRec())
                {
                    PointF WallLine = new PointF(Face.P2.X - Face.P1.X, Face.P2.Y - Face.P1.Y);
                    float t = (((Face.P1.X - Origin.X) * WallLine.Y) - ((Face.P1.Y - Origin.Y) * WallLine.X)) / (Ray.X * WallLine.Y - Ray.Y * WallLine.X);
                    float u = (((Origin.X - Face.P1.X) * Ray.Y) - ((Origin.Y - Face.P1.Y) * Ray.X)) / (WallLine.X * Ray.Y - WallLine.Y * Ray.X);
                    if (u >= 0 && u <= 1 && t >= 0 && t <= 1)
                    {
                        if (t < Per)
                        {
                            Per = t;
                            Hit = new PointF(Face.P1.X + ((Face.P2.X - Face.P1.X) * u), Face.P1.Y + ((Face.P2.Y - Face.P1.Y) * u));
                        }
                    }
                }
            }
            return true;// Per != 1;
        }

        private bool Frame = false;
        public void MinoEndUpdate()
        {
            Frame = true;
        }

        public void AddPoint(PointF pt)
        {
            PointF NewPoint = CalculateViewPosition(pt);
            if (!MapPoints.Contains(NewPoint))
                MapPoints.Add(NewPoint);
        }


        #endregion
    }
}