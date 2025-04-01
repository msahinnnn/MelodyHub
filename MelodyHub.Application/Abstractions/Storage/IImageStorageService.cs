using MelodyHub.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Abstractions.Storage
{
    public interface IImageStorageService
    {
        Task UploadPhotoAsync(string entityId, EntityStorageType entityType, PhotoType photoType, Stream inputStream);
        Task DeletePhotoAsync(string entityId, EntityStorageType entityType, PhotoType photoType);
        Task<Stream> GetPhotoAsync(string entityId, EntityStorageType entityType, PhotoType photoType);
        Task UpdatePhotoAsync(string entityId, EntityStorageType entityType, PhotoType photoType, Stream inputStream);
    }
}
