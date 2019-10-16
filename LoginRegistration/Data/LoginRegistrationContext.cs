using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LoginRegistration.Models
{
    public class LoginRegistrationContext : DbContext
    {
        public LoginRegistrationContext(DbContextOptions<LoginRegistrationContext> options)
            : base(options)
        {
        }

        public DbSet<LoginRegistration.Models.MyUser> MyUser { get; set; }

       


    }
}
