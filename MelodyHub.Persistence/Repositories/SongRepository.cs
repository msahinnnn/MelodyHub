using MelodyHub.Application.Repositories;
using MelodyHub.Domain.Entitites;
using MelodyHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Persistence.Repositories
{
    public class SongRepository : BaseRepository<Song>, ISongRepository
    {
        public SongRepository(MelodyHubDbContext context) : base(context)
        { 
        
        }
    }
}
