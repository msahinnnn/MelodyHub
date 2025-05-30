﻿using MelodyHub.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Abstractions.Services
{
    public interface IPhotoService
    {
        public Task<IEnumerable<Photo>> GetAllPhotos(int skip, int take);
        public Task<Photo> GetPhotoById(int id);
        public Task<IEnumerable<Photo>> GetPhotosByParentId(int id);
        public Task<Photo> GetPhotoByUrl(string url);


        public Task<Photo> CreatePhoto(Photo photo);
        public Task<Photo> UpdatePhoto(Photo photo);
        public Task<Photo> DeletePhoto(int id);
    }
}
