using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Abstractions.Storage
{
    public interface IAudioStorageService
    {
        Task UploadSongAsync(string songId, Stream inputStream);
        Task DeleteSongAsync(string songId);
        Task<Stream> GetSongAsync(string songId);
        Task UpdateSongAsync(string songId, Stream inputStream);
        string GetBucketName();
    }
}
