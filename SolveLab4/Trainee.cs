using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveLab2
{
    internal class Trainee : Person , IPayable
    {
        public string NID { get; set; }
        public int IntakeNumber { get; set; }
        public int Salary { get; set; }

        public Trainee(string name, int age, string nid, int intakeNumber)
            : base(name, age)
        {
            NID = nid;
            IntakeNumber = intakeNumber;
        }

        public override string ToString()
        {
            return $"Trainee Name: {Name}, Age: {Age}, NID: {NID}, IntakeNumber: {IntakeNumber} ";
        }

        int IPayable.ShowPayment()
        {
            return Salary;
        }
    }
}
