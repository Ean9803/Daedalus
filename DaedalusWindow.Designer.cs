
namespace Daedalus
{
    partial class DaedalusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaedalusForm));
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.targetBtn = new System.Windows.Forms.ToolStripButton();
            this.roamBtn = new System.Windows.Forms.ToolStripButton();
            this.mapLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.modeLabel = new System.Windows.Forms.ToolStripLabel();
            this.modeSelection = new System.Windows.Forms.ToolStripLabel();
            this.labyrinthToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.clearBtn = new System.Windows.Forms.ToolStripButton();
            this.loadBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.eraseBtn = new System.Windows.Forms.ToolStripButton();
            this.drawBtn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomControls = new System.Windows.Forms.GroupBox();
            this.zoomOutBtn = new System.Windows.Forms.Button();
            this.zoomInBtn = new System.Windows.Forms.Button();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.mapToolStrip = new System.Windows.Forms.ToolStrip();
            this.labyrinthToolBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.zoomControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.mapToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(141, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(386, 25);
            this.miniToolStrip.TabIndex = 1;
            // 
            // targetBtn
            // 
            this.targetBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.targetBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.targetBtn.Image = ((System.Drawing.Image)(resources.GetObject("targetBtn.Image")));
            this.targetBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.targetBtn.Name = "targetBtn";
            this.targetBtn.Size = new System.Drawing.Size(23, 22);
            this.targetBtn.Text = "Target Mode";
            // 
            // roamBtn
            // 
            this.roamBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.roamBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roamBtn.Image = ((System.Drawing.Image)(resources.GetObject("roamBtn.Image")));
            this.roamBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roamBtn.Name = "roamBtn";
            this.roamBtn.Size = new System.Drawing.Size(23, 22);
            this.roamBtn.Text = "Roam Mode";
            // 
            // mapLabel
            // 
            this.mapLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(31, 22);
            this.mapLabel.Text = "Map";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // modeLabel
            // 
            this.modeLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(41, 22);
            this.modeLabel.Text = "Mode:";
            // 
            // modeSelection
            // 
            this.modeSelection.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.modeSelection.Name = "modeSelection";
            this.modeSelection.Size = new System.Drawing.Size(54, 22);
            this.modeSelection.Text = "<mode>";
            // 
            // labyrinthToolBar
            // 
            this.labyrinthToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.clearBtn,
            this.loadBtn,
            this.saveBtn,
            this.eraseBtn,
            this.drawBtn});
            this.labyrinthToolBar.Location = new System.Drawing.Point(0, 0);
            this.labyrinthToolBar.Name = "labyrinthToolBar";
            this.labyrinthToolBar.Size = new System.Drawing.Size(402, 25);
            this.labyrinthToolBar.TabIndex = 5;
            this.labyrinthToolBar.Text = "toolStrip3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Labyrinth";
            // 
            // clearBtn
            // 
            this.clearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(23, 22);
            this.clearBtn.Text = "Clear";
            // 
            // loadBtn
            // 
            this.loadBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadBtn.Image")));
            this.loadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(23, 22);
            this.loadBtn.Text = "Load Map";
            // 
            // saveBtn
            // 
            this.saveBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(23, 22);
            this.saveBtn.Text = "Save";
            // 
            // eraseBtn
            // 
            this.eraseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.eraseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraseBtn.Image = ((System.Drawing.Image)(resources.GetObject("eraseBtn.Image")));
            this.eraseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(23, 22);
            this.eraseBtn.Text = "Erase";
            // 
            // drawBtn
            // 
            this.drawBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.drawBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawBtn.Image")));
            this.drawBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(23, 22);
            this.drawBtn.Text = "Draw";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.zoomControls, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labyrinthToolBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mapToolStrip, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.35294F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.64706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 353);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // zoomControls
            // 
            this.zoomControls.BackColor = System.Drawing.Color.White;
            this.zoomControls.Controls.Add(this.zoomOutBtn);
            this.zoomControls.Controls.Add(this.zoomInBtn);
            this.zoomControls.Controls.Add(this.zoomTrackBar);
            this.zoomControls.ForeColor = System.Drawing.SystemColors.WindowText;
            this.zoomControls.Location = new System.Drawing.Point(405, 3);
            this.zoomControls.Name = "zoomControls";
            this.tableLayoutPanel1.SetRowSpan(this.zoomControls, 2);
            this.zoomControls.Size = new System.Drawing.Size(54, 347);
            this.zoomControls.TabIndex = 7;
            this.zoomControls.TabStop = false;
            this.zoomControls.Text = "Zoom";
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutBtn.Image")));
            this.zoomOutBtn.Location = new System.Drawing.Point(14, 294);
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(30, 30);
            this.zoomOutBtn.TabIndex = 2;
            this.zoomOutBtn.UseVisualStyleBackColor = true;
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Image = ((System.Drawing.Image)(resources.GetObject("zoomInBtn.Image")));
            this.zoomInBtn.Location = new System.Drawing.Point(14, 44);
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(30, 30);
            this.zoomInBtn.TabIndex = 1;
            this.zoomInBtn.UseVisualStyleBackColor = true;
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Location = new System.Drawing.Point(6, 80);
            this.zoomTrackBar.Maximum = 25;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoomTrackBar.Size = new System.Drawing.Size(45, 208);
            this.zoomTrackBar.TabIndex = 0;
            // 
            // mapToolStrip
            // 
            this.mapToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.targetBtn,
            this.roamBtn,
            this.mapLabel,
            this.toolStripSeparator1,
            this.modeLabel,
            this.modeSelection});
            this.mapToolStrip.Location = new System.Drawing.Point(462, 0);
            this.mapToolStrip.Name = "mapToolStrip";
            this.mapToolStrip.Size = new System.Drawing.Size(386, 25);
            this.mapToolStrip.TabIndex = 1;
            this.mapToolStrip.Text = "toolStrip2";
            // 
            // DaedalusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(872, 364);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DaedalusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daedalus";
            this.Load += new System.EventHandler(this.DaedalusForm_Load);
            this.labyrinthToolBar.ResumeLayout(false);
            this.labyrinthToolBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.zoomControls.ResumeLayout(false);
            this.zoomControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.mapToolStrip.ResumeLayout(false);
            this.mapToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton targetBtn;
        private System.Windows.Forms.ToolStripButton roamBtn;
        private System.Windows.Forms.ToolStripLabel mapLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel modeLabel;
        private System.Windows.Forms.ToolStripLabel modeSelection;
        private System.Windows.Forms.ToolStrip labyrinthToolBar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton clearBtn;
        private System.Windows.Forms.ToolStripButton loadBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton eraseBtn;
        private System.Windows.Forms.ToolStripButton drawBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip mapToolStrip;
        private System.Windows.Forms.GroupBox zoomControls;
        private System.Windows.Forms.Button zoomOutBtn;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.TrackBar zoomTrackBar;
    }
}

