using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BOL;
using DAL;


namespace TestProject
{
    internal class Program
    {
        public static void DemoMySQLRetriveAllEmployees()
        {
            List<BOL.Employee> employees = EmployeeDAL.GetAll();
            foreach (BOL.Employee emp in employees)
            {
                Console.WriteLine(emp.ID + "  " + emp.Name + "  " + emp.Designation);
            }
        }

        static void Main(string[] args)
        {
            DemoMySQLRetriveAllEmployees();
            Console.ReadLine();
        }
    }
}
