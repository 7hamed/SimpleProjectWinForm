using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_EmployeeManagement
{
    public partial class frmChangeBackColor : frmBase
    {
        public frmChangeBackColor()
        {
            InitializeComponent();
        }

        private void updateLabelValues()
        {
            lblRedValue.Text = trackBarRed.Value.ToString();
            lblGreenValue.Text = trackBarGreen.Value.ToString();
            lblBlueValue.Text = trackBarBlue.Value.ToString();
        }

        private void updateBaseFormBackColor()
        {
            sharedBackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);

            foreach (Form f in Application.OpenForms)
            {
                if (f is frmBase form)
                {
                    form.BackColor = sharedBackColor;
                }
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            updateLabelValues();
            updateBaseFormBackColor();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            updateLabelValues();
            updateBaseFormBackColor();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            updateLabelValues();
            updateBaseFormBackColor();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
