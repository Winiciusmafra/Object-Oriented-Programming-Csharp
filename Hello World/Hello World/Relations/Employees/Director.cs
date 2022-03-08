using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public class Director : Employee
    {
        public Director(string cpf) : base(cpf)
        {
            
        }
        public override double GetBonus()
        {
            //override - override parent method

            return Salary + base.GetBonus();
        }
    }
}
