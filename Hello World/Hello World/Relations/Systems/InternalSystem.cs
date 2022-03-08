using Relations.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Systems
{
    public class InternalSystem
    {
        public bool login(Authentication employee, string password)
        {
            bool userAuthenticated = employee.Authenticated(password);
            if (userAuthenticated)
            {
                Console.WriteLine("Wellcome System");
            }
            else
            {
                Console.WriteLine("Password incorrect");
            }
            return true;
        }
    }
}
