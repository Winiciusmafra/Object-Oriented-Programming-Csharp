using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public class Designer : Employee
    {
        public Designer(double salary, string cpf) : base(salary, cpf)
        {

        }
        public override double GetBonus()
        {
            //override - override parent method

            return Salary * 0.17;
        }

        public override void IncreaseSalary()
        {
            Salary = Salary + (Salary * 0.11);
        }
    }
}
