using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SchoolApp
{
    public abstract class User
    {
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract string EmailAddress { get; set; }
        public abstract string Password { get; set; }
    }
}
