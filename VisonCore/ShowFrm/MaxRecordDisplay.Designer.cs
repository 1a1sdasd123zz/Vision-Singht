namespace VisionCore.ShowFrm
{
    partial class MaxRecordDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaxRecordDisplay));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cogDisplayStatusBarV21 = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.cog_RecordDisplay = new Cognex.VisionPro.CogRecordDisplay();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cog_RecordDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cogDisplayStatusBarV21, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cog_RecordDisplay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.07207F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.927928F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1228, 888);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cogDisplayStatusBarV21
            // 
            this.cogDisplayStatusBarV21.CoordinateSpaceName = "*\\#";
            this.cogDisplayStatusBarV21.CoordinateSpaceName3D = "*\\#";
            this.cogDisplayStatusBarV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayStatusBarV21.Location = new System.Drawing.Point(3, 865);
            this.cogDisplayStatusBarV21.Name = "cogDisplayStatusBarV21";
            this.cogDisplayStatusBarV21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cogDisplayStatusBarV21.Size = new System.Drawing.Size(1222, 20);
            this.cogDisplayStatusBarV21.TabIndex = 0;
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
            this.cog_RecordDisplay.Location = new System.Drawing.Point(3, 3);
            this.cog_RecordDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cog_RecordDisplay.MouseWheelSensitivity = 1D;
            this.cog_RecordDisplay.Name = "cog_RecordDisplay";
            //this.cog_RecordDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cog_RecordDisplay.OcxState")));
            this.cog_RecordDisplay.Size = new System.Drawing.Size(1222, 856);
            this.cog_RecordDisplay.TabIndex = 1;
            // 
            // MaxRecordDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 888);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MaxRecordDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图像显示";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaxRecordDisplay_FormClosed);
            this.Shown += new System.EventHandler(this.MaxRecordDisplay_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cog_RecordDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Cognex.VisionPro.CogDisplayStatusBarV2 cogDisplayStatusBarV21;
        private Cognex.VisionPro.CogRecordDisplay cog_RecordDisplay;
    }
}