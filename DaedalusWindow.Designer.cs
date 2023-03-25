
namespace Daedalus
{
    partial class Knossos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Knossos));
            VerticalLayout = new System.Windows.Forms.SplitContainer();
            ControlLayout = new System.Windows.Forms.SplitContainer();
            labyrinthBox = new System.Windows.Forms.GroupBox();
            labyrinthScene = new System.Windows.Forms.PictureBox();
            mapBox = new System.Windows.Forms.GroupBox();
            mapScene = new System.Windows.Forms.PictureBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            zoomBox = new System.Windows.Forms.GroupBox();
            zoomSlider = new System.Windows.Forms.TrackBar();
            labyrinthToolStrip = new System.Windows.Forms.ToolStrip();
            labyrinthTool = new System.Windows.Forms.ToolStripLabel();
            clearBtn = new System.Windows.Forms.ToolStripButton();
            loadBtn = new System.Windows.Forms.ToolStripButton();
            saveBtn = new System.Windows.Forms.ToolStripButton();
            eraseBtn = new System.Windows.Forms.ToolStripButton();
            drawBtn = new System.Windows.Forms.ToolStripButton();
            setMinoPos = new System.Windows.Forms.ToolStripButton();
            mapToolStrip = new System.Windows.Forms.ToolStrip();
            targetBtn = new System.Windows.Forms.ToolStripButton();
            roamBtn = new System.Windows.Forms.ToolStripButton();
            ClearMemory = new System.Windows.Forms.ToolStripButton();
            mapMode = new System.Windows.Forms.ToolStripLabel();
            playBtn = new System.Windows.Forms.ToolStripButton();
            stopBtn = new System.Windows.Forms.ToolStripButton();
            MinotaurWorker = new System.ComponentModel.BackgroundWorker();
            LabyrinthUpdate = new System.ComponentModel.BackgroundWorker();
            openMapFile = new System.Windows.Forms.OpenFileDialog();
            saveMapFile = new System.Windows.Forms.SaveFileDialog();
            MenuSplit = new System.Windows.Forms.SplitContainer();
            ToolBox = new System.Windows.Forms.GroupBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            MenuPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)VerticalLayout).BeginInit();
            VerticalLayout.Panel1.SuspendLayout();
            VerticalLayout.Panel2.SuspendLayout();
            VerticalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ControlLayout).BeginInit();
            ControlLayout.Panel1.SuspendLayout();
            ControlLayout.Panel2.SuspendLayout();
            ControlLayout.SuspendLayout();
            labyrinthBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)labyrinthScene).BeginInit();
            mapBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mapScene).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            zoomBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zoomSlider).BeginInit();
            labyrinthToolStrip.SuspendLayout();
            mapToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuSplit).BeginInit();
            MenuSplit.Panel1.SuspendLayout();
            MenuSplit.Panel2.SuspendLayout();
            MenuSplit.SuspendLayout();
            ToolBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // VerticalLayout
            // 
            VerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            VerticalLayout.Location = new System.Drawing.Point(0, 0);
            VerticalLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            VerticalLayout.Name = "VerticalLayout";
            VerticalLayout.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // VerticalLayout.Panel1
            // 
            VerticalLayout.Panel1.Controls.Add(ControlLayout);
            VerticalLayout.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // VerticalLayout.Panel2
            // 
            VerticalLayout.Panel2.Controls.Add(tableLayoutPanel1);
            VerticalLayout.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            VerticalLayout.Size = new System.Drawing.Size(892, 327);
            VerticalLayout.SplitterDistance = 269;
            VerticalLayout.SplitterWidth = 8;
            VerticalLayout.TabIndex = 4;
            VerticalLayout.TabStop = false;
            // 
            // ControlLayout
            // 
            ControlLayout.BackColor = System.Drawing.SystemColors.MenuText;
            ControlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            ControlLayout.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            ControlLayout.Location = new System.Drawing.Point(0, 0);
            ControlLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ControlLayout.Name = "ControlLayout";
            // 
            // ControlLayout.Panel1
            // 
            ControlLayout.Panel1.Controls.Add(labyrinthBox);
            ControlLayout.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // ControlLayout.Panel2
            // 
            ControlLayout.Panel2.Controls.Add(mapBox);
            ControlLayout.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ControlLayout.Size = new System.Drawing.Size(892, 269);
            ControlLayout.SplitterDistance = 443;
            ControlLayout.SplitterWidth = 9;
            ControlLayout.TabIndex = 3;
            ControlLayout.TabStop = false;
            // 
            // labyrinthBox
            // 
            labyrinthBox.BackColor = System.Drawing.SystemColors.Desktop;
            labyrinthBox.Controls.Add(labyrinthScene);
            labyrinthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            labyrinthBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            labyrinthBox.Location = new System.Drawing.Point(0, 0);
            labyrinthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labyrinthBox.Name = "labyrinthBox";
            labyrinthBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labyrinthBox.Size = new System.Drawing.Size(443, 269);
            labyrinthBox.TabIndex = 0;
            labyrinthBox.TabStop = false;
            labyrinthBox.Text = "Labyrinth";
            // 
            // labyrinthScene
            // 
            labyrinthScene.Dock = System.Windows.Forms.DockStyle.Fill;
            labyrinthScene.Location = new System.Drawing.Point(3, 18);
            labyrinthScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labyrinthScene.Name = "labyrinthScene";
            labyrinthScene.Size = new System.Drawing.Size(437, 249);
            labyrinthScene.TabIndex = 7;
            labyrinthScene.TabStop = false;
            labyrinthScene.Paint += labyrinthScene_Paint;
            labyrinthScene.MouseDown += labyrinthScene_MouseDown;
            labyrinthScene.MouseLeave += labyrinthScene_MouseLeave;
            labyrinthScene.MouseMove += labyrinthScene_Mouse;
            labyrinthScene.MouseUp += labyrinthScene_MouseUp;
            // 
            // mapBox
            // 
            mapBox.Controls.Add(mapScene);
            mapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            mapBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            mapBox.Location = new System.Drawing.Point(0, 0);
            mapBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            mapBox.Name = "mapBox";
            mapBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            mapBox.Size = new System.Drawing.Size(440, 269);
            mapBox.TabIndex = 0;
            mapBox.TabStop = false;
            mapBox.Text = "Map";
            // 
            // mapScene
            // 
            mapScene.Dock = System.Windows.Forms.DockStyle.Fill;
            mapScene.Location = new System.Drawing.Point(3, 18);
            mapScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            mapScene.Name = "mapScene";
            mapScene.Size = new System.Drawing.Size(434, 249);
            mapScene.TabIndex = 3;
            mapScene.TabStop = false;
            mapScene.Paint += mapScene_Paint;
            mapScene.MouseDown += mapScene_MouseDown;
            mapScene.MouseLeave += mapScene_MouseLeave;
            mapScene.MouseMove += mapScene_Mouse;
            mapScene.MouseUp += mapScene_MouseUp;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(zoomBox, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(892, 50);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // zoomBox
            // 
            zoomBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            zoomBox.AutoSize = true;
            zoomBox.Controls.Add(zoomSlider);
            zoomBox.ForeColor = System.Drawing.SystemColors.Info;
            zoomBox.Location = new System.Drawing.Point(112, 1);
            zoomBox.Margin = new System.Windows.Forms.Padding(1);
            zoomBox.Name = "zoomBox";
            zoomBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            zoomBox.Size = new System.Drawing.Size(667, 48);
            zoomBox.TabIndex = 6;
            zoomBox.TabStop = false;
            zoomBox.Text = "Zoom";
            // 
            // zoomSlider
            // 
            zoomSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            zoomSlider.LargeChange = 10;
            zoomSlider.Location = new System.Drawing.Point(3, 19);
            zoomSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            zoomSlider.Maximum = 100;
            zoomSlider.Minimum = 1;
            zoomSlider.Name = "zoomSlider";
            zoomSlider.Size = new System.Drawing.Size(661, 26);
            zoomSlider.TabIndex = 5;
            zoomSlider.TabStop = false;
            zoomSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            zoomSlider.Value = 50;
            zoomSlider.Scroll += zoomSlider_Scroll;
            // 
            // labyrinthToolStrip
            // 
            labyrinthToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            labyrinthToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            labyrinthToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { labyrinthTool, clearBtn, loadBtn, saveBtn, eraseBtn, drawBtn, setMinoPos });
            labyrinthToolStrip.Location = new System.Drawing.Point(0, 0);
            labyrinthToolStrip.MinimumSize = new System.Drawing.Size(0, 15);
            labyrinthToolStrip.Name = "labyrinthToolStrip";
            labyrinthToolStrip.Size = new System.Drawing.Size(438, 28);
            labyrinthToolStrip.Stretch = true;
            labyrinthToolStrip.TabIndex = 0;
            labyrinthToolStrip.Text = "toolStrip3";
            // 
            // labyrinthTool
            // 
            labyrinthTool.ForeColor = System.Drawing.SystemColors.WindowText;
            labyrinthTool.Name = "labyrinthTool";
            labyrinthTool.Size = new System.Drawing.Size(45, 25);
            labyrinthTool.Text = "<Tool>";
            // 
            // clearBtn
            // 
            clearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            clearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            clearBtn.Image = (System.Drawing.Image)resources.GetObject("clearBtn.Image");
            clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new System.Drawing.Size(24, 25);
            clearBtn.Text = "Clear";
            clearBtn.Click += clearBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            loadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            loadBtn.Image = (System.Drawing.Image)resources.GetObject("loadBtn.Image");
            loadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new System.Drawing.Size(24, 25);
            loadBtn.Text = "Load Map";
            loadBtn.Click += loadBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            saveBtn.Image = (System.Drawing.Image)resources.GetObject("saveBtn.Image");
            saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new System.Drawing.Size(24, 25);
            saveBtn.Text = "Save";
            saveBtn.Click += saveBtn_Click;
            // 
            // eraseBtn
            // 
            eraseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            eraseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            eraseBtn.Image = (System.Drawing.Image)resources.GetObject("eraseBtn.Image");
            eraseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            eraseBtn.Name = "eraseBtn";
            eraseBtn.Size = new System.Drawing.Size(24, 25);
            eraseBtn.Text = "Erase";
            eraseBtn.Click += eraseBtn_Click;
            // 
            // drawBtn
            // 
            drawBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            drawBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            drawBtn.Image = (System.Drawing.Image)resources.GetObject("drawBtn.Image");
            drawBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            drawBtn.Name = "drawBtn";
            drawBtn.Size = new System.Drawing.Size(24, 25);
            drawBtn.Text = "Draw";
            drawBtn.Click += drawBtn_Click;
            // 
            // setMinoPos
            // 
            setMinoPos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            setMinoPos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            setMinoPos.Image = (System.Drawing.Image)resources.GetObject("setMinoPos.Image");
            setMinoPos.ImageTransparentColor = System.Drawing.Color.Magenta;
            setMinoPos.Name = "setMinoPos";
            setMinoPos.Size = new System.Drawing.Size(24, 25);
            setMinoPos.Text = "setMinoPos";
            setMinoPos.ToolTipText = "Set Minotaur Position";
            setMinoPos.Click += setMinoPos_Click;
            // 
            // mapToolStrip
            // 
            mapToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            mapToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            mapToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { targetBtn, roamBtn, ClearMemory, mapMode, playBtn, stopBtn });
            mapToolStrip.Location = new System.Drawing.Point(446, 0);
            mapToolStrip.MinimumSize = new System.Drawing.Size(0, 15);
            mapToolStrip.Name = "mapToolStrip";
            mapToolStrip.Size = new System.Drawing.Size(440, 28);
            mapToolStrip.TabIndex = 1;
            mapToolStrip.Text = "toolStrip2";
            // 
            // targetBtn
            // 
            targetBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            targetBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            targetBtn.Image = (System.Drawing.Image)resources.GetObject("targetBtn.Image");
            targetBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            targetBtn.Name = "targetBtn";
            targetBtn.Size = new System.Drawing.Size(24, 25);
            targetBtn.Text = "Type Mode";
            targetBtn.Click += targetBtn_Click;
            // 
            // roamBtn
            // 
            roamBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            roamBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            roamBtn.Image = (System.Drawing.Image)resources.GetObject("roamBtn.Image");
            roamBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            roamBtn.Name = "roamBtn";
            roamBtn.Size = new System.Drawing.Size(24, 25);
            roamBtn.Text = "Roam Mode";
            roamBtn.Click += roamBtn_Click;
            // 
            // ClearMemory
            // 
            ClearMemory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ClearMemory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ClearMemory.Image = (System.Drawing.Image)resources.GetObject("ClearMemory.Image");
            ClearMemory.ImageTransparentColor = System.Drawing.Color.Magenta;
            ClearMemory.Name = "ClearMemory";
            ClearMemory.Size = new System.Drawing.Size(24, 25);
            ClearMemory.Text = "ClearMemory";
            ClearMemory.ToolTipText = "Clear Memory";
            ClearMemory.Click += ClearMemory_Click;
            // 
            // mapMode
            // 
            mapMode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            mapMode.Name = "mapMode";
            mapMode.Size = new System.Drawing.Size(54, 25);
            mapMode.Text = "<mode>";
            // 
            // playBtn
            // 
            playBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            playBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            playBtn.Image = (System.Drawing.Image)resources.GetObject("playBtn.Image");
            playBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            playBtn.Name = "playBtn";
            playBtn.Size = new System.Drawing.Size(24, 25);
            playBtn.Text = "Activate Minotaur";
            playBtn.Click += playBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            stopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            stopBtn.Image = (System.Drawing.Image)resources.GetObject("stopBtn.Image");
            stopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new System.Drawing.Size(24, 25);
            stopBtn.Text = "Deactivate Minotaur";
            stopBtn.Click += stopBtn_Click;
            // 
            // MinotaurWorker
            // 
            MinotaurWorker.WorkerSupportsCancellation = true;
            MinotaurWorker.DoWork += MinotaurWorker_DoWork;
            MinotaurWorker.RunWorkerCompleted += backgroundWorker_End;
            // 
            // LabyrinthUpdate
            // 
            LabyrinthUpdate.WorkerSupportsCancellation = true;
            LabyrinthUpdate.DoWork += LabyrinthUpdate_DoWork;
            LabyrinthUpdate.RunWorkerCompleted += backgroundWorker_End;
            // 
            // openMapFile
            // 
            openMapFile.FileName = "openFileDialog1";
            openMapFile.FileOk += openMapFile_FileOk;
            // 
            // saveMapFile
            // 
            saveMapFile.FileOk += saveMapFile_FileOk;
            // 
            // MenuSplit
            // 
            MenuSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            MenuSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            MenuSplit.Location = new System.Drawing.Point(5, 5);
            MenuSplit.Margin = new System.Windows.Forms.Padding(1);
            MenuSplit.Name = "MenuSplit";
            MenuSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MenuSplit.Panel1
            // 
            MenuSplit.Panel1.Controls.Add(ToolBox);
            MenuSplit.Panel1MinSize = 50;
            // 
            // MenuSplit.Panel2
            // 
            MenuSplit.Panel2.Controls.Add(VerticalLayout);
            MenuSplit.Size = new System.Drawing.Size(892, 385);
            MenuSplit.SplitterWidth = 8;
            MenuSplit.TabIndex = 5;
            // 
            // ToolBox
            // 
            ToolBox.Controls.Add(tableLayoutPanel2);
            ToolBox.Cursor = System.Windows.Forms.Cursors.Hand;
            ToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ToolBox.ForeColor = System.Drawing.SystemColors.Info;
            ToolBox.Location = new System.Drawing.Point(0, 0);
            ToolBox.Name = "ToolBox";
            ToolBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ToolBox.Size = new System.Drawing.Size(892, 50);
            ToolBox.TabIndex = 3;
            ToolBox.TabStop = false;
            ToolBox.Text = "Tool Box";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            tableLayoutPanel2.Controls.Add(labyrinthToolStrip, 0, 0);
            tableLayoutPanel2.Controls.Add(mapToolStrip, 2, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(886, 28);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // MenuPanel
            // 
            MenuPanel.Controls.Add(MenuSplit);
            MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MenuPanel.Location = new System.Drawing.Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Padding = new System.Windows.Forms.Padding(5);
            MenuPanel.Size = new System.Drawing.Size(902, 395);
            MenuPanel.TabIndex = 6;
            // 
            // Knossos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.WindowText;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(902, 395);
            Controls.Add(MenuPanel);
            ForeColor = System.Drawing.SystemColors.InfoText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Knossos";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Daedalus";
            FormClosing += DaedalusForm_Close;
            Load += DaedalusForm_Load;
            VerticalLayout.Panel1.ResumeLayout(false);
            VerticalLayout.Panel2.ResumeLayout(false);
            VerticalLayout.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VerticalLayout).EndInit();
            VerticalLayout.ResumeLayout(false);
            ControlLayout.Panel1.ResumeLayout(false);
            ControlLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ControlLayout).EndInit();
            ControlLayout.ResumeLayout(false);
            labyrinthBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)labyrinthScene).EndInit();
            mapBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mapScene).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            zoomBox.ResumeLayout(false);
            zoomBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zoomSlider).EndInit();
            labyrinthToolStrip.ResumeLayout(false);
            labyrinthToolStrip.PerformLayout();
            mapToolStrip.ResumeLayout(false);
            mapToolStrip.PerformLayout();
            MenuSplit.Panel1.ResumeLayout(false);
            MenuSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenuSplit).EndInit();
            MenuSplit.ResumeLayout(false);
            ToolBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            MenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer VerticalLayout;
        private System.Windows.Forms.SplitContainer ControlLayout;
        private System.Windows.Forms.GroupBox labyrinthBox;
        private System.Windows.Forms.PictureBox labyrinthScene;
        private System.Windows.Forms.ToolStrip labyrinthToolStrip;
        private System.Windows.Forms.ToolStripLabel labyrinthTool;
        private System.Windows.Forms.ToolStripButton clearBtn;
        private System.Windows.Forms.ToolStripButton loadBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton eraseBtn;
        private System.Windows.Forms.ToolStripButton drawBtn;
        private System.Windows.Forms.GroupBox mapBox;
        private System.Windows.Forms.PictureBox mapScene;
        private System.Windows.Forms.ToolStrip mapToolStrip;
        private System.Windows.Forms.ToolStripButton targetBtn;
        private System.Windows.Forms.ToolStripButton roamBtn;
        private System.Windows.Forms.ToolStripLabel mapMode;
        private System.Windows.Forms.ToolStripButton playBtn;
        private System.Windows.Forms.ToolStripButton stopBtn;
        private System.Windows.Forms.TrackBar zoomSlider;
        private System.ComponentModel.BackgroundWorker MinotaurWorker;
        private System.ComponentModel.BackgroundWorker LabyrinthUpdate;
        private System.Windows.Forms.OpenFileDialog openMapFile;
        private System.Windows.Forms.SaveFileDialog saveMapFile;
        private System.Windows.Forms.ToolStripButton setMinoPos;
        private System.Windows.Forms.ToolStripButton ClearMemory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox zoomBox;
        private System.Windows.Forms.SplitContainer MenuSplit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox ToolBox;
        private System.Windows.Forms.Panel MenuPanel;
    }
}

