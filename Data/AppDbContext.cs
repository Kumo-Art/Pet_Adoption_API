

using Microsoft.EntityFrameworkCore;
using Pet_Adoption_API.Models;

namespace Pet_Adoption_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

         //This is the Students table, as far as our C# code is Concerned
        public DbSet<Pets> Pets {get;set;}

        public DbSet<Staff> Staff {get;set;}
    
    }
}