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
    public partial class MaxDisplay : Form
    {
        ICogRecord CogRecord;
        public MaxDisplay(ICogRecord record)
        {
            InitializeComponent();
            CogRecord = record;
        }

        private void MaxDisplay_Shown(object sender, EventArgs e)
        {
            cog_RecordDisplay.Record = CogRecord;
            cog_RecordDisplay.AutoFit = true;
        }

        private void MaxDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            CogRecord = null;
        }
    }
}
