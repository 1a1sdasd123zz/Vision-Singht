using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionCore.ShowFrm
{
    public partial class MaxRecordDisplay : Form
    {
        private ICogImage cogImage;
        public MaxRecordDisplay(ICogImage cogImage)
        {
            InitializeComponent();
            this.cogImage = cogImage;
        }

        private void MaxRecordDisplay_Shown(object sender, EventArgs e)
        {
            cog_RecordDisplay.Image = cogImage;
            cog_RecordDisplay.AutoFit = true;
        }

        private void MaxRecordDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            cogImage = null;
        }
    }
}
