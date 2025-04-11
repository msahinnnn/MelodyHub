using Amazon.S3.Model;
using Amazon.S3;
using MelodyHub.Application.Abstractions.Storage;
using MelodyHub.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Infrastructure.Services.Storage
{
    public class ImageStorageService : IImageStorageService
    {
        private readonly AmazonS3Client _s3Client;
        private const string BucketName = "mymelody-hub";

        public ImageStorageService()
        {
            _s3Client = new();
        }

        public string GetBucketName()
        {
            return BucketName;
        }

        public string GetFileKey(string entityId, EntityStorageType entityType, PhotoType photoType)
        {
            var res = entityType switch
            {
                EntityStorageType.Users or EntityStorageType.Artists => photoType switch
                {
                    PhotoType.Profile => $"{entityType.ToString().ToLower()}/{entityId}/profile.jpg",
                    PhotoType.Banner => $"{entityType.ToString().ToLower()}/{entityId}/banner.jpg",
                    _ => throw new ArgumentException($"Invalid PhotoType '{photoType}' for entityType '{entityType}'.")
                },
                EntityStorageType.Playlists => photoType == PhotoType.Playlist
                    ? $"playlists/{entityId}/{entityId}.jpg"
                    : throw new ArgumentException($"Invalid PhotoType '{photoType}' for Playlists."),
                EntityStorageType.Albums => photoType == PhotoType.Album
                    ? $"albums/{entityId}/{entityId}.jpg"
                    : throw new ArgumentException($"Invalid PhotoType '{photoType}' for Albums."),
                _ => throw new ArgumentException($"Invalid entityType '{entityType}'.")
            };

            return res;
        }

        public async Task<Stream> GetPhotoAsync(string entityId, EntityStorageType entityType, PhotoType photoType)
        {
            string fileKey = GetFileKey(entityId, entityType, photoType);
            var response = await _s3Client.GetObjectAsync(BucketName, fileKey);
            return response.ResponseStream;
        }

        public async Task UpdatePhotoAsync(string entityId, EntityStorageType entityType, PhotoType photoType, Stream inputStream)
        {
            string fileKey = GetFileKey(entityId, entityType, photoType);
            await _s3Client.DeleteObjectAsync(BucketName, fileKey); 
            await UploadPhotoAsync(fileKey, inputStream);           
        }

        private async Task UploadPhotoAsync(string fileKey, Stream inputStream)
        {
            var request = new PutObjectRequest
            {
                BucketName = BucketName,
                Key = fileKey,
                InputStream = inputStream,
                ContentType = "image/jpeg"
            };
            var res = await _s3Client.PutObjectAsync(request);

            // TODO?: Image resizing.
            // Ex: if (photoType == PhotoType.Playlist) { ResizeImage(inputStream, 300, 300); }
        }

        public async Task<string> UploadPhotoAsync(string entityId, EntityStorageType entityType, PhotoType photoType, Stream inputStream)
        {
            string fileKey = GetFileKey(entityId, entityType, photoType);
            await UploadPhotoAsync(fileKey, inputStream);
            return fileKey;
        }

        public async Task DeletePhotoAsync(string entityId, EntityStorageType entityType, PhotoType photoType)
        {
            string fileKey = GetFileKey(entityId, entityType, photoType);
            var res = await _s3Client.DeleteObjectAsync(BucketName, fileKey);
        }

       
    }
}
