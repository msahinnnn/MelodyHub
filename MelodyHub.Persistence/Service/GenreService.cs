using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Repositories;
using MelodyHub.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MelodyHub.Persistence.Service
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<Genre> CreateGenre(Genre genre)
        {
            return await _genreRepository.AddAsync(genre);
        }

        public async Task<Genre> DeleteGenre(int id)
        {
            return await _genreRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            return await _genreRepository.GetAllAsync();
        }

        public async Task<Genre> GetGenreById(int id)
        {
            return await _genreRepository.GetByIdAsync(id);
        }

        public async Task<Genre> GetGenreByName(string name)
        {
            return await _genreRepository.FirstAsync(x => x.Name == name);
        }

        public async Task<Genre> GetGenreByUrl(string url)
        {
            return await _genreRepository.FirstAsync(x => x.Url == url);
        }

        public async Task<Genre> UpdateGenre(Genre genre)
        {
            return await _genreRepository.UpdateAsync(genre);
        }
    }
}
