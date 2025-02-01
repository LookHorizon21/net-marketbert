using MarketBert.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppAdminMarketBert.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Modelos
        public DbSet<CategoriaMd> Categoria { get; set; }

        public DbSet<ArticuloMd> Articulo { get; set; }

        public DbSet<ApplicationUserMd> ApplicationUser { get; set; }
    }
}
