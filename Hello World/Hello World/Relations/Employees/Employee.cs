using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public class Employee
    {

        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salary { get; set; }


        //virtual method - has an implementation but can override
                public virtual double GetBonus()
        {

            return Salary * 0.10;
        }



    }
}
