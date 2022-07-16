using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource
{
    public class SalesEmployee : Employee
    {
        public double Target { get; set; }
        public double TargetAchieved { get; set; }
        public double Bonus { get; set; }
        public override double ComputePay()
        {
            double amount = 0;

            if (TargetAchieved >= Target)
            {
                amount = Bonus + (WorkingDays * DA);
            }
            else
            {
                amount =(WorkingDays * DA);
            }
            return amount;
        }


        //Member Initialized List
        public SalesEmployee():base()
        {
            this.Target = 56000;
            this.TargetAchieved = 40000;
            this.Bonus = 10000;

        }

        public SalesEmployee(int id, string fullName, DateTime joinDate,
                        string department, int workingDay, string location,
                        double da,
                        double target, double targetAchieved,double bonus)
                        : base(id, fullName,joinDate,department,workingDay,location)
        {
            this.Target = target;
            this.TargetAchieved = targetAchieved;
            this.Bonus = bonus;
            this.DA = da;
        }

        public override string ToString()
        {
            string result = string.Format(" Target Set={0}, Target Achieved ={1}, Bonus Declared= {2}",
                                          this.Target, this.TargetAchieved ,this.Bonus);

            return base.ToString() + result;
        }
    }
}
