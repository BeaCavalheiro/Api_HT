using Api_HT.Model;
using Microsoft.EntityFrameworkCore;

namespace Api_HT.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {



        }
        public DbSet<Cliente> Cliente { get; set; }

    
    }
}
