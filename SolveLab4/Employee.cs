using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveLab2
{
    public enum Role
    {
        Admin = 1,
        Accountant = 2,
        Stock = 4,
        Reception = 8
    }

    public struct Employee : IPayable
    {

        public int Salary { get; set; }
        public Role Role { get; set; }
        public string Name { get; set; }

        public Employee(int s, Role r, string n)
        {
            Salary = s;
            Role = r;
            Name = n;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}, Role: {Role}");
        }

        public void AssignRole(Role r)
        {
            Role = r;
        }

        public bool HasRole(Role role)
        {
            return (Role & role) == role;
        }

        int IPayable.ShowPayment()
        {
            return Salary;
        }

       
    }

}
