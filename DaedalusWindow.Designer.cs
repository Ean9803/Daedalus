
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
            this.VerticalLayout = new System.Windows.Forms.SplitContainer();
            this.ControlLayout = new System.Windows.Forms.SplitContainer();
            this.labyrinthBox = new System.Windows.Forms.GroupBox();
            this.labyrinthScene = new System.Windows.Forms.PictureBox();
            this.labyrinthToolStrip = new System.Windows.Forms.ToolStrip();
            this.labyrinthTool = new System.Windows.Forms.ToolStripLabel();
            this.clearBtn = new System.Windows.Forms.ToolStripButton();
            this.loadBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.eraseBtn = new System.Windows.Forms.ToolStripButton();
            this.drawBtn = new System.Windows.Forms.ToolStripButton();
            this.setMinoPos = new System.Windows.Forms.ToolStripButton();
            this.mapBox = new System.Windows.Forms.GroupBox();
            this.mapScene = new System.Windows.Forms.PictureBox();
            this.mapToolStrip = new System.Windows.Forms.ToolStrip();
            this.targetBtn = new System.Windows.Forms.ToolStripButton();
            this.roamBtn = new System.Windows.Forms.ToolStripButton();
            this.ClearMemory = new System.Windows.Forms.ToolStripButton();
            this.mapMode = new System.Windows.Forms.ToolStripLabel();
            this.playBtn = new System.Windows.Forms.ToolStripButton();
            this.stopBtn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomBox = new System.Windows.Forms.GroupBox();
            this.zoomSlider = new System.Windows.Forms.TrackBar();
            this.MinotaurWorker = new System.ComponentModel.BackgroundWorker();
            this.LabyrinthUpdate = new System.ComponentModel.BackgroundWorker();
            this.openMapFile = new System.Windows.Forms.OpenFileDialog();
            this.saveMapFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalLayout)).BeginInit();
            this.VerticalLayout.Panel1.SuspendLayout();
            this.VerticalLayout.Panel2.SuspendLayout();
            this.VerticalLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlLayout)).BeginInit();
            this.ControlLayout.Panel1.SuspendLayout();
            this.ControlLayout.Panel2.SuspendLayout();
            this.ControlLayout.SuspendLayout();
            this.labyrinthBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labyrinthScene)).BeginInit();
            this.labyrinthToolStrip.SuspendLayout();
            this.mapBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapScene)).BeginInit();
            this.mapToolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.zoomBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // VerticalLayout
            // 
            this.VerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerticalLayout.Location = new System.Drawing.Point(0, 0);
            this.VerticalLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VerticalLayout.Name = "VerticalLayout";
            this.VerticalLayout.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // VerticalLayout.Panel1
            // 
            this.VerticalLayout.Panel1.Controls.Add(this.ControlLayout);
            this.VerticalLayout.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // VerticalLayout.Panel2
            // 
            this.VerticalLayout.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.VerticalLayout.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VerticalLayout.Size = new System.Drawing.Size(902, 395);
            this.VerticalLayout.SplitterDistance = 338;
            this.VerticalLayout.SplitterWidth = 8;
            this.VerticalLayout.TabIndex = 4;
            this.VerticalLayout.TabStop = false;
            // 
            // ControlLayout
            // 
            this.ControlLayout.BackColor = System.Drawing.SystemColors.MenuText;
            this.ControlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlLayout.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ControlLayout.Location = new System.Drawing.Point(0, 0);
            this.ControlLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ControlLayout.Name = "ControlLayout";
            // 
            // ControlLayout.Panel1
            // 
            this.ControlLayout.Panel1.Controls.Add(this.labyrinthBox);
            this.ControlLayout.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // ControlLayout.Panel2
            // 
            this.ControlLayout.Panel2.Controls.Add(this.mapBox);
            this.ControlLayout.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ControlLayout.Size = new System.Drawing.Size(902, 338);
            this.ControlLayout.SplitterDistance = 449;
            this.ControlLayout.SplitterWidth = 9;
            this.ControlLayout.TabIndex = 3;
            this.ControlLayout.TabStop = false;
            // 
            // labyrinthBox
            // 
            this.labyrinthBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.labyrinthBox.Controls.Add(this.labyrinthScene);
            this.labyrinthBox.Controls.Add(this.labyrinthToolStrip);
            this.labyrinthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labyrinthBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labyrinthBox.Location = new System.Drawing.Point(0, 0);
            this.labyrinthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labyrinthBox.Name = "labyrinthBox";
            this.labyrinthBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labyrinthBox.Size = new System.Drawing.Size(449, 338);
            this.labyrinthBox.TabIndex = 0;
            this.labyrinthBox.TabStop = false;
            this.labyrinthBox.Text = "Labyrinth";
            // 
            // labyrinthScene
            // 
            this.labyrinthScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labyrinthScene.Location = new System.Drawing.Point(3, 68);
            this.labyrinthScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labyrinthScene.Name = "labyrinthScene";
            this.labyrinthScene.Size = new System.Drawing.Size(443, 268);
            this.labyrinthScene.TabIndex = 7;
            this.labyrinthScene.TabStop = false;
            this.labyrinthScene.Paint += new System.Windows.Forms.PaintEventHandler(this.labyrinthScene_Paint);
            this.labyrinthScene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labyrinthScene_MouseDown);
            this.labyrinthScene.MouseLeave += new System.EventHandler(this.labyrinthScene_MouseLeave);
            this.labyrinthScene.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labyrinthScene_Mouse);
            this.labyrinthScene.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labyrinthScene_MouseUp);
            // 
            // labyrinthToolStrip
            // 
            this.labyrinthToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.labyrinthToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labyrinthTool,
            this.clearBtn,
            this.loadBtn,
            this.saveBtn,
            this.eraseBtn,
            this.drawBtn,
            this.setMinoPos});
            this.labyrinthToolStrip.Location = new System.Drawing.Point(3, 18);
            this.labyrinthToolStrip.MinimumSize = new System.Drawing.Size(0, 50);
            this.labyrinthToolStrip.Name = "labyrinthToolStrip";
            this.labyrinthToolStrip.Size = new System.Drawing.Size(443, 50);
            this.labyrinthToolStrip.TabIndex = 0;
            this.labyrinthToolStrip.Text = "toolStrip3";
            // 
            // labyrinthTool
            // 
            this.labyrinthTool.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labyrinthTool.Name = "labyrinthTool";
            this.labyrinthTool.Size = new System.Drawing.Size(45, 47);
            this.labyrinthTool.Text = "<Tool>";
            // 
            // clearBtn
            // 
            this.clearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(24, 47);
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadBtn.Image")));
            this.loadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(24, 47);
            this.loadBtn.Text = "Load Map";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(24, 47);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // eraseBtn
            // 
            this.eraseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.eraseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraseBtn.Image = ((System.Drawing.Image)(resources.GetObject("eraseBtn.Image")));
            this.eraseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(24, 47);
            this.eraseBtn.Text = "Erase";
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.drawBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawBtn.Image")));
            this.drawBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(24, 47);
            this.drawBtn.Text = "Draw";
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // setMinoPos
            // 
            this.setMinoPos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.setMinoPos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setMinoPos.Image = ((System.Drawing.Image)(resources.GetObject("setMinoPos.Image")));
            this.setMinoPos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setMinoPos.Name = "setMinoPos";
            this.setMinoPos.Size = new System.Drawing.Size(24, 47);
            this.setMinoPos.Text = "setMinoPos";
            this.setMinoPos.ToolTipText = "Set Minotaur Position";
            this.setMinoPos.Click += new System.EventHandler(this.setMinoPos_Click);
            // 
            // mapBox
            // 
            this.mapBox.Controls.Add(this.mapScene);
            this.mapBox.Controls.Add(this.mapToolStrip);
            this.mapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mapBox.Location = new System.Drawing.Point(0, 0);
            this.mapBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapBox.Name = "mapBox";
            this.mapBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapBox.Size = new System.Drawing.Size(444, 338);
            this.mapBox.TabIndex = 0;
            this.mapBox.TabStop = false;
            this.mapBox.Text = "Map";
            // 
            // mapScene
            // 
            this.mapScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapScene.Location = new System.Drawing.Point(3, 68);
            this.mapScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapScene.Name = "mapScene";
            this.mapScene.Size = new System.Drawing.Size(438, 268);
            this.mapScene.TabIndex = 3;
            this.mapScene.TabStop = false;
            this.mapScene.Paint += new System.Windows.Forms.PaintEventHandler(this.mapScene_Paint);
            this.mapScene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapScene_MouseDown);
            this.mapScene.MouseLeave += new System.EventHandler(this.mapScene_MouseLeave);
            this.mapScene.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapScene_Mouse);
            this.mapScene.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mapScene_MouseUp);
            // 
            // mapToolStrip
            // 
            this.mapToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mapToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.targetBtn,
            this.roamBtn,
            this.ClearMemory,
            this.mapMode,
            this.playBtn,
            this.stopBtn});
            this.mapToolStrip.Location = new System.Drawing.Point(3, 18);
            this.mapToolStrip.MinimumSize = new System.Drawing.Size(0, 50);
            this.mapToolStrip.Name = "mapToolStrip";
            this.mapToolStrip.Size = new System.Drawing.Size(438, 50);
            this.mapToolStrip.TabIndex = 1;
            this.mapToolStrip.Text = "toolStrip2";
            // 
            // targetBtn
            // 
            this.targetBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.targetBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.targetBtn.Image = ((System.Drawing.Image)(resources.GetObject("targetBtn.Image")));
            this.targetBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.targetBtn.Name = "targetBtn";
            this.targetBtn.Size = new System.Drawing.Size(24, 47);
            this.targetBtn.Text = "Type Mode";
            this.targetBtn.Click += new System.EventHandler(this.targetBtn_Click);
            // 
            // roamBtn
            // 
            this.roamBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.roamBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roamBtn.Image = ((System.Drawing.Image)(resources.GetObject("roamBtn.Image")));
            this.roamBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roamBtn.Name = "roamBtn";
            this.roamBtn.Size = new System.Drawing.Size(24, 47);
            this.roamBtn.Text = "Roam Mode";
            this.roamBtn.Click += new System.EventHandler(this.roamBtn_Click);
            // 
            // ClearMemory
            // 
            this.ClearMemory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ClearMemory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearMemory.Image = ((System.Drawing.Image)(resources.GetObject("ClearMemory.Image")));
            this.ClearMemory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearMemory.Name = "ClearMemory";
            this.ClearMemory.Size = new System.Drawing.Size(24, 47);
            this.ClearMemory.Text = "ClearMemory";
            this.ClearMemory.ToolTipText = "Clear Memory";
            this.ClearMemory.Click += new System.EventHandler(this.ClearMemory_Click);
            // 
            // mapMode
            // 
            this.mapMode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mapMode.Name = "mapMode";
            this.mapMode.Size = new System.Drawing.Size(54, 47);
            this.mapMode.Text = "<mode>";
            // 
            // playBtn
            // 
            this.playBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.playBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playBtn.Image = ((System.Drawing.Image)(resources.GetObject("playBtn.Image")));
            this.playBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(24, 47);
            this.playBtn.Text = "Activate Minotaur";
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(24, 47);
            this.stopBtn.Text = "Deactivate Minotaur";
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.zoomBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 49);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // zoomBox
            // 
            this.zoomBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomBox.AutoSize = true;
            this.zoomBox.Controls.Add(this.zoomSlider);
            this.zoomBox.ForeColor = System.Drawing.SystemColors.Info;
            this.zoomBox.Location = new System.Drawing.Point(113, 1);
            this.zoomBox.Margin = new System.Windows.Forms.Padding(1);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zoomBox.Size = new System.Drawing.Size(674, 47);
            this.zoomBox.TabIndex = 6;
            this.zoomBox.TabStop = false;
            this.zoomBox.Text = "Zoom";
            // 
            // zoomSlider
            // 
            this.zoomSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomSlider.LargeChange = 10;
            this.zoomSlider.Location = new System.Drawing.Point(3, 19);
            this.zoomSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoomSlider.Maximum = 100;
            this.zoomSlider.Minimum = 1;
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Size = new System.Drawing.Size(668, 25);
            this.zoomSlider.TabIndex = 5;
            this.zoomSlider.TabStop = false;
            this.zoomSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.zoomSlider.Value = 50;
            this.zoomSlider.Scroll += new System.EventHandler(this.zoomSlider_Scroll);
            // 
            // MinotaurWorker
            // 
            this.MinotaurWorker.WorkerSupportsCancellation = true;
            this.MinotaurWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MinotaurWorker_DoWork);
            this.MinotaurWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_End);
            // 
            // LabyrinthUpdate
            // 
            this.LabyrinthUpdate.WorkerSupportsCancellation = true;
            this.LabyrinthUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LabyrinthUpdate_DoWork);
            this.LabyrinthUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_End);
            // 
            // openMapFile
            // 
            this.openMapFile.FileName = "openFileDialog1";
            this.openMapFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openMapFile_FileOk);
            // 
            // saveMapFile
            // 
            this.saveMapFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveMapFile_FileOk);
            // 
            // Knossos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(902, 395);
            this.Controls.Add(this.VerticalLayout);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Knossos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Daedalus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DaedalusForm_Close);
            this.Load += new System.EventHandler(this.DaedalusForm_Load);
            this.VerticalLayout.Panel1.ResumeLayout(false);
            this.VerticalLayout.Panel2.ResumeLayout(false);
            this.VerticalLayout.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalLayout)).EndInit();
            this.VerticalLayout.ResumeLayout(false);
            this.ControlLayout.Panel1.ResumeLayout(false);
            this.ControlLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControlLayout)).EndInit();
            this.ControlLayout.ResumeLayout(false);
            this.labyrinthBox.ResumeLayout(false);
            this.labyrinthBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labyrinthScene)).EndInit();
            this.labyrinthToolStrip.ResumeLayout(false);
            this.labyrinthToolStrip.PerformLayout();
            this.mapBox.ResumeLayout(false);
            this.mapBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapScene)).EndInit();
            this.mapToolStrip.ResumeLayout(false);
            this.mapToolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.zoomBox.ResumeLayout(false);
            this.zoomBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            this.ResumeLayout(false);

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
    }
}

