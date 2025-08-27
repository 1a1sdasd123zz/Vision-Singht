using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Share;

namespace VisonCore.CoreFrm
{
    public partial class Toolbar : UserControl,IRestorable
    {
        public Toolbar()
        {
            InitializeComponent();
            InitControls();
            //SetToolItem();
        }

        private void InitControls()
        {
            //// 存储所有根节点
            //var rootNodes = new Dictionary<string, TreeListNode>();
            //// 添加根节点
            //rootNodes["图像采集"] = dev_ToolTreeList.AppendNode(
            //    new object[] { "图像采集" },
            //    null
            //);
            //rootNodes["模块工具"] = dev_ToolTreeList.AppendNode(
            //    new object[] { "逻辑工具" },
            //    null
            //);
            //rootNodes["图像采集"] = dev_ToolTreeList.AppendNode(
            //    new object[] { "图像采集" },
            //    null
            //);
            //foreach (TreeListNode node in dev_ToolTreeList.Nodes)
            //{

            //}
            //dev_ToolTreeList.OptionsBehavior.Editable = false; //不可编辑
        }

        private void SetToolItem()
        {
        }
        public void RestoreToDefault()
        {
            //try
            //{
            //    string path =
            //        Path.Combine(
            //            Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly()?.Location) ?? string.Empty,
            //            "Layout\\DefaultLayout.xml");
            //    dev_DockManager.RestoreLayoutFromXml(path);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
            //dev_ToolPanel.Restore();
            //dev_WorkPanel.Restore();
        }
    }
}
