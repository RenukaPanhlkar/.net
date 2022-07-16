using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public sealed class SalesEmployee : Employee
    {
        double sales, comm;
        //Shadowing
        //Blocking Polymorphism
        public new double CalculateSalary()
        { 
            return BasicSalary + (sales * comm);
        }
    }
}
