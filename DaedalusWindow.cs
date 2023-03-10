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
using static Daedalus.Knossos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using Daedalus.Daedalus.Programs;

namespace Daedalus
{
    public partial class Knossos : Form
    {
        Minotaur Mino;
        public static Knossos KnossosUI;
        public Knossos()
        {
            InitializeComponent();
            Mino = new Minotaur(this, 10, Resolution: 50);
            KnossosUI = this;
        }

        public delegate void SceneDel(Knossos Form);
        SceneDel RefreshSceneWindows;

        System.Drawing.SolidBrush BrushColor = new System.Drawing.SolidBrush(Color.Wheat);
        Random random = new Random();

        private Dictionary<string, string> LogOuput = new Dictionary<string, string>();
        private Dictionary<string, string> MapLogOuput = new Dictionary<string, string>();

        private const float LineWidth = 10;
        private float ZoomAmount;


        public PointF CalculateViewPosition(PointF In)
        {
            return new PointF((In.X / ZoomAmount) + Origin.X, -(In.Y / ZoomAmount) + Origin.Y);
        }

        public List<Lclass.Line> Walls = new List<Lclass.Line>();
        public List<Lclass.Line> EraseWalls = new List<Lclass.Line>();
        public List<KeyValuePair<PointF, TargetPoint>> MapPoints = new List<KeyValuePair<PointF, TargetPoint>>();
        public List<KeyValuePair<Lclass.Line, Color>> MapLines = new List<KeyValuePair<Lclass.Line, Color>>();

        private void DaedalusForm_Load(object sender, EventArgs e)
        {
            SetLabPenMode(labPenMode.Draw);
            SetMapMode(mapPenMode.Roam);
            SetMinoState(MinoMode.Off);
            StartWorkers();
            RefreshSceneWindows = RefreshScene;
            ScreenOrigin = new PointF(labyrinthScene.Width / 2, labyrinthScene.Height / 2);
            ZoomAmount = 1;
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

        public enum labPenMode { Draw, Erase, MinoPos }
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

        private void setMinoPos_Click(object sender, EventArgs e)
        {
            SetLabPenMode(labPenMode.MinoPos);
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
            foreach (Lclass.Line item in Walls)
            {
                output += item.P1.X + "/" + item.P1.Y + "#" + item.P2.X + "/" + item.P2.Y + "#" + item.Width + "___";
            }
            output += "\n" + Mino.ExportMapData();
            File.WriteAllText(FilePath, output);
        }

        private void ProcessLoadFile(string FilePath)
        {
            Walls.Clear();
            string input;
            input = File.ReadAllText(FilePath);
            string[] SplitData = input.Split('\n');
            input = SplitData[0];
            if (SplitData.Length > 1)
                Mino.ImportMapData(SplitData[1]);

            // Split all lines into individual coordinates
            string[] delimeters = {"___", "#", "/"};
            string[] coordinates = input.Split(delimeters, StringSplitOptions.None);

            // Four coordinates per line
            float x1, y1, x2, y2, width;
            for (int i = 0; i < coordinates.Length - 4; i += 5)
            {
                x1 = float.Parse(coordinates[i]);
                y1 = float.Parse(coordinates[i + 1]);
                x2 = float.Parse(coordinates[i + 2]);
                y2 = float.Parse(coordinates[i + 3]);
                width = float.Parse(coordinates[i + 4]);

                Walls.Add(new Lclass.Line() { P1 = new PointF(x1, y1), P2 = new PointF(x2, y2), Width = width });
            }

        }

        #endregion

        #region DisplayControl

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Walls.Clear();
        }

        private void ClearMemory_Click(object sender, EventArgs e)
        {
            Mino.WipeMemory();
        }

        private void zoomSlider_Scroll(object sender, EventArgs e)
        {
            ZoomAmount = MathF.Pow(((float)zoomSlider.Value + 1) / ((float)zoomSlider.Maximum / 2.0f), 2);
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
        private bool SetMino = false;
        private Lclass.Line TempLine = new Lclass.Line() { P1 = new PointF() { X = 0, Y = 1 }, P2 = new PointF() { X = 1, Y = 1 }, Width = 1 };

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
            else if (SetMino && labPen == labPenMode.MinoPos)
            {
                Mino.SetPosition(MouseLocationLab);
            }
            if (EraseWalls.Count > 0)
            {
                foreach (Lclass.Line item in EraseWalls)
                {
                    item.SetHighlight(false);
                }
            }
            EraseWalls.Clear();
            if (labPen == labPenMode.Erase)
            {
                for (int i = 0; i < Walls.Count; i++)
                {
                    Walls[i].SetHighlight(false);
                    if (PointDistanceToLine(Walls[i], MouseLocationLab))
                    {
                        Walls[i].SetHighlight(true);
                        if (!EraseWalls.Contains(Walls[i]))
                        {
                            EraseWalls.Add(Walls[i]);
                        }
                    }
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

        private bool PointDistanceToLine(Lclass.Line Item, PointF Point)
        {
            PointF Mid = midpoint(Item.P1, Item.P2);
            if (Dist(Mid, Point) <= Dist(Mid, Item.P1))
            {
                float num = MathF.Abs((Item.P2.X - Item.P1.X) * (Item.P1.Y - Point.Y) - (Item.P1.X - Point.X) * (Item.P2.Y - Item.P1.Y));
                float dom = MathF.Sqrt(MathF.Pow((Item.P2.X - Item.P1.X), 2) + MathF.Pow((Item.P2.Y - Item.P1.Y), 2));
                float Dist = num / dom;
                return Dist <= Item.Width;
            }
            return false;
        }

        private void mapScene_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Pan = true;
            }
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
                    foreach (Lclass.Line item in EraseWalls)
                    {
                        Walls.Remove(item);
                    }
                }
            }
            else if (labPen == labPenMode.MinoPos)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Mino.SetPosition(MouseLocationLab);
                    SetMino = true;
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
            else if (labPen == labPenMode.MinoPos)
            {
                if (e.Button == MouseButtons.Left)
                {
                    SetMino = false;
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
            SetMino = false;
            Pan = false;
        }

        private void mapScene_MouseLeave(object sender, EventArgs e)
        {
            Pan = false;
        }

        private void AddLine(PointF P1, PointF P2)
        {
            if (Dist(TempLine.P1, TempLine.P2) > 0.1f)
            {
                Walls.Add(new Lclass.Line()
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

            if (Pan)
            {
                float DiffX = Current.X - MouseLocation.X;
                float DiffY = Current.Y - MouseLocation.Y;
                OriginOffset.X += DiffX * ZoomAmount;
                OriginOffset.Y += DiffY * ZoomAmount;
            }
            MouseLocation = Current;
        }

        private void mapScene_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Pan = false;
            }
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

        private static void RefreshScene(Knossos Form) { Form.PaintWindows(); }

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
            Graphics window = e.Graphics;
            UpdateOrigin();
            //TODO
            foreach (Lclass.Line item in Walls)
            {
                foreach (Lclass.Line Wall in item.GenerateRec(Origin, ZoomAmount))
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
                    foreach (Lclass.Line Wall in TempLine.GenerateRec(Origin, ZoomAmount))
                    {
                        window.DrawLine(DrawPen, Wall.P1, Wall.P2);
                    }
                }
            }
            window.DrawEllipse(DrawPen, ScreenOrigin.X, ScreenOrigin.Y, 1, 1);

            DrawMino(window);

            PrintMessages(window, LogOuput);
            DrawPen.Dispose();
            RedPen.Dispose();
        }

        KeyValuePair<PointF, TargetPoint>[] CopyMapPoints;
        KeyValuePair<Lclass.Line, Color>[] CopyMapLines = new KeyValuePair<Lclass.Line, Color>[0];
        private void mapScene_Paint(object sender, PaintEventArgs e)
        {
            Pen DrawPen = new Pen(Color.White, 2);
            Graphics window = e.Graphics;
            
            int Count = MapPoints.Count;
            CopyMapPoints = new KeyValuePair<PointF, TargetPoint>[Count];
            for (int i = 0; i < Count; i++)
            {
                if (i < MapPoints.Count)
                {
                    CopyMapPoints[i] = MapPoints[i];
                }
            }
            if (UpdateFrame)
            {
                UpdateFrame = false;
                Count = MapLines.Count;
                CopyMapLines = new KeyValuePair<Lclass.Line, Color>[Count];
                for (int i = 0; i < Count; i++)
                {
                    if (i < MapLines.Count)
                    {
                        CopyMapLines[i] = MapLines[i];
                    }
                }
            }

            window.DrawEllipse(DrawPen, Origin.X, Origin.Y, 1, 1);
            DebugLog("Mouse Location - Map", "Marker Location: " + MouseLocationMap.X.ToString() + " : " + MouseLocationMap.Y.ToString(), false);


            float Prev = DrawPen.Width;
            foreach (KeyValuePair<Lclass.Line, Color> item in CopyMapLines)
            {
                if (item.Key != null)
                {
                    DrawPen.Color = item.Value;
                    DrawPen.Width = (item.Key.Width * 1.5f) / ZoomAmount;
                    window.DrawLine(DrawPen, CalculateViewPosition(item.Key.P1), CalculateViewPosition(item.Key.P2));
                }
            }
            DrawPen.Width = Prev;

            for (int i = 0; i < CopyMapPoints.Length; i++)
            {
                DrawPen.Color = CopyMapPoints[i].Value.color;
                float Diameter = CopyMapPoints[i].Value.Diameter / (CopyMapPoints[i].Value.Scale ? ZoomAmount : 1);
                Diameter = Math.Max(Diameter, 0.01f);
                switch (CopyMapPoints[i].Value.Type)
                {
                    case TargetPoint.DrawType.Dot:
                        SolidBrush Fill = new SolidBrush(CopyMapPoints[i].Value.color);
                        window.FillEllipse(Fill, new Rectangle()
                        {
                            X = (int)(CopyMapPoints[i].Key.X - (Diameter / 2)),
                            Y = (int)(CopyMapPoints[i].Key.Y - (Diameter / 2)),
                            Width = (int)Diameter,
                            Height = (int)Diameter
                        });
                        Fill.Dispose();
                        break;
                    case TargetPoint.DrawType.Cross:
                        PointF UpperLeft = new PointF(CopyMapPoints[i].Key.X - Diameter, CopyMapPoints[i].Key.Y - Diameter);
                        PointF LowerRight = new PointF(CopyMapPoints[i].Key.X + Diameter, CopyMapPoints[i].Key.Y + Diameter);

                        PointF LowerLeft = new PointF(CopyMapPoints[i].Key.X - Diameter, CopyMapPoints[i].Key.Y + Diameter);
                        PointF UpperRight = new PointF(CopyMapPoints[i].Key.X + Diameter, CopyMapPoints[i].Key.Y - Diameter);

                        window.DrawLine(DrawPen, UpperLeft, LowerRight);
                        window.DrawLine(DrawPen, LowerLeft, UpperRight);
                        break;
                    case TargetPoint.DrawType.Diamond:
                        PointF Top = new PointF(CopyMapPoints[i].Key.X, CopyMapPoints[i].Key.Y - Diameter);
                        PointF Bottom = new PointF(CopyMapPoints[i].Key.X, CopyMapPoints[i].Key.Y + Diameter);

                        PointF Left = new PointF(CopyMapPoints[i].Key.X - Diameter, CopyMapPoints[i].Key.Y);
                        PointF Right = new PointF(CopyMapPoints[i].Key.X + Diameter, CopyMapPoints[i].Key.Y);

                        window.DrawLine(DrawPen, Top, Left);
                        window.DrawLine(DrawPen, Left, Bottom);
                        window.DrawLine(DrawPen, Bottom, Right);
                        window.DrawLine(DrawPen, Right, Top);
                        break;
                    case TargetPoint.DrawType.Square:
                        PointF TopLeft = new PointF(CopyMapPoints[i].Key.X - Diameter, CopyMapPoints[i].Key.Y - Diameter);
                        PointF BottomRight = new PointF(CopyMapPoints[i].Key.X + Diameter, CopyMapPoints[i].Key.Y + Diameter);

                        PointF BottomLeft = new PointF(CopyMapPoints[i].Key.X - Diameter, CopyMapPoints[i].Key.Y + Diameter);
                        PointF TopRight = new PointF(CopyMapPoints[i].Key.X + Diameter, CopyMapPoints[i].Key.Y - Diameter);

                        window.DrawLine(DrawPen, TopLeft, TopRight);
                        window.DrawLine(DrawPen, TopRight, BottomRight);
                        window.DrawLine(DrawPen, BottomRight, BottomLeft);
                        window.DrawLine(DrawPen, BottomLeft, TopLeft);
                        break;
                    default:
                        break;
                }
            }


            if (ClearFrame)
            {
                ClearFrame = false;
                MapPoints.Clear();
                MapLines.Clear();
            }

            DrawMino(window);

            PrintMessages(window, MapLogOuput);
            DrawPen.Dispose();
        }

        private void DrawMino(Graphics window)
        {
            Pen DrawPen = new Pen(Color.Pink, 2);
            PointF MinoPosition = CalculateViewPosition(Mino.getPosition());
            float Radius = Mino.getRadius() / ZoomAmount;
            window.DrawEllipse(DrawPen, new Rectangle()
            {
                X = (int)(MinoPosition.X - (Radius / 2)),
                Y = (int)(MinoPosition.Y - (Radius / 2)),
                Width = (int)Radius,
                Height = (int)Radius
            });
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
                    DebugLog("Mino Status", "Mino Active", false);
                    Mino.Update();
                }
                else
                {
                    DebugLog("Mino Status", "Mino Disabled", false);
                }

                Mino.ConstantUpdate();
            }
        }

        public bool WallDetectAngle(PointF Origin, float[] Angles, float Dist, out List<PointF?> Hits)
        {
            PointF[] Slopes = new PointF[Angles.Length];
            for (int i = 0; i < Slopes.Length; i++)
            {
                Slopes[i] = new PointF(MathF.Cos(Angles[i]), MathF.Sin(Angles[i]));
            }
            return WallDetect(Origin, Slopes, Dist, out Hits);
        }

        public bool WallDetect(PointF Origin, PointF[] Slopes, float Dist, out List<PointF?> Hits)
        {
            PointF[] Ray = new PointF[Slopes.Length];
            float[] Percents = new float[Slopes.Length];
            Hits = new List<PointF?>();
            for (int i = 0; i < Ray.Length; i++)
            {
                PointF Max = Origin;

                float distance = (float)Math.Sqrt(Math.Pow((Slopes[i].X), 2) + Math.Pow((Slopes[i].Y), 2));

                float YSlope = (Slopes[i].Y / distance);
                float XSlope = (Slopes[i].X / distance);

                Max.X += XSlope * Dist;
                Max.Y += YSlope * Dist;

                Ray[i] = new PointF(Max.X - Origin.X, Max.Y - Origin.Y);
                Percents[i] = 1;
                Hits.Add(null);
            }

            int Count = Walls.Count;
            Lclass.Line[] CopyWalls = new Lclass.Line[Count];
            for (int i = 0; i < Count; i++)
            {
                if (i < Walls.Count)
                {
                    CopyWalls[i] = Walls[i];
                }
            }
            bool Hitted = false;
            foreach (Lclass.Line Wall in CopyWalls)
            {
                foreach (Lclass.Line Face in Wall.GenerateRec())
                {
                    for (int i = 0; i < Slopes.Length; i++)
                    {
                        PointF WallLine = new PointF(Face.P2.X - Face.P1.X, Face.P2.Y - Face.P1.Y);
                        float t = (((Face.P1.X - Origin.X) * WallLine.Y) - ((Face.P1.Y - Origin.Y) * WallLine.X)) / (Ray[i].X * WallLine.Y - Ray[i].Y * WallLine.X);
                        float u = (((Origin.X - Face.P1.X) * Ray[i].Y) - ((Origin.Y - Face.P1.Y) * Ray[i].X)) / (WallLine.X * Ray[i].Y - WallLine.Y * Ray[i].X);
                        if (u >= 0 && u <= 1 && t >= 0 && t <= 1)
                        {
                            if (t < Percents[i])
                            {
                                Percents[i] = t;
                                Hits[i] = new PointF(Face.P1.X + ((Face.P2.X - Face.P1.X) * u), Face.P1.Y + ((Face.P2.Y - Face.P1.Y) * u));
                                Hitted = true;
                            }
                        }
                    }
                }
            }
            return Hitted;
        }

        private bool ClearFrame = false;
        public void MinoEndUpdate()
        {
            ClearFrame = true;
        }

        private bool UpdateFrame = false;
        public void MinoRefresh()
        {
            UpdateFrame = true;
        }

        public struct TargetPoint
        {
            public PointF Point;
            public enum DrawType { Dot, Cross, Diamond, Square }
            public DrawType Type;
            public Color color;
            public float Diameter;
            public bool Scale;
        }
        public void AddPoint(TargetPoint Point)
        {
            PointF NewPoint = CalculateViewPosition(Point.Point);
            KeyValuePair<PointF, TargetPoint> NewItem = new KeyValuePair<PointF, TargetPoint>(NewPoint, Point);
            if (!MapPoints.Contains(NewItem))
                MapPoints.Add(NewItem);
        }
        public void addLine(Lclass.Line line, Color color)
        {
            KeyValuePair<Lclass.Line, Color> NewItem = new KeyValuePair<Lclass.Line, Color>(line, color);
            if (!MapLines.Contains(NewItem))
                MapLines.Add(NewItem);
        }


        #endregion
    }
}