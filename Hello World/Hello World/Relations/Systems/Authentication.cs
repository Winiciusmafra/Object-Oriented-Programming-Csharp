using Relations.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Systems
{

    public abstract class Authentication : Employee
    {
        public Authentication(double salary, string cpf) : base(salary, cpf)
        {
        }

        public string Password { get; set; }

        public bool Authenticated(string password)
        {
            if (this.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
