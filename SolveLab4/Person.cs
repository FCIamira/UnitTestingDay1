using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveLab2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }  
        public Person()
        {
            Name = "";
            Age = 0;
        }

        public override string ToString()
        {
            return $"Person Name: {Name}, Age: {Age} ";
        }
    }
}
