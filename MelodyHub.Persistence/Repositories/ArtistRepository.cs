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
    public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(MelodyHubDbContext context) : base(context)
        {

        }
        
    }
}
