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
        public string Major { get; set; }
    }
}
