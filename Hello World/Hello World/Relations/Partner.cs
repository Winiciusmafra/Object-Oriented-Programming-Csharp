using Relations.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    public class Partner : IAuthentication
    {
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
