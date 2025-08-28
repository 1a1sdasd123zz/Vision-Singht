using Cognex.VisionPro;

namespace VisionCore.ShowFrm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDisplayFrm));
      this.grc_ShowName = new DevExpress.XtraEditors.GroupControl();
      this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
      ((System.ComponentModel.ISupportInitialize)(this.grc_ShowName)).BeginInit();
      this.grc_ShowName.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
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
      this.grc_ShowName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grc_ShowName.GroupStyle = DevExpress.Utils.GroupStyle.Title;
      this.grc_ShowName.Location = new System.Drawing.Point(0, 0);
      this.grc_ShowName.Name = "grc_ShowName";
      this.grc_ShowName.Size = new System.Drawing.Size(706, 633);
      this.grc_ShowName.TabIndex = 0;
      this.grc_ShowName.Text = "显示";
      // 
      // tablePanel1
      // 
      this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
      this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tablePanel1.Location = new System.Drawing.Point(0, 33);
      this.tablePanel1.Name = "tablePanel1";
      this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 494.666F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
      this.tablePanel1.Size = new System.Drawing.Size(706, 600);
      this.tablePanel1.TabIndex = 4;
      this.tablePanel1.UseSkinIndents = true;
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
      ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.GroupControl grc_ShowName;
    private DevExpress.Utils.Layout.TablePanel tablePanel1;
    private CogRecordDisplay cog_ShowRecordDisplay;
  }
}
