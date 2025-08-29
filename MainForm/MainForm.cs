using System;
using System.IO;
using System.Windows.Forms;
using HardWareNet;
using Share;
using ToolBar = VisionCore.CoreFrm.Toolbar;

namespace Vision_Sight;
public partial class MainForm : Form
{
    readonly Frm_Splash frm_Splash = new();
    private ToolBar frm_Toolbar;

    public MainForm()
    {
        InitializeComponent();
        frmLayout();
    }
    private void MainForm_Load(object sender, EventArgs e)
    {

        frm_Splash.Show();
        frm_Splash.lbl_Splash.Text = "系统启动中……";
        frm_Splash.lbl_Splash.Refresh();
        //if (!HslCommunication.Authorization.SetAuthorizationCode("cc792fa4-0c45-4748-a1d9-a18db8c5c3ab"))
        //{
        //    MessageBox.Show(@"通信组件授权失败！请联系厂商！");
        //    string logmsg = "PLC 通讯组件授权失败";
        //    MessageBox.Show(logmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    return;
        //}
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
        frm_Splash.lbl_Splash.Text = "相机加载中……";
        frm_Splash.lbl_Splash.Refresh();
        HardCamera.Instance.Initialization();
        frm_Splash.lbl_Splash.Text = "相机完成……";
        frm_Splash.Close();
        WindowState = FormWindowState.Maximized;
    }

    #region 视图

    private void frmLayout()
    {
        DefaultView();
        frm_Toolbar = new ToolBar();
        frm_Toolbar.Dock = DockStyle.Fill;
        dev_ToolPanel.Controls.Add(frm_Toolbar);
        dev_ToolPanel.Refresh();
    }
    private void DefaultView()
    {
        try
        {
            string path =
                Path.Combine(
                    Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly()?.Location) ?? string.Empty,
                    "Layout\\DefaultLayout.xml");
            dev_MainDockManager.RestoreLayoutFromXml(path);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    /// <summary>
    /// 递归遍历所有控件，对实现了IRestorable的控件执行恢复操作
    /// </summary>
    private void RestoreAllControls(Control.ControlCollection controls)
    {
        foreach (Control control in controls)
        {
            if (control is IRestorable restorable)
            {
                restorable.RestoreToDefault();
            }

            // 递归处理嵌套控件
            if (control.Controls.Count > 0)
            {
                RestoreAllControls(control.Controls);
            }
        }
    }

    private void btn_DefaultView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        //RestoreAllControls(this.Controls);
        DefaultView();
    }

    #endregion

    private void btn_ShowTool_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        //frm_Toolbar.RestoreToDefault();
    }

    private void btn_HardwareCamera_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        var frm = HardCamera.Instance.frm_Camera2D;
        frm.ShowDialog();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        HardCamera.Instance.Unitialization();
    }
}
