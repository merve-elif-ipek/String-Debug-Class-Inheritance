using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("merve ipek", "2022", 20000);
            Manager mng1 = new Manager("merve ipek", "2022", 20000,25);
            //emp1.Fullname = "tugçe";
            //Console.WriteLine(emp1.Fullname);
            Console.WriteLine(emp1.Fullname+mng1.NumberOfWorker);
            Console.ReadLine();
        }
    }
}
