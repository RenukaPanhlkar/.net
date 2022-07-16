using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TestProject
{
    internal class Program
    {
        #region EntryPoint
        static void Main(string[] args)
        {
            #region Employee instance Construction
            Employee employee = new Employee();
            employee.FirstName = "Ravi";
            employee.LastName = "Tambade";
            employee.BasicSalary = 10000;
            employee.DailyAllowance = 5000;
            #endregion


            Books myFavBookCollection=new Books();
            myFavBookCollection[0] = "Wings of Fire";
            myFavBookCollection[1] = "Ignited Minds";
            myFavBookCollection[2] = "Who Moved My Cheese";
            myFavBookCollection[3] = "You can win";
            Console.WriteLine(myFavBookCollection[3]);
           // Console.ReadLine();

            Employee employee1 = new Employee();
            employee1.CalculateSalary();   /// Employee function will be called

            Employee employee2 = new Manager();
            employee2.CalculateSalary();  //Manager function will be called
           
            Employee employee3 = new SalesEmployee();
            employee3.CalculateSalary();

            SalesEmployee salesemp = new SalesEmployee();
            salesemp.CalculateSalary();

            //introspection ( Reflection )

            Type t=salesemp.GetType();  //**********************************
            Console.WriteLine(t.Name);
            Console.WriteLine(t.FullName);
            MethodInfo[] mi=t.GetMethods();
            foreach(MethodInfo m in mi)
            {
              Console.WriteLine(m.Name);
              Console.WriteLine("Public = " + m.IsPublic);
            }
            

            //Rutime Typ Information ( RTTI)--------C++
            //Reflection---------------------------C#, Java



            int count = 67;
            int result = count;

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            
            Employee emp3 = new Employee();
            //Shallow Copy
            Employee emp4 = emp3;
            emp3.FirstName = "Sachin";
            emp3.LastName = "Mane";

            Employee empCopy = emp3;
            empCopy.FirstName = "Shatki";
            empCopy.LastName = "Kapoor";


            //Deep Copy

            Employee emp5 = (Employee)emp3.Clone();
            emp5.FirstName = "Sara";
            emp5.LastName = "Khan";

            Console.WriteLine(emp3.FirstName + "  " +emp3.LastName);
            Console.WriteLine(empCopy.FirstName + "  " + empCopy.LastName);
            Console.WriteLine(emp5.FirstName + "  " + emp5.LastName);
            //  GC.SuppressFinalize(emp5);
            //  GC.SuppressFinalize(emp4);

            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.GetGeneration(emp5);
            Console.ReadLine();
        }
        #endregion
    }
}
