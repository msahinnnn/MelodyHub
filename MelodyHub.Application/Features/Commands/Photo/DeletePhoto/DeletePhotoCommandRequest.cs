using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Photo.DeletePhoto
{
    public class DeletePhotoCommandRequest : IRequest<DeletePhotoCommandResponse>
    {
    }
   
}