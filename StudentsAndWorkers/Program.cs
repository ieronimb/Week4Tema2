using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Tema2_Ecercitiul3_StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            var students = new List<Student>()
           {new Student("Ieronim", "Birnat", 5),
            new Student("Ciprian", "Popescu", 6),
            new Student("Valentin", "Filip", 8),
            new Student("Cristina", "Botoc",9),
            new Student("Filip", "Gabriel", 7),
            new Student("Stefan", "Diac", 8),
            new Student("Francescu", "Beta", 5),
            new Student("Robert", "Stefan", 10),
            new Student("Andreea", "Diac", 10),
            new Student("Stefana", "Dragomir", 10)}; 

            students = students.OrderBy(student => student.Grade).ToList();

            foreach (var student in students)
                Console.WriteLine(student);

            Console.WriteLine("\n");

            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            var workers = new List<Worker>()
            {new Worker("Ieronim", "Birnat", 2500, 34),
            new Worker("Catalin", "Durnache", 1800, 40),
            new Worker("Iosif", "Beta", 1343.6, 43),
            new Worker("Iulian", "Ioja", 2345, 25),
            new Worker("Filip", "Beta", 1243.23, 21),
            new Worker("Robert", "Ciprian", 1453, 24),
            new Worker("Calin", "Andrei", 1234, 15),
            new Worker("Dumitru", "Murariu", 2550, 21),
            new Worker("Ionut", "Cristache", 326, 7),
            new Worker("Marian", "Dumitru", 342, 5)};

            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            foreach (var worker in workers)
                Console.WriteLine(worker);

            Console.WriteLine("\n");

            //Merge the lists and sort them by first name and last name.
            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            humans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList();

            foreach (var human in humans)
                Console.WriteLine(human);

            Console.ReadLine();
        }
    }
}
