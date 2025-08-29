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
      this.cog_RecordDisplay = new Cognex.VisionPro.CogRecordDisplay();
      ((System.ComponentModel.ISupportInitialize)(this.grc_ShowName)).BeginInit();
      this.grc_ShowName.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cog_RecordDisplay)).BeginInit();
      this.SuspendLayout();
      // 
      // grc_ShowName
      // 
      this.grc_ShowName.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.grc_ShowName.Appearance.Options.UseBackColor = true;
      this.grc_ShowName.Appearance.Options.UseBorderColor = true;
      this.grc_ShowName.Appearance.Options.UseForeColor = true;
      this.grc_ShowName.AppearanceCaption.BorderColor = System.Drawing.Color.SlateBlue;
      this.grc_ShowName.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grc_ShowName.AppearanceCaption.ForeColor = System.Drawing.Color.Transparent;
      this.grc_ShowName.AppearanceCaption.Options.UseBorderColor = true;
      this.grc_ShowName.AppearanceCaption.Options.UseFont = true;
      this.grc_ShowName.AppearanceCaption.Options.UseForeColor = true;
      this.grc_ShowName.AutoSize = true;
      this.grc_ShowName.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grc_ShowName.CaptionImageOptions.Image")));
      this.grc_ShowName.Controls.Add(this.cog_RecordDisplay);
      this.grc_ShowName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grc_ShowName.GroupStyle = DevExpress.Utils.GroupStyle.Title;
      this.grc_ShowName.Location = new System.Drawing.Point(0, 0);
      this.grc_ShowName.Name = "grc_ShowName";
      this.grc_ShowName.Size = new System.Drawing.Size(706, 633);
      this.grc_ShowName.TabIndex = 0;
      this.grc_ShowName.Text = "显示";
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
      this.cog_RecordDisplay.Location = new System.Drawing.Point(0, 33);
      this.cog_RecordDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
      this.cog_RecordDisplay.MouseWheelSensitivity = 1D;
      this.cog_RecordDisplay.Name = "cog_RecordDisplay";
      this.cog_RecordDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cog_RecordDisplay.OcxState")));
      this.cog_RecordDisplay.Size = new System.Drawing.Size(706, 600);
      this.cog_RecordDisplay.TabIndex = 0;
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
      ((System.ComponentModel.ISupportInitialize)(this.cog_RecordDisplay)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

  }

  #endregion

  private DevExpress.XtraEditors.GroupControl grc_ShowName;
  private CogRecordDisplay cog_RecordDisplay;
}