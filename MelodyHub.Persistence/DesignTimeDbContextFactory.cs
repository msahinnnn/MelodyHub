using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelodyHub.Persistence.Context;

namespace MelodyHub.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MelodyHubDbContext>
    {
        public MelodyHubDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MelodyHubDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql("Host=localhost;Database=melodyhub;Username=postgres;Password=mhawk");
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
