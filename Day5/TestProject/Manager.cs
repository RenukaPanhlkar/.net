using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Manager:Employee
    {
        public override double CalculateSalary()
        {

            return base.CalculateSalary() + 7000;
        }

    }
}
