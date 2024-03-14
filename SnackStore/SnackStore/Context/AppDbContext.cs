using Microsoft.EntityFrameworkCore;
using SnackStore.Models;

namespace SnackStore.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // DbContextOptions carrega as informações necessárias para configurar o DbContext;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Snack> Snacks { get; set; }

    }
}
