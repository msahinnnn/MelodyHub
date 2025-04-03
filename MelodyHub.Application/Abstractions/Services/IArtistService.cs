using MelodyHub.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Abstractions.Services
{
    public interface IArtistService
    {
        public Task<IEnumerable<Artist>> GetAllArtists(int skip, int take);
        public Task<Artist> GetArtistById(int artistId);
        public Task<Artist> GetArtistByUrl(string artistUrl);

        public Task<Artist> CreateArtist(Artist artist);
        public Task<Artist> UpdateArtist(Artist artist);
        public Task<Artist> DeleteArtist(int artistId);

    }
}
