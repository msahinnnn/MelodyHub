using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Photo.CreatePhoto
{
    public class CreatePhotoCommandHandler : IRequestHandler<CreatePhotoCommandRequest, CreatePhotoCommandResponse>
    {
        public Task<CreatePhotoCommandResponse> Handle(CreatePhotoCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}