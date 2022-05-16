using Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    //здесь добавляем в базу данных таблицы и так же их описываем
    public class ComicsDbContext : DbContext
    {
        public ComicsDbContext() : base() { }

        public virtual DbSet<Comics> Comics { get; set; }

        public virtual DbSet<Genre> Genres { get; set; }

        public virtual DbSet<Studio> Studios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;DataBase=ComicsDB;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .Property(ct => ct.Title)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Studio>()
                .Property(c => c.Title)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Comics>()
                .HasOne(c => c.Studio)
                .WithMany(cmc => cmc.Comics)
                .HasForeignKey(c => c.StudioId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comics>()
                .HasOne(c => c.Genre)
                .WithMany(cmc => cmc.Comics)
                .HasForeignKey(c => c.GenreId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
