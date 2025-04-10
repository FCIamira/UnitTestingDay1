using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveLab2
{
    internal class CompareTraineeByAge : IComparer<Trainee>
    {
        public int Compare(Trainee x, Trainee y)
        {
            return x.Age.CompareTo(y.Age); 
        }
    }


}
