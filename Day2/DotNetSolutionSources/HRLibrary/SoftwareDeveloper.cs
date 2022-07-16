using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource
{
    public sealed class SoftwareDeveloper : Employee
    {
        public string Project { get; set; }
        public double TaskCompleted { get; set; }
        public override double ComputePay()
        {
            double salary = (this.DA * this.WorkingDays) * TaskCompleted;
            return salary;
        }

        public override string ToString()
        {
            string result = string.Format("Project working on : {0}, Task completed : {1}",
                    this.Project, this.TaskCompleted);
            return base.ToString() + " result";
        }


        //Member Initialized List
        public SoftwareDeveloper() : base()
        {
            this.Project = "Content Mangement System";
            this.TaskCompleted = 0.02;
        }

        public SoftwareDeveloper(int id, string fullName, DateTime joinDate,
                        string department, int workingDay, string location,
                        string project, double da, double taskCompleted)
                        : base(id, fullName, joinDate, department, workingDay, location)
        {
            this.Project = project;
            this.TaskCompleted = taskCompleted;
        }
    }
}
