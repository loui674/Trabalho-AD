using Microsoft.EntityFrameworkCore;
using Trabalho_AD.Model;

namespace Trabalho_AD
{
    public class GeralContext : DbContext
    {
        public GeralContext(DbContextOptions<GeralContext> options) : base(options) { 
        

        }

        public DbSet<Veiculo> Veiculo { get; set; }

    }

}
