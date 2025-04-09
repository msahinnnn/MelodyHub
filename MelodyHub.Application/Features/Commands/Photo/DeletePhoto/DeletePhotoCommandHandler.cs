using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Abstractions.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Photo.DeletePhoto
{
    public class DeletePhotoCommandHandler : IRequestHandler<DeletePhotoCommandRequest, DeletePhotoCommandResponse>
    {
        private readonly IPhotoService _photoService;
        private readonly IImageStorageService _imageStorageService;
        public DeletePhotoCommandHandler(IPhotoService photoService, IImageStorageService imageStorageService)
        {
            _photoService = photoService;
            _imageStorageService = imageStorageService;
        }
     
        public async Task<DeletePhotoCommandResponse> Handle(DeletePhotoCommandRequest request, CancellationToken cancellationToken)
        {
            await _imageStorageService.DeletePhotoAsync(request.Id.ToString(), request.EntityType, request.PhotoType);

            var response = await _photoService.DeletePhoto(request.Id);

            return new DeletePhotoCommandResponse
            {
                Photo = response
            };
        }
    }
  
}