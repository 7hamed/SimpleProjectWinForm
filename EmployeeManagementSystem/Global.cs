using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EmployeeManagement
{
    public struct stEmployee
    {
        public string FullName;
        public string Email;
        public string Phone;
        public DateTime DateOfBirth;
        public byte Gender; // 0-female 1-male

        public string ID;
        public double Salary;
        public string WorkFrom;
        public string WorkTo;
    }

    static public class Global
    {
        static public stEmployee CurrentEmployee;

        static public bool isEmployeeChanged = false;
    }
}
