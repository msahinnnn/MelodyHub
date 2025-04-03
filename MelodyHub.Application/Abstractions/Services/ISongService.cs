using MelodyHub.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Abstractions.Services
{
    public interface ISongService
    {
        public Task<IEnumerable<Song>> GetAllSongs();
        public Task<IEnumerable<Song>> GetSongsByListId(int ListId);
        public Task<IEnumerable<Song>> GetSongsByAlbumId(int albumId);
        public Task<Song> GetSongById(int songId);
        public Task<Song> GetSongByUrl(string url);
        public Task<Song> GetSongByName(string name);


        public Task<Song> CreateSong(Song song);
        public Task<Song> UpdateSong(Song song);
        public Task<Song> DeleteSong(int songId);  

    }
}
