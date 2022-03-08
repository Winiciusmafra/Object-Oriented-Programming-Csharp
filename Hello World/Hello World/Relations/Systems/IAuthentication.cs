using Relations.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Systems
{

    public interface IAuthentication 
    {
        bool Authenticated(string password);
    }
}
