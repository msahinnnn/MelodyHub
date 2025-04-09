using MediatR;
using MelodyHub.Application.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Photo.UpdatePhoto
{
    public class UpdatePhotoCommandRequest : IRequest<UpdatePhotoCommandResponse>
    {
        public int Id { get; set; } // id itself
        public EntityStorageType EntityType { get; set; }
        public PhotoType PhotoType { get; set; }
        public IFormFile File { get; set; }
    }
}