using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Repositories;
using MelodyHub.Persistence.Repositories;
using MelodyHub.Persistence.Service;
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
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<ISongRepository, SongRepository>();
            services.AddScoped<IArtistRepository, ArtistRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();

            services.AddScoped<IAlbumService, AlbumService>();
            services.AddScoped<ISongService, SongService>();
            services.AddScoped<IArtistService, ArtistService>();
            services.AddScoped<IPhotoService, PhotoService>();


           
            //services.AddIdentity<AppUser, AppRole>(options =>
            //{
            //    options.Password.RequiredLength = 3;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireDigit = false;
            //    options.Password.RequireLowercase = false;
            //    options.Password.RequireUppercase = false;
            //}).AddEntityFrameworkStores<MelodyHubDbContext>()
            //.AddDefaultTokenProviders();

          
        }
    }
}
