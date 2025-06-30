using InfNet.Ispotifai.Domain;
using Microsoft.EntityFrameworkCore;

namespace InfNet.Ispotifai.Infrastructure
{
    public class IspotifaiDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Musica> Musica { get; set; }
        public DbSet<Plano> Plano { get; set; }

        public IspotifaiDbContext(DbContextOptions<IspotifaiDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.IdUsuario);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Favoritas)
                .WithMany();
            
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Plano)
                .WithMany()
                .HasForeignKey("IdPlano")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Musica>()
                .HasKey(m => m.IdMusica);

            modelBuilder.Entity<Plano>()
                .HasKey(p => p.IdPlano);


            base.OnModelCreating(modelBuilder);
        }
    }
}
