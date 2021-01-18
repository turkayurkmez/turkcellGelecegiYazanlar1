using introEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introEFCore.Data
{
   public class TurkcellDbContext : DbContext
    {
        public TurkcellDbContext()
        {

        }
        public TurkcellDbContext(DbContextOptions<TurkcellDbContext> options):base(options)
        {

        }
        public DbSet<Director>  Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>()
                        .HasMany(x => x.Movies)
                        .WithOne(q => q.Director)
                        .HasForeignKey(w => w.DirectorId);

            modelBuilder.Entity<Genre>()
                        .HasMany(t => t.Movies)
                        .WithOne(y => y.Genre)
                        .HasForeignKey(x => x.GenreId);

            //PK kolonlarını belirttik
            modelBuilder.Entity<MovieArtist>()
                        .HasKey(ma => new { ma.MovieId, ma.ArtistId  });

            modelBuilder.Entity<MovieArtist>()
                        .HasOne(f => f.Movie)
                        .WithMany(a => a.Artists)
                        .HasForeignKey(x => x.MovieId);

            modelBuilder.Entity<MovieArtist>()
                        .HasOne(s => s.Artist)
                        .WithMany(m => m.Movies)
                        .HasForeignKey(x => x.ArtistId);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB; Database=LadiesOfTurkcell;Integrated Security=yes");
            }
        }



    }
}
