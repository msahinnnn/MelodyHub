using MelodyHub.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Abstractions.Storage
{
    public interface IS3Service
    {
        Task<string> UploadPhotoAsync(Stream fileStream, PhotoType photoType, string relatedId, string fileName);
        Task<string> UploadSongAsync(Stream fileStream, string artistName, string albumName, string songName);
        Task<string> UploadAlbumPhotoAsync(Stream fileStream, string artistName, string albumName, string fileName);
        Task DeleteFileAsync(string key);
        Task<string> UpdateFileAsync(Stream fileStream, string key);

    }
}
