using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
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
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly ISongRepository _songRepository;
        private readonly IPhotoRepository _photoRepository;
        public AlbumService(IAlbumRepository albumRepository, ISongRepository songRepository, IPhotoRepository photoRepository)
        {
            _albumRepository = albumRepository;
            _songRepository = songRepository;
            _photoRepository = photoRepository;
        }

        public async Task<Album> CreateAlbum(Album album)
        {
            return await _albumRepository.AddAsync(album);
        }

        public async Task<Album> DeleteAlbum(int id)
        {
            return await _albumRepository.DeleteAsync(id);
        }

        public async Task<Album> GetAlbumById(int id)
        {
            return await _albumRepository.GetByIdAsync(id);
        }

        public async Task<Album> GetAlbumByName(string name)
        {
            return await _albumRepository.FirstAsync(x => x.Name == name);
        }

        public async Task<Album> GetAlbumByUrl(string url)
        {
            return await _albumRepository.FirstAsync(x => x.Url == url);
        }

        public async Task<IEnumerable<Album>> GetAlbumsByArtistId(int artistId)
        {
            return await _albumRepository.GetAsync(x => x.ArtistId == artistId);
        }

        public async Task<IEnumerable<Album>> GetAlbumsByGenreId(int id)
        {
            return await _albumRepository.GetAsync(x => x.GenreId == id);
        }

        public async Task<IEnumerable<Album>> GetAllAlbums()
        {
            return await _albumRepository.GetAllAsync();
        }

        public async Task<Album> UpdateAlbum(Album album)
        {
            return await _albumRepository.UpdateAsync(album);
        }
    }
}
