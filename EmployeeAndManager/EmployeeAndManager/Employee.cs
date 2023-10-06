using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndManager
{
    internal class Employee
    {
        private string fullname;
        private string startwork;
        private int salary;

        public Employee(string fullname, string startwork, int salary)
        {
            this.fullname = fullname;
            this.startwork = startwork;
            this.salary = salary;

        }

        public string Fullname 
        {
            get { return fullname; }
            set { fullname = value; }
        
        }

        public string Startwork
        {
            get { return startwork; }
            set { startwork = value; }

        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }

        }


    }
}
