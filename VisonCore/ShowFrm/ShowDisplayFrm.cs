using System;
using System.Drawing;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;

namespace VisionCore.ShowFrm;

public partial class ShowDisplayFrm : UserControl
{
    public string ShowDisplayName
    {
        get => grc_ShowName.Text;
        set => grc_ShowName.Text = value;
    }
    public ICogImage ShowImage
    {
        get => cog_RecordDisplay.Image;
        set
        {
            cog_RecordDisplay.StaticGraphics.Clear();
            cog_RecordDisplay.InteractiveGraphics.Clear();
            cog_RecordDisplay.Image = value;
            cog_RecordDisplay.AutoFit = true;
        }
    }
    public ICogImage ContinuousShowImage
    {
        get => cog_RecordDisplay.Image;
        set
        {
            cog_RecordDisplay.StaticGraphics.Clear();
            cog_RecordDisplay.InteractiveGraphics.Clear();
            cog_RecordDisplay.Image = value;
        }
    }
    public ICogRecord ShowRecord
    {
        get => cog_RecordDisplay.Record;
        set
        {
            cog_RecordDisplay.StaticGraphics.Clear();
            cog_RecordDisplay.InteractiveGraphics.Clear();
            cog_RecordDisplay.Record = value;
            cog_RecordDisplay.AutoFit = true;
        }
    }
    public ShowDisplayFrm()
    {
        InitializeComponent();
    }

    private void ShowDisplayFrm_Load(object sender, EventArgs e)
    {
    }

    private void cog_RecordDisplay_DoubleClick(object sender, EventArgs e)
    {
        var frm = new MaxRecordDisplay(ShowImage);
        frm.Show();
    }
}

