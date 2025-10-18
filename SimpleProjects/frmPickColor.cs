using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_testForms
{
    public partial class frmPickColor : Form
    {
        public frmPickColor()
        {
            InitializeComponent();
        }

        private void updateLabelValues()
        {
            lblRedValue.Text = trackBarRed.Value.ToString();
            lblGreenValue.Text = trackBarGreen.Value.ToString();
            lblBlueValue.Text = trackBarBlue.Value.ToString();
        }

        private void updateFormBackColor()
        {
            this.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            updateLabelValues();
            updateFormBackColor();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            updateLabelValues();
            updateFormBackColor();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            updateLabelValues();
            updateFormBackColor();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            trackBarRed.Value = 255;
            trackBarGreen.Value = 255;
            trackBarBlue.Value = 255;
            
            updateLabelValues();
            updateFormBackColor();

        }
    }
}
