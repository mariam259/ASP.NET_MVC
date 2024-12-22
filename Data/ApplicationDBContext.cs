// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options){

        }

        public DbSet<Race> Races {get; set;}
        public DbSet<Club> Clubs {get; set;}
        public DbSet<Address> Addresses {get; set;}
        // public DbSet<AppUser> AppUsers {get; set;}
    }
}