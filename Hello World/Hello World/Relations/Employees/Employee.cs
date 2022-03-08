using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public class Employee
    {
        public static int TotalEmplyee { get; private set; }
        public string Name { get; set; }
        public string Cpf { get; private set; }
        public double Salary { get; set; }

        public Employee(string cpf)
        {   
            this.Cpf = cpf; 
            TotalEmplyee++;
        }
        //virtual method - has an implementation but can override
                public virtual double GetBonus()
        {

            return Salary * 0.10;
        }



    }
}
