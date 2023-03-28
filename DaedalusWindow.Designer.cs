
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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Protanopia");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Red-Green Blindness", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Tritanopia");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Blue-Yellow Blindness", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Achromatopsia");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Visual", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Display");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Internal");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Environment");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Reset");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Settings", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Manual");
            this.VerticalLayout = new System.Windows.Forms.SplitContainer();
            this.ControlLayout = new System.Windows.Forms.SplitContainer();
            this.labyrinthBox = new System.Windows.Forms.GroupBox();
            this.labyrinthScene = new System.Windows.Forms.PictureBox();
            this.mapBox = new System.Windows.Forms.GroupBox();
            this.mapScene = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomBox = new System.Windows.Forms.GroupBox();
            this.zoomSlider = new System.Windows.Forms.TrackBar();
            this.labyrinthToolStrip = new System.Windows.Forms.ToolStrip();
            this.labyrinthTool = new System.Windows.Forms.ToolStripLabel();
            this.clearBtn = new System.Windows.Forms.ToolStripButton();
            this.loadBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.eraseBtn = new System.Windows.Forms.ToolStripButton();
            this.drawBtn = new System.Windows.Forms.ToolStripButton();
            this.setMinoPos = new System.Windows.Forms.ToolStripButton();
            this.mapToolStrip = new System.Windows.Forms.ToolStrip();
            this.targetBtn = new System.Windows.Forms.ToolStripButton();
            this.roamBtn = new System.Windows.Forms.ToolStripButton();
            this.ClearMemory = new System.Windows.Forms.ToolStripButton();
            this.mapMode = new System.Windows.Forms.ToolStripLabel();
            this.playBtn = new System.Windows.Forms.ToolStripButton();
            this.stopBtn = new System.Windows.Forms.ToolStripButton();
            this.MinotaurWorker = new System.ComponentModel.BackgroundWorker();
            this.LabyrinthUpdate = new System.ComponentModel.BackgroundWorker();
            this.openMapFile = new System.Windows.Forms.OpenFileDialog();
            this.saveMapFile = new System.Windows.Forms.SaveFileDialog();
            this.MenuSplit = new System.Windows.Forms.SplitContainer();
            this.ToolBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.MenuTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.tableSettings = new System.Windows.Forms.TableLayoutPanel();
            this.SettingControl = new System.Windows.Forms.TabControl();
            this.Visual = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LabColor = new System.Windows.Forms.Panel();
            this.ChangeMapColor = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.LabHighlightColor = new System.Windows.Forms.Panel();
            this.ChangeHighlightColor = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MinoColor = new System.Windows.Forms.Panel();
            this.ChangeMinoColor = new System.Windows.Forms.Button();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.NonHitColor = new System.Windows.Forms.Panel();
            this.ChangeNonHitColor = new System.Windows.Forms.Button();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.RayLineColor = new System.Windows.Forms.Panel();
            this.ChangeRayColor = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.MapObjectsColor = new System.Windows.Forms.Panel();
            this.ChangeMapObjectsColor = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.MapChunkColor = new System.Windows.Forms.Panel();
            this.ChangeMapChunckColor = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.MapWallColor = new System.Windows.Forms.Panel();
            this.ChangeMapWallColor = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ShowCollidedPoints = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.ShowUncollidedPoints = new System.Windows.Forms.CheckBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.ShowCurrentTarget = new System.Windows.Forms.CheckBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.ShowRoamTargets = new System.Windows.Forms.CheckBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.ShowUserTarget = new System.Windows.Forms.CheckBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.ShowPath = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.ObjectRadius = new System.Windows.Forms.TextBox();
            this.ObjectRadiusSlider = new System.Windows.Forms.TrackBar();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.ChunkRadius = new System.Windows.Forms.TextBox();
            this.ChunkRadiusSlider = new System.Windows.Forms.TrackBar();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.ShowNonHitRays = new System.Windows.Forms.CheckBox();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.ShowHitRays = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.ShowWallData = new System.Windows.Forms.CheckBox();
            this.Internal = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.MinoRadius = new System.Windows.Forms.TextBox();
            this.MinoRadiusSlider = new System.Windows.Forms.TrackBar();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.ExpansionBias = new System.Windows.Forms.TextBox();
            this.ExpansionBiasSlider = new System.Windows.Forms.TrackBar();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.GridRadius = new System.Windows.Forms.TextBox();
            this.GridRadiusSlider = new System.Windows.Forms.TrackBar();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.MinoRayRes = new System.Windows.Forms.TextBox();
            this.MinoRayResSlider = new System.Windows.Forms.TrackBar();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.MinoSpeed = new System.Windows.Forms.TextBox();
            this.MinoSpeedSlider = new System.Windows.Forms.TrackBar();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.MinoViewDistance = new System.Windows.Forms.TextBox();
            this.MinoViewDistanceSlider = new System.Windows.Forms.TrackBar();
            this.Environment = new System.Windows.Forms.TabPage();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.WallWidth = new System.Windows.Forms.TextBox();
            this.WallWidthSlider = new System.Windows.Forms.TrackBar();
            this.ApplyColor = new System.Windows.Forms.TabPage();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.Apply = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.treeSettings = new System.Windows.Forms.TreeView();
            this.HelpTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox65 = new System.Windows.Forms.GroupBox();
            this.treeHelp = new System.Windows.Forms.TreeView();
            this.richTextHelp = new System.Windows.Forms.RichTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.TabPage();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.ResetSet = new System.Windows.Forms.Button();
            this.CancelSet = new System.Windows.Forms.Button();
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
            this.mapBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapScene)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.zoomBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            this.labyrinthToolStrip.SuspendLayout();
            this.mapToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplit)).BeginInit();
            this.MenuSplit.Panel1.SuspendLayout();
            this.MenuSplit.Panel2.SuspendLayout();
            this.MenuSplit.SuspendLayout();
            this.ToolBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.MenuTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.tableSettings.SuspendLayout();
            this.SettingControl.SuspendLayout();
            this.Visual.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.Display.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectRadiusSlider)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChunkRadiusSlider)).BeginInit();
            this.groupBox33.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.Internal.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinoRadiusSlider)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpansionBiasSlider)).BeginInit();
            this.groupBox26.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRadiusSlider)).BeginInit();
            this.groupBox19.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinoRayResSlider)).BeginInit();
            this.groupBox20.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinoSpeedSlider)).BeginInit();
            this.groupBox23.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinoViewDistanceSlider)).BeginInit();
            this.Environment.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallWidthSlider)).BeginInit();
            this.ApplyColor.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.HelpTab.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.groupBox65.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.Reset.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerticalLayout
            // 
            this.VerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerticalLayout.Location = new System.Drawing.Point(0, 0);
            this.VerticalLayout.Name = "VerticalLayout";
            this.VerticalLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.VerticalLayout.Size = new System.Drawing.Size(1005, 493);
            this.VerticalLayout.SplitterDistance = 401;
            this.VerticalLayout.SplitterWidth = 11;
            this.VerticalLayout.TabIndex = 4;
            this.VerticalLayout.TabStop = false;
            // 
            // ControlLayout
            // 
            this.ControlLayout.BackColor = System.Drawing.SystemColors.MenuText;
            this.ControlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlLayout.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ControlLayout.Location = new System.Drawing.Point(0, 0);
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
            this.ControlLayout.Size = new System.Drawing.Size(1005, 401);
            this.ControlLayout.SplitterDistance = 497;
            this.ControlLayout.SplitterWidth = 10;
            this.ControlLayout.TabIndex = 3;
            this.ControlLayout.TabStop = false;
            // 
            // labyrinthBox
            // 
            this.labyrinthBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.labyrinthBox.Controls.Add(this.labyrinthScene);
            this.labyrinthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labyrinthBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labyrinthBox.Location = new System.Drawing.Point(0, 0);
            this.labyrinthBox.Name = "labyrinthBox";
            this.labyrinthBox.Size = new System.Drawing.Size(497, 401);
            this.labyrinthBox.TabIndex = 0;
            this.labyrinthBox.TabStop = false;
            this.labyrinthBox.Text = "Labyrinth";
            // 
            // labyrinthScene
            // 
            this.labyrinthScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labyrinthScene.Location = new System.Drawing.Point(3, 23);
            this.labyrinthScene.Name = "labyrinthScene";
            this.labyrinthScene.Size = new System.Drawing.Size(491, 375);
            this.labyrinthScene.TabIndex = 7;
            this.labyrinthScene.TabStop = false;
            this.labyrinthScene.Paint += labyrinthScene_Paint;
            this.labyrinthScene.MouseDown += labyrinthScene_MouseDown;
            this.labyrinthScene.MouseLeave += labyrinthScene_MouseLeave;
            this.labyrinthScene.MouseMove += labyrinthScene_Mouse;
            this.labyrinthScene.MouseUp += labyrinthScene_MouseUp;
            this.labyrinthScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // mapBox
            // 
            this.mapBox.Controls.Add(this.mapScene);
            this.mapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mapBox.Location = new System.Drawing.Point(0, 0);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(498, 401);
            this.mapBox.TabIndex = 0;
            this.mapBox.TabStop = false;
            this.mapBox.Text = "Map";
            this.mapBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // mapScene
            // 
            this.mapScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapScene.Location = new System.Drawing.Point(3, 23);
            this.mapScene.Name = "mapScene";
            this.mapScene.Size = new System.Drawing.Size(492, 375);
            this.mapScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapScene.TabIndex = 3;
            this.mapScene.TabStop = false;
            this.mapScene.Paint += mapScene_Paint;
            this.mapScene.MouseDown += mapScene_MouseDown;
            this.mapScene.MouseLeave += mapScene_MouseLeave;
            this.mapScene.MouseMove += mapScene_Mouse;
            this.mapScene.MouseUp += mapScene_MouseUp;
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 81);
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
            this.zoomBox.Location = new System.Drawing.Point(126, 1);
            this.zoomBox.Margin = new System.Windows.Forms.Padding(1);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zoomBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zoomBox.Size = new System.Drawing.Size(751, 79);
            this.zoomBox.TabIndex = 6;
            this.zoomBox.TabStop = false;
            this.zoomBox.Text = "Zoom";
            // 
            // zoomSlider
            // 
            this.zoomSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomSlider.LargeChange = 10;
            this.zoomSlider.Location = new System.Drawing.Point(3, 24);
            this.zoomSlider.Maximum = 100;
            this.zoomSlider.Minimum = 1;
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.zoomSlider.Size = new System.Drawing.Size(745, 51);
            this.zoomSlider.TabIndex = 5;
            this.zoomSlider.TabStop = false;
            this.zoomSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.zoomSlider.Value = 50;
            this.zoomSlider.Scroll += zoomSlider_Scroll;
            this.zoomSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // labyrinthToolStrip
            // 
            this.labyrinthToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labyrinthToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.labyrinthToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labyrinthTool,
            this.clearBtn,
            this.loadBtn,
            this.saveBtn,
            this.eraseBtn,
            this.drawBtn,
            this.setMinoPos});
            this.labyrinthToolStrip.Location = new System.Drawing.Point(0, 0);
            this.labyrinthToolStrip.MinimumSize = new System.Drawing.Size(0, 20);
            this.labyrinthToolStrip.Name = "labyrinthToolStrip";
            this.labyrinthToolStrip.Size = new System.Drawing.Size(494, 22);
            this.labyrinthToolStrip.Stretch = true;
            this.labyrinthToolStrip.TabIndex = 0;
            this.labyrinthToolStrip.Text = "toolStrip3";
            // 
            // labyrinthTool
            // 
            this.labyrinthTool.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labyrinthTool.Name = "labyrinthTool";
            this.labyrinthTool.Size = new System.Drawing.Size(58, 19);
            this.labyrinthTool.Text = "<Tool>";
            // 
            // clearBtn
            // 
            this.clearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(29, 19);
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += clearBtn_Click;
            // 
            // loadBtn
            // 
            this.loadBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadBtn.Image")));
            this.loadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(29, 19);
            this.loadBtn.Text = "Load Map";
            this.loadBtn.Click += loadBtn_Click;
            // 
            // saveBtn
            // 
            this.saveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(29, 19);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += saveBtn_Click;
            // 
            // eraseBtn
            // 
            this.eraseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.eraseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraseBtn.Image = ((System.Drawing.Image)(resources.GetObject("eraseBtn.Image")));
            this.eraseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(29, 19);
            this.eraseBtn.Text = "Erase";
            this.eraseBtn.Click += eraseBtn_Click;
            // 
            // drawBtn
            // 
            this.drawBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.drawBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawBtn.Image")));
            this.drawBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(29, 19);
            this.drawBtn.Text = "Draw";
            this.drawBtn.Click += drawBtn_Click;
            // 
            // setMinoPos
            // 
            this.setMinoPos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.setMinoPos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setMinoPos.Image = ((System.Drawing.Image)(resources.GetObject("setMinoPos.Image")));
            this.setMinoPos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setMinoPos.Name = "setMinoPos";
            this.setMinoPos.Size = new System.Drawing.Size(29, 19);
            this.setMinoPos.Text = "setMinoPos";
            this.setMinoPos.ToolTipText = "Set Minotaur Position";
            this.setMinoPos.Click += setMinoPos_Click;
            // 
            // mapToolStrip
            // 
            this.mapToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mapToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.targetBtn,
            this.roamBtn,
            this.ClearMemory,
            this.mapMode,
            this.playBtn,
            this.stopBtn});
            this.mapToolStrip.Location = new System.Drawing.Point(503, 0);
            this.mapToolStrip.MinimumSize = new System.Drawing.Size(0, 20);
            this.mapToolStrip.Name = "mapToolStrip";
            this.mapToolStrip.Size = new System.Drawing.Size(496, 22);
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
            this.targetBtn.Size = new System.Drawing.Size(29, 19);
            this.targetBtn.Text = "Type Mode";
            this.targetBtn.Click += targetBtn_Click;
            // 
            // roamBtn
            // 
            this.roamBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.roamBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roamBtn.Image = ((System.Drawing.Image)(resources.GetObject("roamBtn.Image")));
            this.roamBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roamBtn.Name = "roamBtn";
            this.roamBtn.Size = new System.Drawing.Size(29, 19);
            this.roamBtn.Text = "Roam Mode";
            this.roamBtn.Click += roamBtn_Click;
            // 
            // ClearMemory
            // 
            this.ClearMemory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ClearMemory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearMemory.Image = ((System.Drawing.Image)(resources.GetObject("ClearMemory.Image")));
            this.ClearMemory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearMemory.Name = "ClearMemory";
            this.ClearMemory.Size = new System.Drawing.Size(29, 19);
            this.ClearMemory.Text = "ClearMemory";
            this.ClearMemory.ToolTipText = "Clear Memory";
            this.ClearMemory.Click += ClearMemory_Click;
            // 
            // mapMode
            // 
            this.mapMode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mapMode.Name = "mapMode";
            this.mapMode.Size = new System.Drawing.Size(68, 19);
            this.mapMode.Text = "<mode>";
            // 
            // playBtn
            // 
            this.playBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.playBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playBtn.Image = ((System.Drawing.Image)(resources.GetObject("playBtn.Image")));
            this.playBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(29, 19);
            this.playBtn.Text = "Activate Minotaur";
            this.playBtn.Click += playBtn_Click;
            // 
            // stopBtn
            // 
            this.stopBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(29, 19);
            this.stopBtn.Text = "Deactivate Minotaur";
            this.stopBtn.Click += stopBtn_Click;
            // 
            // MinotaurWorker
            // 
            this.MinotaurWorker.WorkerSupportsCancellation = true;
            this.MinotaurWorker.DoWork += MinotaurWorker_DoWork;
            this.MinotaurWorker.RunWorkerCompleted += backgroundWorker_End;
            // 
            // LabyrinthUpdate
            // 
            this.LabyrinthUpdate.WorkerSupportsCancellation = true;
            this.LabyrinthUpdate.DoWork += LabyrinthUpdate_DoWork;
            this.LabyrinthUpdate.RunWorkerCompleted += backgroundWorker_End;
            // 
            // openMapFile
            // 
            this.openMapFile.FileName = "";
            this.openMapFile.FileOk += openMapFile_FileOk;
            this.saveMapFile.FileOk += saveMapFile_FileOk;
            // 
            // MenuSplit
            // 
            this.MenuSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MenuSplit.Location = new System.Drawing.Point(6, 7);
            this.MenuSplit.Margin = new System.Windows.Forms.Padding(1);
            this.MenuSplit.Name = "MenuSplit";
            this.MenuSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MenuSplit.Panel1
            // 
            this.MenuSplit.Panel1.Controls.Add(this.ToolBox);
            this.MenuSplit.Panel1MinSize = 50;
            // 
            // MenuSplit.Panel2
            // 
            this.MenuSplit.Panel2.Controls.Add(this.VerticalLayout);
            this.MenuSplit.Size = new System.Drawing.Size(1005, 554);
            this.MenuSplit.SplitterWidth = 11;
            this.MenuSplit.TabIndex = 5;
            // 
            // ToolBox
            // 
            this.ToolBox.Controls.Add(this.tableLayoutPanel2);
            this.ToolBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ToolBox.Location = new System.Drawing.Point(0, 0);
            this.ToolBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToolBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolBox.Size = new System.Drawing.Size(1005, 50);
            this.ToolBox.TabIndex = 3;
            this.ToolBox.TabStop = false;
            this.ToolBox.Text = "Tool Box";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel2.Controls.Add(this.labyrinthToolStrip, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mapToolStrip, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(999, 22);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuSplit);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(3, 4);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MenuPanel.Size = new System.Drawing.Size(1017, 568);
            this.MenuPanel.TabIndex = 6;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.MenuTab);
            this.tabMenu.Controls.Add(this.SettingsTab);
            this.tabMenu.Controls.Add(this.HelpTab);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMenu.Multiline = true;
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1031, 609);
            this.tabMenu.TabIndex = 7;
            // 
            // MenuTab
            // 
            this.MenuTab.BackColor = System.Drawing.Color.Black;
            this.MenuTab.Controls.Add(this.MenuPanel);
            this.MenuTab.Location = new System.Drawing.Point(4, 29);
            this.MenuTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuTab.Size = new System.Drawing.Size(1023, 576);
            this.MenuTab.TabIndex = 0;
            this.MenuTab.Text = "Tower";
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.Black;
            this.SettingsTab.Controls.Add(this.tableSettings);
            this.SettingsTab.Location = new System.Drawing.Point(4, 29);
            this.SettingsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingsTab.Size = new System.Drawing.Size(1023, 576);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            // 
            // tableSettings
            // 
            this.tableSettings.ColumnCount = 2;
            this.tableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableSettings.Controls.Add(this.SettingControl, 1, 0);
            this.tableSettings.Controls.Add(this.groupBox24, 0, 0);
            this.tableSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSettings.Location = new System.Drawing.Point(3, 4);
            this.tableSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableSettings.Name = "tableSettings";
            this.tableSettings.RowCount = 1;
            this.tableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSettings.Size = new System.Drawing.Size(1017, 568);
            this.tableSettings.TabIndex = 0;
            // 
            // SettingControl
            // 
            this.SettingControl.Controls.Add(this.Visual);
            this.SettingControl.Controls.Add(this.Display);
            this.SettingControl.Controls.Add(this.Internal);
            this.SettingControl.Controls.Add(this.Environment);
            this.SettingControl.Controls.Add(this.ApplyColor);
            this.SettingControl.Controls.Add(this.Reset);
            this.SettingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingControl.ItemSize = new System.Drawing.Size(0, 1);
            this.SettingControl.Location = new System.Drawing.Point(206, 4);
            this.SettingControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingControl.Name = "SettingControl";
            this.SettingControl.Padding = new System.Drawing.Point(0, 0);
            this.SettingControl.SelectedIndex = 0;
            this.SettingControl.Size = new System.Drawing.Size(808, 560);
            this.SettingControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.SettingControl.TabIndex = 1;
            this.SettingControl.TabStop = false;
            // 
            // Visual
            // 
            this.Visual.BackColor = System.Drawing.Color.Black;
            this.Visual.Controls.Add(this.groupBox1);
            this.Visual.Location = new System.Drawing.Point(4, 5);
            this.Visual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Visual.Name = "Visual";
            this.Visual.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Visual.Size = new System.Drawing.Size(800, 551);
            this.Visual.TabIndex = 0;
            this.Visual.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(794, 543);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visual Settings";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox9);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox30);
            this.flowLayoutPanel1.Controls.Add(this.groupBox31);
            this.flowLayoutPanel1.Controls.Add(this.groupBox7);
            this.flowLayoutPanel1.Controls.Add(this.groupBox8);
            this.flowLayoutPanel1.Controls.Add(this.groupBox15);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 515);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Location = new System.Drawing.Point(3, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(744, 88);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Labyrinth Map Color";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LabColor, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ChangeMapColor, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // LabColor
            // 
            this.LabColor.BackColor = System.Drawing.Color.White;
            this.LabColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabColor.Location = new System.Drawing.Point(3, 4);
            this.LabColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabColor.Name = "LabColor";
            this.LabColor.Size = new System.Drawing.Size(363, 52);
            this.LabColor.TabIndex = 0;
            // 
            // ChangeMapColor
            // 
            this.ChangeMapColor.BackColor = System.Drawing.Color.White;
            this.ChangeMapColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeMapColor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChangeMapColor.Location = new System.Drawing.Point(372, 4);
            this.ChangeMapColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeMapColor.Name = "ChangeMapColor";
            this.ChangeMapColor.Size = new System.Drawing.Size(363, 52);
            this.ChangeMapColor.TabIndex = 1;
            this.ChangeMapColor.Text = "Change";
            this.ChangeMapColor.UseVisualStyleBackColor = false;
            this.ChangeMapColor.Click += new System.EventHandler(this.ChangeMapColor_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel8);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox9.Location = new System.Drawing.Point(3, 100);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox9.Size = new System.Drawing.Size(744, 88);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Labyrinth Highlight Color";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.LabHighlightColor, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.ChangeHighlightColor, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // LabHighlightColor
            // 
            this.LabHighlightColor.BackColor = System.Drawing.Color.White;
            this.LabHighlightColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabHighlightColor.Location = new System.Drawing.Point(3, 4);
            this.LabHighlightColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabHighlightColor.Name = "LabHighlightColor";
            this.LabHighlightColor.Size = new System.Drawing.Size(363, 52);
            this.LabHighlightColor.TabIndex = 0;
            // 
            // ChangeHighlightColor
            // 
            this.ChangeHighlightColor.BackColor = System.Drawing.Color.White;
            this.ChangeHighlightColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeHighlightColor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChangeHighlightColor.Location = new System.Drawing.Point(372, 4);
            this.ChangeHighlightColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeHighlightColor.Name = "ChangeHighlightColor";
            this.ChangeHighlightColor.Size = new System.Drawing.Size(363, 52);
            this.ChangeHighlightColor.TabIndex = 1;
            this.ChangeHighlightColor.Text = "Change";
            this.ChangeHighlightColor.UseVisualStyleBackColor = false;
            this.ChangeHighlightColor.Click += new System.EventHandler(this.ChangeHighlightColor_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox5.Location = new System.Drawing.Point(3, 196);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(744, 88);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mino Color";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.MinoColor, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ChangeMinoColor, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // MinoColor
            // 
            this.MinoColor.BackColor = System.Drawing.Color.White;
            this.MinoColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinoColor.Location = new System.Drawing.Point(3, 4);
            this.MinoColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinoColor.Name = "MinoColor";
            this.MinoColor.Size = new System.Drawing.Size(363, 52);
            this.MinoColor.TabIndex = 0;
            // 
            // ChangeMinoColor
            // 
            this.ChangeMinoColor.BackColor = System.Drawing.Color.White;
            this.ChangeMinoColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeMinoColor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChangeMinoColor.Location = new System.Drawing.Point(372, 4);
            this.ChangeMinoColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeMinoColor.Name = "ChangeMinoColor";
            this.ChangeMinoColor.Size = new System.Drawing.Size(363, 52);
            this.ChangeMinoColor.TabIndex = 1;
            this.ChangeMinoColor.Text = "Change";
            this.ChangeMinoColor.UseVisualStyleBackColor = false;
            this.ChangeMinoColor.Click += new System.EventHandler(this.ChangeMinoColor_Click);
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.tableLayoutPanel19);
            this.groupBox30.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox30.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox30.Location = new System.Drawing.Point(3, 292);
            this.groupBox30.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox30.Size = new System.Drawing.Size(744, 88);
            this.groupBox30.TabIndex = 1;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Non-Hit Point Color";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Controls.Add(this.NonHitColor, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.ChangeNonHitColor, 1, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel19.TabIndex = 0;
            // 
            // NonHitColor
            // 
            this.NonHitColor.BackColor = System.Drawing.Color.White;
            this.NonHitColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NonHitColor.Location = new System.Drawing.Point(3, 4);
            this.NonHitColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NonHitColor.Name = "NonHitColor";
            this.NonHitColor.Size = new System.Drawing.Size(363, 52);
            this.NonHitColor.TabIndex = 0;
            // 
            // ChangeNonHitColor
            // 
            this.ChangeNonHitColor.BackColor = System.Drawing.Color.White;
            this.ChangeNonHitColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeNonHitColor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChangeNonHitColor.Location = new System.Drawing.Point(372, 4);
            this.ChangeNonHitColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeNonHitColor.Name = "ChangeNonHitColor";
            this.ChangeNonHitColor.Size = new System.Drawing.Size(363, 52);
            this.ChangeNonHitColor.TabIndex = 1;
            this.ChangeNonHitColor.Text = "Change";
            this.ChangeNonHitColor.UseVisualStyleBackColor = false;
            this.ChangeNonHitColor.Click += new System.EventHandler(this.ChangeNonHitColor_Click);
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.tableLayoutPanel20);
            this.groupBox31.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox31.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox31.Location = new System.Drawing.Point(3, 388);
            this.groupBox31.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox31.Size = new System.Drawing.Size(744, 88);
            this.groupBox31.TabIndex = 1;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Ray Line Color";
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 2;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Controls.Add(this.RayLineColor, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.ChangeRayColor, 1, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 1;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel20.TabIndex = 0;
            // 
            // RayLineColor
            // 
            this.RayLineColor.BackColor = System.Drawing.Color.White;
            this.RayLineColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RayLineColor.Location = new System.Drawing.Point(3, 4);
            this.RayLineColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RayLineColor.Name = "RayLineColor";
            this.RayLineColor.Size = new System.Drawing.Size(363, 52);
            this.RayLineColor.TabIndex = 0;
            // 
            // ChangeRayColor
            // 
            this.ChangeRayColor.BackColor = System.Drawing.Color.White;
            this.ChangeRayColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeRayColor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChangeRayColor.Location = new System.Drawing.Point(372, 4);
            this.ChangeRayColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeRayColor.Name = "ChangeRayColor";
            this.ChangeRayColor.Size = new System.Drawing.Size(363, 52);
            this.ChangeRayColor.TabIndex = 1;
            this.ChangeRayColor.Text = "Change";
            this.ChangeRayColor.UseVisualStyleBackColor = false;
            this.ChangeRayColor.Click += new System.EventHandler(this.ChangeRayColor_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel6);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox7.Location = new System.Drawing.Point(3, 484);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(744, 88);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Map Object Color";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.MapObjectsColor, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.ChangeMapObjectsColor, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // MapObjectsColor
            // 
            this.MapObjectsColor.BackColor = System.Drawing.Color.White;
            this.MapObjectsColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapObjectsColor.Location = new System.Drawing.Point(3, 4);
            this.MapObjectsColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapObjectsColor.Name = "MapObjectsColor";
            this.MapObjectsColor.Size = new System.Drawing.Size(363, 52);
            this.MapObjectsColor.TabIndex = 0;
            // 
            // ChangeMapObjectsColor
            // 
            this.ChangeMapObjectsColor.BackColor = System.Drawing.Color.White;
            this.ChangeMapObjectsColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeMapObjectsColor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChangeMapObjectsColor.Location = new System.Drawing.Point(372, 4);
            this.ChangeMapObjectsColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeMapObjectsColor.Name = "ChangeMapObjectsColor";
            this.ChangeMapObjectsColor.Size = new System.Drawing.Size(363, 52);
            this.ChangeMapObjectsColor.TabIndex = 1;
            this.ChangeMapObjectsColor.Text = "Change";
            this.ChangeMapObjectsColor.UseVisualStyleBackColor = false;
            this.ChangeMapObjectsColor.Click += new System.EventHandler(this.ChangeMapObjectsColor_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel7);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox8.Location = new System.Drawing.Point(3, 580);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox8.Size = new System.Drawing.Size(744, 88);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Map Chunk Color";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.MapChunkColor, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.ChangeMapChunckColor, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // MapChunkColor
            // 
            this.MapChunkColor.BackColor = System.Drawing.Color.White;
            this.MapChunkColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapChunkColor.Location = new System.Drawing.Point(3, 4);
            this.MapChunkColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapChunkColor.Name = "MapChunkColor";
            this.MapChunkColor.Size = new System.Drawing.Size(363, 52);
            this.MapChunkColor.TabIndex = 0;
            // 
            // ChangeMapChunckColor
            // 
            this.ChangeMapChunckColor.BackColor = System.Drawing.Color.White;
            this.ChangeMapChunckColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeMapChunckColor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChangeMapChunckColor.Location = new System.Drawing.Point(372, 4);
            this.ChangeMapChunckColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeMapChunckColor.Name = "ChangeMapChunckColor";
            this.ChangeMapChunckColor.Size = new System.Drawing.Size(363, 52);
            this.ChangeMapChunckColor.TabIndex = 1;
            this.ChangeMapChunckColor.Text = "Change";
            this.ChangeMapChunckColor.UseVisualStyleBackColor = false;
            this.ChangeMapChunckColor.Click += new System.EventHandler(this.ChangeMapChunckColor_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.tableLayoutPanel11);
            this.groupBox15.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox15.Location = new System.Drawing.Point(3, 676);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox15.Size = new System.Drawing.Size(744, 88);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Map Wall Color";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.MapWallColor, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.ChangeMapWallColor, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // MapWallColor
            // 
            this.MapWallColor.BackColor = System.Drawing.Color.White;
            this.MapWallColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapWallColor.Location = new System.Drawing.Point(3, 4);
            this.MapWallColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapWallColor.Name = "MapWallColor";
            this.MapWallColor.Size = new System.Drawing.Size(363, 52);
            this.MapWallColor.TabIndex = 0;
            // 
            // ChangeMapWallColor
            // 
            this.ChangeMapWallColor.BackColor = System.Drawing.Color.White;
            this.ChangeMapWallColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeMapWallColor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ChangeMapWallColor.Location = new System.Drawing.Point(372, 4);
            this.ChangeMapWallColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeMapWallColor.Name = "ChangeMapWallColor";
            this.ChangeMapWallColor.Size = new System.Drawing.Size(363, 52);
            this.ChangeMapWallColor.TabIndex = 1;
            this.ChangeMapWallColor.Text = "Change";
            this.ChangeMapWallColor.UseVisualStyleBackColor = false;
            this.ChangeMapWallColor.Click += new System.EventHandler(this.ChangeMapWallColor_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Black;
            this.Display.Controls.Add(this.groupBox2);
            this.Display.Location = new System.Drawing.Point(4, 5);
            this.Display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Display.Name = "Display";
            this.Display.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Display.Size = new System.Drawing.Size(800, 551);
            this.Display.TabIndex = 1;
            this.Display.Text = "2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(794, 543);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Settings";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.groupBox10);
            this.flowLayoutPanel2.Controls.Add(this.groupBox11);
            this.flowLayoutPanel2.Controls.Add(this.groupBox18);
            this.flowLayoutPanel2.Controls.Add(this.groupBox16);
            this.flowLayoutPanel2.Controls.Add(this.groupBox25);
            this.flowLayoutPanel2.Controls.Add(this.groupBox17);
            this.flowLayoutPanel2.Controls.Add(this.groupBox12);
            this.flowLayoutPanel2.Controls.Add(this.groupBox13);
            this.flowLayoutPanel2.Controls.Add(this.groupBox33);
            this.flowLayoutPanel2.Controls.Add(this.groupBox32);
            this.flowLayoutPanel2.Controls.Add(this.groupBox14);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(788, 515);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.ShowCollidedPoints);
            this.groupBox10.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox10.Location = new System.Drawing.Point(3, 4);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox10.Size = new System.Drawing.Size(744, 53);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Collided Points";
            // 
            // ShowCollidedPoints
            // 
            this.ShowCollidedPoints.AutoSize = true;
            this.ShowCollidedPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowCollidedPoints.Location = new System.Drawing.Point(3, 24);
            this.ShowCollidedPoints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowCollidedPoints.Name = "ShowCollidedPoints";
            this.ShowCollidedPoints.Size = new System.Drawing.Size(738, 25);
            this.ShowCollidedPoints.TabIndex = 0;
            this.ShowCollidedPoints.Text = "Show";
            this.ShowCollidedPoints.UseVisualStyleBackColor = true;
            this.ShowCollidedPoints.CheckedChanged += ShowCollidedPoints_CheckedChanged;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.ShowUncollidedPoints);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox11.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox11.Location = new System.Drawing.Point(3, 65);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox11.Size = new System.Drawing.Size(744, 53);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Uncollided Points";
            // 
            // ShowUncollidedPoints
            // 
            this.ShowUncollidedPoints.AutoSize = true;
            this.ShowUncollidedPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowUncollidedPoints.Location = new System.Drawing.Point(3, 24);
            this.ShowUncollidedPoints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowUncollidedPoints.Name = "ShowUncollidedPoints";
            this.ShowUncollidedPoints.Size = new System.Drawing.Size(738, 25);
            this.ShowUncollidedPoints.TabIndex = 0;
            this.ShowUncollidedPoints.Text = "Show";
            this.ShowUncollidedPoints.UseVisualStyleBackColor = true;
            this.ShowUncollidedPoints.CheckedChanged += ShowUncollidedPoints_CheckedChanged;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.ShowCurrentTarget);
            this.groupBox18.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox18.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox18.Location = new System.Drawing.Point(3, 126);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox18.Size = new System.Drawing.Size(744, 53);
            this.groupBox18.TabIndex = 3;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Current Target";
            // 
            // ShowCurrentTarget
            // 
            this.ShowCurrentTarget.AutoSize = true;
            this.ShowCurrentTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowCurrentTarget.Location = new System.Drawing.Point(3, 24);
            this.ShowCurrentTarget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowCurrentTarget.Name = "ShowCurrentTarget";
            this.ShowCurrentTarget.Size = new System.Drawing.Size(738, 25);
            this.ShowCurrentTarget.TabIndex = 0;
            this.ShowCurrentTarget.Text = "Show";
            this.ShowCurrentTarget.UseVisualStyleBackColor = true;
            this.ShowCurrentTarget.CheckedChanged += ShowCurrentTarget_CheckedChanged;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.ShowRoamTargets);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox16.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox16.Location = new System.Drawing.Point(3, 187);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox16.Size = new System.Drawing.Size(744, 53);
            this.groupBox16.TabIndex = 1;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Roam Targets";
            // 
            // ShowRoamTargets
            // 
            this.ShowRoamTargets.AutoSize = true;
            this.ShowRoamTargets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowRoamTargets.Location = new System.Drawing.Point(3, 24);
            this.ShowRoamTargets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowRoamTargets.Name = "ShowRoamTargets";
            this.ShowRoamTargets.Size = new System.Drawing.Size(738, 25);
            this.ShowRoamTargets.TabIndex = 0;
            this.ShowRoamTargets.Text = "Show";
            this.ShowRoamTargets.UseVisualStyleBackColor = true;
            this.ShowRoamTargets.CheckedChanged += ShowRoamTargets_CheckedChanged;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.ShowUserTarget);
            this.groupBox25.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox25.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox25.Location = new System.Drawing.Point(3, 248);
            this.groupBox25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox25.Size = new System.Drawing.Size(744, 53);
            this.groupBox25.TabIndex = 4;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "User Target";
            // 
            // ShowUserTarget
            // 
            this.ShowUserTarget.AutoSize = true;
            this.ShowUserTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowUserTarget.Location = new System.Drawing.Point(3, 24);
            this.ShowUserTarget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowUserTarget.Name = "ShowUserTarget";
            this.ShowUserTarget.Size = new System.Drawing.Size(738, 25);
            this.ShowUserTarget.TabIndex = 0;
            this.ShowUserTarget.Text = "Show";
            this.ShowUserTarget.UseVisualStyleBackColor = true;
            this.ShowUserTarget.CheckedChanged += ShowUserTarget_CheckedChanged;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.ShowPath);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox17.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox17.Location = new System.Drawing.Point(3, 309);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox17.Size = new System.Drawing.Size(744, 53);
            this.groupBox17.TabIndex = 2;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Target Path";
            // 
            // ShowPath
            // 
            this.ShowPath.AutoSize = true;
            this.ShowPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowPath.Location = new System.Drawing.Point(3, 24);
            this.ShowPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPath.Name = "ShowPath";
            this.ShowPath.Size = new System.Drawing.Size(738, 25);
            this.ShowPath.TabIndex = 0;
            this.ShowPath.Text = "Show";
            this.ShowPath.UseVisualStyleBackColor = true;
            this.ShowPath.CheckedChanged += ShowPath_CheckedChanged;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tableLayoutPanel9);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox12.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox12.Location = new System.Drawing.Point(3, 370);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox12.Size = new System.Drawing.Size(744, 88);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Map Object Radius";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.ObjectRadius, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.ObjectRadiusSlider, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // ObjectRadius
            // 
            this.ObjectRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectRadius.Location = new System.Drawing.Point(3, 4);
            this.ObjectRadius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ObjectRadius.Name = "ObjectRadius";
            this.ObjectRadius.Size = new System.Drawing.Size(732, 27);
            this.ObjectRadius.TabIndex = 0;
            this.ObjectRadius.TextChanged += ObjectRadius_TextChanged;
            // 
            // ObjectRadiusSlider
            // 
            this.ObjectRadiusSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectRadiusSlider.Location = new System.Drawing.Point(3, 34);
            this.ObjectRadiusSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ObjectRadiusSlider.Maximum = 20;
            this.ObjectRadiusSlider.Name = "ObjectRadiusSlider";
            this.ObjectRadiusSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ObjectRadiusSlider.Size = new System.Drawing.Size(732, 22);
            this.ObjectRadiusSlider.TabIndex = 1;
            this.ObjectRadiusSlider.TickFrequency = 0;
            this.ObjectRadiusSlider.Value = 3;
            this.ObjectRadiusSlider.Scroll += ObjectRadiusSlider_Scroll;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.tableLayoutPanel10);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox13.Location = new System.Drawing.Point(3, 466);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox13.Size = new System.Drawing.Size(744, 88);
            this.groupBox13.TabIndex = 2;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Map Chunk Radius";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.ChunkRadius, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.ChunkRadiusSlider, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // ChunkRadius
            // 
            this.ChunkRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChunkRadius.Location = new System.Drawing.Point(3, 4);
            this.ChunkRadius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChunkRadius.Name = "ChunkRadius";
            this.ChunkRadius.Size = new System.Drawing.Size(732, 27);
            this.ChunkRadius.TabIndex = 0;
            this.ChunkRadius.TextChanged += ChunkRadius_TextChanged;
            // 
            // ChunkRadiusSlider
            // 
            this.ChunkRadiusSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChunkRadiusSlider.Location = new System.Drawing.Point(3, 34);
            this.ChunkRadiusSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChunkRadiusSlider.Maximum = 20;
            this.ChunkRadiusSlider.Name = "ChunkRadiusSlider";
            this.ChunkRadiusSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChunkRadiusSlider.Size = new System.Drawing.Size(732, 22);
            this.ChunkRadiusSlider.TabIndex = 1;
            this.ChunkRadiusSlider.TickFrequency = 0;
            this.ChunkRadiusSlider.Value = 3;
            this.ChunkRadiusSlider.Scroll += ChunkRadiusSlider_Scroll;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.ShowNonHitRays);
            this.groupBox33.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox33.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox33.Location = new System.Drawing.Point(3, 562);
            this.groupBox33.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox33.Size = new System.Drawing.Size(744, 53);
            this.groupBox33.TabIndex = 3;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Non-Hit Rays";
            // 
            // ShowNonHitRays
            // 
            this.ShowNonHitRays.AutoSize = true;
            this.ShowNonHitRays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowNonHitRays.Location = new System.Drawing.Point(3, 24);
            this.ShowNonHitRays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowNonHitRays.Name = "ShowNonHitRays";
            this.ShowNonHitRays.Size = new System.Drawing.Size(738, 25);
            this.ShowNonHitRays.TabIndex = 0;
            this.ShowNonHitRays.Text = "Show";
            this.ShowNonHitRays.UseVisualStyleBackColor = true;
            this.ShowNonHitRays.CheckedChanged += new System.EventHandler(this.ShowNonHitRays_CheckedChanged);
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.ShowHitRays);
            this.groupBox32.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox32.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox32.Location = new System.Drawing.Point(3, 623);
            this.groupBox32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox32.Size = new System.Drawing.Size(744, 53);
            this.groupBox32.TabIndex = 2;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Hit Rays";
            // 
            // ShowHitRays
            // 
            this.ShowHitRays.AutoSize = true;
            this.ShowHitRays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowHitRays.Location = new System.Drawing.Point(3, 24);
            this.ShowHitRays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowHitRays.Name = "ShowHitRays";
            this.ShowHitRays.Size = new System.Drawing.Size(738, 25);
            this.ShowHitRays.TabIndex = 0;
            this.ShowHitRays.Text = "Show";
            this.ShowHitRays.UseVisualStyleBackColor = true;
            this.ShowHitRays.CheckedChanged += new System.EventHandler(this.ShowHitRays_CheckedChanged);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.ShowWallData);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox14.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox14.Location = new System.Drawing.Point(3, 684);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox14.Size = new System.Drawing.Size(744, 53);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Wall Data";
            // 
            // ShowWallData
            // 
            this.ShowWallData.AutoSize = true;
            this.ShowWallData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowWallData.Location = new System.Drawing.Point(3, 24);
            this.ShowWallData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowWallData.Name = "ShowWallData";
            this.ShowWallData.Size = new System.Drawing.Size(738, 25);
            this.ShowWallData.TabIndex = 0;
            this.ShowWallData.Text = "Show";
            this.ShowWallData.UseVisualStyleBackColor = true;
            this.ShowWallData.CheckedChanged += ShowWallData_CheckedChanged;
            // 
            // Internal
            // 
            this.Internal.BackColor = System.Drawing.Color.Black;
            this.Internal.Controls.Add(this.groupBox3);
            this.Internal.Location = new System.Drawing.Point(4, 5);
            this.Internal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Internal.Name = "Internal";
            this.Internal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Internal.Size = new System.Drawing.Size(800, 551);
            this.Internal.TabIndex = 2;
            this.Internal.Text = "3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Location = new System.Drawing.Point(3, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(794, 543);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal Settings";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Controls.Add(this.groupBox21);
            this.flowLayoutPanel3.Controls.Add(this.groupBox22);
            this.flowLayoutPanel3.Controls.Add(this.groupBox26);
            this.flowLayoutPanel3.Controls.Add(this.groupBox19);
            this.flowLayoutPanel3.Controls.Add(this.groupBox20);
            this.flowLayoutPanel3.Controls.Add(this.groupBox23);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(788, 515);
            this.flowLayoutPanel3.TabIndex = 2;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.tableLayoutPanel12);
            this.groupBox21.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox21.Location = new System.Drawing.Point(3, 4);
            this.groupBox21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox21.Size = new System.Drawing.Size(744, 88);
            this.groupBox21.TabIndex = 1;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Mino Radius";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.MinoRadius, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.MinoRadiusSlider, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // MinoRadius
            // 
            this.MinoRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinoRadius.Location = new System.Drawing.Point(3, 4);
            this.MinoRadius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinoRadius.Name = "MinoRadius";
            this.MinoRadius.Size = new System.Drawing.Size(732, 27);
            this.MinoRadius.TabIndex = 0;
            this.MinoRadius.TextChanged += MinoRadius_TextChanged;
            // 
            // MinoRadiusSlider
            // 
            this.MinoRadiusSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinoRadiusSlider.Location = new System.Drawing.Point(3, 34);
            this.MinoRadiusSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinoRadiusSlider.Maximum = 100;
            this.MinoRadiusSlider.Name = "MinoRadiusSlider";
            this.MinoRadiusSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinoRadiusSlider.Size = new System.Drawing.Size(732, 22);
            this.MinoRadiusSlider.TabIndex = 1;
            this.MinoRadiusSlider.TickFrequency = 0;
            this.MinoRadiusSlider.Value = 3;
            this.MinoRadiusSlider.Scroll += MinoRadiusSlider_Scroll;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.tableLayoutPanel13);
            this.groupBox22.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox22.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox22.Location = new System.Drawing.Point(3, 100);
            this.groupBox22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox22.Size = new System.Drawing.Size(744, 88);
            this.groupBox22.TabIndex = 2;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Object Expansion Bias";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.ExpansionBias, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.ExpansionBiasSlider, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // ExpansionBias
            // 
            this.ExpansionBias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpansionBias.Location = new System.Drawing.Point(3, 4);
            this.ExpansionBias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExpansionBias.Name = "ExpansionBias";
            this.ExpansionBias.Size = new System.Drawing.Size(732, 27);
            this.ExpansionBias.TabIndex = 0;
            this.ExpansionBias.TextChanged += ExapansionBias_TextChanged;
            // 
            // ExpansionBiasSlider
            // 
            this.ExpansionBiasSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpansionBiasSlider.Location = new System.Drawing.Point(3, 34);
            this.ExpansionBiasSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExpansionBiasSlider.Maximum = 100;
            this.ExpansionBiasSlider.Name = "ExpansionBiasSlider";
            this.ExpansionBiasSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExpansionBiasSlider.Size = new System.Drawing.Size(732, 22);
            this.ExpansionBiasSlider.TabIndex = 1;
            this.ExpansionBiasSlider.TickFrequency = 0;
            this.ExpansionBiasSlider.Value = 3;
            this.ExpansionBiasSlider.Scroll += ExpansionBiasSlider_Scroll;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.tableLayoutPanel17);
            this.groupBox26.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox26.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox26.Location = new System.Drawing.Point(3, 196);
            this.groupBox26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox26.Size = new System.Drawing.Size(744, 88);
            this.groupBox26.TabIndex = 2;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Grid Radius";
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Controls.Add(this.GridRadius, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.GridRadiusSlider, 0, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel17.TabIndex = 0;
            // 
            // GridRadius
            // 
            this.GridRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRadius.Location = new System.Drawing.Point(3, 4);
            this.GridRadius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridRadius.Name = "GridRadius";
            this.GridRadius.Size = new System.Drawing.Size(732, 27);
            this.GridRadius.TabIndex = 0;
            this.GridRadius.TextChanged += GridRadius_TextChanged;
            // 
            // GridRadiusSlider
            // 
            this.GridRadiusSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRadiusSlider.Location = new System.Drawing.Point(3, 34);
            this.GridRadiusSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridRadiusSlider.Maximum = 50;
            this.GridRadiusSlider.Name = "GridRadiusSlider";
            this.GridRadiusSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridRadiusSlider.Size = new System.Drawing.Size(732, 22);
            this.GridRadiusSlider.TabIndex = 1;
            this.GridRadiusSlider.TickFrequency = 0;
            this.GridRadiusSlider.Value = 3;
            this.GridRadiusSlider.Scroll += GridRadiusSlider_Scroll;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.tableLayoutPanel14);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox19.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox19.Location = new System.Drawing.Point(3, 292);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox19.Size = new System.Drawing.Size(744, 88);
            this.groupBox19.TabIndex = 2;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Mino Ray Count";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.MinoRayRes, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.MinoRayResSlider, 0, 1);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // MinoRayRes
            // 
            this.MinoRayRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinoRayRes.Location = new System.Drawing.Point(3, 4);
            this.MinoRayRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinoRayRes.Name = "MinoRayRes";
            this.MinoRayRes.Size = new System.Drawing.Size(732, 27);
            this.MinoRayRes.TabIndex = 0;
            this.MinoRayRes.TextChanged += MinoRayRes_TextChanged;
            // 
            // MinoRayResSlider
            // 
            this.MinoRayResSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinoRayResSlider.Location = new System.Drawing.Point(3, 34);
            this.MinoRayResSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinoRayResSlider.Maximum = 720;
            this.MinoRayResSlider.Name = "MinoRayResSlider";
            this.MinoRayResSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinoRayResSlider.Size = new System.Drawing.Size(732, 22);
            this.MinoRayResSlider.TabIndex = 1;
            this.MinoRayResSlider.TickFrequency = 0;
            this.MinoRayResSlider.Value = 3;
            this.MinoRayResSlider.Scroll += MinoRayResSlider_Scroll;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.tableLayoutPanel15);
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox20.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox20.Location = new System.Drawing.Point(3, 388);
            this.groupBox20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox20.Size = new System.Drawing.Size(744, 88);
            this.groupBox20.TabIndex = 2;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Mino Speed";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.MinoSpeed, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.MinoSpeedSlider, 0, 1);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // MinoSpeed
            // 
            this.MinoSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinoSpeed.Location = new System.Drawing.Point(3, 4);
            this.MinoSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinoSpeed.Name = "MinoSpeed";
            this.MinoSpeed.Size = new System.Drawing.Size(732, 27);
            this.MinoSpeed.TabIndex = 0;
            this.MinoSpeed.TextChanged += MinoSpeed_TextChanged;
            // 
            // MinoSpeedSlider
            // 
            this.MinoSpeedSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinoSpeedSlider.Location = new System.Drawing.Point(3, 34);
            this.MinoSpeedSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinoSpeedSlider.Name = "MinoSpeedSlider";
            this.MinoSpeedSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinoSpeedSlider.Size = new System.Drawing.Size(732, 22);
            this.MinoSpeedSlider.TabIndex = 1;
            this.MinoSpeedSlider.TickFrequency = 0;
            this.MinoSpeedSlider.Value = 3;
            this.MinoSpeedSlider.Scroll += MinoSpeedSlider_Scroll;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.tableLayoutPanel16);
            this.groupBox23.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox23.Location = new System.Drawing.Point(3, 484);
            this.groupBox23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox23.Size = new System.Drawing.Size(744, 88);
            this.groupBox23.TabIndex = 2;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Mino View Distance";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.MinoViewDistance, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.MinoViewDistanceSlider, 0, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // MinoViewDistance
            // 
            this.MinoViewDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinoViewDistance.Location = new System.Drawing.Point(3, 4);
            this.MinoViewDistance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinoViewDistance.Name = "MinoViewDistance";
            this.MinoViewDistance.Size = new System.Drawing.Size(732, 27);
            this.MinoViewDistance.TabIndex = 0;
            this.MinoViewDistance.TextChanged += MinoViewDistance_TextChanged;
            // 
            // MinoViewDistanceSlider
            // 
            this.MinoViewDistanceSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinoViewDistanceSlider.Location = new System.Drawing.Point(3, 34);
            this.MinoViewDistanceSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinoViewDistanceSlider.Maximum = 200;
            this.MinoViewDistanceSlider.Name = "MinoViewDistanceSlider";
            this.MinoViewDistanceSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinoViewDistanceSlider.Size = new System.Drawing.Size(732, 22);
            this.MinoViewDistanceSlider.TabIndex = 1;
            this.MinoViewDistanceSlider.TickFrequency = 0;
            this.MinoViewDistanceSlider.Value = 3;
            this.MinoViewDistanceSlider.Scroll += MinoViewDistanceSlider_Scroll;
            // 
            // Environment
            // 
            this.Environment.BackColor = System.Drawing.Color.Black;
            this.Environment.Controls.Add(this.groupBox27);
            this.Environment.Location = new System.Drawing.Point(4, 5);
            this.Environment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Environment.Name = "Environment";
            this.Environment.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Environment.Size = new System.Drawing.Size(800, 551);
            this.Environment.TabIndex = 3;
            this.Environment.Text = "Environment";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.flowLayoutPanel4);
            this.groupBox27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox27.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox27.Location = new System.Drawing.Point(3, 4);
            this.groupBox27.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox27.Size = new System.Drawing.Size(794, 543);
            this.groupBox27.TabIndex = 1;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Internal Settings";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.Controls.Add(this.groupBox28);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(788, 515);
            this.flowLayoutPanel4.TabIndex = 2;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.tableLayoutPanel18);
            this.groupBox28.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox28.Location = new System.Drawing.Point(3, 4);
            this.groupBox28.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox28.Size = new System.Drawing.Size(744, 88);
            this.groupBox28.TabIndex = 1;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Wall Width";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Controls.Add(this.WallWidth, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.WallWidthSlider, 0, 1);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(738, 60);
            this.tableLayoutPanel18.TabIndex = 0;
            // 
            // WallWidth
            // 
            this.WallWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WallWidth.Location = new System.Drawing.Point(3, 4);
            this.WallWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WallWidth.Name = "WallWidth";
            this.WallWidth.Size = new System.Drawing.Size(732, 27);
            this.WallWidth.TabIndex = 0;
            this.WallWidth.TextChanged += WallWidth_TextChanged;
            // 
            // WallWidthSlider
            // 
            this.WallWidthSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WallWidthSlider.Location = new System.Drawing.Point(3, 34);
            this.WallWidthSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WallWidthSlider.Maximum = 50;
            this.WallWidthSlider.Minimum = 1;
            this.WallWidthSlider.Name = "WallWidthSlider";
            this.WallWidthSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WallWidthSlider.Size = new System.Drawing.Size(732, 22);
            this.WallWidthSlider.TabIndex = 1;
            this.WallWidthSlider.TickFrequency = 0;
            this.WallWidthSlider.Value = 3;
            this.WallWidthSlider.Scroll += WallWidthSlider_Scroll;
            // 
            // ApplyColor
            // 
            this.ApplyColor.BackColor = System.Drawing.Color.Black;
            this.ApplyColor.Controls.Add(this.groupBox29);
            this.ApplyColor.Location = new System.Drawing.Point(4, 5);
            this.ApplyColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ApplyColor.Name = "ApplyColor";
            this.ApplyColor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ApplyColor.Size = new System.Drawing.Size(800, 551);
            this.ApplyColor.TabIndex = 4;
            this.ApplyColor.Text = "Apply Color";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.flowLayoutPanel5);
            this.groupBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox29.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox29.Location = new System.Drawing.Point(3, 4);
            this.groupBox29.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox29.Size = new System.Drawing.Size(794, 543);
            this.groupBox29.TabIndex = 0;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Apply Color Group?";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.Apply);
            this.flowLayoutPanel5.Controls.Add(this.Cancel);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(788, 515);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.White;
            this.Apply.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Apply.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Apply.Location = new System.Drawing.Point(3, 4);
            this.Apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(239, 84);
            this.Apply.TabIndex = 0;
            this.Apply.Text = "Yes";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += Apply_Click;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Cancel.Location = new System.Drawing.Point(3, 96);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(239, 60);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "No";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += Cancel_Click;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.treeSettings);
            this.groupBox24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox24.Location = new System.Drawing.Point(3, 4);
            this.groupBox24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox24.Size = new System.Drawing.Size(197, 560);
            this.groupBox24.TabIndex = 2;
            this.groupBox24.TabStop = false;
            // 
            // treeSettings
            // 
            this.treeSettings.BackColor = System.Drawing.SystemColors.MenuText;
            this.treeSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSettings.ForeColor = System.Drawing.SystemColors.Info;
            this.treeSettings.LineColor = System.Drawing.Color.White;
            this.treeSettings.Location = new System.Drawing.Point(3, 24);
            this.treeSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeSettings.Name = "treeSettings";
            treeNode14.Name = "Protanopia";
            treeNode14.Text = "Protanopia";
            treeNode16.Name = "Red-Green Blindness";
            treeNode16.Text = "Red-Green Blindness";
            treeNode17.Name = "Tritanopia";
            treeNode17.Text = "Tritanopia";
            treeNode18.Name = "Blue-Yellow Blindness";
            treeNode18.Text = "Blue-Yellow Blindness";
            treeNode19.Name = "Achromatopsia";
            treeNode19.Text = "Achromatopsia";
            treeNode20.Name = "Visual";
            treeNode20.Text = "Visual";
            treeNode21.Name = "Display";
            treeNode21.Text = "Display";
            treeNode22.Name = "Internal";
            treeNode22.Text = "Internal";
            treeNode23.Name = "Environment";
            treeNode23.Text = "Environment";
            treeNode24.Name = "Reset";
            treeNode24.Text = "Reset";
            treeNode25.Name = "Main";
            treeNode25.Text = "Settings";
            this.treeSettings.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode25});
            this.treeSettings.Size = new System.Drawing.Size(191, 532);
            this.treeSettings.TabIndex = 0;
            this.treeSettings.AfterSelect += treeSettings_AfterSelect;
            // 
            // HelpTab
            // 
            this.HelpTab.BackColor = System.Drawing.Color.Black;
            this.HelpTab.Controls.Add(this.tableLayoutPanel21);
            this.HelpTab.Location = new System.Drawing.Point(4, 29);
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Padding = new System.Windows.Forms.Padding(3);
            this.HelpTab.Size = new System.Drawing.Size(1023, 576);
            this.HelpTab.TabIndex = 2;
            this.HelpTab.Text = "Help";
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel21.Controls.Add(this.groupBox65, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.richTextHelp, 1, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(1017, 570);
            this.tableLayoutPanel21.TabIndex = 1;
            // 
            // groupBox65
            // 
            this.groupBox65.Controls.Add(this.treeHelp);
            this.groupBox65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox65.Location = new System.Drawing.Point(3, 4);
            this.groupBox65.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox65.Name = "groupBox65";
            this.groupBox65.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox65.Size = new System.Drawing.Size(197, 562);
            this.groupBox65.TabIndex = 2;
            this.groupBox65.TabStop = false;
            // 
            // treeHelp
            // 
            this.treeHelp.BackColor = System.Drawing.SystemColors.MenuText;
            this.treeHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeHelp.ForeColor = System.Drawing.SystemColors.Info;
            this.treeHelp.LineColor = System.Drawing.Color.White;
            this.treeHelp.Location = new System.Drawing.Point(3, 24);
            this.treeHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeHelp.Name = "treeHelp";
            treeNode26.Name = "Manual";
            treeNode26.Text = "Manual";
            this.treeHelp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.treeHelp.Size = new System.Drawing.Size(191, 534);
            this.treeHelp.TabIndex = 0;
            // 
            // richTextHelp
            // 
            this.richTextHelp.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextHelp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextHelp.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextHelp.Location = new System.Drawing.Point(206, 3);
            this.richTextHelp.Name = "richTextHelp";
            this.richTextHelp.ReadOnly = true;
            this.richTextHelp.Size = new System.Drawing.Size(808, 564);
            this.richTextHelp.TabIndex = 3;
            this.richTextHelp.Text = "";
            // 
            // colorDialog
            // 
            this.colorDialog.AllowFullOpen = false;
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.Red;
            this.colorDialog.SolidColorOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 94);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(103, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Black;
            this.Reset.Controls.Add(this.groupBox34);
            this.Reset.Location = new System.Drawing.Point(4, 5);
            this.Reset.Name = "Reset";
            this.Reset.Padding = new System.Windows.Forms.Padding(3);
            this.Reset.Size = new System.Drawing.Size(800, 551);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.flowLayoutPanel6);
            this.groupBox34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox34.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox34.Location = new System.Drawing.Point(3, 3);
            this.groupBox34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox34.Size = new System.Drawing.Size(794, 545);
            this.groupBox34.TabIndex = 1;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Reset Settings?";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.ResetSet);
            this.flowLayoutPanel6.Controls.Add(this.CancelSet);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(788, 517);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // ResetSet
            // 
            this.ResetSet.BackColor = System.Drawing.Color.White;
            this.ResetSet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetSet.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ResetSet.Location = new System.Drawing.Point(3, 4);
            this.ResetSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetSet.Name = "ResetSet";
            this.ResetSet.Size = new System.Drawing.Size(239, 84);
            this.ResetSet.TabIndex = 0;
            this.ResetSet.Text = "Yes";
            this.ResetSet.UseVisualStyleBackColor = false;
            this.ResetSet.Click += new System.EventHandler(this.Reset_Click);
            // 
            // CancelSet
            // 
            this.CancelSet.BackColor = System.Drawing.Color.White;
            this.CancelSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelSet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelSet.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CancelSet.Location = new System.Drawing.Point(3, 96);
            this.CancelSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelSet.Name = "CancelSet";
            this.CancelSet.Size = new System.Drawing.Size(239, 60);
            this.CancelSet.TabIndex = 1;
            this.CancelSet.Text = "No";
            this.CancelSet.UseVisualStyleBackColor = false;
            this.CancelSet.Click += new System.EventHandler(this.CancelSet_Click);
            // 
            // Knossos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1031, 609);
            this.Controls.Add(this.tabMenu);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Knossos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Daedalus";
            this.FormClosing += DaedalusForm_Close;
            this.Load += DaedalusForm_Load;
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
            ((System.ComponentModel.ISupportInitialize)(this.labyrinthScene)).EndInit();
            this.mapBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapScene)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.zoomBox.ResumeLayout(false);
            this.zoomBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            this.labyrinthToolStrip.ResumeLayout(false);
            this.labyrinthToolStrip.PerformLayout();
            this.mapToolStrip.ResumeLayout(false);
            this.mapToolStrip.PerformLayout();
            this.MenuSplit.Panel1.ResumeLayout(false);
            this.MenuSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplit)).EndInit();
            this.MenuSplit.ResumeLayout(false);
            this.ToolBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.MenuTab.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.tableSettings.ResumeLayout(false);
            this.SettingControl.ResumeLayout(false);
            this.Visual.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox30.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.groupBox31.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.Display.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectRadiusSlider)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChunkRadiusSlider)).EndInit();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.Internal.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinoRadiusSlider)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpansionBiasSlider)).EndInit();
            this.groupBox26.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRadiusSlider)).EndInit();
            this.groupBox19.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinoRayResSlider)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinoSpeedSlider)).EndInit();
            this.groupBox23.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinoViewDistanceSlider)).EndInit();
            this.Environment.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallWidthSlider)).EndInit();
            this.ApplyColor.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.HelpTab.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.groupBox65.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.Reset.ResumeLayout(false);
            this.groupBox34.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
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

