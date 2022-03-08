using Relations.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Employees
{
    public abstract class EmployeeAuthenticated : Employee, IAuthentication
    {
        public string Password { get; set; }
        public EmployeeAuthenticated(double salary, string cpf) : base(salary, cpf)
        {
        }

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
