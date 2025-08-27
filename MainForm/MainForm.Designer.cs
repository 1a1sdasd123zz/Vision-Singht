namespace Vision_Sight
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.dev_MainBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.dx_ToolBar = new DevExpress.XtraBars.Bar();
            this.dev_MainStatusBar = new DevExpress.XtraBars.Bar();
            this.dev_MainMenuBar = new DevExpress.XtraBars.Bar();
            this.btn_Login = new DevExpress.XtraBars.BarButtonItem();
            this.btn_View = new DevExpress.XtraBars.BarSubItem();
            this.btn_DefaultView = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ShowTool = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dev_MainDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dev_ToolPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dev_WorkPressPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dev_ViewPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dev_HardStatusPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dev_LogPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer2 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.dev_DataPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer3 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentGroup2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.btn_HardwareCamera = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dev_MainBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dev_MainDockManager)).BeginInit();
            this.dev_ToolPanel.SuspendLayout();
            this.dev_WorkPressPanel.SuspendLayout();
            this.dev_ViewPanel.SuspendLayout();
            this.dev_HardStatusPanel.SuspendLayout();
            this.dev_LogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // dev_MainBarManager
            // 
            this.dev_MainBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.dx_ToolBar,
            this.dev_MainStatusBar,
            this.dev_MainMenuBar});
            this.dev_MainBarManager.DockControls.Add(this.barDockControlTop);
            this.dev_MainBarManager.DockControls.Add(this.barDockControlBottom);
            this.dev_MainBarManager.DockControls.Add(this.barDockControlLeft);
            this.dev_MainBarManager.DockControls.Add(this.barDockControlRight);
            this.dev_MainBarManager.DockManager = this.dev_MainDockManager;
            this.dev_MainBarManager.Form = this;
            this.dev_MainBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Login,
            this.btn_View,
            this.btn_DefaultView,
            this.btn_ShowTool,
            this.btn_HardwareCamera});
            this.dev_MainBarManager.MainMenu = this.dev_MainMenuBar;
            this.dev_MainBarManager.MaxItemId = 18;
            this.dev_MainBarManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4});
            this.dev_MainBarManager.StatusBar = this.dev_MainStatusBar;
            // 
            // dx_ToolBar
            // 
            this.dx_ToolBar.BarName = "工具";
            this.dx_ToolBar.DockCol = 0;
            this.dx_ToolBar.DockRow = 1;
            this.dx_ToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.dx_ToolBar.OptionsBar.DrawBorder = false;
            this.dx_ToolBar.Text = "工具";
            // 
            // dev_MainStatusBar
            // 
            this.dev_MainStatusBar.BarName = "状态栏";
            this.dev_MainStatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.dev_MainStatusBar.DockCol = 0;
            this.dev_MainStatusBar.DockRow = 0;
            this.dev_MainStatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.dev_MainStatusBar.OptionsBar.AllowQuickCustomization = false;
            this.dev_MainStatusBar.OptionsBar.DrawBorder = false;
            this.dev_MainStatusBar.OptionsBar.DrawDragBorder = false;
            this.dev_MainStatusBar.OptionsBar.MultiLine = true;
            this.dev_MainStatusBar.OptionsBar.UseWholeRow = true;
            this.dev_MainStatusBar.Text = "主菜单";
            // 
            // dev_MainMenuBar
            // 
            this.dev_MainMenuBar.BarName = "主菜单";
            this.dev_MainMenuBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.dev_MainMenuBar.DockCol = 0;
            this.dev_MainMenuBar.DockRow = 0;
            this.dev_MainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.dev_MainMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Login),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_View),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_HardwareCamera)});
            this.dev_MainMenuBar.OptionsBar.AllowQuickCustomization = false;
            this.dev_MainMenuBar.OptionsBar.DrawDragBorder = false;
            this.dev_MainMenuBar.OptionsBar.MultiLine = true;
            this.dev_MainMenuBar.OptionsBar.UseWholeRow = true;
            this.dev_MainMenuBar.Text = "状态栏";
            // 
            // btn_Login
            // 
            this.btn_Login.Caption = "登录";
            this.btn_Login.Id = 0;
            this.btn_Login.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Login.ImageOptions.SvgImage")));
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipItem3.Text = "登录";
            superToolTip3.Items.Add(toolTipItem3);
            this.btn_Login.SuperTip = superToolTip3;
            // 
            // btn_View
            // 
            this.btn_View.Caption = "视图";
            this.btn_View.Id = 5;
            this.btn_View.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DefaultView),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ShowTool)});
            this.btn_View.Name = "btn_View";
            // 
            // btn_DefaultView
            // 
            this.btn_DefaultView.Caption = "默认视图";
            this.btn_DefaultView.Id = 6;
            this.btn_DefaultView.Name = "btn_DefaultView";
            this.btn_DefaultView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DefaultView_ItemClick);
            // 
            // btn_ShowTool
            // 
            this.btn_ShowTool.Caption = "工具栏视图";
            this.btn_ShowTool.Id = 14;
            this.btn_ShowTool.Name = "btn_ShowTool";
            this.btn_ShowTool.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ShowTool_CheckedChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.dev_MainBarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1898, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1004);
            this.barDockControlBottom.Manager = this.dev_MainBarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1898, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.dev_MainBarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 949);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1898, 55);
            this.barDockControlRight.Manager = this.dev_MainBarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 949);
            // 
            // dev_MainDockManager
            // 
            this.dev_MainDockManager.Form = this;
            this.dev_MainDockManager.MenuManager = this.dev_MainBarManager;
            this.dev_MainDockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dev_ToolPanel,
            this.dev_WorkPressPanel,
            this.dev_ViewPanel,
            this.dev_HardStatusPanel,
            this.dev_LogPanel});
            this.dev_MainDockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dev_ToolPanel
            // 
            this.dev_ToolPanel.Controls.Add(this.dockPanel1_Container);
            this.dev_ToolPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dev_ToolPanel.ID = new System.Guid("62a04ff1-d691-43b1-a2bc-8b4683ed0b1a");
            this.dev_ToolPanel.Location = new System.Drawing.Point(0, 55);
            this.dev_ToolPanel.Name = "dev_ToolPanel";
            this.dev_ToolPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dev_ToolPanel.Size = new System.Drawing.Size(200, 949);
            this.dev_ToolPanel.Text = "工具栏";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 38);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(189, 907);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dev_WorkPressPanel
            // 
            this.dev_WorkPressPanel.Controls.Add(this.controlContainer1);
            this.dev_WorkPressPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dev_WorkPressPanel.ID = new System.Guid("721b19ba-e49d-401d-8aa4-512545f36408");
            this.dev_WorkPressPanel.Location = new System.Drawing.Point(200, 55);
            this.dev_WorkPressPanel.Name = "dev_WorkPressPanel";
            this.dev_WorkPressPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dev_WorkPressPanel.Size = new System.Drawing.Size(200, 949);
            this.dev_WorkPressPanel.Text = "流程栏";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Location = new System.Drawing.Point(4, 38);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(189, 907);
            this.controlContainer1.TabIndex = 0;
            // 
            // dev_ViewPanel
            // 
            this.dev_ViewPanel.Controls.Add(this.dockPanel2_Container);
            this.dev_ViewPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dev_ViewPanel.FloatVertical = true;
            this.dev_ViewPanel.ID = new System.Guid("fb5b1396-3ac9-4820-93f2-1ccd7a5708a0");
            this.dev_ViewPanel.Location = new System.Drawing.Point(400, 55);
            this.dev_ViewPanel.Name = "dev_ViewPanel";
            this.dev_ViewPanel.OriginalSize = new System.Drawing.Size(200, 683);
            this.dev_ViewPanel.Size = new System.Drawing.Size(1498, 683);
            this.dev_ViewPanel.Text = "显示";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 38);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(1490, 638);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dev_HardStatusPanel
            // 
            this.dev_HardStatusPanel.Controls.Add(this.dockPanel4_Container);
            this.dev_HardStatusPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dev_HardStatusPanel.ID = new System.Guid("3055d933-9df8-462b-b59b-bc49bb673561");
            this.dev_HardStatusPanel.Location = new System.Drawing.Point(1698, 738);
            this.dev_HardStatusPanel.Name = "dev_HardStatusPanel";
            this.dev_HardStatusPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dev_HardStatusPanel.Size = new System.Drawing.Size(200, 266);
            this.dev_HardStatusPanel.Text = "硬件状态";
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Location = new System.Drawing.Point(7, 38);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(189, 224);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // dev_LogPanel
            // 
            this.dev_LogPanel.Controls.Add(this.controlContainer2);
            this.dev_LogPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dev_LogPanel.FloatVertical = true;
            this.dev_LogPanel.ID = new System.Guid("a8f203f8-ceee-43f0-94dc-333a9064d704");
            this.dev_LogPanel.Location = new System.Drawing.Point(400, 738);
            this.dev_LogPanel.Name = "dev_LogPanel";
            this.dev_LogPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dev_LogPanel.Size = new System.Drawing.Size(1298, 266);
            this.dev_LogPanel.Text = "信息栏";
            // 
            // controlContainer2
            // 
            this.controlContainer2.Location = new System.Drawing.Point(4, 38);
            this.controlContainer2.Name = "controlContainer2";
            this.controlContainer2.Size = new System.Drawing.Size(1290, 224);
            this.controlContainer2.TabIndex = 0;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // document1
            // 
            this.document1.Caption = "dockPanel1";
            this.document1.ControlName = "dockPanel1";
            this.document1.ControlTypeName = null;
            this.document1.FloatLocation = new System.Drawing.Point(443, 553);
            this.document1.FloatSize = new System.Drawing.Size(200, 200);
            this.document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // dev_DataPanel
            // 
            this.dev_DataPanel.DockedAsTabbedDocument = true;
            this.dev_DataPanel.FloatLocation = new System.Drawing.Point(651, 241);
            this.dev_DataPanel.FloatSize = new System.Drawing.Size(1290, 225);
            this.dev_DataPanel.ID = new System.Guid("6c882fa4-440c-4f6b-9180-a02c4b3ea3f3");
            this.dev_DataPanel.Name = "dev_DataPanel";
            this.dev_DataPanel.Options.FloatOnDblClick = false;
            this.dev_DataPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dev_DataPanel.SavedIndex = 4;
            this.dev_DataPanel.SavedMdiDocument = true;
            this.dev_DataPanel.SavedMdiDocumentIndex = 1;
            this.dev_DataPanel.Text = "数据栏";
            // 
            // controlContainer3
            // 
            this.controlContainer3.Location = new System.Drawing.Point(0, 0);
            this.controlContainer3.Name = "controlContainer3";
            this.controlContainer3.Size = new System.Drawing.Size(1290, 225);
            this.controlContainer3.TabIndex = 0;
            // 
            // document3
            // 
            this.document3.Caption = "数据栏";
            this.document3.ControlName = "dev_DataPanel";
            this.document3.ControlTypeName = null;
            this.document3.FloatLocation = new System.Drawing.Point(651, 241);
            this.document3.FloatSize = new System.Drawing.Size(1290, 225);
            this.document3.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True;
            this.document3.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
            this.document3.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            // 
            // btn_HardwareCamera
            // 
            this.btn_HardwareCamera.Caption = "相机模块";
            this.btn_HardwareCamera.Id = 17;
            this.btn_HardwareCamera.Name = "btn_HardwareCamera";
            this.btn_HardwareCamera.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HardwareCamera_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.dev_LogPanel);
            this.Controls.Add(this.dev_HardStatusPanel);
            this.Controls.Add(this.dev_ViewPanel);
            this.Controls.Add(this.dev_WorkPressPanel);
            this.Controls.Add(this.dev_ToolPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dev_MainBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dev_MainDockManager)).EndInit();
            this.dev_ToolPanel.ResumeLayout(false);
            this.dev_WorkPressPanel.ResumeLayout(false);
            this.dev_ViewPanel.ResumeLayout(false);
            this.dev_HardStatusPanel.ResumeLayout(false);
            this.dev_LogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager dev_MainBarManager;
        private DevExpress.XtraBars.Bar dx_ToolBar;
        private DevExpress.XtraBars.Bar dev_MainStatusBar;
        private DevExpress.XtraBars.Bar dev_MainMenuBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking.DockManager dev_MainDockManager;
        private DevExpress.XtraBars.BarButtonItem btn_Login;
        private DevExpress.XtraBars.BarSubItem btn_View;
        private DevExpress.XtraBars.BarButtonItem btn_DefaultView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.Docking.DockPanel dev_ToolPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private DevExpress.XtraBars.Docking.DockPanel dev_HardStatusPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraBars.Docking.DockPanel dev_ViewPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dev_WorkPressPanel;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraBars.BarCheckItem btn_ShowTool;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraBars.Docking.DockPanel dev_DataPanel;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer3;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document3;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup2;
        private DevExpress.XtraBars.Docking.DockPanel dev_LogPanel;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer2;
    private DevExpress.XtraBars.BarButtonItem btn_HardwareCamera;
  }
}