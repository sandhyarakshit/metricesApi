using Metrices_psql.Models;
using Microsoft.EntityFrameworkCore;

namespace Metrices_psql
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employes> Employes {get;set;}
    }
}
