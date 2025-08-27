namespace VisonCore.ShowFrm
{
  partial class ShowDisplayFrm
  {
    /// <summary> 
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region 组件设计器生成的代码

    /// <summary> 
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDisplayFrm));
            this.grc_ShowName = new DevExpress.XtraEditors.GroupControl();
            this.cogDisplayToolStrip1 = new Cognex.VisionPro.CogDisplayToolStrip();
            this.cogDisplayStatusBarV21 = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.cog_ShowRecordDisplay = new Cognex.VisionPro.CogRecordDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.grc_ShowName)).BeginInit();
            this.grc_ShowName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cog_ShowRecordDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // grc_ShowName
            // 
            this.grc_ShowName.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grc_ShowName.Appearance.Options.UseBackColor = true;
            this.grc_ShowName.Appearance.Options.UseBorderColor = true;
            this.grc_ShowName.Appearance.Options.UseForeColor = true;
            this.grc_ShowName.AppearanceCaption.BorderColor = System.Drawing.Color.Black;
            this.grc_ShowName.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grc_ShowName.AppearanceCaption.ForeColor = System.Drawing.Color.Transparent;
            this.grc_ShowName.AppearanceCaption.Options.UseBorderColor = true;
            this.grc_ShowName.AppearanceCaption.Options.UseFont = true;
            this.grc_ShowName.AppearanceCaption.Options.UseForeColor = true;
            this.grc_ShowName.AutoSize = true;
            this.grc_ShowName.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grc_ShowName.CaptionImageOptions.Image")));
            this.grc_ShowName.Controls.Add(this.tablePanel1);
            this.grc_ShowName.Controls.Add(this.cogDisplayToolStrip1);
            this.grc_ShowName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_ShowName.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.grc_ShowName.Location = new System.Drawing.Point(0, 0);
            this.grc_ShowName.Name = "grc_ShowName";
            this.grc_ShowName.Size = new System.Drawing.Size(706, 633);
            this.grc_ShowName.TabIndex = 0;
            this.grc_ShowName.Text = "显示";
            // 
            // cogDisplayToolStrip1
            // 
            this.cogDisplayToolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.cogDisplayToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cogDisplayToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cogDisplayToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cogDisplayToolStrip1.Location = new System.Drawing.Point(0, 33);
            this.cogDisplayToolStrip1.Name = "cogDisplayToolStrip1";
            this.cogDisplayToolStrip1.Size = new System.Drawing.Size(706, 38);
            this.cogDisplayToolStrip1.TabIndex = 2;
            this.cogDisplayToolStrip1.Text = "cogDisplayToolStrip1";
            // 
            // cogDisplayStatusBarV21
            // 
            this.tablePanel1.SetColumn(this.cogDisplayStatusBarV21, 0);
            this.cogDisplayStatusBarV21.CoordinateSpaceName = "*\\#";
            this.cogDisplayStatusBarV21.CoordinateSpaceName3D = "*\\#";
            this.cogDisplayStatusBarV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayStatusBarV21.Location = new System.Drawing.Point(19, 515);
            this.cogDisplayStatusBarV21.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cogDisplayStatusBarV21.Name = "cogDisplayStatusBarV21";
            this.cogDisplayStatusBarV21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablePanel1.SetRow(this.cogDisplayStatusBarV21, 1);
            this.cogDisplayStatusBarV21.Size = new System.Drawing.Size(668, 26);
            this.cogDisplayStatusBarV21.TabIndex = 3;
            this.cogDisplayStatusBarV21.Use3DCoordinateSpaceTree = false;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.cog_ShowRecordDisplay);
            this.tablePanel1.Controls.Add(this.cogDisplayStatusBarV21);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 71);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 494.666F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(706, 562);
            this.tablePanel1.TabIndex = 4;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // cog_ShowRecordDisplay
            // 
            this.cog_ShowRecordDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cog_ShowRecordDisplay.ColorMapLowerRoiLimit = 0D;
            this.cog_ShowRecordDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cog_ShowRecordDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cog_ShowRecordDisplay.ColorMapUpperRoiLimit = 1D;
            this.tablePanel1.SetColumn(this.cog_ShowRecordDisplay, 0);
            this.cog_ShowRecordDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cog_ShowRecordDisplay.DoubleTapZoomCycleLength = 2;
            this.cog_ShowRecordDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.cog_ShowRecordDisplay.Location = new System.Drawing.Point(19, 18);
            this.cog_ShowRecordDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cog_ShowRecordDisplay.MouseWheelSensitivity = 1D;
            this.cog_ShowRecordDisplay.Name = "cog_ShowRecordDisplay";
            this.cog_ShowRecordDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cog_ShowRecordDisplay.OcxState")));
            this.tablePanel1.SetRow(this.cog_ShowRecordDisplay, 0);
            this.cog_ShowRecordDisplay.Size = new System.Drawing.Size(668, 489);
            this.cog_ShowRecordDisplay.TabIndex = 4;
            // 
            // ShowDisplayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grc_ShowName);
            this.Name = "ShowDisplayFrm";
            this.Size = new System.Drawing.Size(706, 633);
            ((System.ComponentModel.ISupportInitialize)(this.grc_ShowName)).EndInit();
            this.grc_ShowName.ResumeLayout(false);
            this.grc_ShowName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cog_ShowRecordDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.GroupControl grc_ShowName;
        private Cognex.VisionPro.CogDisplayToolStrip cogDisplayToolStrip1;
    private Cognex.VisionPro.CogDisplayStatusBarV2 cogDisplayStatusBarV21;
    private DevExpress.Utils.Layout.TablePanel tablePanel1;
    private Cognex.VisionPro.CogRecordDisplay cog_ShowRecordDisplay;
  }
}
