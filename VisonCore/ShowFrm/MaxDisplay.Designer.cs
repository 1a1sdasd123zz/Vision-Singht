namespace VisionCore.ShowFrm
{
    partial class MaxDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaxDisplay));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cogDisplayToolStrip1 = new Cognex.VisionPro.CogDisplayToolStrip();
            this.cogDisplayStatusBarV21 = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.cog_RecordDisplay = new Cognex.VisionPro.CogRecordDisplay();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cog_RecordDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cogDisplayToolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cogDisplayStatusBarV21, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cog_RecordDisplay, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 733);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cogDisplayToolStrip1
            // 
            this.cogDisplayToolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.cogDisplayToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cogDisplayToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cogDisplayToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cogDisplayToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.cogDisplayToolStrip1.Name = "cogDisplayToolStrip1";
            this.cogDisplayToolStrip1.Size = new System.Drawing.Size(895, 40);
            this.cogDisplayToolStrip1.TabIndex = 0;
            this.cogDisplayToolStrip1.Text = "cogDisplayToolStrip1";
            // 
            // cogDisplayStatusBarV21
            // 
            this.cogDisplayStatusBarV21.CoordinateSpaceName = "*\\#";
            this.cogDisplayStatusBarV21.CoordinateSpaceName3D = "*\\#";
            this.cogDisplayStatusBarV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayStatusBarV21.Location = new System.Drawing.Point(3, 711);
            this.cogDisplayStatusBarV21.Name = "cogDisplayStatusBarV21";
            this.cogDisplayStatusBarV21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cogDisplayStatusBarV21.Size = new System.Drawing.Size(889, 19);
            this.cogDisplayStatusBarV21.TabIndex = 1;
            this.cogDisplayStatusBarV21.Use3DCoordinateSpaceTree = false;
            // 
            // cog_RecordDisplay
            // 
            this.cog_RecordDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cog_RecordDisplay.ColorMapLowerRoiLimit = 0D;
            this.cog_RecordDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cog_RecordDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cog_RecordDisplay.ColorMapUpperRoiLimit = 1D;
            this.cog_RecordDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cog_RecordDisplay.DoubleTapZoomCycleLength = 2;
            this.cog_RecordDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.cog_RecordDisplay.Location = new System.Drawing.Point(3, 43);
            this.cog_RecordDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cog_RecordDisplay.MouseWheelSensitivity = 1D;
            this.cog_RecordDisplay.Name = "cog_RecordDisplay";
            this.cog_RecordDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cog_RecordDisplay.OcxState")));
            this.cog_RecordDisplay.Size = new System.Drawing.Size(889, 662);
            this.cog_RecordDisplay.TabIndex = 2;
            // 
            // MaxDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 733);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MaxDisplay";
            this.Text = "MaxDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaxDisplay_FormClosed);
            this.Shown += new System.EventHandler(this.MaxDisplay_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cog_RecordDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Cognex.VisionPro.CogDisplayToolStrip cogDisplayToolStrip1;
        private Cognex.VisionPro.CogDisplayStatusBarV2 cogDisplayStatusBarV21;
        private Cognex.VisionPro.CogRecordDisplay cog_RecordDisplay;
    }
}