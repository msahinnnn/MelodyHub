using Amazon.Runtime.Internal;
using MediatR;
using MelodyHub.Application.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Photo.CreatePhoto
{
    public class CreatePhotoCommandRequest : IRequest<CreatePhotoCommandResponse>
    {
        public int ParentId { get; set; }
        public EntityStorageType EntityType { get; set; }
        public PhotoType PhotoType { get; set; }
        public IFormFile File { get; set; }
    }
}