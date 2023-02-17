using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SchoolApp
{
    // In the context of our Application, a Student IS A User
    public class Student : User 
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override string EmailAddress { get; set; }
        public override string Password { get; set; }

        public string Major { get; set; }
        // Create a property for Registration status, it will be an enum
        public RegistrationStatus CurrentStatus { get; set; }
    }
}
