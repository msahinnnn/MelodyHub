using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Abstractions.Storage
{
    public interface IAudioStorageService
    {
        Task UploadSongAsync(string songId, int albumId, Stream inputStream);
        Task DeleteSongAsync(string songId, int albumId);
        Task<Stream> GetSongAsync(string songId, int albumId);
        Task UpdateSongAsync(string songId, int albumId, Stream inputStream);
        string GetBucketName();
    }
}
