using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public class Director : Employee
    {
        public double GetBonus()
        {

            return Salary;
        }
    }
}
