namespace HardWareNet.Frm
{
  partial class Frm_Camera2D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Camera2D));
            this.split_Display = new DevExpress.XtraEditors.SplitContainerControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Continuous = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TriggerOnce = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Connect = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmb_HardSource = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_MaxExposure = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.chk_Hard = new DevExpress.XtraEditors.CheckEdit();
            this.chk_Soft = new DevExpress.XtraEditors.CheckEdit();
            this.txt_MaxGain = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Exposure = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Gain = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_SnList = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pnl_DevInfo = new DevExpress.XtraEditors.PanelControl();
            this.txt_ManufacturerName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ModelName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_UserDefinedName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tabPanel_Main = new DevExpress.Utils.Layout.TablePanel();
            this.user_ShowDisplay = new Cognex.VisionPro.Display.CogDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.split_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split_Display.Panel1)).BeginInit();
            this.split_Display.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Display.Panel2)).BeginInit();
            this.split_Display.Panel2.SuspendLayout();
            this.split_Display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HardSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Hard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Soft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Exposure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Gain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SnList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_DevInfo)).BeginInit();
            this.pnl_DevInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel_Main)).BeginInit();
            this.tabPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_ShowDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // split_Display
            // 
            this.split_Display.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.split_Display.Appearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.split_Display.Appearance.Options.UseBackColor = true;
            this.split_Display.Appearance.Options.UseBorderColor = true;
            this.split_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_Display.Location = new System.Drawing.Point(19, 18);
            this.split_Display.Name = "split_Display";
            // 
            // split_Display.Panel1
            // 
            this.split_Display.Panel1.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.split_Display.Panel1.Appearance.Options.UseBackColor = true;
            this.split_Display.Panel1.Controls.Add(this.tablePanel1);
            this.split_Display.Panel1.Text = "Panel1";
            // 
            // split_Display.Panel2
            // 
            this.split_Display.Panel2.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.split_Display.Panel2.Appearance.Options.UseBackColor = true;
            this.split_Display.Panel2.Controls.Add(this.user_ShowDisplay);
            this.split_Display.Panel2.Text = "Panel2";
            this.split_Display.Size = new System.Drawing.Size(1373, 683);
            this.split_Display.SplitterPosition = 621;
            this.split_Display.TabIndex = 2;
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.panelControl1);
            this.tablePanel1.Controls.Add(this.panelControl3);
            this.tablePanel1.Controls.Add(this.panelControl2);
            this.tablePanel1.Controls.Add(this.pnl_DevInfo);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 130.6667F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 206.6669F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 224.666F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(621, 683);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelControl1, 0);
            this.panelControl1.Controls.Add(this.btn_Continuous);
            this.panelControl1.Controls.Add(this.btn_TriggerOnce);
            this.panelControl1.Controls.Add(this.btn_Close);
            this.panelControl1.Controls.Add(this.btn_Connect);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(19, 581);
            this.panelControl1.Name = "panelControl1";
            this.tablePanel1.SetRow(this.panelControl1, 3);
            this.panelControl1.Size = new System.Drawing.Size(583, 83);
            this.panelControl1.TabIndex = 14;
            // 
            // btn_Continuous
            // 
            this.btn_Continuous.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Continuous.Appearance.Options.UseBackColor = true;
            this.btn_Continuous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Continuous.Location = new System.Drawing.Point(440, 21);
            this.btn_Continuous.Name = "btn_Continuous";
            this.btn_Continuous.Size = new System.Drawing.Size(112, 34);
            this.btn_Continuous.TabIndex = 3;
            this.btn_Continuous.Text = "连续采集";
            this.btn_Continuous.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // btn_TriggerOnce
            // 
            this.btn_TriggerOnce.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_TriggerOnce.Appearance.Options.UseBackColor = true;
            this.btn_TriggerOnce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TriggerOnce.Location = new System.Drawing.Point(306, 21);
            this.btn_TriggerOnce.Name = "btn_TriggerOnce";
            this.btn_TriggerOnce.Size = new System.Drawing.Size(112, 34);
            this.btn_TriggerOnce.TabIndex = 2;
            this.btn_TriggerOnce.Text = "软触发一次";
            this.btn_TriggerOnce.Click += new System.EventHandler(this.btn_TriggerOnce_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Close.Appearance.Options.UseBackColor = true;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(157, 21);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 34);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "断开";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Connect.Appearance.Options.UseBackColor = true;
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Connect.Location = new System.Drawing.Point(12, 21);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(112, 34);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelControl3, 0);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(19, 149);
            this.panelControl3.Name = "panelControl3";
            this.tablePanel1.SetRow(this.panelControl3, 1);
            this.panelControl3.Size = new System.Drawing.Size(583, 201);
            this.panelControl3.TabIndex = 25;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelControl2, 0);
            this.panelControl2.Controls.Add(this.cmb_HardSource);
            this.panelControl2.Controls.Add(this.txt_MaxExposure);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.chk_Hard);
            this.panelControl2.Controls.Add(this.chk_Soft);
            this.panelControl2.Controls.Add(this.txt_MaxGain);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txt_Exposure);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txt_Gain);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.cmb_SnList);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(19, 356);
            this.panelControl2.Name = "panelControl2";
            this.tablePanel1.SetRow(this.panelControl2, 2);
            this.panelControl2.Size = new System.Drawing.Size(583, 219);
            this.panelControl2.TabIndex = 13;
            // 
            // cmb_HardSource
            // 
            this.cmb_HardSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_HardSource.Location = new System.Drawing.Point(363, 12);
            this.cmb_HardSource.Name = "cmb_HardSource";
            this.cmb_HardSource.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_HardSource.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmb_HardSource.Properties.Appearance.Options.UseBackColor = true;
            this.cmb_HardSource.Properties.Appearance.Options.UseForeColor = true;
            this.cmb_HardSource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_HardSource.Properties.DropDownRows = 3;
            this.cmb_HardSource.Properties.PopupSizeable = true;
            this.cmb_HardSource.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_HardSource.Size = new System.Drawing.Size(140, 28);
            this.cmb_HardSource.TabIndex = 19;
            this.cmb_HardSource.SelectedIndexChanged += new System.EventHandler(this.cmb_HardSource_SelectedIndexChanged);
            // 
            // txt_MaxExposure
            // 
            this.txt_MaxExposure.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_MaxExposure.Appearance.Options.UseForeColor = true;
            this.txt_MaxExposure.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_MaxExposure.Location = new System.Drawing.Point(443, 118);
            this.txt_MaxExposure.Name = "txt_MaxExposure";
            this.txt_MaxExposure.Size = new System.Drawing.Size(10, 22);
            this.txt_MaxExposure.TabIndex = 18;
            this.txt_MaxExposure.Text = "0";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl9.Location = new System.Drawing.Point(348, 118);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 22);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "最大曝光:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl8.Location = new System.Drawing.Point(234, 119);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 22);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "us";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl7.Location = new System.Drawing.Point(234, 163);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(20, 22);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "db";
            // 
            // chk_Hard
            // 
            this.chk_Hard.Location = new System.Drawing.Point(228, 62);
            this.chk_Hard.Name = "chk_Hard";
            this.chk_Hard.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.chk_Hard.Properties.Appearance.Options.UseForeColor = true;
            this.chk_Hard.Properties.Caption = "硬触发";
            this.chk_Hard.Size = new System.Drawing.Size(112, 27);
            this.chk_Hard.TabIndex = 14;
            this.chk_Hard.CheckedChanged += new System.EventHandler(this.chk_Hard_CheckedChanged);
            // 
            // chk_Soft
            // 
            this.chk_Soft.Enabled = false;
            this.chk_Soft.Location = new System.Drawing.Point(102, 62);
            this.chk_Soft.Name = "chk_Soft";
            this.chk_Soft.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.chk_Soft.Properties.Appearance.Options.UseForeColor = true;
            this.chk_Soft.Properties.Caption = "软触发";
            this.chk_Soft.Size = new System.Drawing.Size(112, 27);
            this.chk_Soft.TabIndex = 13;
            this.chk_Soft.Visible = false;
            // 
            // txt_MaxGain
            // 
            this.txt_MaxGain.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_MaxGain.Appearance.Options.UseForeColor = true;
            this.txt_MaxGain.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_MaxGain.Location = new System.Drawing.Point(443, 162);
            this.txt_MaxGain.Name = "txt_MaxGain";
            this.txt_MaxGain.Size = new System.Drawing.Size(10, 22);
            this.txt_MaxGain.TabIndex = 12;
            this.txt_MaxGain.Text = "0";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl5.Location = new System.Drawing.Point(348, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 22);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "最大增益:";
            // 
            // txt_Exposure
            // 
            this.txt_Exposure.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Exposure.Location = new System.Drawing.Point(102, 117);
            this.txt_Exposure.Name = "txt_Exposure";
            this.txt_Exposure.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Exposure.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_Exposure.Properties.Appearance.Options.UseBackColor = true;
            this.txt_Exposure.Properties.Appearance.Options.UseForeColor = true;
            this.txt_Exposure.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Exposure.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_Exposure.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_Exposure.Properties.MaskSettings.Set("mask", "f3");
            this.txt_Exposure.Properties.MaxValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txt_Exposure.Size = new System.Drawing.Size(123, 28);
            this.txt_Exposure.TabIndex = 7;
            this.txt_Exposure.EditValueChanged += new System.EventHandler(this.txt_Exposure_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl4.Location = new System.Drawing.Point(39, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 22);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "增益";
            // 
            // txt_Gain
            // 
            this.txt_Gain.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Gain.Location = new System.Drawing.Point(102, 161);
            this.txt_Gain.Name = "txt_Gain";
            this.txt_Gain.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Gain.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_Gain.Properties.Appearance.Options.UseBackColor = true;
            this.txt_Gain.Properties.Appearance.Options.UseForeColor = true;
            this.txt_Gain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Gain.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_Gain.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_Gain.Properties.MaskSettings.Set("mask", "f3");
            this.txt_Gain.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_Gain.Size = new System.Drawing.Size(123, 28);
            this.txt_Gain.TabIndex = 9;
            this.txt_Gain.EditValueChanged += new System.EventHandler(this.txt_Gain_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "相机列表";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl3.Location = new System.Drawing.Point(39, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 22);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "曝光";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl2.Location = new System.Drawing.Point(3, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "触发模式";
            // 
            // cmb_SnList
            // 
            this.cmb_SnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_SnList.Location = new System.Drawing.Point(102, 12);
            this.cmb_SnList.Name = "cmb_SnList";
            this.cmb_SnList.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_SnList.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmb_SnList.Properties.Appearance.Options.UseBackColor = true;
            this.cmb_SnList.Properties.Appearance.Options.UseForeColor = true;
            this.cmb_SnList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_SnList.Properties.DropDownRows = 20;
            this.cmb_SnList.Properties.PopupSizeable = true;
            this.cmb_SnList.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_SnList.Size = new System.Drawing.Size(238, 28);
            this.cmb_SnList.TabIndex = 4;
            this.cmb_SnList.SelectedIndexChanged += new System.EventHandler(this.cmb_SnList_SelectedIndexChanged);
            // 
            // pnl_DevInfo
            // 
            this.pnl_DevInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_DevInfo.Appearance.Options.UseBackColor = true;
            this.pnl_DevInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.pnl_DevInfo, 0);
            this.pnl_DevInfo.Controls.Add(this.txt_ManufacturerName);
            this.pnl_DevInfo.Controls.Add(this.labelControl13);
            this.pnl_DevInfo.Controls.Add(this.txt_ModelName);
            this.pnl_DevInfo.Controls.Add(this.labelControl11);
            this.pnl_DevInfo.Controls.Add(this.txt_UserDefinedName);
            this.pnl_DevInfo.Controls.Add(this.labelControl6);
            this.pnl_DevInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_DevInfo.Location = new System.Drawing.Point(19, 18);
            this.pnl_DevInfo.Name = "pnl_DevInfo";
            this.tablePanel1.SetRow(this.pnl_DevInfo, 0);
            this.pnl_DevInfo.Size = new System.Drawing.Size(583, 125);
            this.pnl_DevInfo.TabIndex = 3;
            // 
            // txt_ManufacturerName
            // 
            this.txt_ManufacturerName.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_ManufacturerName.Appearance.Options.UseForeColor = true;
            this.txt_ManufacturerName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_ManufacturerName.Location = new System.Drawing.Point(114, 88);
            this.txt_ManufacturerName.Name = "txt_ManufacturerName";
            this.txt_ManufacturerName.Size = new System.Drawing.Size(18, 22);
            this.txt_ManufacturerName.TabIndex = 24;
            this.txt_ManufacturerName.Text = "无";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl13.Location = new System.Drawing.Point(23, 88);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(36, 22);
            this.labelControl13.TabIndex = 23;
            this.labelControl13.Text = "厂商";
            // 
            // txt_ModelName
            // 
            this.txt_ModelName.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_ModelName.Appearance.Options.UseForeColor = true;
            this.txt_ModelName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_ModelName.Location = new System.Drawing.Point(114, 49);
            this.txt_ModelName.Name = "txt_ModelName";
            this.txt_ModelName.Size = new System.Drawing.Size(18, 22);
            this.txt_ModelName.TabIndex = 22;
            this.txt_ModelName.Text = "无";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl11.Location = new System.Drawing.Point(23, 49);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(36, 22);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "型号";
            // 
            // txt_UserDefinedName
            // 
            this.txt_UserDefinedName.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_UserDefinedName.Appearance.Options.UseForeColor = true;
            this.txt_UserDefinedName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txt_UserDefinedName.Location = new System.Drawing.Point(114, 12);
            this.txt_UserDefinedName.Name = "txt_UserDefinedName";
            this.txt_UserDefinedName.Size = new System.Drawing.Size(18, 22);
            this.txt_UserDefinedName.TabIndex = 20;
            this.txt_UserDefinedName.Text = "无";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl6.Location = new System.Drawing.Point(23, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 22);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "设备名称:";
            // 
            // tabPanel_Main
            // 
            this.tabPanel_Main.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tabPanel_Main.Controls.Add(this.split_Display);
            this.tabPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tabPanel_Main.Name = "tabPanel_Main";
            this.tabPanel_Main.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 602.0003F)});
            this.tabPanel_Main.Size = new System.Drawing.Size(1411, 720);
            this.tabPanel_Main.TabIndex = 2;
            this.tabPanel_Main.UseSkinIndents = true;
            // 
            // user_ShowDisplay
            // 
            this.user_ShowDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.user_ShowDisplay.ColorMapLowerRoiLimit = 0D;
            this.user_ShowDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.user_ShowDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.user_ShowDisplay.ColorMapUpperRoiLimit = 1D;
            this.user_ShowDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_ShowDisplay.DoubleTapZoomCycleLength = 2;
            this.user_ShowDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.user_ShowDisplay.Location = new System.Drawing.Point(0, 0);
            this.user_ShowDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.user_ShowDisplay.MouseWheelSensitivity = 1D;
            this.user_ShowDisplay.Name = "user_ShowDisplay";
            this.user_ShowDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("user_ShowDisplay.OcxState")));
            this.user_ShowDisplay.Size = new System.Drawing.Size(737, 683);
            this.user_ShowDisplay.TabIndex = 0;
            // 
            // Frm_Camera2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1411, 720);
            this.Controls.Add(this.tabPanel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Camera2D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "面阵相机测试界面";
            this.Load += new System.EventHandler(this.Frm_Camera2D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.split_Display.Panel1)).EndInit();
            this.split_Display.Panel1.ResumeLayout(false);
            this.split_Display.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_Display.Panel2)).EndInit();
            this.split_Display.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_Display)).EndInit();
            this.split_Display.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HardSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Hard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Soft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Exposure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Gain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SnList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_DevInfo)).EndInit();
            this.pnl_DevInfo.ResumeLayout(false);
            this.pnl_DevInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel_Main)).EndInit();
            this.tabPanel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_ShowDisplay)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private DevExpress.XtraEditors.SplitContainerControl split_Display;
    private DevExpress.Utils.Layout.TablePanel tablePanel1;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.SimpleButton btn_Continuous;
    private DevExpress.XtraEditors.SimpleButton btn_TriggerOnce;
    private DevExpress.XtraEditors.SimpleButton btn_Close;
    private DevExpress.XtraEditors.SimpleButton btn_Connect;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.LabelControl txt_MaxExposure;
    private DevExpress.XtraEditors.LabelControl labelControl9;
    private DevExpress.XtraEditors.LabelControl labelControl8;
    private DevExpress.XtraEditors.LabelControl labelControl7;
    private DevExpress.XtraEditors.CheckEdit chk_Hard;
    private DevExpress.XtraEditors.CheckEdit chk_Soft;
    private DevExpress.XtraEditors.LabelControl txt_MaxGain;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.SpinEdit txt_Exposure;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.SpinEdit txt_Gain;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.ComboBoxEdit cmb_SnList;
    private DevExpress.XtraEditors.PanelControl pnl_DevInfo;
    private DevExpress.XtraEditors.LabelControl txt_ManufacturerName;
    private DevExpress.XtraEditors.LabelControl labelControl13;
    private DevExpress.XtraEditors.LabelControl txt_ModelName;
    private DevExpress.XtraEditors.LabelControl labelControl11;
    private DevExpress.XtraEditors.LabelControl txt_UserDefinedName;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.Utils.Layout.TablePanel tabPanel_Main;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_HardSource;
    private Cognex.VisionPro.Display.CogDisplay user_ShowDisplay;
  }
}