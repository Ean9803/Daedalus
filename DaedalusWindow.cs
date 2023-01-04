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

namespace Daedalus
{
    public partial class DaedalusForm : Form
    {
        public DaedalusForm()
        {
            InitializeComponent();
        }

        public delegate void SceneDel(DaedalusForm Form);
        SceneDel RefreshSceneWindows;

        System.Drawing.SolidBrush BrushColor = new System.Drawing.SolidBrush(Color.Wheat);
        Random random = new Random();

        private Dictionary<string, string> LogOuput = new Dictionary<string, string>();
        private Dictionary<string, string> MapLogOuput = new Dictionary<string, string>();

        private void DaedalusForm_Load(object sender, EventArgs e)
        {
            SetLabPenMode(labPenMode.Draw);
            SetMapMode(mapPenMode.Roam);
            SetMinoState(MinoMode.Off);
            StartWorkers();
            RefreshSceneWindows = RefreshScene;
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
            //TODO
        }

        private void ProcessLoadFile(string FilePath)
        {
            //TODO
        }

        #endregion

        #region DisplayControl

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void zoomSlider_Scroll(object sender, EventArgs e)
        {
            //TODO
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
            Graphics window = e.Graphics;
            //TODO
            
            /*Debug to screen test*/
            DebugLog("Test Message", "Number: " + random.Next(1000));
            DebugLog("Test Message2", "Number: " + random.Next(1000));

            PrintMessages(window, LogOuput);
            DrawPen.Dispose();
        }

        private void mapScene_Paint(object sender, PaintEventArgs e)
        {
            Pen DrawPen = new Pen(Color.White, 2);
            Graphics window = e.Graphics;
            //TODO
            
            /*Debug to screen test*/
            DebugLog("Test Message", "Number: " + random.Next(1000), false);
            DebugLog("Test Message2", "Number: " + random.Next(1000), false);

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
                }
                else
                {
                    //TODO
                    DebugLog("Mino Status", "Mino Disabled", false);
                }
            }
        }

        #endregion
    }
}
