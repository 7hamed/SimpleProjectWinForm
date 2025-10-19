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
    public partial class frmBase : Form
    {
        static protected Color sharedBackColor = Color.WhiteSmoke;
        
        public frmBase()
        {
            InitializeComponent();
            this.BackColor = sharedBackColor;
        }

        protected void updateFormBackColor()
        {
            this.BackColor = sharedBackColor;
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            
        }
    }
}
