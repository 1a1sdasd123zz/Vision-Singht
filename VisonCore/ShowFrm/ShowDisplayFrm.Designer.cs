using Cognex.VisionPro;

namespace VisionCore.ShowFrm;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cog_ShowRecordDisplay = new Cognex.VisionPro.CogRecordDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.grc_ShowName)).BeginInit();
            this.grc_ShowName.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.grc_ShowName.Controls.Add(this.tableLayoutPanel1);
            this.grc_ShowName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_ShowName.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.grc_ShowName.Location = new System.Drawing.Point(0, 0);
            this.grc_ShowName.Name = "grc_ShowName";
            this.grc_ShowName.Size = new System.Drawing.Size(706, 633);
            this.grc_ShowName.TabIndex = 0;
            this.grc_ShowName.Text = "显示";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cog_ShowRecordDisplay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cog_ShowRecordDisplay
            // 
            this.cog_ShowRecordDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cog_ShowRecordDisplay.ColorMapLowerRoiLimit = 0D;
            this.cog_ShowRecordDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cog_ShowRecordDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cog_ShowRecordDisplay.ColorMapUpperRoiLimit = 1D;
            this.cog_ShowRecordDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cog_ShowRecordDisplay.DoubleTapZoomCycleLength = 2;
            this.cog_ShowRecordDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.cog_ShowRecordDisplay.Location = new System.Drawing.Point(3, 3);
            this.cog_ShowRecordDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cog_ShowRecordDisplay.MouseWheelSensitivity = 1D;
            this.cog_ShowRecordDisplay.Name = "cog_ShowRecordDisplay";
            this.cog_ShowRecordDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cog_ShowRecordDisplay.OcxState")));
            this.cog_ShowRecordDisplay.Size = new System.Drawing.Size(700, 594);
            this.cog_ShowRecordDisplay.TabIndex = 2;
            this.cog_ShowRecordDisplay.DoubleClick += new System.EventHandler(this.cog_ShowRecordDisplay_DoubleClick);
            // 
            // ShowDisplayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grc_ShowName);
            this.Name = "ShowDisplayFrm";
            this.Size = new System.Drawing.Size(706, 633);
            this.Load += new System.EventHandler(this.ShowDisplayFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grc_ShowName)).EndInit();
            this.grc_ShowName.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cog_ShowRecordDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

  }

  #endregion

    private DevExpress.XtraEditors.GroupControl grc_ShowName;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  private CogRecordDisplay cog_ShowRecordDisplay;
}
