using MelodyHub.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Abstractions.Services
{
    public interface IGenreService
    {
        public Task<IEnumerable<Genre>> GetAllGenres(int skip, int take);
        public Task<Genre> GetGenreById(int id);
        public Task<Genre> GetGenreByUrl(string url);
        public Task<Genre> GetGenreByName(string name);


        public Task<Genre> CreateGenre(Genre genre);
        public Task<Genre> UpdateGenre(Genre genre);
        public Task<Genre> DeleteGenre(int id);

    }
}
