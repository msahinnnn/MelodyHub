using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Artist.CreateArtist
{
    public class CreateArtistCommandHandler : IRequestHandler<CreateArtistCommandRequest, CreateArtistCommandResponse>
    {
        public Task<CreateArtistCommandResponse> Handle(CreateArtistCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
    {
    }
}