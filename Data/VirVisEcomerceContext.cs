using VirVisEcomerce.Models;
using Microsoft.EntityFrameworkCore;
namespace VirVisEcomerce.Context
{
    public class VirVisEcomerceContext : DbContext
    {
        public VirVisEcomerceContext(DbContextOptions<VirVisEcomerceContext> options) :base(options)
            { }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
