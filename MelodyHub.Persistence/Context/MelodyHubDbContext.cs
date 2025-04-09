using MelodyHub.Domain.Entitites;
using MelodyHub.Domain.Entitites.Cammon;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Persistence.Context
{
    public class MelodyHubDbContext : DbContext
    {
        public MelodyHubDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Artist>()
            //   .HasMany(a => a.Photos)
            //   .WithOne()
            //   .IsRequired(false);

            //builder.Entity<Artist>()
            //    .HasMany(a => a.Albums)
            //    .WithOne()
            //    .IsRequired(false);

            //builder.Entity<Genre>()
            //    .HasMany(g => g.Albums)
            //    .WithOne(a => a.Genre)
            //    .HasForeignKey(a => a.GenreId)
            //    .IsRequired();

            //builder.Entity<Album>()
            //    .HasOne(a => a.Artist)
            //    .WithMany(ar => ar.Albums)
            //    .HasForeignKey(a => a.ArtistId)
            //    .IsRequired();

            //builder.Entity<Album>()
            //    .HasOne(a => a.Photo)
            //    .WithMany()
            //    .HasForeignKey(a => a.PhotoId)
            //    .IsRequired();

            //builder.Entity<Song>()
            //    .HasOne(s => s.Album)
            //    .WithMany(a => a.Songs)
            //    .HasForeignKey(s => s.AlbumId)
            //    .IsRequired();

            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

    }
}
