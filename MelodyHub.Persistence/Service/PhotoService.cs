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
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository _photoRepository;

        public PhotoService(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public async Task<Photo> CreatePhoto(Photo photo)
        {
            return await _photoRepository.AddAsync(photo);
        }

        public async Task<Photo> DeletePhoto(int id)
        {
            return await _photoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Photo>> GetAllPhotos(int skip, int take)
        {
            return await _photoRepository.GetAsync(x => true, skip: skip, take: take);
        }

        public async Task<Photo> GetPhotoById(int id)
        {
            return await _photoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Photo>> GetPhotosByParentId(int id)
        {
            return await _photoRepository.GetAsync(x => x.ParentId == id);
        }

        public async Task<Photo> GetPhotoByUrl(string url)
        {
            return await _photoRepository.FirstAsync(x => x.Url == url);
        }

        public async Task<Photo> UpdatePhoto(Photo photo)
        {
            return await _photoRepository.UpdateAsync(photo);
        }
    }
}
