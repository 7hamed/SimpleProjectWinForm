using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_EmployeeManagement
{
        

    public partial class frmMain : frmBase
    {

        public frmMain()
        {
            InitializeComponent();
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

        private stEmployee convertDateToEmployee()
        {
            stEmployee emp;

            emp.FullName = txtFullName.Text;
            emp.Email = txtEmail.Text;
            emp.Phone = txtPhone.Text;
            emp.DateOfBirth = dtpDateOfBirth.Value;
            emp.Gender = (rbFemaleGender.Checked ? (byte)0 : (byte)1);

            emp.ID = txtID.Text;
            emp.Salary = double.Parse(txtSalary.Text);
            emp.WorkFrom = mtxtWorkFrom.Text;
            emp.WorkTo = mtxtWorkTo.Text;

            return emp;
        }

        private stEmployee convertItemToEmployee(ListViewItem item)
        {
            
            stEmployee emp = new stEmployee()
            {
                ID = item.SubItems[0].Text,
                FullName = item.SubItems[1].Text,
                Email = item.SubItems[2].Text,
                Phone = item.SubItems[3].Text,
                DateOfBirth = DateTime.Parse(item.SubItems[4].Text),
                Gender = (byte)(item.SubItems[6].Text.ToLower() == "female" ? 0 : 1),
                Salary = double.Parse(item.SubItems[7].Text),
                WorkFrom = item.SubItems[8].Text.Substring(0, 5),
                WorkTo = item.SubItems[8].Text.Substring(9, 5)

            };

            //DateTime.TryParse(item.SubItems[4].Text, out DateTime result);
            //emp.DateOfBirth = result;

            return emp;
        }

        private float calculateHoursOfWork(string from, string to)
        {
            TimeSpan timeFrom = TimeSpan.Parse(from);
            TimeSpan timeTo = TimeSpan.Parse(to);

            if (timeFrom > timeTo) timeTo = timeTo.Add(new TimeSpan(24, 0, 0));

            TimeSpan timeOfWork = timeTo - timeFrom;

            return timeOfWork.Hours + (float)(timeOfWork.Minutes >= 30 ? 0.5 : 0);
        }

        private ListViewItem convertEmployeeToItem(stEmployee employee)
        {
            ListViewItem item = new ListViewItem(employee.ID.Trim());

            item.ImageIndex = employee.Gender;

            item.SubItems.Add(employee.FullName);
            item.SubItems.Add(employee.Email);
            item.SubItems.Add(employee.Phone);
            item.SubItems.Add(employee.DateOfBirth.ToString("MM/dd/yyyy"));
            item.SubItems.Add(calculateAge(employee.DateOfBirth).ToString());
            item.SubItems.Add((employee.Gender == 0 ? "Female" : "Male"));
            item.SubItems.Add(employee.Salary.ToString());
            item.SubItems.Add(employee.WorkFrom + " to " + employee.WorkTo);
            item.SubItems.Add($"{calculateHoursOfWork(employee.WorkFrom, employee.WorkTo):F1}");

            return item;
        }

        

        private void clearControls()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            rbFemaleGender.Checked = true;

            txtID.Clear();
            txtSalary.Clear();
            mtxtWorkFrom.Clear();
            mtxtWorkTo.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isTextBoxesEmpty() && isAgeBiggerThan(18) && (rbMaleGender.Checked || rbFemaleGender.Checked))
            {
                lvMain.Items.Add(convertEmployeeToItem(convertDateToEmployee()));

                clearControls();
            }
            else
            {
                MessageBox.Show("one of info not correct");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            lvMain.View = View.Details;

            lvMain.Columns.Add("ID", 100);
            lvMain.Columns.Add("Full Name", 200);
            lvMain.Columns.Add("Email", 250);
            lvMain.Columns.Add("Phone", 150);
            lvMain.Columns.Add("Date of Birth", 150);
            lvMain.Columns.Add("Age", 60);
            lvMain.Columns.Add("Gender", 100);
            lvMain.Columns.Add("Salary", 100);
            lvMain.Columns.Add("Work From To", 150);
            lvMain.Columns.Add("Hours Of Work", 150);

        }

        private void cbListViewFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbListViewFormat.SelectedItem.ToString().ToLower())
            {
                case "details":
                    lvMain.View = View.Details;
                    break;

                case "large icon":
                    lvMain.View = View.LargeIcon;
                    break;

                case "small icon":
                    lvMain.View = View.SmallIcon;
                    break;

                case "list":
                    lvMain.View = View.List;
                    break;

                case "title":
                    lvMain.View = View.Tile;
                    break;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvMain.Items.Count > 0)
            {
                for (int i = lvMain.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lvMain.Items.Remove(lvMain.SelectedItems[i]);
                }
            }
            else
            {
                MessageBox.Show("there is no employee to delete");
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            stEmployee tempEmp;

            for (int i = 0; i < 10; i++)
            {
                tempEmp = new stEmployee()
                {
                    FullName = "person " + (i + 1).ToString(),
                    Email = $"person{i + 1}@hotmail.com",
                    Phone = $"0500000{14 + i}",
                    DateOfBirth = new DateTime(1900 + i, 1 + i, 15 + i),
                    Gender = (byte)(i % 2),


                    ID = (1001 + i).ToString(),
                    Salary = 500*(i+1),
                    WorkFrom = $"{i+10}:00",
                    WorkTo = $"21:30"
                };

                lvMain.Items.Add(convertEmployeeToItem(tempEmp));

            }
        }

        private void lvMain_DoubleClick(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count > 0)
            {
                Global.CurrentEmployee = convertItemToEmployee(lvMain.SelectedItems[0]);
                Form EmployeeCardFrom = new frmEmployeeCard();
                EmployeeCardFrom.Show();
            }
            else
            {
                MessageBox.Show("select employee");
            }
        }


        private void updateItemByEmployee(ListViewItem item)
        {
            item.SubItems[1].Text = Global.CurrentEmployee.FullName;
            item.SubItems[2].Text = Global.CurrentEmployee.Email;
            item.SubItems[3].Text = Global.CurrentEmployee.Phone;
            item.SubItems[7].Text = Global.CurrentEmployee.Salary.ToString();
            item.SubItems[8].Text = Global.CurrentEmployee.WorkFrom + " to " + Global.CurrentEmployee.WorkTo;
            item.SubItems[9].Text = $"{calculateHoursOfWork(Global.CurrentEmployee.WorkFrom, Global.CurrentEmployee.WorkTo):F1}";

            Global.isEmployeeChanged = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count > 0)
            {
                Global.CurrentEmployee = convertItemToEmployee(lvMain.SelectedItems[0]);
                Form EditEmployeeForm = new frmEditEmployee();
                EditEmployeeForm.ShowDialog();

                if (Global.isEmployeeChanged)
                {
                    updateItemByEmployee(lvMain.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("pls select an employee");
            }


        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            txtFullName.Focus();
        }


        private void isNullOrEmptyErrorProvider(TextBox textBox, string errorText, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, errorText);
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        private void validatingTextBox(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            
            string message;
            if (txt.Name == "txtFullName") message = "Enter your real full name";
            else if (txt.Name == "txtEmail") message = "Email is required";
            else if (txt.Name == "txtPhone") message = "Phone number cannot be empty";
            else if (txt.Name == "txtID") message = "Salary cannot be empty";
            else message = "This field is required";

            isNullOrEmptyErrorProvider((TextBox)sender, message, e);
        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(txtSalary.Text, out _))
            {
                errorProvider1.SetError((TextBox)sender, "cannot be empty and non-number");
            }
            else
            {
                errorProvider1.SetError((TextBox)sender, "");
            }
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            Form changeBackColorForm = new frmChangeBackColor();
            changeBackColorForm.ShowDialog();


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lvMain.Height = (int)numericUpDown1.Value;
        }

        Form ALlInOneVersionForm;
        private void btnAllInOneVersion_Click(object sender, EventArgs e)
        {
            if (ALlInOneVersionForm == null || ALlInOneVersionForm.Disposing)
            {
                ALlInOneVersionForm = new frmAllInOne();
            }

            ALlInOneVersionForm.Show();
        }
    }
}
