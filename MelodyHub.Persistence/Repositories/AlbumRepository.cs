using MelodyHub.Application.Repositories;
using MelodyHub.Domain.Entitites;
using MelodyHub.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Persistence.Repositories
{
    public class AlbumRepository : BaseRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(MelodyHubDbContext context) : base(context)
        {
        }
    }
}
