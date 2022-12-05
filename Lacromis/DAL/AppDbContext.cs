using Microsoft.EntityFrameworkCore;

namespace Lacromis.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
