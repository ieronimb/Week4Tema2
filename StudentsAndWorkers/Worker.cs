using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public double workSalary;
        public double workHoursPerDay = 8;       

        public Worker(string firstName, string lastName, double workSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            //Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay 
            this.WorkSalary = workSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WorkSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        //and a method MoneyPerHour() that returns money earned per hour by the worker.
        public double MoneyPerHour()
        {
            return Math.Round(this.WorkSalary / this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return string.Format("Worker's first name and last name: {0} {1}; Salary: {2} $; Hours per day: {3}; Money per hour: {4}.", this.FirstName, this.LastName, this.WorkSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}
