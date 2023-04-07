using System;
using Microsoft.EntityFrameworkCore;

namespace Demo_04_MVC_EFC.Models
{
    public class AppUserContext : DbContext
    {
        public AppUserContext(DbContextOptions<AppUserContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}

