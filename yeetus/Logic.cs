using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeetus
{
    internal class Logic
    {
        internal static int CalculateBron(int age)
        {
            var bdate = DateTime.Now.Year - age;
            return bdate;
        }
    }
}
