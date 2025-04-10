using SolveLab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProject1
{

    public class EmployeeTest
    {//string name, int age, string nid, double salary
        Employees employee = new("mariam",23,"123",12);

        [Fact]
        public void Salary()
        {
            bool SalaryMax = employee.MaxSalary();
            double Salary = employee.Salary;


            Assert.Equal(2, Salary);

            Assert.InRange(Salary, 1, 3);

            Assert.True(Salary >= 2);

            Assert.False(SalaryMax);
        }

        [Fact]
        public void Name()
        {
            string actualResult = employee.Name;

             Assert.Equal("Mariam", actualResult);
           
            Assert.Contains("ma", actualResult);

        }

        [Fact]
        public void Employee_AskForCopy_SameRefrence()
        {
            Employees employee1 = new("mariam", 23, "123", 12);

            List<Person> Persons = new List<Person>();
            Employees employe2 = new("mariam", 23, "123", 12);

            Persons.Add(employe2);

            Assert.Empty(Persons);
            Assert.NotEmpty(Persons);
            Assert.NotNull(employee1);
            Assert.NotSame(employee1, employee);


        }

    }
}
