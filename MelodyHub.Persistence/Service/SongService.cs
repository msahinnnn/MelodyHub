using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Repositories;
using MelodyHub.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MelodyHub.Persistence.Service
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        public Task<Song> CreateSong(Song song)
        {
            return _songRepository.AddAsync(song);
        }

        public Task<Song> DeleteSong(int songId)
        {
            return _songRepository.DeleteAsync(songId);
        }

        public Task<IEnumerable<Song>> GetAllSongs(int skip, int take)
        {
            return _songRepository.GetAsync(x=>true,
                skip: skip,
                take: take);
        }

        public Task<Song> GetSongById(int songId)
        {
            return _songRepository.GetByIdAsync(songId);
        }

        public Task<Song> GetSongByName(string name)
        {
            return _songRepository.FirstAsync(x => x.Name == name);
        }

        public Task<Song> GetSongByUrl(string url)
        {
            return _songRepository.FirstAsync(x => x.Url == url);
        }

        public Task<IEnumerable<Song>> GetSongsByAlbumId(int albumId, int skip, int take)
        {
            return _songRepository.GetAsync(x => x.AlbumId == albumId,
                skip: skip,
                take: take
            );
        }
        public async Task<Song> UpdateSong(Song song)
        {
            return await _songRepository.UpdateAsync(song);
        }
    }
}
