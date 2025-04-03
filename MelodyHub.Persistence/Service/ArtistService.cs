using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Repositories;
using MelodyHub.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Persistence.Service
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IAlbumRepository _albumRepository;
        public ArtistService(IArtistRepository artistRepository, IAlbumRepository albumRepository)
        {
            _artistRepository = artistRepository;
            _albumRepository = albumRepository;
        }

        public async Task<Artist> CreateArtist(Artist artist)
        {
            return await _artistRepository.AddAsync(artist);
        }

        public async Task<Artist> DeleteArtist(int artistId)
        {
            return await _artistRepository.DeleteAsync(artistId);
        }

        public async Task<IEnumerable<Artist>> GetAllArtists()
        {
            return await _artistRepository.GetAllAsync();
        }

        public async Task<Artist> GetArtistById(int artistId)
        {
            return await _artistRepository.GetByIdAsync(artistId);
        }

        public async Task<Artist> GetArtistByUrl(string artistUrl)
        {
            return await _artistRepository.FirstAsync(x => x.Url == artistUrl);
        }

        public async Task<Artist> UpdateArtist(Artist artist)
        {
            return await _artistRepository.UpdateAsync(artist);
        }
    }
}
