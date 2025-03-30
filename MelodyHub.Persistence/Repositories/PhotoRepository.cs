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
    public class PhotoRepository : BaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(MelodyHubDbContext context) : base(context)
        {

        }
        
    }
}
