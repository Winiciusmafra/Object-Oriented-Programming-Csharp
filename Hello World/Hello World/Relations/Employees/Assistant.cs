using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public class Assistant:Employee
    {
        public Assistant(double salary, string cpf) : base(salary, cpf)
        {

        }
        public override double GetBonus()
        {
            //override - override parent method

            return Salary * 0.20;
        }

        public override void IncreaseSalary()
        {
            Salary = Salary + (Salary * 0.1);
        }
    }
}
