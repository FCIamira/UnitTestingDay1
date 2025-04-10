using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveLab2
{
    internal interface IPayable
    {
         int Salary { get; set; }
        int ShowPayment();

    }
}
