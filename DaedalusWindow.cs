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
        #region SettingProfile
        public class DaedalusFormSettings
        {
            public Color LabMap_Color;
            public Color Highlight_Color;
            public Color Mino_Color;
            public Color Chunk_Color;
            public Color Object_Color;
            public Color Wall_Color;

            public Color NonPointColor;
            public Color RayColor;

            public bool Collided_Show;
            public bool Uncollided_Show;
            public bool Walls_Show;
            public bool RoamTargets_Show;
            public bool CurrentTarget_Show;
            public bool UserTarget_Show;
            public bool Path_Show;

            public bool RayHit_Show;
            public bool NonRayHit_Show;

            public float ObjectRadius_Show;
            public float ChunkRadius_Show;

            public float Mino_Radius;
            public float ExpansionBias;
            public float RayCount;
            public float Mino_Speed;
            public float Mino_ViewDist;
            public float GridRadius;

            public float WallWidth;

            private Color GenerateColor(string Data)
            {
                string[] RGBA = Data.Split(':');
                Color Ret = Color.FromArgb(int.Parse(RGBA[3]), int.Parse(RGBA[0]), int.Parse(RGBA[1]), int.Parse(RGBA[2]));
                return Ret;
            }

            public DaedalusFormSettings(string Data)
            {
                string[] DataChuncks = Data.Split('/');
                if (DataChuncks.Length != 27)
                {
                    SetDefaults();
                }
                else
                {
                    LabMap_Color = GenerateColor(DataChuncks[0]);
                    Highlight_Color = GenerateColor(DataChuncks[1]);
                    Mino_Color = GenerateColor(DataChuncks[2]);
                    Chunk_Color = GenerateColor(DataChuncks[3]);
                    Object_Color = GenerateColor(DataChuncks[4]);
                    Wall_Color = GenerateColor(DataChuncks[5]);

                    Collided_Show = DataChuncks[6].Equals("1");
                    Uncollided_Show = DataChuncks[7].Equals("1");
                    Walls_Show = DataChuncks[8].Equals("1");
                    RoamTargets_Show = DataChuncks[9].Equals("1");
                    CurrentTarget_Show = DataChuncks[10].Equals("1");
                    UserTarget_Show = DataChuncks[11].Equals("1");
                    Path_Show = DataChuncks[12].Equals("1");

                    ObjectRadius_Show = float.Parse(DataChuncks[13]);
                    ChunkRadius_Show = float.Parse(DataChuncks[14]);

                    Mino_Radius = float.Parse(DataChuncks[15]);
                    ExpansionBias = float.Parse(DataChuncks[16]);
                    RayCount = float.Parse(DataChuncks[17]);
                    Mino_Speed = float.Parse(DataChuncks[18]);
                    Mino_ViewDist = float.Parse(DataChuncks[19]);
                    GridRadius = float.Parse(DataChuncks[20]);

                    WallWidth = float.Parse(DataChuncks[21]);

                    NonPointColor = GenerateColor(DataChuncks[22]);
                    RayColor = GenerateColor(DataChuncks[23]);

                    RayHit_Show = DataChuncks[24].Equals("1");
                    NonRayHit_Show = DataChuncks[25].Equals("1");
                }
            }

            public DaedalusFormSettings()
            {
                SetDefaults();
            }

            public void SetDefaults()
            {
                LabMap_Color = Color.White;
                Highlight_Color = Color.Red;
                Mino_Color = Color.White;
                Chunk_Color = Color.Red;
                Object_Color = Color.Green;
                Wall_Color = Color.Blue;

                Collided_Show = true;
                Uncollided_Show = true;
                Walls_Show = false;
                RoamTargets_Show = true;
                CurrentTarget_Show = true;
                UserTarget_Show = true;
                Path_Show = true;

                ObjectRadius_Show = 2;
                ChunkRadius_Show = 3;

                Mino_Radius = 10;
                ExpansionBias = 1;
                RayCount = 50;
                Mino_Speed = 1;
                Mino_ViewDist = 100;
                GridRadius = 25;
                WallWidth = 10;

                RayHit_Show = false;
                NonRayHit_Show = false;

                NonPointColor = Color.ForestGreen;
                RayColor = Color.LightSeaGreen;
            }

            public string Export()
            {
                string Out = "";
                Out += LabMap_Color.R + ":" + LabMap_Color.G + ":" + LabMap_Color.B + ":" + LabMap_Color.A + "/";
                Out += Highlight_Color.R + ":" + Highlight_Color.G + ":" + Highlight_Color.B + ":" + Highlight_Color.A + "/";
                Out += Mino_Color.R + ":" + Mino_Color.G + ":" + Mino_Color.B + ":" + Mino_Color.A + "/";
                Out += Chunk_Color.R + ":" + Chunk_Color.G + ":" + Chunk_Color.B + ":" + Chunk_Color.A + "/";
                Out += Object_Color.R + ":" + Object_Color.G + ":" + Object_Color.B + ":" + Object_Color.A + "/";
                Out += Wall_Color.R + ":" + Wall_Color.G + ":" + Wall_Color.B + ":" + Wall_Color.A + "/";

                Out += (Collided_Show ? "1" : "0") + "/";
                Out += (Uncollided_Show ? "1" : "0") + "/";
                Out += (Walls_Show ? "1" : "0") + "/";
                Out += (RoamTargets_Show ? "1" : "0") + "/";
                Out += (CurrentTarget_Show ? "1" : "0") + "/";
                Out += (UserTarget_Show ? "1" : "0") + "/";
                Out += (Path_Show ? "1" : "0") + "/";

                Out += ObjectRadius_Show.ToString() + "/";
                Out += ChunkRadius_Show.ToString() + "/";

                Out += Mino_Radius.ToString() + "/";
                Out += ExpansionBias.ToString() + "/";
                Out += RayCount.ToString() + "/";
                Out += Mino_Speed.ToString() + "/";
                Out += Mino_ViewDist.ToString() + "/";
                Out += GridRadius.ToString() + "/";
                Out += WallWidth.ToString() + "/";

                Out += NonPointColor.R + ":" + NonPointColor.G + ":" + NonPointColor.B + ":" + NonPointColor.A + "/";
                Out += RayColor.R + ":" + RayColor.G + ":" + RayColor.B + ":" + RayColor.A + "/";

                Out += (RayHit_Show ? "1" : "0") + "/";
                Out += (NonRayHit_Show ? "1" : "0") + "/";

                return Out;
            }

            public enum ColorBlindness { Protanopia, Tritanopia, Achromatopsia }
            public ColorBlindness Blindness;

            public void ApplyColorChanges()
            {
                switch (Blindness)
                {
                    case ColorBlindness.Protanopia:
                        LabMap_Color = Color.BlueViolet;
                        Highlight_Color = Color.PaleGoldenrod;
                        Mino_Color = Color.Gold;
                        Object_Color = Color.LightGoldenrodYellow;
                        Chunk_Color = Color.LightSteelBlue;
                        NonPointColor = Color.DarkGoldenrod;
                        RayColor = Color.LightYellow;
                        break;
                    case ColorBlindness.Tritanopia:
                        LabMap_Color = Color.DarkCyan;
                        Highlight_Color = Color.SeaGreen;
                        Mino_Color = Color.LightSeaGreen;
                        Object_Color = Color.Tomato;
                        Chunk_Color = Color.Teal;
                        NonPointColor = Color.HotPink;
                        RayColor = Color.LightPink;
                        break;
                    case ColorBlindness.Achromatopsia:
                        LabMap_Color = Color.White;
                        Highlight_Color = Color.Tan;
                        Mino_Color = Color.FloralWhite;
                        Object_Color = Color.AntiqueWhite;
                        Chunk_Color = Color.DimGray;
                        NonPointColor = Color.NavajoWhite;
                        RayColor = Color.WhiteSmoke;
                        break;
                    default:
                        break;
                }
            }

        }
        #endregion

        Minotaur Mino;
        public static Knossos KnossosUI;
        public DaedalusFormSettings Settings;
        public float DeltaTime = 0;

        public Knossos()
        {
            InitializeComponent();
            LoadSettings();
            KnossosUI = this;
        }

        public delegate void SceneDel(Knossos Form);
        SceneDel RefreshSceneWindows;

        System.Drawing.SolidBrush BrushColor = new System.Drawing.SolidBrush(Color.Wheat);
        Random random = new Random();

        private Dictionary<string, string> LogOuput = new Dictionary<string, string>();
        private Dictionary<string, string> MapLogOuput = new Dictionary<string, string>();

        private float ZoomAmount;


        public PointF CalculateViewPosition(PointF In)
        {
            return new PointF((In.X / ZoomAmount) + Origin.X, -(In.Y / ZoomAmount) + Origin.Y);
        }

        public List<Lclass.Line> Walls = new List<Lclass.Line>();
        public List<Lclass.Line> EraseWalls = new List<Lclass.Line>();
        public List<KeyValuePair<PointF, TargetPoint>> MapPoints = new List<KeyValuePair<PointF, TargetPoint>>();
        public List<TargetLine> MapLines = new List<TargetLine>();
        public List<TargetShape> MapShapes = new List<TargetShape>();

        private void DaedalusForm_Load(object sender, EventArgs e)
        {
            Mino = new Minotaur(this);

            AssignSettings();
            HelpData.PopulateManual(treeHelp, richTextHelp);
            tabMenu.SelectedIndexChanged += TabMenu_SelectedIndexChanged;
            //AssignCallBacks();

            SetLabPenMode(labPenMode.Draw);
            SetMapMode(mapPenMode.Roam);
            SetMinoState(MinoMode.Off);
            MinoDisplay = MinoMode.On;
            StartWorkers();
            RefreshSceneWindows = RefreshScene;
            ScreenOrigin = new PointF(labyrinthScene.Width / 2, labyrinthScene.Height / 2);
            ZoomAmount = 1;
        }

        private void TabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMenu.SelectedIndex == 0)
                Mino.RefreshMap();
        }

        int WorkersOpen = 0;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveSettings();
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

        private void AssignCallBacks()
        {
            //Serves as a backup in case the designer messes up
            this.labyrinthScene.Paint += labyrinthScene_Paint;
            this.labyrinthScene.MouseDown += labyrinthScene_MouseDown;
            this.labyrinthScene.MouseLeave += labyrinthScene_MouseLeave;
            this.labyrinthScene.MouseMove += labyrinthScene_Mouse;
            this.labyrinthScene.MouseUp += labyrinthScene_MouseUp;

            this.mapScene.Paint += mapScene_Paint;
            this.mapScene.MouseDown += mapScene_MouseDown;
            this.mapScene.MouseLeave += mapScene_MouseLeave;
            this.mapScene.MouseMove += mapScene_Mouse;
            this.mapScene.MouseUp += mapScene_MouseUp;

            this.zoomSlider.Scroll += zoomSlider_Scroll;

            this.clearBtn.Click += clearBtn_Click;

            this.loadBtn.Click += loadBtn_Click;

            this.saveBtn.Click += saveBtn_Click;

            this.eraseBtn.Click += eraseBtn_Click;

            this.drawBtn.Click += drawBtn_Click;

            this.setMinoPos.Click += setMinoPos_Click;

            this.targetBtn.Click += targetBtn_Click;

            this.roamBtn.Click += roamBtn_Click;

            this.ClearMemory.Click += ClearMemory_Click;

            this.playBtn.Click += playBtn_Click;

            this.stopBtn.Click += stopBtn_Click;

            this.MinotaurWorker.DoWork += MinotaurWorker_DoWork;
            this.MinotaurWorker.RunWorkerCompleted += backgroundWorker_End;

            this.LabyrinthUpdate.DoWork += LabyrinthUpdate_DoWork;
            this.LabyrinthUpdate.RunWorkerCompleted += backgroundWorker_End;

            this.openMapFile.FileOk += openMapFile_FileOk;
            this.saveMapFile.FileOk += saveMapFile_FileOk;

            this.ChangeMapColor.Click += new System.EventHandler(this.ChangeMapColor_Click);
            this.ChangeHighlightColor.Click += new System.EventHandler(this.ChangeHighlightColor_Click);
            this.ChangeMinoColor.Click += new System.EventHandler(this.ChangeMinoColor_Click);
            this.ChangeNonHitColor.Click += new System.EventHandler(this.ChangeNonHitColor_Click);
            this.ChangeRayColor.Click += new System.EventHandler(this.ChangeRayColor_Click);
            this.ChangeMapObjectsColor.Click += new System.EventHandler(this.ChangeMapObjectsColor_Click);
            this.ChangeMapChunckColor.Click += new System.EventHandler(this.ChangeMapChunckColor_Click);
            this.ChangeMapWallColor.Click += new System.EventHandler(this.ChangeMapWallColor_Click);
            this.ShowCollidedPoints.CheckedChanged += ShowCollidedPoints_CheckedChanged;
            this.ShowUncollidedPoints.CheckedChanged += ShowUncollidedPoints_CheckedChanged;
            this.ShowCurrentTarget.CheckedChanged += ShowCurrentTarget_CheckedChanged;
            this.ShowRoamTargets.CheckedChanged += ShowRoamTargets_CheckedChanged;
            this.ShowUserTarget.CheckedChanged += ShowUserTarget_CheckedChanged;
            this.ShowPath.CheckedChanged += ShowPath_CheckedChanged;
            this.ObjectRadius.TextChanged += ObjectRadius_TextChanged;
            this.ObjectRadiusSlider.Scroll += ObjectRadiusSlider_Scroll;
            this.ChunkRadius.TextChanged += ChunkRadius_TextChanged;
            this.ChunkRadiusSlider.Scroll += ChunkRadiusSlider_Scroll;
            this.ShowNonHitRays.CheckedChanged += new System.EventHandler(this.ShowNonHitRays_CheckedChanged);
            this.ShowHitRays.CheckedChanged += new System.EventHandler(this.ShowHitRays_CheckedChanged);
            this.ShowWallData.CheckedChanged += ShowWallData_CheckedChanged;
            this.MinoRadius.TextChanged += MinoRadius_TextChanged;
            this.MinoRadiusSlider.Scroll += MinoRadiusSlider_Scroll;
            this.ExpansionBias.TextChanged += ExapansionBias_TextChanged;
            this.ExpansionBiasSlider.Scroll += ExpansionBiasSlider_Scroll;
            this.GridRadius.TextChanged += GridRadius_TextChanged;
            this.GridRadiusSlider.Scroll += GridRadiusSlider_Scroll;
            this.MinoRayRes.TextChanged += MinoRayRes_TextChanged;
            this.MinoRayResSlider.Scroll += MinoRayResSlider_Scroll;
            this.MinoSpeed.TextChanged += MinoSpeed_TextChanged;
            this.MinoSpeedSlider.Scroll += MinoSpeedSlider_Scroll;
            this.MinoViewDistance.TextChanged += MinoViewDistance_TextChanged;
            this.MinoViewDistanceSlider.Scroll += MinoViewDistanceSlider_Scroll;
            this.WallWidth.TextChanged += WallWidth_TextChanged;
            this.WallWidthSlider.Scroll += WallWidthSlider_Scroll;
            this.Apply.Click += Apply_Click;
            this.Cancel.Click += Cancel_Click;
            this.treeSettings.AfterSelect += treeSettings_AfterSelect;
            this.ResetSet.Click += new System.EventHandler(this.Reset_Click);
            this.CancelSet.Click += new System.EventHandler(this.CancelSet_Click);
            this.FormClosing += DaedalusForm_Close;
            this.Load += DaedalusForm_Load;

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
            SetMinoState(MinoMode.Off);
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
            MinoDisplay = MinoMode.Off;
            Walls.Clear();
            string input;
            input = File.ReadAllText(FilePath);
            string[] SplitData = input.Split('\n');
            input = SplitData[0];
            if (SplitData.Length > 1)
                Mino.ImportMapData(SplitData[1]);

            // Split all lines into individual coordinates
            string[] delimeters = { "___", "#", "/" };
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
            MinoDisplay = MinoMode.On;
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
                TempLine.Width = Settings.WallWidth;
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
                    TempLine.Width = Settings.WallWidth;
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
                    Width = Settings.WallWidth
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

        private static void RefreshScene(Knossos Form)
        {
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Form.PaintWindows();
            float DT = (float)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - milliseconds) / 100.0f;
            if (DT != 0)
                Form.DeltaTime = DT;
            HelpData.Update(Form.DeltaTime);
        }

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
            Pen DrawPen = new Pen(Settings.LabMap_Color, 2);
            Pen RedPen = new Pen(Settings.Highlight_Color, 2);
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


            DrawPen = new Pen(Settings.Highlight_Color, 2);
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

            DrawPen.Color = Settings.Mino_Color;
            window.DrawEllipse(DrawPen, ScreenOrigin.X, ScreenOrigin.Y, 1, 1);

            DrawMino(window);

            PrintMessages(window, LogOuput);
            DrawPen.Dispose();
            RedPen.Dispose();
        }

        KeyValuePair<PointF, TargetPoint>[] CopyMapPoints;
        TargetLine[] CopyMapLines = new TargetLine[0];
        TargetShape[] CopyMapShapes = new TargetShape[0];
        private void mapScene_Paint(object sender, PaintEventArgs e)
        {
            Pen DrawPen = new Pen(Color.White, 2);
            SolidBrush FillBrush = new SolidBrush(Color.White);
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
                CopyMapLines = new TargetLine[Count];
                for (int i = 0; i < Count; i++)
                {
                    if (i < MapLines.Count && MapLines[i].Line != null)
                    {
                        CopyMapLines[i] = new TargetLine()
                        {
                            Line = new Lclass.Line() { P1 = MapLines[i].Line.P1, P2 = MapLines[i].Line.P2, Width = (MapLines[i].ViewWidth == 0 ? MapLines[i].Line.Width : MapLines[i].ViewWidth) },
                            color = MapLines[i].color,
                            Type = MapLines[i].Type,
                            ViewWidth = MapLines[i].ViewWidth
                        };
                    }
                }

                Count = MapShapes.Count;
                CopyMapShapes = new TargetShape[Count];
                for (int i = 0; i < Count; i++)
                {
                    if (i < MapShapes.Count && MapShapes[i].Points != null)
                    {
                        int L = MapShapes[i].Points.Length;
                        CopyMapShapes[i] = new TargetShape()
                        {
                            Points = new PointF[L],
                            color = MapShapes[i].color
                        };
                        Array.Copy(MapShapes[i].Points, CopyMapShapes[i].Points, L);
                    }
                }
            }

            window.DrawEllipse(DrawPen, Origin.X, Origin.Y, 1, 1);
            DebugLog("Mouse Location - Map", "Marker Location: " + MouseLocationMap.X.ToString() + " : " + MouseLocationMap.Y.ToString(), false);

            foreach (TargetShape item in CopyMapShapes)
            {
                if (item.Points != null)
                {
                    DrawPen.Color = item.color;
                    window.DrawPolygon(DrawPen, item.Points);
                }
            }

            float Prev = DrawPen.Width;
            foreach (TargetLine item in CopyMapLines)
            {
                if (item.Line != null)
                {
                    DrawPen.Color = item.color;
                    switch (item.Type)
                    {
                        case TargetLine.DrawType.Solid:
                            DrawPen.Width = ((item.ViewWidth == 0 ? item.Line.Width : item.ViewWidth) * 1.5f) / ZoomAmount;
                            window.DrawLine(DrawPen, CalculateViewPosition(item.Line.P1), CalculateViewPosition(item.Line.P2));
                            break;
                        case TargetLine.DrawType.Outline:
                            DrawPen.Width = Prev;
                            foreach (Lclass.Line Wall in item.Line.GenerateRec(Origin, ZoomAmount))
                            {
                                window.DrawLine(DrawPen, Wall.P1, Wall.P2);
                            }
                            break;
                        default:
                            break;
                    }
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
            Pen DrawPen = new Pen(Settings.Mino_Color, 2);
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
        private MinoMode MinoDisplay;

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
                if (MinoDisplay == MinoMode.On)
                    Mino.ConstantUpdate();
            }
        }

        public bool WallDetectAngle(PointF Origin, float[] Angles, float Dist, out List<Lclass.CollisionPoint> Hits)
        {
            PointF[] Slopes = new PointF[Angles.Length];
            for (int i = 0; i < Slopes.Length; i++)
            {
                Slopes[i] = new PointF(MathF.Cos(Angles[i]), MathF.Sin(Angles[i]));
            }
            return WallDetect(Origin, Slopes, Dist, out Hits);
        }

        public bool WallDetect(PointF Origin, PointF[] Slopes, float Dist, out List<Lclass.CollisionPoint> Hits)
        {
            PointF[] Ray = new PointF[Slopes.Length];
            float[] Percents = new float[Slopes.Length];
            Hits = new List<Lclass.CollisionPoint>();
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
                Hits.Add(new Lclass.CollisionPoint() { Point = Max, Hit = false });
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
                                Hits[i].Point = new PointF(Face.P1.X + ((Face.P2.X - Face.P1.X) * u), Face.P1.Y + ((Face.P2.Y - Face.P1.Y) * u));
                                Hits[i].Hit = true;
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

        public struct TargetLine
        {
            public Lclass.Line Line;
            public Color color;
            public enum DrawType { Solid, Outline }
            public DrawType Type;
            public float ViewWidth;
        }

        public void AddLine(TargetLine Line)
        {
            if (!MapLines.Contains(Line))
                MapLines.Add(Line);
        }

        public struct TargetShape
        {
            public PointF[] Points;
            public Color color;
        }

        public void AddShape(TargetShape Shape)
        {
            if (!MapShapes.Contains(Shape))
                MapShapes.Add(Shape);
        }


        #endregion

        #region Settings

        private void treeSettings_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "Visual":
                    SettingControl.SelectTab(0);
                    AssignVisualSettings();
                    break;
                case "Display":
                    SettingControl.SelectTab(1);
                    AssignDisplaySettings();
                    break;
                case "Internal":
                    SettingControl.SelectTab(2);
                    AssignInternalSettings();
                    break;
                case "Environment":
                    SettingControl.SelectTab(3);
                    AssignEnvironmentSettings();
                    break;
                case "Protanopia":
                    SettingControl.SelectTab(4);
                    Settings.Blindness = DaedalusFormSettings.ColorBlindness.Protanopia;
                    break;
                case "Tritanopia":
                    SettingControl.SelectTab(4);
                    Settings.Blindness = DaedalusFormSettings.ColorBlindness.Tritanopia;
                    break;
                case "Achromatopsia":
                    SettingControl.SelectTab(4);
                    Settings.Blindness = DaedalusFormSettings.ColorBlindness.Achromatopsia;
                    break;
                case "Reset":
                    SettingControl.SelectTab(5);
                    break;
                default:
                    break;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Settings.SetDefaults();
            SettingControl.SelectTab(0);
            AssignSettings();
        }

        private void CancelSet_Click(object sender, EventArgs e)
        {
            SettingControl.SelectTab(0);
            AssignSettings();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Settings.ApplyColorChanges();
            SettingControl.SelectTab(0);
            AssignVisualSettings();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            SettingControl.SelectTab(0);
        }

        private void SaveSettings()
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "/Settings.daedalusSettings", Settings.Export());
        }

        private void LoadSettings()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "/Settings.daedalusSettings"))
                Settings = new DaedalusFormSettings(File.ReadAllText(Directory.GetCurrentDirectory() + "/Settings.daedalusSettings"));
            else
                Settings = new DaedalusFormSettings();
        }

        private void AssignVisualSettings()
        {
            LabColor.BackColor = Settings.LabMap_Color;
            LabHighlightColor.BackColor = Settings.Highlight_Color;
            MinoColor.BackColor = Settings.Mino_Color;
            MapChunkColor.BackColor = Settings.Chunk_Color;
            MapObjectsColor.BackColor = Settings.Object_Color;
            MapWallColor.BackColor = Settings.Wall_Color;

            NonHitColor.BackColor = Settings.NonPointColor;
            RayLineColor.BackColor = Settings.RayColor;
        }

        private void AssignDisplaySettings()
        {
            ShowCollidedPoints.Checked = Settings.Collided_Show;
            ShowUncollidedPoints.Checked = Settings.Uncollided_Show;
            ShowUserTarget.Checked = Settings.UserTarget_Show;
            ShowWallData.Checked = Settings.Walls_Show;
            ShowRoamTargets.Checked = Settings.RoamTargets_Show;
            ShowCurrentTarget.Checked = Settings.CurrentTarget_Show;
            ShowPath.Checked = Settings.Path_Show;

            ObjectRadius.Text = Settings.ObjectRadius_Show.ToString();
            ChunkRadius.Text = Settings.ChunkRadius_Show.ToString();

            ObjectRadiusSlider.Value = (int)Math.Clamp(Settings.ObjectRadius_Show, ObjectRadiusSlider.Minimum, ObjectRadiusSlider.Maximum);
            ChunkRadiusSlider.Value = (int)Math.Clamp(Settings.ChunkRadius_Show, ChunkRadiusSlider.Minimum, ChunkRadiusSlider.Maximum);

            ShowHitRays.Checked = Settings.RayHit_Show;
            ShowNonHitRays.Checked = Settings.NonRayHit_Show;
        }

        private void AssignInternalSettings()
        {
            MinoRadius.Text = Settings.Mino_Radius.ToString();
            ExpansionBias.Text = Settings.ExpansionBias.ToString();
            MinoRayRes.Text = Settings.RayCount.ToString();
            MinoSpeed.Text = Settings.Mino_Speed.ToString();
            MinoViewDistance.Text = Settings.Mino_ViewDist.ToString();
            GridRadius.Text = Settings.GridRadius.ToString();

            MinoRadiusSlider.Value = (int)Math.Clamp(Settings.Mino_Radius, MinoRadiusSlider.Minimum, MinoRadiusSlider.Maximum);
            ExpansionBiasSlider.Value = (int)Math.Clamp(Settings.ExpansionBias, ExpansionBiasSlider.Minimum, ExpansionBiasSlider.Maximum);
            MinoRayResSlider.Value = (int)Math.Clamp(Settings.RayCount, MinoRadiusSlider.Minimum, MinoRayResSlider.Maximum);
            MinoSpeedSlider.Value = (int)Math.Clamp(Settings.Mino_Speed, MinoSpeedSlider.Minimum, MinoSpeedSlider.Maximum);
            MinoViewDistanceSlider.Value = (int)Math.Clamp(Settings.Mino_ViewDist, MinoViewDistanceSlider.Minimum, MinoViewDistanceSlider.Maximum);
            GridRadiusSlider.Value = (int)Math.Clamp(Settings.GridRadius, GridRadiusSlider.Minimum, GridRadiusSlider.Maximum);
        }

        private void AssignEnvironmentSettings()
        {
            WallWidth.Text = Settings.WallWidth.ToString();
            WallWidthSlider.Value = (int)Math.Clamp(Settings.WallWidth, WallWidthSlider.Minimum, WallWidthSlider.Maximum);
        }

        private void AssignSettings()
        {
            AssignDisplaySettings();
            AssignVisualSettings();
            AssignInternalSettings();
            AssignEnvironmentSettings();
        }

        private void SetColorSetting(ref Color subject)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                subject = colorDialog.Color;
            }
            AssignVisualSettings();
        }

        private void SetFloatSetting(string Value, System.Windows.Forms.TrackBar Slider, ref float ValueResult)
        {
            if (float.TryParse(Value, out float Result))
            {
                Result = Math.Clamp(Result, Slider.Minimum, Slider.Maximum);
                ValueResult = Result;
                Slider.Value = (int)Result;
            }
        }

        private void SetFloatSetting(int Value, System.Windows.Forms.TextBox Text, ref float ValueResult)
        {
            Text.Text = Value.ToString();
            ValueResult = Value;
        }

        private void ChangeNonHitColor_Click(object sender, EventArgs e)
        {
            SetColorSetting(ref Settings.NonPointColor);
        }

        private void ChangeRayColor_Click(object sender, EventArgs e)
        {
            SetColorSetting(ref Settings.RayColor);
        }

        private void ChangeMapColor_Click(object sender, EventArgs e)
        {
            SetColorSetting(ref Settings.LabMap_Color);
        }

        private void ChangeHighlightColor_Click(object sender, EventArgs e)
        {
            SetColorSetting(ref Settings.Highlight_Color);
        }

        private void ChangeMinoColor_Click(object sender, EventArgs e)
        {
            SetColorSetting(ref Settings.Mino_Color);
        }

        private void ChangeMapObjectsColor_Click(object sender, EventArgs e)
        {
            SetColorSetting(ref Settings.Object_Color);
        }

        private void ChangeMapChunckColor_Click(object sender, EventArgs e)
        {
            SetColorSetting(ref Settings.Chunk_Color);
        }

        private void ChangeMapWallColor_Click(object sender, EventArgs e)
        {
            SetColorSetting(ref Settings.Wall_Color);
        }

        private void ShowCollidedPoints_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Collided_Show = ShowCollidedPoints.Checked;
        }

        private void ShowUncollidedPoints_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Uncollided_Show = ShowUncollidedPoints.Checked;
        }

        private void ObjectRadius_TextChanged(object sender, EventArgs e)
        {
            SetFloatSetting(ObjectRadius.Text, ObjectRadiusSlider, ref Settings.ObjectRadius_Show);
        }

        private void ObjectRadiusSlider_Scroll(object sender, EventArgs e)
        {
            SetFloatSetting(ObjectRadiusSlider.Value, ObjectRadius, ref Settings.ObjectRadius_Show);
        }

        private void ChunkRadius_TextChanged(object sender, EventArgs e)
        {
            SetFloatSetting(ChunkRadius.Text, ChunkRadiusSlider, ref Settings.ChunkRadius_Show);
        }

        private void ChunkRadiusSlider_Scroll(object sender, EventArgs e)
        {
            SetFloatSetting(ChunkRadiusSlider.Value, ChunkRadius, ref Settings.ChunkRadius_Show);
        }

        private void ShowWallData_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Walls_Show = ShowWallData.Checked;
        }

        private void ShowRoamTargets_CheckedChanged(object sender, EventArgs e)
        {
            Settings.RoamTargets_Show = ShowRoamTargets.Checked;
        }

        private void ShowCurrentTarget_CheckedChanged(object sender, EventArgs e)
        {
            Settings.CurrentTarget_Show = ShowCurrentTarget.Checked;
        }

        private void ShowPath_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Path_Show = ShowPath.Checked;
        }

        private void ShowUserTarget_CheckedChanged(object sender, EventArgs e)
        {
            Settings.UserTarget_Show = ShowUserTarget.Checked;
        }

        private void ShowNonHitRays_CheckedChanged(object sender, EventArgs e)
        {
            Settings.NonRayHit_Show = ShowNonHitRays.Checked;
        }

        private void ShowHitRays_CheckedChanged(object sender, EventArgs e)
        {
            Settings.RayHit_Show = ShowHitRays.Checked;
        }

        private void MinoRadius_TextChanged(object sender, EventArgs e)
        {
            SetFloatSetting(MinoRadius.Text, MinoRadiusSlider, ref Settings.Mino_Radius);
        }

        private void MinoRadiusSlider_Scroll(object sender, EventArgs e)
        {
            SetFloatSetting(MinoRadiusSlider.Value, MinoRadius, ref Settings.Mino_Radius);
        }

        private void ExapansionBias_TextChanged(object sender, EventArgs e)
        {
            SetFloatSetting(ExpansionBias.Text, ExpansionBiasSlider, ref Settings.ExpansionBias);
        }

        private void ExpansionBiasSlider_Scroll(object sender, EventArgs e)
        {
            SetFloatSetting(ExpansionBiasSlider.Value, ExpansionBias, ref Settings.ExpansionBias);
        }

        private void MinoRayRes_TextChanged(object sender, EventArgs e)
        {
            SetFloatSetting(MinoRayRes.Text, MinoRayResSlider, ref Settings.RayCount);
        }

        private void MinoRayResSlider_Scroll(object sender, EventArgs e)
        {
            SetFloatSetting(MinoRayResSlider.Value, MinoRayRes, ref Settings.RayCount);
        }

        private void MinoSpeed_TextChanged(object sender, EventArgs e)
        {
            SetFloatSetting(MinoSpeed.Text, MinoSpeedSlider, ref Settings.Mino_Speed);
        }

        private void MinoSpeedSlider_Scroll(object sender, EventArgs e)
        {
            SetFloatSetting(MinoSpeedSlider.Value, MinoSpeed, ref Settings.Mino_Speed);
        }

        private void MinoViewDistance_TextChanged(object sender, EventArgs e)
        {
            SetFloatSetting(MinoViewDistance.Text, MinoViewDistanceSlider, ref Settings.Mino_ViewDist);
        }

        private void MinoViewDistanceSlider_Scroll(object sender, EventArgs e)
        {
            SetFloatSetting(MinoViewDistanceSlider.Value, MinoViewDistance, ref Settings.Mino_ViewDist);
        }

        private void GridRadius_TextChanged(object sender, EventArgs e)
        {
            SetFloatSetting(GridRadius.Text, GridRadiusSlider, ref Settings.GridRadius);
        }

        private void GridRadiusSlider_Scroll(object sender, EventArgs e)
        {
            SetFloatSetting(GridRadiusSlider.Value, GridRadius, ref Settings.GridRadius);
        }

        private void WallWidth_TextChanged(object sender, EventArgs e)
        {
            SetFloatSetting(WallWidth.Text, WallWidthSlider, ref Settings.WallWidth);
        }

        private void WallWidthSlider_Scroll(object sender, EventArgs e)
        {
            SetFloatSetting(WallWidthSlider.Value, WallWidth, ref Settings.WallWidth);
        }

        #endregion
    }
}