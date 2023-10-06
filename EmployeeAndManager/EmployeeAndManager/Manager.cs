using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndManager
{
    internal class Manager : Employee
    {
        private int numberOfWorker;
        public Manager(string fullname, string startwork, int salary, int numberOfWorker) : base(fullname,startwork, salary)
        {
            this.numberOfWorker=numberOfWorker;
        }

        public int NumberOfWorker
        {
            get { return numberOfWorker; }
            set { numberOfWorker = value; }
        }
    }
}
