using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ConsoleAndEFC
{
    public class SchoolContext : DbContext
    {
        // We want to generate some SQL tables from our classes: Student, Course
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        // Build and Configure the Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=ConsoleAppWithEF; Integrated Security=SSPI; Trust Server Certificate=true;");
        }

    }
}
