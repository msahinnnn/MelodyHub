using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Repositories;
using MelodyHub.Persistence.Context;
using MelodyHub.Persistence.Repositories;
using MelodyHub.Persistence.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MelodyHubDbContext>(options =>
             options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<ISongRepository, SongRepository>();
            services.AddScoped<IArtistRepository, ArtistRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();

            services.AddScoped<IAlbumService, AlbumService>();
            services.AddScoped<ISongService, SongService>();
            services.AddScoped<IArtistService, ArtistService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IGenreService, GenreService>();

        }
    }
}
