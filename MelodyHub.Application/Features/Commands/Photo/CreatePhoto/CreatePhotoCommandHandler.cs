using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Abstractions.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Photo.CreatePhoto
{
    public class CreatePhotoCommandHandler : IRequestHandler<CreatePhotoCommandRequest, CreatePhotoCommandResponse>
    {
        private readonly IPhotoService _photoService;
        private readonly IImageStorageService _imageStorageService;
        public CreatePhotoCommandHandler(IPhotoService photoService, IImageStorageService imageStorageService)
        {
            _photoService = photoService;
            _imageStorageService = imageStorageService;
        }

        public async Task<CreatePhotoCommandResponse> Handle(CreatePhotoCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.File == null || request.File.Length == 0)
                throw new ArgumentException("No file uploaded or file is empty.");

            var storageUploadResponse = await _imageStorageService.UploadPhotoAsync(request.ParentId.ToString(), request.EntityType, request.PhotoType, request.File.OpenReadStream());

            var response = await _photoService.CreatePhoto(new()
            {
                ParentId = request.ParentId,
                PhotoType = (Domain.Entitites.PhotoType)request.PhotoType,
                Url = storageUploadResponse
            });

            return new CreatePhotoCommandResponse
            {
                Photo = response
            };
     
        }
    }
}