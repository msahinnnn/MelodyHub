using MelodyHub.Domain.Entitites;
using MelodyHub.Domain.Entitites.Cammon;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Album>()
            //     .HasOne(a => a.Artist)
            //     .WithMany(a => a.Albums)
            //     .HasForeignKey(a => a.ArtistId);

            // builder.Entity<Artist>()
            //     .HasMany(a => a.Albums)
            //     .WithOne(a => a.Artist)
            //     .HasForeignKey(a => a.ArtistId);

            // builder.Entity<Song>()
            //     .HasOne(s => s.Album)
            //     .WithMany(s => s.Songs)
            //     .HasForeignKey(s => s.AlbumId);



            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Database=melodyhub;Username=postgres;Password=mhawk");

        }
        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    var datas = ChangeTracker
        //         .Entries<BaseEntity>();

        //    foreach (var data in datas)
        //    {
        //        _ = data.State switch
        //        {
        //            EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
        //            EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
        //            _ => DateTime.UtcNow
        //        };
        //    }

        //    return await base.SaveChangesAsync(cancellationToken);
        //}
    }
}
