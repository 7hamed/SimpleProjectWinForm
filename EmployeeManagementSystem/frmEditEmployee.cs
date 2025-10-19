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
    public partial class frmEditEmployee : frmBase
    {
        public frmEditEmployee()
        {
            InitializeComponent();

            gbGender.Enabled = false;
            dtpDateOfBirth.Enabled = false;
            txtID.Enabled = false;
        }


        private bool isTextBoxesEmpty()
        {
            return (txtFullName.Text == "" && txtEmail.Text == "" && txtPhone.Text == ""
                && txtSalary.Text == "" && txtID.Text == "" && mtxtWorkFrom.Text == "" && mtxtWorkTo.Text == "");
        }

        private int calculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth > today.AddYears(-age))
                age--;

            return age;
        }

        private bool isAgeBiggerThan(int Age)
        {
            if (dtpDateOfBirth.Value == null) return false;

            int age = calculateAge(dtpDateOfBirth.Value);

            return age >= Age;
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            txtFullName.Text = Global.CurrentEmployee.FullName;
            txtEmail.Text = Global.CurrentEmployee.Email;
            txtPhone.Text = Global.CurrentEmployee.Phone;
            dtpDateOfBirth.Value = Global.CurrentEmployee.DateOfBirth;
            
            if (Global.CurrentEmployee.Gender == 0) { rbFemaleGender.Checked = true; }
            else { rbMaleGender.Checked = true; }

            txtSalary.Text = Global.CurrentEmployee.Salary.ToString();
            txtID.Text = Global.CurrentEmployee.ID;
            mtxtWorkFrom.Text = Global.CurrentEmployee.WorkFrom;
            mtxtWorkTo.Text = Global.CurrentEmployee.WorkTo;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (!isTextBoxesEmpty() && isAgeBiggerThan(18) && (rbMaleGender.Checked || rbFemaleGender.Checked))
            {
                Global.CurrentEmployee.FullName = txtFullName.Text;
                Global.CurrentEmployee.Email = txtEmail.Text;
                Global.CurrentEmployee.Phone = txtPhone.Text;
                Global.CurrentEmployee.Salary = double.Parse(txtSalary.Text);
                Global.CurrentEmployee.WorkFrom = mtxtWorkFrom.Text;
                Global.CurrentEmployee.WorkTo = mtxtWorkTo.Text;

                Global.isEmployeeChanged = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("one of info not correct");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
