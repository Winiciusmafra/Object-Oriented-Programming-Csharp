using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public class Employee
    {
        // 1 - Director
        // 2 - Designer
        // 3 - Employee
        private int _office;
        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salary { get; set; }

        public Employee(int office)
        {
            this._office = office;
        }

        public double GetBonus()
        {
            if (_office == 1)
            {
                return Salary;
            }
            return Salary * 0.10;
        }



    }
}
