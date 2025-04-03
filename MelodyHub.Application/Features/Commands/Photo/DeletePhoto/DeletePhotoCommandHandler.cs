using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Photo.DeletePhoto
{
    public class DeletePhotoCommandHandler : IRequestHandler<DeletePhotoCommandRequest, DeletePhotoCommandResponse>
    {
        public Task<DeletePhotoCommandResponse> Handle(DeletePhotoCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
  
}