using Lacromis.Models;
using Microsoft.EntityFrameworkCore;

namespace Lacromis.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            

        }
       public DbSet<Garbage> garbages { get; set; }
      public  DbSet<Catagory> catagories { get; set; }
      public  DbSet<Metal> metals { get; set; }
    }
}
