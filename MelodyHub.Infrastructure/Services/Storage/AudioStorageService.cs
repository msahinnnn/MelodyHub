using Amazon.S3.Transfer;
using Amazon.S3;
using MelodyHub.Application.Abstractions.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3.Model;
using Npgsql.PostgresTypes;

namespace MelodyHub.Infrastructure.Services.Storage
{
    public class AudioStorageService : IAudioStorageService
    {
        private readonly AmazonS3Client _s3Client;
        private const string BucketName = "mymelody-hub"; 

        public AudioStorageService()
        {
            _s3Client = new();
        }

        public string GetBucketName()
        {
            return BucketName;
        }

        public async Task UploadSongAsync(string songId, int albumId, Stream inputStream)
        {
            string fileKey = $"songs/album_{albumId}/{songId}.mp4";
            var request = new PutObjectRequest
            {
                BucketName = BucketName,
                Key = fileKey,
                InputStream = inputStream,
                ContentType = "audio/mp4"
            };
            var res = await _s3Client.PutObjectAsync(request);       
        }

        public async Task DeleteSongAsync(string songId, int albumId)
        {
            string fileKey = $"songs/album_{albumId}/{songId}.mp4";
            await _s3Client.DeleteObjectAsync(BucketName, fileKey);
        }

        public async Task<Stream> GetSongAsync(string songId, int albumId)
        {
            string fileKey = $"songs/album_{albumId}/{songId}.mp4";
            var response = await _s3Client.GetObjectAsync(BucketName, fileKey);
            return response.ResponseStream;
        }

        public async Task UpdateSongAsync(string songId, int albumId, Stream inputStream)
        {
            await DeleteSongAsync(songId, albumId);
            await UploadSongAsync(songId, albumId, inputStream);
        }

    }
}
