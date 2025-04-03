using MelodyHub.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Abstractions.Services
{
    public interface IAlbumService
    {
        public Task<IEnumerable<Album>> GetAllAlbums(int skip, int take);
        public Task<IEnumerable<Album>> GetAlbumsByGenreId(int id, int skip, int take);
        public Task<IEnumerable<Album>> GetAlbumsByArtistId(int artistId, int skip, int take);
        public Task<Album> GetAlbumById(int id);
        public Task<Album> GetAlbumByUrl(string url);
        public Task<Album> GetAlbumByName(string name);


        public Task<Album> CreateAlbum(Album album);
        public Task<Album> UpdateAlbum(Album album);
        public Task<Album> DeleteAlbum(int id);


    }
}
