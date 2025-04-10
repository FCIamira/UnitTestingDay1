using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolveLab2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Role r;
            Employee e = new Employee(100000, Role.Admin, "mariam");
            e.Display();

            Console.WriteLine("\nTesting Person, Employee, and Trainee Classes:");
            Person person = new Person("M", 40);
            Employees employee = new Employees("J", 30, "E", 55000);
            Trainee trainee = new Trainee("T", 22, "T", 5);

            Person[] people = { person, employee, trainee };
            Console.WriteLine("\nArray of Persons, Employees, and Trainees:");
            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
            List<Trainee> trainees = new List<Trainee>
{
    new Trainee("Mariam", 25, "1", 1),
    new Trainee("Khaled", 22, "2", 2),
    new Trainee("Ahmed", 30, "3", 3)
};

            Console.WriteLine("Before");
            foreach (var t in trainees)
            {
                Console.WriteLine($"{t.Name}, Age: {t.Age}");
            }

            trainees.Sort(new CompareTraineeByAge());

            Console.WriteLine("\nAfter:");
            foreach (var t in trainees)
            {
                Console.WriteLine($"{t.Name}, Age: {t.Age}");
            }
        }
    }
}
