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
    public ICogImage ContinuousShowImage
    {
        get => cog_ShowRecordDisplay.Image;
        set
        {
            cog_ShowRecordDisplay.StaticGraphics.Clear();
            cog_ShowRecordDisplay.InteractiveGraphics.Clear();
            cog_ShowRecordDisplay.Image = value;
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
        //SetControls();
    }
    private void SetControls()
    { 
        cog_ShowRecordDisplay = new CogRecordDisplay();
        cog_ShowRecordDisplay.Dock = DockStyle.Fill;
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
        //this.cog_ShowRecordDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cog_ShowRecordDisplay.OcxState")));
        this.tablePanel1.SetRow(this.cog_ShowRecordDisplay, 0);
        this.cog_ShowRecordDisplay.Size = new System.Drawing.Size(668, 489);
        this.cog_ShowRecordDisplay.TabIndex = 4;
        tablePanel1.Controls.Add(cog_ShowRecordDisplay);
    }
}

