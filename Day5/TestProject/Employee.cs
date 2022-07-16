using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public   partial class Employee:ICloneable
    {

        public Employee()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual double CalculateSalary()
        { 
            return BasicSalary +5000 + DailyAllowance;
        }

        public object Clone()
        {
           Employee employee=new Employee();
            employee.FirstName=this.FirstName;
            employee.LastName=this.LastName;
            return employee;

        }


        ~Employee()
        {

            int count = 56;
            count++;
            //DeInitialization Code

        }
    }
}
