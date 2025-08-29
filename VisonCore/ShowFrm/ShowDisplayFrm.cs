using System.Windows.Forms;
using Cognex.VisionPro;

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
        get => cog_ShowRecordDisplay.Image;
        set
        {
            cog_ShowRecordDisplay.StaticGraphics.Clear();
            cog_ShowRecordDisplay.InteractiveGraphics.Clear();
            cog_ShowRecordDisplay.Image = value;
            cog_ShowRecordDisplay.AutoFit = true;
        }
    }
    public ICogRecord ShowRecord
    {
        get => cog_ShowRecordDisplay.Record;
        set
        {
            cog_ShowRecordDisplay.StaticGraphics.Clear();
            cog_ShowRecordDisplay.InteractiveGraphics.Clear();
            cog_ShowRecordDisplay.Record = value;
            cog_ShowRecordDisplay.AutoFit = true;
        }
    }
    public ShowDisplayFrm()
    {
        InitializeComponent();
    }

    private void ShowDisplayFrm_Load(object sender, System.EventArgs e)
    {
        
    }

    private void cog_ShowRecordDisplay_DoubleClick(object sender, System.EventArgs e)
    {
        var frm = new MaxDisplay(ShowRecord);
        frm.Show();
    }
}

