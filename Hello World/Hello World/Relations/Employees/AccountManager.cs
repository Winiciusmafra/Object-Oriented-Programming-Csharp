using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public class AccountManager: Employee
    {
        public AccountManager(double salary, string cpf) : base(salary, cpf)
        {

        }
        public override double GetBonus()
        {
            //override - override parent method

            return Salary * 0.25;
        }

        public override void IncreaseSalary()
        {
            Salary = Salary + (Salary * 0.05);
        }
    }
}
