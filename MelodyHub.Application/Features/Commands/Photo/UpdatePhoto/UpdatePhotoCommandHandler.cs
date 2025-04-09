using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Abstractions.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Photo.UpdatePhoto
{
    public class UpdatePhotoCommandHandler : IRequestHandler<UpdatePhotoCommandRequest, UpdatePhotoCommandResponse>
    {
        private readonly IPhotoService _photoService;
        private readonly IImageStorageService _imageStorageService;

        public UpdatePhotoCommandHandler(IImageStorageService imageStorageService, IPhotoService photoService)
        {
            _imageStorageService = imageStorageService;
            _photoService = photoService;
        }

        public async Task<UpdatePhotoCommandResponse> Handle(UpdatePhotoCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.File == null || request.File.Length == 0)
                throw new ArgumentException("No file uploaded or file is empty.");

            await _imageStorageService.UpdatePhotoAsync(request.Id.ToString(), request.EntityType, request.PhotoType, request.File.OpenReadStream());

            var response = await _photoService.UpdatePhoto(new()
            {
                Id = request.Id,
                PhotoType = (Domain.Entitites.PhotoType)request.PhotoType
            });

            return new UpdatePhotoCommandResponse
            {
                Photo = response
            };
        }
    }
}