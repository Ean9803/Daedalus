
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Protanopia");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Red-Green Blindness", new System.Windows.Forms.TreeNode[] { treeNode1 });
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tritanopia");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Blue-Yellow Blindness", new System.Windows.Forms.TreeNode[] { treeNode3 });
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Achromatopsia");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Visual", new System.Windows.Forms.TreeNode[] { treeNode2, treeNode4, treeNode5 });
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Display");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Internal");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Environment");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Reset");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Settings", new System.Windows.Forms.TreeNode[] { treeNode6, treeNode7, treeNode8, treeNode9, treeNode10 });
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Manual");
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
            tabMenu = new System.Windows.Forms.TabControl();
            MenuTab = new System.Windows.Forms.TabPage();
            SettingsTab = new System.Windows.Forms.TabPage();
            tableSettings = new System.Windows.Forms.TableLayoutPanel();
            SettingControl = new System.Windows.Forms.TabControl();
            Visual = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox4 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            LabColor = new System.Windows.Forms.Panel();
            ChangeMapColor = new System.Windows.Forms.Button();
            groupBox9 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            LabHighlightColor = new System.Windows.Forms.Panel();
            ChangeHighlightColor = new System.Windows.Forms.Button();
            groupBox5 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            MinoColor = new System.Windows.Forms.Panel();
            ChangeMinoColor = new System.Windows.Forms.Button();
            groupBox30 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            NonHitColor = new System.Windows.Forms.Panel();
            ChangeNonHitColor = new System.Windows.Forms.Button();
            groupBox31 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            RayLineColor = new System.Windows.Forms.Panel();
            ChangeRayColor = new System.Windows.Forms.Button();
            groupBox7 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            MapObjectsColor = new System.Windows.Forms.Panel();
            ChangeMapObjectsColor = new System.Windows.Forms.Button();
            groupBox8 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            MapChunkColor = new System.Windows.Forms.Panel();
            ChangeMapChunckColor = new System.Windows.Forms.Button();
            groupBox15 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            MapWallColor = new System.Windows.Forms.Panel();
            ChangeMapWallColor = new System.Windows.Forms.Button();
            Display = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox10 = new System.Windows.Forms.GroupBox();
            ShowCollidedPoints = new System.Windows.Forms.CheckBox();
            groupBox11 = new System.Windows.Forms.GroupBox();
            ShowUncollidedPoints = new System.Windows.Forms.CheckBox();
            groupBox18 = new System.Windows.Forms.GroupBox();
            ShowCurrentTarget = new System.Windows.Forms.CheckBox();
            groupBox16 = new System.Windows.Forms.GroupBox();
            ShowRoamTargets = new System.Windows.Forms.CheckBox();
            groupBox25 = new System.Windows.Forms.GroupBox();
            ShowUserTarget = new System.Windows.Forms.CheckBox();
            groupBox17 = new System.Windows.Forms.GroupBox();
            ShowPath = new System.Windows.Forms.CheckBox();
            groupBox12 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            ObjectRadius = new System.Windows.Forms.TextBox();
            ObjectRadiusSlider = new System.Windows.Forms.TrackBar();
            groupBox13 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            ChunkRadius = new System.Windows.Forms.TextBox();
            ChunkRadiusSlider = new System.Windows.Forms.TrackBar();
            groupBox33 = new System.Windows.Forms.GroupBox();
            ShowNonHitRays = new System.Windows.Forms.CheckBox();
            groupBox32 = new System.Windows.Forms.GroupBox();
            ShowHitRays = new System.Windows.Forms.CheckBox();
            groupBox14 = new System.Windows.Forms.GroupBox();
            ShowWallData = new System.Windows.Forms.CheckBox();
            Internal = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox21 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            MinoRadius = new System.Windows.Forms.TextBox();
            MinoRadiusSlider = new System.Windows.Forms.TrackBar();
            groupBox22 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            ExpansionBias = new System.Windows.Forms.TextBox();
            ExpansionBiasSlider = new System.Windows.Forms.TrackBar();
            groupBox26 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            GridRadius = new System.Windows.Forms.TextBox();
            GridRadiusSlider = new System.Windows.Forms.TrackBar();
            groupBox19 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            MinoRayRes = new System.Windows.Forms.TextBox();
            MinoRayResSlider = new System.Windows.Forms.TrackBar();
            groupBox20 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            MinoSpeed = new System.Windows.Forms.TextBox();
            MinoSpeedSlider = new System.Windows.Forms.TrackBar();
            groupBox23 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            MinoViewDistance = new System.Windows.Forms.TextBox();
            MinoViewDistanceSlider = new System.Windows.Forms.TrackBar();
            Environment = new System.Windows.Forms.TabPage();
            groupBox27 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox28 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            WallWidth = new System.Windows.Forms.TextBox();
            WallWidthSlider = new System.Windows.Forms.TrackBar();
            ApplyColor = new System.Windows.Forms.TabPage();
            groupBox29 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            Apply = new System.Windows.Forms.Button();
            Cancel = new System.Windows.Forms.Button();
            Reset = new System.Windows.Forms.TabPage();
            groupBox34 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            ResetSet = new System.Windows.Forms.Button();
            CancelSet = new System.Windows.Forms.Button();
            groupBox24 = new System.Windows.Forms.GroupBox();
            treeSettings = new System.Windows.Forms.TreeView();
            HelpTab = new System.Windows.Forms.TabPage();
            tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            groupBox65 = new System.Windows.Forms.GroupBox();
            treeHelp = new System.Windows.Forms.TreeView();
            richTextHelp = new System.Windows.Forms.RichTextBox();
            colorDialog = new System.Windows.Forms.ColorDialog();
            groupBox6 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
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
            tabMenu.SuspendLayout();
            MenuTab.SuspendLayout();
            SettingsTab.SuspendLayout();
            tableSettings.SuspendLayout();
            SettingControl.SuspendLayout();
            Visual.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox30.SuspendLayout();
            tableLayoutPanel19.SuspendLayout();
            groupBox31.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            groupBox7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox15.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            Display.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox18.SuspendLayout();
            groupBox16.SuspendLayout();
            groupBox25.SuspendLayout();
            groupBox17.SuspendLayout();
            groupBox12.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ObjectRadiusSlider).BeginInit();
            groupBox13.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChunkRadiusSlider).BeginInit();
            groupBox33.SuspendLayout();
            groupBox32.SuspendLayout();
            groupBox14.SuspendLayout();
            Internal.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox21.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinoRadiusSlider).BeginInit();
            groupBox22.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpansionBiasSlider).BeginInit();
            groupBox26.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridRadiusSlider).BeginInit();
            groupBox19.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinoRayResSlider).BeginInit();
            groupBox20.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinoSpeedSlider).BeginInit();
            groupBox23.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinoViewDistanceSlider).BeginInit();
            Environment.SuspendLayout();
            groupBox27.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            groupBox28.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WallWidthSlider).BeginInit();
            ApplyColor.SuspendLayout();
            groupBox29.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            Reset.SuspendLayout();
            groupBox34.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            groupBox24.SuspendLayout();
            HelpTab.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            groupBox65.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
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
            VerticalLayout.Size = new System.Drawing.Size(878, 355);
            VerticalLayout.SplitterDistance = 288;
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
            ControlLayout.Size = new System.Drawing.Size(878, 288);
            ControlLayout.SplitterDistance = 434;
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
            labyrinthBox.Size = new System.Drawing.Size(434, 288);
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
            labyrinthScene.Size = new System.Drawing.Size(428, 268);
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
            mapBox.Size = new System.Drawing.Size(435, 288);
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
            mapScene.Size = new System.Drawing.Size(429, 268);
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
            tableLayoutPanel1.Size = new System.Drawing.Size(878, 59);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // zoomBox
            // 
            zoomBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            zoomBox.AutoSize = true;
            zoomBox.Controls.Add(zoomSlider);
            zoomBox.ForeColor = System.Drawing.SystemColors.Info;
            zoomBox.Location = new System.Drawing.Point(110, 1);
            zoomBox.Margin = new System.Windows.Forms.Padding(1);
            zoomBox.Name = "zoomBox";
            zoomBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            zoomBox.Size = new System.Drawing.Size(656, 57);
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
            zoomSlider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            zoomSlider.Size = new System.Drawing.Size(650, 35);
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
            labyrinthToolStrip.Size = new System.Drawing.Size(431, 28);
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
            mapToolStrip.Location = new System.Drawing.Point(439, 0);
            mapToolStrip.MinimumSize = new System.Drawing.Size(0, 15);
            mapToolStrip.Name = "mapToolStrip";
            mapToolStrip.Size = new System.Drawing.Size(433, 28);
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
            MenuSplit.Size = new System.Drawing.Size(878, 413);
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
            ToolBox.Size = new System.Drawing.Size(878, 50);
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
            tableLayoutPanel2.Size = new System.Drawing.Size(872, 28);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // MenuPanel
            // 
            MenuPanel.Controls.Add(MenuSplit);
            MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MenuPanel.Location = new System.Drawing.Point(3, 3);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Padding = new System.Windows.Forms.Padding(5);
            MenuPanel.Size = new System.Drawing.Size(888, 423);
            MenuPanel.TabIndex = 6;
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(MenuTab);
            tabMenu.Controls.Add(SettingsTab);
            tabMenu.Controls.Add(HelpTab);
            tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            tabMenu.Location = new System.Drawing.Point(0, 0);
            tabMenu.Multiline = true;
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new System.Drawing.Size(902, 457);
            tabMenu.TabIndex = 7;
            // 
            // MenuTab
            // 
            MenuTab.BackColor = System.Drawing.Color.Black;
            MenuTab.Controls.Add(MenuPanel);
            MenuTab.Location = new System.Drawing.Point(4, 24);
            MenuTab.Name = "MenuTab";
            MenuTab.Padding = new System.Windows.Forms.Padding(3);
            MenuTab.Size = new System.Drawing.Size(894, 429);
            MenuTab.TabIndex = 0;
            MenuTab.Text = "Tower";
            // 
            // SettingsTab
            // 
            SettingsTab.BackColor = System.Drawing.Color.Black;
            SettingsTab.Controls.Add(tableSettings);
            SettingsTab.Location = new System.Drawing.Point(4, 24);
            SettingsTab.Name = "SettingsTab";
            SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            SettingsTab.Size = new System.Drawing.Size(894, 429);
            SettingsTab.TabIndex = 1;
            SettingsTab.Text = "Settings";
            // 
            // tableSettings
            // 
            tableSettings.ColumnCount = 2;
            tableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableSettings.Controls.Add(SettingControl, 1, 0);
            tableSettings.Controls.Add(groupBox24, 0, 0);
            tableSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            tableSettings.Location = new System.Drawing.Point(3, 3);
            tableSettings.Name = "tableSettings";
            tableSettings.RowCount = 1;
            tableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableSettings.Size = new System.Drawing.Size(888, 423);
            tableSettings.TabIndex = 0;
            // 
            // SettingControl
            // 
            SettingControl.Controls.Add(Visual);
            SettingControl.Controls.Add(Display);
            SettingControl.Controls.Add(Internal);
            SettingControl.Controls.Add(Environment);
            SettingControl.Controls.Add(ApplyColor);
            SettingControl.Controls.Add(Reset);
            SettingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            SettingControl.ItemSize = new System.Drawing.Size(0, 1);
            SettingControl.Location = new System.Drawing.Point(180, 3);
            SettingControl.Name = "SettingControl";
            SettingControl.Padding = new System.Drawing.Point(0, 0);
            SettingControl.SelectedIndex = 0;
            SettingControl.Size = new System.Drawing.Size(705, 417);
            SettingControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            SettingControl.TabIndex = 1;
            SettingControl.TabStop = false;
            // 
            // Visual
            // 
            Visual.BackColor = System.Drawing.Color.Black;
            Visual.Controls.Add(groupBox1);
            Visual.Location = new System.Drawing.Point(4, 5);
            Visual.Name = "Visual";
            Visual.Padding = new System.Windows.Forms.Padding(3);
            Visual.Size = new System.Drawing.Size(697, 408);
            Visual.TabIndex = 0;
            Visual.Text = "1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(691, 402);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Visual Settings";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox9);
            flowLayoutPanel1.Controls.Add(groupBox5);
            flowLayoutPanel1.Controls.Add(groupBox30);
            flowLayoutPanel1.Controls.Add(groupBox31);
            flowLayoutPanel1.Controls.Add(groupBox7);
            flowLayoutPanel1.Controls.Add(groupBox8);
            flowLayoutPanel1.Controls.Add(groupBox15);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(685, 380);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel3);
            groupBox4.ForeColor = System.Drawing.SystemColors.Info;
            groupBox4.Location = new System.Drawing.Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox4.Size = new System.Drawing.Size(651, 66);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Labyrinth Map Color";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(LabColor, 0, 0);
            tableLayoutPanel3.Controls.Add(ChangeMapColor, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // LabColor
            // 
            LabColor.BackColor = System.Drawing.Color.White;
            LabColor.Dock = System.Windows.Forms.DockStyle.Fill;
            LabColor.Location = new System.Drawing.Point(3, 3);
            LabColor.Name = "LabColor";
            LabColor.Size = new System.Drawing.Size(316, 38);
            LabColor.TabIndex = 0;
            // 
            // ChangeMapColor
            // 
            ChangeMapColor.BackColor = System.Drawing.Color.White;
            ChangeMapColor.Dock = System.Windows.Forms.DockStyle.Fill;
            ChangeMapColor.ForeColor = System.Drawing.SystemColors.InfoText;
            ChangeMapColor.Location = new System.Drawing.Point(325, 3);
            ChangeMapColor.Name = "ChangeMapColor";
            ChangeMapColor.Size = new System.Drawing.Size(317, 38);
            ChangeMapColor.TabIndex = 1;
            ChangeMapColor.Text = "Change";
            ChangeMapColor.UseVisualStyleBackColor = false;
            ChangeMapColor.Click += ChangeMapColor_Click;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(tableLayoutPanel8);
            groupBox9.ForeColor = System.Drawing.SystemColors.Info;
            groupBox9.Location = new System.Drawing.Point(3, 75);
            groupBox9.Name = "groupBox9";
            groupBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox9.Size = new System.Drawing.Size(651, 66);
            groupBox9.TabIndex = 1;
            groupBox9.TabStop = false;
            groupBox9.Text = "Labyrinth Highlight Color";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(LabHighlightColor, 0, 0);
            tableLayoutPanel8.Controls.Add(ChangeHighlightColor, 1, 0);
            tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel8.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // LabHighlightColor
            // 
            LabHighlightColor.BackColor = System.Drawing.Color.White;
            LabHighlightColor.Dock = System.Windows.Forms.DockStyle.Fill;
            LabHighlightColor.Location = new System.Drawing.Point(3, 3);
            LabHighlightColor.Name = "LabHighlightColor";
            LabHighlightColor.Size = new System.Drawing.Size(316, 38);
            LabHighlightColor.TabIndex = 0;
            // 
            // ChangeHighlightColor
            // 
            ChangeHighlightColor.BackColor = System.Drawing.Color.White;
            ChangeHighlightColor.Dock = System.Windows.Forms.DockStyle.Fill;
            ChangeHighlightColor.ForeColor = System.Drawing.SystemColors.InfoText;
            ChangeHighlightColor.Location = new System.Drawing.Point(325, 3);
            ChangeHighlightColor.Name = "ChangeHighlightColor";
            ChangeHighlightColor.Size = new System.Drawing.Size(317, 38);
            ChangeHighlightColor.TabIndex = 1;
            ChangeHighlightColor.Text = "Change";
            ChangeHighlightColor.UseVisualStyleBackColor = false;
            ChangeHighlightColor.Click += ChangeHighlightColor_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel4);
            groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox5.ForeColor = System.Drawing.SystemColors.Info;
            groupBox5.Location = new System.Drawing.Point(3, 147);
            groupBox5.Name = "groupBox5";
            groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox5.Size = new System.Drawing.Size(651, 66);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Mino Color";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(MinoColor, 0, 0);
            tableLayoutPanel4.Controls.Add(ChangeMinoColor, 1, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // MinoColor
            // 
            MinoColor.BackColor = System.Drawing.Color.White;
            MinoColor.Dock = System.Windows.Forms.DockStyle.Fill;
            MinoColor.Location = new System.Drawing.Point(3, 3);
            MinoColor.Name = "MinoColor";
            MinoColor.Size = new System.Drawing.Size(316, 38);
            MinoColor.TabIndex = 0;
            // 
            // ChangeMinoColor
            // 
            ChangeMinoColor.BackColor = System.Drawing.Color.White;
            ChangeMinoColor.Dock = System.Windows.Forms.DockStyle.Fill;
            ChangeMinoColor.ForeColor = System.Drawing.SystemColors.InfoText;
            ChangeMinoColor.Location = new System.Drawing.Point(325, 3);
            ChangeMinoColor.Name = "ChangeMinoColor";
            ChangeMinoColor.Size = new System.Drawing.Size(317, 38);
            ChangeMinoColor.TabIndex = 1;
            ChangeMinoColor.Text = "Change";
            ChangeMinoColor.UseVisualStyleBackColor = false;
            ChangeMinoColor.Click += ChangeMinoColor_Click;
            // 
            // groupBox30
            // 
            groupBox30.Controls.Add(tableLayoutPanel19);
            groupBox30.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox30.ForeColor = System.Drawing.SystemColors.Info;
            groupBox30.Location = new System.Drawing.Point(3, 219);
            groupBox30.Name = "groupBox30";
            groupBox30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox30.Size = new System.Drawing.Size(651, 66);
            groupBox30.TabIndex = 1;
            groupBox30.TabStop = false;
            groupBox30.Text = "Non-Hit Point Color";
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 2;
            tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel19.Controls.Add(NonHitColor, 0, 0);
            tableLayoutPanel19.Controls.Add(ChangeNonHitColor, 1, 0);
            tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel19.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 1;
            tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel19.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel19.TabIndex = 0;
            // 
            // NonHitColor
            // 
            NonHitColor.BackColor = System.Drawing.Color.White;
            NonHitColor.Dock = System.Windows.Forms.DockStyle.Fill;
            NonHitColor.Location = new System.Drawing.Point(3, 3);
            NonHitColor.Name = "NonHitColor";
            NonHitColor.Size = new System.Drawing.Size(316, 38);
            NonHitColor.TabIndex = 0;
            // 
            // ChangeNonHitColor
            // 
            ChangeNonHitColor.BackColor = System.Drawing.Color.White;
            ChangeNonHitColor.Dock = System.Windows.Forms.DockStyle.Fill;
            ChangeNonHitColor.ForeColor = System.Drawing.SystemColors.InfoText;
            ChangeNonHitColor.Location = new System.Drawing.Point(325, 3);
            ChangeNonHitColor.Name = "ChangeNonHitColor";
            ChangeNonHitColor.Size = new System.Drawing.Size(317, 38);
            ChangeNonHitColor.TabIndex = 1;
            ChangeNonHitColor.Text = "Change";
            ChangeNonHitColor.UseVisualStyleBackColor = false;
            ChangeNonHitColor.Click += ChangeNonHitColor_Click;
            // 
            // groupBox31
            // 
            groupBox31.Controls.Add(tableLayoutPanel20);
            groupBox31.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox31.ForeColor = System.Drawing.SystemColors.Info;
            groupBox31.Location = new System.Drawing.Point(3, 291);
            groupBox31.Name = "groupBox31";
            groupBox31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox31.Size = new System.Drawing.Size(651, 66);
            groupBox31.TabIndex = 1;
            groupBox31.TabStop = false;
            groupBox31.Text = "Ray Line Color";
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.ColumnCount = 2;
            tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel20.Controls.Add(RayLineColor, 0, 0);
            tableLayoutPanel20.Controls.Add(ChangeRayColor, 1, 0);
            tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel20.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.RowCount = 1;
            tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel20.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel20.TabIndex = 0;
            // 
            // RayLineColor
            // 
            RayLineColor.BackColor = System.Drawing.Color.White;
            RayLineColor.Dock = System.Windows.Forms.DockStyle.Fill;
            RayLineColor.Location = new System.Drawing.Point(3, 3);
            RayLineColor.Name = "RayLineColor";
            RayLineColor.Size = new System.Drawing.Size(316, 38);
            RayLineColor.TabIndex = 0;
            // 
            // ChangeRayColor
            // 
            ChangeRayColor.BackColor = System.Drawing.Color.White;
            ChangeRayColor.Dock = System.Windows.Forms.DockStyle.Fill;
            ChangeRayColor.ForeColor = System.Drawing.SystemColors.InfoText;
            ChangeRayColor.Location = new System.Drawing.Point(325, 3);
            ChangeRayColor.Name = "ChangeRayColor";
            ChangeRayColor.Size = new System.Drawing.Size(317, 38);
            ChangeRayColor.TabIndex = 1;
            ChangeRayColor.Text = "Change";
            ChangeRayColor.UseVisualStyleBackColor = false;
            ChangeRayColor.Click += ChangeRayColor_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(tableLayoutPanel6);
            groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox7.ForeColor = System.Drawing.SystemColors.Info;
            groupBox7.Location = new System.Drawing.Point(3, 363);
            groupBox7.Name = "groupBox7";
            groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox7.Size = new System.Drawing.Size(651, 66);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Map Object Color";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(MapObjectsColor, 0, 0);
            tableLayoutPanel6.Controls.Add(ChangeMapObjectsColor, 1, 0);
            tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel6.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // MapObjectsColor
            // 
            MapObjectsColor.BackColor = System.Drawing.Color.White;
            MapObjectsColor.Dock = System.Windows.Forms.DockStyle.Fill;
            MapObjectsColor.Location = new System.Drawing.Point(3, 3);
            MapObjectsColor.Name = "MapObjectsColor";
            MapObjectsColor.Size = new System.Drawing.Size(316, 38);
            MapObjectsColor.TabIndex = 0;
            // 
            // ChangeMapObjectsColor
            // 
            ChangeMapObjectsColor.BackColor = System.Drawing.Color.White;
            ChangeMapObjectsColor.Dock = System.Windows.Forms.DockStyle.Fill;
            ChangeMapObjectsColor.ForeColor = System.Drawing.SystemColors.InfoText;
            ChangeMapObjectsColor.Location = new System.Drawing.Point(325, 3);
            ChangeMapObjectsColor.Name = "ChangeMapObjectsColor";
            ChangeMapObjectsColor.Size = new System.Drawing.Size(317, 38);
            ChangeMapObjectsColor.TabIndex = 1;
            ChangeMapObjectsColor.Text = "Change";
            ChangeMapObjectsColor.UseVisualStyleBackColor = false;
            ChangeMapObjectsColor.Click += ChangeMapObjectsColor_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(tableLayoutPanel7);
            groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox8.ForeColor = System.Drawing.SystemColors.Info;
            groupBox8.Location = new System.Drawing.Point(3, 435);
            groupBox8.Name = "groupBox8";
            groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox8.Size = new System.Drawing.Size(651, 66);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Map Chunk Color";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(MapChunkColor, 0, 0);
            tableLayoutPanel7.Controls.Add(ChangeMapChunckColor, 1, 0);
            tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel7.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // MapChunkColor
            // 
            MapChunkColor.BackColor = System.Drawing.Color.White;
            MapChunkColor.Dock = System.Windows.Forms.DockStyle.Fill;
            MapChunkColor.Location = new System.Drawing.Point(3, 3);
            MapChunkColor.Name = "MapChunkColor";
            MapChunkColor.Size = new System.Drawing.Size(316, 38);
            MapChunkColor.TabIndex = 0;
            // 
            // ChangeMapChunckColor
            // 
            ChangeMapChunckColor.BackColor = System.Drawing.Color.White;
            ChangeMapChunckColor.Dock = System.Windows.Forms.DockStyle.Fill;
            ChangeMapChunckColor.ForeColor = System.Drawing.SystemColors.InfoText;
            ChangeMapChunckColor.Location = new System.Drawing.Point(325, 3);
            ChangeMapChunckColor.Name = "ChangeMapChunckColor";
            ChangeMapChunckColor.Size = new System.Drawing.Size(317, 38);
            ChangeMapChunckColor.TabIndex = 1;
            ChangeMapChunckColor.Text = "Change";
            ChangeMapChunckColor.UseVisualStyleBackColor = false;
            ChangeMapChunckColor.Click += ChangeMapChunckColor_Click;
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(tableLayoutPanel11);
            groupBox15.ForeColor = System.Drawing.SystemColors.Info;
            groupBox15.Location = new System.Drawing.Point(3, 507);
            groupBox15.Name = "groupBox15";
            groupBox15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox15.Size = new System.Drawing.Size(651, 66);
            groupBox15.TabIndex = 2;
            groupBox15.TabStop = false;
            groupBox15.Text = "Map Wall Color";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(MapWallColor, 0, 0);
            tableLayoutPanel11.Controls.Add(ChangeMapWallColor, 1, 0);
            tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel11.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // MapWallColor
            // 
            MapWallColor.BackColor = System.Drawing.Color.White;
            MapWallColor.Dock = System.Windows.Forms.DockStyle.Fill;
            MapWallColor.Location = new System.Drawing.Point(3, 3);
            MapWallColor.Name = "MapWallColor";
            MapWallColor.Size = new System.Drawing.Size(316, 38);
            MapWallColor.TabIndex = 0;
            // 
            // ChangeMapWallColor
            // 
            ChangeMapWallColor.BackColor = System.Drawing.Color.White;
            ChangeMapWallColor.Dock = System.Windows.Forms.DockStyle.Fill;
            ChangeMapWallColor.ForeColor = System.Drawing.SystemColors.InfoText;
            ChangeMapWallColor.Location = new System.Drawing.Point(325, 3);
            ChangeMapWallColor.Name = "ChangeMapWallColor";
            ChangeMapWallColor.Size = new System.Drawing.Size(317, 38);
            ChangeMapWallColor.TabIndex = 1;
            ChangeMapWallColor.Text = "Change";
            ChangeMapWallColor.UseVisualStyleBackColor = false;
            ChangeMapWallColor.Click += ChangeMapWallColor_Click;
            // 
            // Display
            // 
            Display.BackColor = System.Drawing.Color.Black;
            Display.Controls.Add(groupBox2);
            Display.Location = new System.Drawing.Point(4, 5);
            Display.Name = "Display";
            Display.Padding = new System.Windows.Forms.Padding(3);
            Display.Size = new System.Drawing.Size(697, 408);
            Display.TabIndex = 1;
            Display.Text = "2";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            groupBox2.Location = new System.Drawing.Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(691, 402);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Display Settings";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(groupBox10);
            flowLayoutPanel2.Controls.Add(groupBox11);
            flowLayoutPanel2.Controls.Add(groupBox18);
            flowLayoutPanel2.Controls.Add(groupBox16);
            flowLayoutPanel2.Controls.Add(groupBox25);
            flowLayoutPanel2.Controls.Add(groupBox17);
            flowLayoutPanel2.Controls.Add(groupBox12);
            flowLayoutPanel2.Controls.Add(groupBox13);
            flowLayoutPanel2.Controls.Add(groupBox33);
            flowLayoutPanel2.Controls.Add(groupBox32);
            flowLayoutPanel2.Controls.Add(groupBox14);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(685, 380);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.WrapContents = false;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(ShowCollidedPoints);
            groupBox10.ForeColor = System.Drawing.SystemColors.Info;
            groupBox10.Location = new System.Drawing.Point(3, 3);
            groupBox10.Name = "groupBox10";
            groupBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox10.Size = new System.Drawing.Size(651, 40);
            groupBox10.TabIndex = 0;
            groupBox10.TabStop = false;
            groupBox10.Text = "Collided Points";
            // 
            // ShowCollidedPoints
            // 
            ShowCollidedPoints.AutoSize = true;
            ShowCollidedPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            ShowCollidedPoints.Location = new System.Drawing.Point(3, 19);
            ShowCollidedPoints.Name = "ShowCollidedPoints";
            ShowCollidedPoints.Size = new System.Drawing.Size(645, 18);
            ShowCollidedPoints.TabIndex = 0;
            ShowCollidedPoints.Text = "Show";
            ShowCollidedPoints.UseVisualStyleBackColor = true;
            ShowCollidedPoints.CheckedChanged += ShowCollidedPoints_CheckedChanged;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(ShowUncollidedPoints);
            groupBox11.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox11.ForeColor = System.Drawing.SystemColors.Info;
            groupBox11.Location = new System.Drawing.Point(3, 49);
            groupBox11.Name = "groupBox11";
            groupBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox11.Size = new System.Drawing.Size(651, 40);
            groupBox11.TabIndex = 1;
            groupBox11.TabStop = false;
            groupBox11.Text = "Uncollided Points";
            // 
            // ShowUncollidedPoints
            // 
            ShowUncollidedPoints.AutoSize = true;
            ShowUncollidedPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            ShowUncollidedPoints.Location = new System.Drawing.Point(3, 19);
            ShowUncollidedPoints.Name = "ShowUncollidedPoints";
            ShowUncollidedPoints.Size = new System.Drawing.Size(645, 18);
            ShowUncollidedPoints.TabIndex = 0;
            ShowUncollidedPoints.Text = "Show";
            ShowUncollidedPoints.UseVisualStyleBackColor = true;
            ShowUncollidedPoints.CheckedChanged += ShowUncollidedPoints_CheckedChanged;
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(ShowCurrentTarget);
            groupBox18.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox18.ForeColor = System.Drawing.SystemColors.Info;
            groupBox18.Location = new System.Drawing.Point(3, 95);
            groupBox18.Name = "groupBox18";
            groupBox18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox18.Size = new System.Drawing.Size(651, 40);
            groupBox18.TabIndex = 3;
            groupBox18.TabStop = false;
            groupBox18.Text = "Current Target";
            // 
            // ShowCurrentTarget
            // 
            ShowCurrentTarget.AutoSize = true;
            ShowCurrentTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            ShowCurrentTarget.Location = new System.Drawing.Point(3, 19);
            ShowCurrentTarget.Name = "ShowCurrentTarget";
            ShowCurrentTarget.Size = new System.Drawing.Size(645, 18);
            ShowCurrentTarget.TabIndex = 0;
            ShowCurrentTarget.Text = "Show";
            ShowCurrentTarget.UseVisualStyleBackColor = true;
            ShowCurrentTarget.CheckedChanged += ShowCurrentTarget_CheckedChanged;
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(ShowRoamTargets);
            groupBox16.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox16.ForeColor = System.Drawing.SystemColors.Info;
            groupBox16.Location = new System.Drawing.Point(3, 141);
            groupBox16.Name = "groupBox16";
            groupBox16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox16.Size = new System.Drawing.Size(651, 40);
            groupBox16.TabIndex = 1;
            groupBox16.TabStop = false;
            groupBox16.Text = "Roam Targets";
            // 
            // ShowRoamTargets
            // 
            ShowRoamTargets.AutoSize = true;
            ShowRoamTargets.Dock = System.Windows.Forms.DockStyle.Fill;
            ShowRoamTargets.Location = new System.Drawing.Point(3, 19);
            ShowRoamTargets.Name = "ShowRoamTargets";
            ShowRoamTargets.Size = new System.Drawing.Size(645, 18);
            ShowRoamTargets.TabIndex = 0;
            ShowRoamTargets.Text = "Show";
            ShowRoamTargets.UseVisualStyleBackColor = true;
            ShowRoamTargets.CheckedChanged += ShowRoamTargets_CheckedChanged;
            // 
            // groupBox25
            // 
            groupBox25.Controls.Add(ShowUserTarget);
            groupBox25.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox25.ForeColor = System.Drawing.SystemColors.Info;
            groupBox25.Location = new System.Drawing.Point(3, 187);
            groupBox25.Name = "groupBox25";
            groupBox25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox25.Size = new System.Drawing.Size(651, 40);
            groupBox25.TabIndex = 4;
            groupBox25.TabStop = false;
            groupBox25.Text = "User Target";
            // 
            // ShowUserTarget
            // 
            ShowUserTarget.AutoSize = true;
            ShowUserTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            ShowUserTarget.Location = new System.Drawing.Point(3, 19);
            ShowUserTarget.Name = "ShowUserTarget";
            ShowUserTarget.Size = new System.Drawing.Size(645, 18);
            ShowUserTarget.TabIndex = 0;
            ShowUserTarget.Text = "Show";
            ShowUserTarget.UseVisualStyleBackColor = true;
            ShowUserTarget.CheckedChanged += ShowUserTarget_CheckedChanged;
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(ShowPath);
            groupBox17.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox17.ForeColor = System.Drawing.SystemColors.Info;
            groupBox17.Location = new System.Drawing.Point(3, 233);
            groupBox17.Name = "groupBox17";
            groupBox17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox17.Size = new System.Drawing.Size(651, 40);
            groupBox17.TabIndex = 2;
            groupBox17.TabStop = false;
            groupBox17.Text = "Target Path";
            // 
            // ShowPath
            // 
            ShowPath.AutoSize = true;
            ShowPath.Dock = System.Windows.Forms.DockStyle.Fill;
            ShowPath.Location = new System.Drawing.Point(3, 19);
            ShowPath.Name = "ShowPath";
            ShowPath.Size = new System.Drawing.Size(645, 18);
            ShowPath.TabIndex = 0;
            ShowPath.Text = "Show";
            ShowPath.UseVisualStyleBackColor = true;
            ShowPath.CheckedChanged += ShowPath_CheckedChanged;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(tableLayoutPanel9);
            groupBox12.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox12.ForeColor = System.Drawing.SystemColors.Info;
            groupBox12.Location = new System.Drawing.Point(3, 279);
            groupBox12.Name = "groupBox12";
            groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox12.Size = new System.Drawing.Size(651, 66);
            groupBox12.TabIndex = 1;
            groupBox12.TabStop = false;
            groupBox12.Text = "Map Object Radius";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(ObjectRadius, 0, 0);
            tableLayoutPanel9.Controls.Add(ObjectRadiusSlider, 0, 1);
            tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel9.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // ObjectRadius
            // 
            ObjectRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            ObjectRadius.Location = new System.Drawing.Point(3, 3);
            ObjectRadius.Name = "ObjectRadius";
            ObjectRadius.Size = new System.Drawing.Size(639, 23);
            ObjectRadius.TabIndex = 0;
            ObjectRadius.TextChanged += ObjectRadius_TextChanged;
            // 
            // ObjectRadiusSlider
            // 
            ObjectRadiusSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            ObjectRadiusSlider.Location = new System.Drawing.Point(3, 25);
            ObjectRadiusSlider.Maximum = 20;
            ObjectRadiusSlider.Name = "ObjectRadiusSlider";
            ObjectRadiusSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ObjectRadiusSlider.Size = new System.Drawing.Size(639, 16);
            ObjectRadiusSlider.TabIndex = 1;
            ObjectRadiusSlider.TickFrequency = 0;
            ObjectRadiusSlider.Value = 3;
            ObjectRadiusSlider.Scroll += ObjectRadiusSlider_Scroll;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(tableLayoutPanel10);
            groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox13.ForeColor = System.Drawing.SystemColors.Info;
            groupBox13.Location = new System.Drawing.Point(3, 351);
            groupBox13.Name = "groupBox13";
            groupBox13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox13.Size = new System.Drawing.Size(651, 66);
            groupBox13.TabIndex = 2;
            groupBox13.TabStop = false;
            groupBox13.Text = "Map Chunk Radius";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(ChunkRadius, 0, 0);
            tableLayoutPanel10.Controls.Add(ChunkRadiusSlider, 0, 1);
            tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel10.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // ChunkRadius
            // 
            ChunkRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            ChunkRadius.Location = new System.Drawing.Point(3, 3);
            ChunkRadius.Name = "ChunkRadius";
            ChunkRadius.Size = new System.Drawing.Size(639, 23);
            ChunkRadius.TabIndex = 0;
            ChunkRadius.TextChanged += ChunkRadius_TextChanged;
            // 
            // ChunkRadiusSlider
            // 
            ChunkRadiusSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            ChunkRadiusSlider.Location = new System.Drawing.Point(3, 25);
            ChunkRadiusSlider.Maximum = 20;
            ChunkRadiusSlider.Name = "ChunkRadiusSlider";
            ChunkRadiusSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ChunkRadiusSlider.Size = new System.Drawing.Size(639, 16);
            ChunkRadiusSlider.TabIndex = 1;
            ChunkRadiusSlider.TickFrequency = 0;
            ChunkRadiusSlider.Value = 3;
            ChunkRadiusSlider.Scroll += ChunkRadiusSlider_Scroll;
            // 
            // groupBox33
            // 
            groupBox33.Controls.Add(ShowNonHitRays);
            groupBox33.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox33.ForeColor = System.Drawing.SystemColors.Info;
            groupBox33.Location = new System.Drawing.Point(3, 423);
            groupBox33.Name = "groupBox33";
            groupBox33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox33.Size = new System.Drawing.Size(651, 40);
            groupBox33.TabIndex = 3;
            groupBox33.TabStop = false;
            groupBox33.Text = "Non-Hit Rays";
            // 
            // ShowNonHitRays
            // 
            ShowNonHitRays.AutoSize = true;
            ShowNonHitRays.Dock = System.Windows.Forms.DockStyle.Fill;
            ShowNonHitRays.Location = new System.Drawing.Point(3, 19);
            ShowNonHitRays.Name = "ShowNonHitRays";
            ShowNonHitRays.Size = new System.Drawing.Size(645, 18);
            ShowNonHitRays.TabIndex = 0;
            ShowNonHitRays.Text = "Show";
            ShowNonHitRays.UseVisualStyleBackColor = true;
            ShowNonHitRays.CheckedChanged += ShowNonHitRays_CheckedChanged;
            // 
            // groupBox32
            // 
            groupBox32.Controls.Add(ShowHitRays);
            groupBox32.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox32.ForeColor = System.Drawing.SystemColors.Info;
            groupBox32.Location = new System.Drawing.Point(3, 469);
            groupBox32.Name = "groupBox32";
            groupBox32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox32.Size = new System.Drawing.Size(651, 40);
            groupBox32.TabIndex = 2;
            groupBox32.TabStop = false;
            groupBox32.Text = "Hit Rays";
            // 
            // ShowHitRays
            // 
            ShowHitRays.AutoSize = true;
            ShowHitRays.Dock = System.Windows.Forms.DockStyle.Fill;
            ShowHitRays.Location = new System.Drawing.Point(3, 19);
            ShowHitRays.Name = "ShowHitRays";
            ShowHitRays.Size = new System.Drawing.Size(645, 18);
            ShowHitRays.TabIndex = 0;
            ShowHitRays.Text = "Show";
            ShowHitRays.UseVisualStyleBackColor = true;
            ShowHitRays.CheckedChanged += ShowHitRays_CheckedChanged;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(ShowWallData);
            groupBox14.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox14.ForeColor = System.Drawing.SystemColors.Info;
            groupBox14.Location = new System.Drawing.Point(3, 515);
            groupBox14.Name = "groupBox14";
            groupBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox14.Size = new System.Drawing.Size(651, 40);
            groupBox14.TabIndex = 1;
            groupBox14.TabStop = false;
            groupBox14.Text = "Wall Data";
            // 
            // ShowWallData
            // 
            ShowWallData.AutoSize = true;
            ShowWallData.Dock = System.Windows.Forms.DockStyle.Fill;
            ShowWallData.Location = new System.Drawing.Point(3, 19);
            ShowWallData.Name = "ShowWallData";
            ShowWallData.Size = new System.Drawing.Size(645, 18);
            ShowWallData.TabIndex = 0;
            ShowWallData.Text = "Show";
            ShowWallData.UseVisualStyleBackColor = true;
            ShowWallData.CheckedChanged += ShowWallData_CheckedChanged;
            // 
            // Internal
            // 
            Internal.BackColor = System.Drawing.Color.Black;
            Internal.Controls.Add(groupBox3);
            Internal.Location = new System.Drawing.Point(4, 5);
            Internal.Name = "Internal";
            Internal.Padding = new System.Windows.Forms.Padding(3);
            Internal.Size = new System.Drawing.Size(697, 408);
            Internal.TabIndex = 2;
            Internal.Text = "3";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel3);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(691, 402);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Internal Settings";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.Controls.Add(groupBox21);
            flowLayoutPanel3.Controls.Add(groupBox22);
            flowLayoutPanel3.Controls.Add(groupBox26);
            flowLayoutPanel3.Controls.Add(groupBox19);
            flowLayoutPanel3.Controls.Add(groupBox20);
            flowLayoutPanel3.Controls.Add(groupBox23);
            flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(685, 380);
            flowLayoutPanel3.TabIndex = 2;
            flowLayoutPanel3.WrapContents = false;
            // 
            // groupBox21
            // 
            groupBox21.Controls.Add(tableLayoutPanel12);
            groupBox21.ForeColor = System.Drawing.SystemColors.Info;
            groupBox21.Location = new System.Drawing.Point(3, 3);
            groupBox21.Name = "groupBox21";
            groupBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox21.Size = new System.Drawing.Size(651, 66);
            groupBox21.TabIndex = 1;
            groupBox21.TabStop = false;
            groupBox21.Text = "Mino Radius";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(MinoRadius, 0, 0);
            tableLayoutPanel12.Controls.Add(MinoRadiusSlider, 0, 1);
            tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel12.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // MinoRadius
            // 
            MinoRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            MinoRadius.Location = new System.Drawing.Point(3, 3);
            MinoRadius.Name = "MinoRadius";
            MinoRadius.Size = new System.Drawing.Size(639, 23);
            MinoRadius.TabIndex = 0;
            MinoRadius.TextChanged += MinoRadius_TextChanged;
            // 
            // MinoRadiusSlider
            // 
            MinoRadiusSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            MinoRadiusSlider.Location = new System.Drawing.Point(3, 25);
            MinoRadiusSlider.Maximum = 100;
            MinoRadiusSlider.Name = "MinoRadiusSlider";
            MinoRadiusSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MinoRadiusSlider.Size = new System.Drawing.Size(639, 16);
            MinoRadiusSlider.TabIndex = 1;
            MinoRadiusSlider.TickFrequency = 0;
            MinoRadiusSlider.Value = 3;
            MinoRadiusSlider.Scroll += MinoRadiusSlider_Scroll;
            // 
            // groupBox22
            // 
            groupBox22.Controls.Add(tableLayoutPanel13);
            groupBox22.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox22.ForeColor = System.Drawing.SystemColors.Info;
            groupBox22.Location = new System.Drawing.Point(3, 75);
            groupBox22.Name = "groupBox22";
            groupBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox22.Size = new System.Drawing.Size(651, 66);
            groupBox22.TabIndex = 2;
            groupBox22.TabStop = false;
            groupBox22.Text = "Object Expansion Bias";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(ExpansionBias, 0, 0);
            tableLayoutPanel13.Controls.Add(ExpansionBiasSlider, 0, 1);
            tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel13.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel13.TabIndex = 0;
            // 
            // ExpansionBias
            // 
            ExpansionBias.Dock = System.Windows.Forms.DockStyle.Fill;
            ExpansionBias.Location = new System.Drawing.Point(3, 3);
            ExpansionBias.Name = "ExpansionBias";
            ExpansionBias.Size = new System.Drawing.Size(639, 23);
            ExpansionBias.TabIndex = 0;
            ExpansionBias.TextChanged += ExapansionBias_TextChanged;
            // 
            // ExpansionBiasSlider
            // 
            ExpansionBiasSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            ExpansionBiasSlider.Location = new System.Drawing.Point(3, 25);
            ExpansionBiasSlider.Maximum = 100;
            ExpansionBiasSlider.Name = "ExpansionBiasSlider";
            ExpansionBiasSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ExpansionBiasSlider.Size = new System.Drawing.Size(639, 16);
            ExpansionBiasSlider.TabIndex = 1;
            ExpansionBiasSlider.TickFrequency = 0;
            ExpansionBiasSlider.Value = 3;
            ExpansionBiasSlider.Scroll += ExpansionBiasSlider_Scroll;
            // 
            // groupBox26
            // 
            groupBox26.Controls.Add(tableLayoutPanel17);
            groupBox26.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox26.ForeColor = System.Drawing.SystemColors.Info;
            groupBox26.Location = new System.Drawing.Point(3, 147);
            groupBox26.Name = "groupBox26";
            groupBox26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox26.Size = new System.Drawing.Size(651, 66);
            groupBox26.TabIndex = 2;
            groupBox26.TabStop = false;
            groupBox26.Text = "Grid Radius";
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 1;
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel17.Controls.Add(GridRadius, 0, 0);
            tableLayoutPanel17.Controls.Add(GridRadiusSlider, 0, 1);
            tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel17.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 2;
            tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel17.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel17.TabIndex = 0;
            // 
            // GridRadius
            // 
            GridRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            GridRadius.Location = new System.Drawing.Point(3, 3);
            GridRadius.Name = "GridRadius";
            GridRadius.Size = new System.Drawing.Size(639, 23);
            GridRadius.TabIndex = 0;
            GridRadius.TextChanged += GridRadius_TextChanged;
            // 
            // GridRadiusSlider
            // 
            GridRadiusSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            GridRadiusSlider.Location = new System.Drawing.Point(3, 25);
            GridRadiusSlider.Maximum = 50;
            GridRadiusSlider.Name = "GridRadiusSlider";
            GridRadiusSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            GridRadiusSlider.Size = new System.Drawing.Size(639, 16);
            GridRadiusSlider.TabIndex = 1;
            GridRadiusSlider.TickFrequency = 0;
            GridRadiusSlider.Value = 3;
            GridRadiusSlider.Scroll += GridRadiusSlider_Scroll;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(tableLayoutPanel14);
            groupBox19.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox19.ForeColor = System.Drawing.SystemColors.Info;
            groupBox19.Location = new System.Drawing.Point(3, 219);
            groupBox19.Name = "groupBox19";
            groupBox19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox19.Size = new System.Drawing.Size(651, 66);
            groupBox19.TabIndex = 2;
            groupBox19.TabStop = false;
            groupBox19.Text = "Mino Ray Count";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(MinoRayRes, 0, 0);
            tableLayoutPanel14.Controls.Add(MinoRayResSlider, 0, 1);
            tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel14.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel14.TabIndex = 0;
            // 
            // MinoRayRes
            // 
            MinoRayRes.Dock = System.Windows.Forms.DockStyle.Fill;
            MinoRayRes.Location = new System.Drawing.Point(3, 3);
            MinoRayRes.Name = "MinoRayRes";
            MinoRayRes.Size = new System.Drawing.Size(639, 23);
            MinoRayRes.TabIndex = 0;
            MinoRayRes.TextChanged += MinoRayRes_TextChanged;
            // 
            // MinoRayResSlider
            // 
            MinoRayResSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            MinoRayResSlider.Location = new System.Drawing.Point(3, 25);
            MinoRayResSlider.Maximum = 720;
            MinoRayResSlider.Name = "MinoRayResSlider";
            MinoRayResSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MinoRayResSlider.Size = new System.Drawing.Size(639, 16);
            MinoRayResSlider.TabIndex = 1;
            MinoRayResSlider.TickFrequency = 0;
            MinoRayResSlider.Value = 3;
            MinoRayResSlider.Scroll += MinoRayResSlider_Scroll;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(tableLayoutPanel15);
            groupBox20.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox20.ForeColor = System.Drawing.SystemColors.Info;
            groupBox20.Location = new System.Drawing.Point(3, 291);
            groupBox20.Name = "groupBox20";
            groupBox20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox20.Size = new System.Drawing.Size(651, 66);
            groupBox20.TabIndex = 2;
            groupBox20.TabStop = false;
            groupBox20.Text = "Mino Speed";
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel15.Controls.Add(MinoSpeed, 0, 0);
            tableLayoutPanel15.Controls.Add(MinoSpeedSlider, 0, 1);
            tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel15.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 2;
            tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel15.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel15.TabIndex = 0;
            // 
            // MinoSpeed
            // 
            MinoSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            MinoSpeed.Location = new System.Drawing.Point(3, 3);
            MinoSpeed.Name = "MinoSpeed";
            MinoSpeed.Size = new System.Drawing.Size(639, 23);
            MinoSpeed.TabIndex = 0;
            MinoSpeed.TextChanged += MinoSpeed_TextChanged;
            // 
            // MinoSpeedSlider
            // 
            MinoSpeedSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            MinoSpeedSlider.Location = new System.Drawing.Point(3, 25);
            MinoSpeedSlider.Name = "MinoSpeedSlider";
            MinoSpeedSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MinoSpeedSlider.Size = new System.Drawing.Size(639, 16);
            MinoSpeedSlider.TabIndex = 1;
            MinoSpeedSlider.TickFrequency = 0;
            MinoSpeedSlider.Value = 3;
            MinoSpeedSlider.Scroll += MinoSpeedSlider_Scroll;
            // 
            // groupBox23
            // 
            groupBox23.Controls.Add(tableLayoutPanel16);
            groupBox23.ForeColor = System.Drawing.SystemColors.Info;
            groupBox23.Location = new System.Drawing.Point(3, 363);
            groupBox23.Name = "groupBox23";
            groupBox23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox23.Size = new System.Drawing.Size(651, 66);
            groupBox23.TabIndex = 2;
            groupBox23.TabStop = false;
            groupBox23.Text = "Mino View Distance";
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 1;
            tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel16.Controls.Add(MinoViewDistance, 0, 0);
            tableLayoutPanel16.Controls.Add(MinoViewDistanceSlider, 0, 1);
            tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel16.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel16.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // MinoViewDistance
            // 
            MinoViewDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            MinoViewDistance.Location = new System.Drawing.Point(3, 3);
            MinoViewDistance.Name = "MinoViewDistance";
            MinoViewDistance.Size = new System.Drawing.Size(639, 23);
            MinoViewDistance.TabIndex = 0;
            MinoViewDistance.TextChanged += MinoViewDistance_TextChanged;
            // 
            // MinoViewDistanceSlider
            // 
            MinoViewDistanceSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            MinoViewDistanceSlider.Location = new System.Drawing.Point(3, 25);
            MinoViewDistanceSlider.Maximum = 200;
            MinoViewDistanceSlider.Name = "MinoViewDistanceSlider";
            MinoViewDistanceSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MinoViewDistanceSlider.Size = new System.Drawing.Size(639, 16);
            MinoViewDistanceSlider.TabIndex = 1;
            MinoViewDistanceSlider.TickFrequency = 0;
            MinoViewDistanceSlider.Value = 3;
            MinoViewDistanceSlider.Scroll += MinoViewDistanceSlider_Scroll;
            // 
            // Environment
            // 
            Environment.BackColor = System.Drawing.Color.Black;
            Environment.Controls.Add(groupBox27);
            Environment.Location = new System.Drawing.Point(4, 5);
            Environment.Name = "Environment";
            Environment.Padding = new System.Windows.Forms.Padding(3);
            Environment.Size = new System.Drawing.Size(697, 408);
            Environment.TabIndex = 3;
            Environment.Text = "Environment";
            // 
            // groupBox27
            // 
            groupBox27.Controls.Add(flowLayoutPanel4);
            groupBox27.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox27.ForeColor = System.Drawing.SystemColors.Info;
            groupBox27.Location = new System.Drawing.Point(3, 3);
            groupBox27.Name = "groupBox27";
            groupBox27.Size = new System.Drawing.Size(691, 402);
            groupBox27.TabIndex = 1;
            groupBox27.TabStop = false;
            groupBox27.Text = "Internal Settings";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoScroll = true;
            flowLayoutPanel4.Controls.Add(groupBox28);
            flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new System.Drawing.Size(685, 380);
            flowLayoutPanel4.TabIndex = 2;
            flowLayoutPanel4.WrapContents = false;
            // 
            // groupBox28
            // 
            groupBox28.Controls.Add(tableLayoutPanel18);
            groupBox28.ForeColor = System.Drawing.SystemColors.Info;
            groupBox28.Location = new System.Drawing.Point(3, 3);
            groupBox28.Name = "groupBox28";
            groupBox28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            groupBox28.Size = new System.Drawing.Size(651, 66);
            groupBox28.TabIndex = 1;
            groupBox28.TabStop = false;
            groupBox28.Text = "Wall Width";
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 1;
            tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel18.Controls.Add(WallWidth, 0, 0);
            tableLayoutPanel18.Controls.Add(WallWidthSlider, 0, 1);
            tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel18.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 2;
            tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel18.Size = new System.Drawing.Size(645, 44);
            tableLayoutPanel18.TabIndex = 0;
            // 
            // WallWidth
            // 
            WallWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            WallWidth.Location = new System.Drawing.Point(3, 3);
            WallWidth.Name = "WallWidth";
            WallWidth.Size = new System.Drawing.Size(639, 23);
            WallWidth.TabIndex = 0;
            WallWidth.TextChanged += WallWidth_TextChanged;
            // 
            // WallWidthSlider
            // 
            WallWidthSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            WallWidthSlider.Location = new System.Drawing.Point(3, 25);
            WallWidthSlider.Maximum = 50;
            WallWidthSlider.Minimum = 1;
            WallWidthSlider.Name = "WallWidthSlider";
            WallWidthSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            WallWidthSlider.Size = new System.Drawing.Size(639, 16);
            WallWidthSlider.TabIndex = 1;
            WallWidthSlider.TickFrequency = 0;
            WallWidthSlider.Value = 3;
            WallWidthSlider.Scroll += WallWidthSlider_Scroll;
            // 
            // ApplyColor
            // 
            ApplyColor.BackColor = System.Drawing.Color.Black;
            ApplyColor.Controls.Add(groupBox29);
            ApplyColor.Location = new System.Drawing.Point(4, 5);
            ApplyColor.Name = "ApplyColor";
            ApplyColor.Padding = new System.Windows.Forms.Padding(3);
            ApplyColor.Size = new System.Drawing.Size(697, 408);
            ApplyColor.TabIndex = 4;
            ApplyColor.Text = "Apply Color";
            // 
            // groupBox29
            // 
            groupBox29.Controls.Add(flowLayoutPanel5);
            groupBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox29.ForeColor = System.Drawing.SystemColors.Info;
            groupBox29.Location = new System.Drawing.Point(3, 3);
            groupBox29.Name = "groupBox29";
            groupBox29.Size = new System.Drawing.Size(691, 402);
            groupBox29.TabIndex = 0;
            groupBox29.TabStop = false;
            groupBox29.Text = "Apply Color Group?";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(Apply);
            flowLayoutPanel5.Controls.Add(Cancel);
            flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new System.Drawing.Size(685, 380);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // Apply
            // 
            Apply.BackColor = System.Drawing.Color.White;
            Apply.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Apply.ForeColor = System.Drawing.SystemColors.InfoText;
            Apply.Location = new System.Drawing.Point(3, 3);
            Apply.Name = "Apply";
            Apply.Size = new System.Drawing.Size(209, 63);
            Apply.TabIndex = 0;
            Apply.Text = "Yes";
            Apply.UseVisualStyleBackColor = false;
            Apply.Click += Apply_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = System.Drawing.Color.White;
            Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            Cancel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Cancel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            Cancel.Location = new System.Drawing.Point(3, 72);
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(209, 45);
            Cancel.TabIndex = 1;
            Cancel.Text = "No";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // Reset
            // 
            Reset.BackColor = System.Drawing.Color.Black;
            Reset.Controls.Add(groupBox34);
            Reset.Location = new System.Drawing.Point(4, 5);
            Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Reset.Name = "Reset";
            Reset.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Reset.Size = new System.Drawing.Size(697, 408);
            Reset.TabIndex = 5;
            Reset.Text = "Reset";
            // 
            // groupBox34
            // 
            groupBox34.Controls.Add(flowLayoutPanel6);
            groupBox34.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox34.ForeColor = System.Drawing.SystemColors.Info;
            groupBox34.Location = new System.Drawing.Point(3, 2);
            groupBox34.Name = "groupBox34";
            groupBox34.Size = new System.Drawing.Size(691, 404);
            groupBox34.TabIndex = 1;
            groupBox34.TabStop = false;
            groupBox34.Text = "Reset Settings?";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(ResetSet);
            flowLayoutPanel6.Controls.Add(CancelSet);
            flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel6.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new System.Drawing.Size(685, 382);
            flowLayoutPanel6.TabIndex = 0;
            // 
            // ResetSet
            // 
            ResetSet.BackColor = System.Drawing.Color.White;
            ResetSet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ResetSet.ForeColor = System.Drawing.SystemColors.InfoText;
            ResetSet.Location = new System.Drawing.Point(3, 3);
            ResetSet.Name = "ResetSet";
            ResetSet.Size = new System.Drawing.Size(209, 63);
            ResetSet.TabIndex = 0;
            ResetSet.Text = "Yes";
            ResetSet.UseVisualStyleBackColor = false;
            ResetSet.Click += Reset_Click;
            // 
            // CancelSet
            // 
            CancelSet.BackColor = System.Drawing.Color.White;
            CancelSet.Dock = System.Windows.Forms.DockStyle.Fill;
            CancelSet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CancelSet.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            CancelSet.Location = new System.Drawing.Point(3, 72);
            CancelSet.Name = "CancelSet";
            CancelSet.Size = new System.Drawing.Size(209, 45);
            CancelSet.TabIndex = 1;
            CancelSet.Text = "No";
            CancelSet.UseVisualStyleBackColor = false;
            CancelSet.Click += CancelSet_Click;
            // 
            // groupBox24
            // 
            groupBox24.Controls.Add(treeSettings);
            groupBox24.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox24.Location = new System.Drawing.Point(3, 3);
            groupBox24.Name = "groupBox24";
            groupBox24.Size = new System.Drawing.Size(171, 417);
            groupBox24.TabIndex = 2;
            groupBox24.TabStop = false;
            // 
            // treeSettings
            // 
            treeSettings.BackColor = System.Drawing.SystemColors.MenuText;
            treeSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            treeSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            treeSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            treeSettings.ForeColor = System.Drawing.SystemColors.Info;
            treeSettings.LineColor = System.Drawing.Color.White;
            treeSettings.Location = new System.Drawing.Point(3, 19);
            treeSettings.Name = "treeSettings";
            treeNode1.Name = "Protanopia";
            treeNode1.Text = "Protanopia";
            treeNode2.Name = "Red-Green Blindness";
            treeNode2.Text = "Red-Green Blindness";
            treeNode3.Name = "Tritanopia";
            treeNode3.Text = "Tritanopia";
            treeNode4.Name = "Blue-Yellow Blindness";
            treeNode4.Text = "Blue-Yellow Blindness";
            treeNode5.Name = "Achromatopsia";
            treeNode5.Text = "Achromatopsia";
            treeNode6.Name = "Visual";
            treeNode6.Text = "Visual";
            treeNode7.Name = "Display";
            treeNode7.Text = "Display";
            treeNode8.Name = "Internal";
            treeNode8.Text = "Internal";
            treeNode9.Name = "Environment";
            treeNode9.Text = "Environment";
            treeNode10.Name = "Reset";
            treeNode10.Text = "Reset";
            treeNode11.Name = "Main";
            treeNode11.Text = "Settings";
            treeSettings.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode11 });
            treeSettings.Size = new System.Drawing.Size(165, 395);
            treeSettings.TabIndex = 0;
            treeSettings.AfterSelect += treeSettings_AfterSelect;
            // 
            // HelpTab
            // 
            HelpTab.BackColor = System.Drawing.Color.Black;
            HelpTab.Controls.Add(tableLayoutPanel21);
            HelpTab.Location = new System.Drawing.Point(4, 24);
            HelpTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            HelpTab.Name = "HelpTab";
            HelpTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            HelpTab.Size = new System.Drawing.Size(894, 429);
            HelpTab.TabIndex = 2;
            HelpTab.Text = "Help";
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.ColumnCount = 2;
            tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel21.Controls.Add(groupBox65, 0, 0);
            tableLayoutPanel21.Controls.Add(richTextHelp, 1, 0);
            tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel21.Location = new System.Drawing.Point(3, 2);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.RowCount = 1;
            tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel21.Size = new System.Drawing.Size(888, 425);
            tableLayoutPanel21.TabIndex = 1;
            // 
            // groupBox65
            // 
            groupBox65.Controls.Add(treeHelp);
            groupBox65.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox65.Location = new System.Drawing.Point(3, 3);
            groupBox65.Name = "groupBox65";
            groupBox65.Size = new System.Drawing.Size(171, 419);
            groupBox65.TabIndex = 2;
            groupBox65.TabStop = false;
            // 
            // treeHelp
            // 
            treeHelp.BackColor = System.Drawing.SystemColors.MenuText;
            treeHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            treeHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            treeHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            treeHelp.ForeColor = System.Drawing.SystemColors.Info;
            treeHelp.LineColor = System.Drawing.Color.White;
            treeHelp.Location = new System.Drawing.Point(3, 19);
            treeHelp.Name = "treeHelp";
            treeNode12.Name = "Manual";
            treeNode12.Text = "Manual";
            treeHelp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode12 });
            treeHelp.Size = new System.Drawing.Size(165, 397);
            treeHelp.TabIndex = 0;
            // 
            // richTextHelp
            // 
            richTextHelp.BackColor = System.Drawing.SystemColors.WindowText;
            richTextHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            richTextHelp.Cursor = System.Windows.Forms.Cursors.IBeam;
            richTextHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextHelp.ForeColor = System.Drawing.SystemColors.Menu;
            richTextHelp.Location = new System.Drawing.Point(180, 2);
            richTextHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            richTextHelp.Name = "richTextHelp";
            richTextHelp.ReadOnly = true;
            richTextHelp.Size = new System.Drawing.Size(705, 421);
            richTextHelp.TabIndex = 3;
            richTextHelp.Text = "";
            // 
            // colorDialog
            // 
            colorDialog.AllowFullOpen = false;
            colorDialog.AnyColor = true;
            colorDialog.Color = System.Drawing.Color.Red;
            colorDialog.SolidColorOnly = true;
            // 
            // groupBox6
            // 
            groupBox6.Location = new System.Drawing.Point(0, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(200, 100);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel1, 0, 0);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(94, 94);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.Dock = System.Windows.Forms.DockStyle.Fill;
            button1.ForeColor = System.Drawing.SystemColors.InfoText;
            button1.Location = new System.Drawing.Point(103, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 94);
            button1.TabIndex = 1;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = false;
            // 
            // Knossos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.WindowText;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(902, 457);
            Controls.Add(tabMenu);
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
            tabMenu.ResumeLayout(false);
            MenuTab.ResumeLayout(false);
            SettingsTab.ResumeLayout(false);
            tableSettings.ResumeLayout(false);
            SettingControl.ResumeLayout(false);
            Visual.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox30.ResumeLayout(false);
            tableLayoutPanel19.ResumeLayout(false);
            groupBox31.ResumeLayout(false);
            tableLayoutPanel20.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            groupBox15.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            Display.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox18.ResumeLayout(false);
            groupBox18.PerformLayout();
            groupBox16.ResumeLayout(false);
            groupBox16.PerformLayout();
            groupBox25.ResumeLayout(false);
            groupBox25.PerformLayout();
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            groupBox12.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ObjectRadiusSlider).EndInit();
            groupBox13.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChunkRadiusSlider).EndInit();
            groupBox33.ResumeLayout(false);
            groupBox33.PerformLayout();
            groupBox32.ResumeLayout(false);
            groupBox32.PerformLayout();
            groupBox14.ResumeLayout(false);
            groupBox14.PerformLayout();
            Internal.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            groupBox21.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinoRadiusSlider).EndInit();
            groupBox22.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExpansionBiasSlider).EndInit();
            groupBox26.ResumeLayout(false);
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridRadiusSlider).EndInit();
            groupBox19.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinoRayResSlider).EndInit();
            groupBox20.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinoSpeedSlider).EndInit();
            groupBox23.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinoViewDistanceSlider).EndInit();
            Environment.ResumeLayout(false);
            groupBox27.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            groupBox28.ResumeLayout(false);
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WallWidthSlider).EndInit();
            ApplyColor.ResumeLayout(false);
            groupBox29.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            Reset.ResumeLayout(false);
            groupBox34.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            groupBox24.ResumeLayout(false);
            HelpTab.ResumeLayout(false);
            tableLayoutPanel21.ResumeLayout(false);
            groupBox65.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage MenuTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TableLayoutPanel tableSettings;
        private System.Windows.Forms.TreeView treeSettings;
        private System.Windows.Forms.TabControl SettingControl;
        private System.Windows.Forms.TabPage Visual;
        private System.Windows.Forms.TabPage Display;
        private System.Windows.Forms.TabPage Internal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel LabColor;
        private System.Windows.Forms.Button ChangeMapColor;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel LabHighlightColor;
        private System.Windows.Forms.Button ChangeHighlightColor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel MinoColor;
        private System.Windows.Forms.Button ChangeMinoColor;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel MapObjectsColor;
        private System.Windows.Forms.Button ChangeMapObjectsColor;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel MapChunkColor;
        private System.Windows.Forms.Button ChangeMapChunckColor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox ShowCollidedPoints;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox ShowUncollidedPoints;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Panel MapWallColor;
        private System.Windows.Forms.Button ChangeMapWallColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox ObjectRadius;
        private System.Windows.Forms.TrackBar ObjectRadiusSlider;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox ChunkRadius;
        private System.Windows.Forms.TrackBar ChunkRadiusSlider;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox ShowWallData;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox ShowRoamTargets;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.CheckBox ShowCurrentTarget;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.CheckBox ShowPath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TextBox MinoRadius;
        private System.Windows.Forms.TrackBar MinoRadiusSlider;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TextBox ExpansionBias;
        private System.Windows.Forms.TrackBar ExpansionBiasSlider;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TextBox MinoRayRes;
        private System.Windows.Forms.TrackBar MinoRayResSlider;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TextBox MinoSpeed;
        private System.Windows.Forms.TrackBar MinoSpeedSlider;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TextBox MinoViewDistance;
        private System.Windows.Forms.TrackBar MinoViewDistanceSlider;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.CheckBox ShowUserTarget;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.TextBox GridRadius;
        private System.Windows.Forms.TrackBar GridRadiusSlider;
        private System.Windows.Forms.TabPage Environment;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.TextBox WallWidth;
        private System.Windows.Forms.TrackBar WallWidthSlider;
        private System.Windows.Forms.TabPage ApplyColor;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.Panel NonHitColor;
        private System.Windows.Forms.Button ChangeNonHitColor;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Panel RayLineColor;
        private System.Windows.Forms.Button ChangeRayColor;
        private System.Windows.Forms.TabPage HelpTab;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.CheckBox ShowNonHitRays;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.CheckBox ShowHitRays;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.GroupBox groupBox65;
        private System.Windows.Forms.TreeView treeHelp;
        private System.Windows.Forms.RichTextBox richTextHelp;
        private System.Windows.Forms.TabPage Reset;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button ResetSet;
        private System.Windows.Forms.Button CancelSet;
    }
}

