using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentsAndWorkers
{
    public class Student: Human
    {
        //Define a new class Student which is derived from Human and has a new field – grade
        public Student(string firstName, string lastName, uint grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public decimal Grade { get; set; }

        public override string ToString()
        {
            return string.Format("Student's first name and last name: {0} {1}; Achieved grade: {2}", this.FirstName, this.LastName, this.Grade);
        }
        
    }
}
