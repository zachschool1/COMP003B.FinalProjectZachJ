using COMP003B.SP26.FinalProject.ZachJ.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP26.FinalProject.ZachJ.Data
{
    public class FinalsContext : DbContext
    {
        public FinalsContext(DbContextOptions<FinalsContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Shows> Shows { get; set; }
        public DbSet<COMP003B.SP26.FinalProject.ZachJ.Models.Music> Music { get; set; } = default!;

    }
}
