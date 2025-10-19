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
    public partial class frmEmployeeCard : frmBase
    {
        //private stEmployee CurrentEmployee;

        public frmEmployeeCard()
        {
            InitializeComponent();
        }

        private int calculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth > today.AddYears(-age))
                age--;

            return age;
        }
        private float calculateHoursOfWork(string from, string to)
        {
            TimeSpan timeFrom = TimeSpan.Parse(from);
            TimeSpan timeTo = TimeSpan.Parse(to);

            if (timeFrom > timeTo) timeTo = timeTo.Add(new TimeSpan(24, 0, 0));

            TimeSpan timeOfWork = timeTo - timeFrom;

            return timeOfWork.Hours + (float)(timeOfWork.Minutes >= 30 ? 0.5 : 0);
        }


        private void frmEmployeeCard_Load(object sender, EventArgs e)
        {
            this.Text = Global.CurrentEmployee.FullName;

            lblFullName.Text = Global.CurrentEmployee.FullName;
            lblEmail.Text = Global.CurrentEmployee.Email;
            lblPhone.Text = Global.CurrentEmployee.Phone;
            lblGender.Text = (Global.CurrentEmployee.Gender == 0? "Female" : "Male");
            lblDateOfBirth.Text = Global.CurrentEmployee.DateOfBirth.ToString("dd/MM/yyyy");
            lblAge.Text = calculateAge(Global.CurrentEmployee.DateOfBirth).ToString();

            lblID.Text = Global.CurrentEmployee.ID;
            lblSalary.Text = Global.CurrentEmployee.Salary.ToString();
            lblWorkFromTo.Text = $"{Global.CurrentEmployee.WorkFrom} to {Global.CurrentEmployee.WorkTo}";
            lblHoursOfWork.Text = calculateHoursOfWork(Global.CurrentEmployee.WorkFrom, Global.CurrentEmployee.WorkTo).ToString();

            pbEmployeeImage.Image = imageList1.Images[Global.CurrentEmployee.Gender];
        }
    }
}
