using Microsoft.EntityFrameworkCore;

namespace Hackfest.Models
{
    public class ContexteBD : DbContext
    {
        public ContexteBD(DbContextOptions<ContexteBD> options) : base(options) { }

        public DbSet<Réponse> Réponses { get; set; }
    }
}
