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
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

    }
}
