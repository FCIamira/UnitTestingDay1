using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveLab2
{
    public class Employees : Person
    {
        public string NID { get; set; }
        public double Salary { get; set; }

        public Employees(string name, int age, string nid, double salary)
            : base(name, age)
        {
            NID = nid;
            Salary = salary;
        }

        public bool MaxSalary()
        {
            return Salary > 100;
        }


        public override string ToString()
        {
            return $"Employee Name: {Name}, Age: {Age}, NID: {NID}, Salary: {Salary}";
        }
    }
}
