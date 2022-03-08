using Relations.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public class Director : EmployeeAuthenticated
    {
     

        public Director(double salary ,string cpf) : base(salary,cpf)
        {
            
        }

        public bool Authenticated(string password)
        {
            return true;
        }

        public override double GetBonus()
        {
            //override - override parent method

            return Salary * 0.5;
        }

        public override void IncreaseSalary()
        {
            Salary = Salary + (Salary * 0.3);
        }
    }
}
