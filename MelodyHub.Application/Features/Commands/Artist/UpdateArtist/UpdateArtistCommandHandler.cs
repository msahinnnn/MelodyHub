using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Artist.UpdateArtist
{
    public class UpdateArtistCommandHandler : IRequestHandler<UpdateArtistCommandRequest, UpdateArtistCommandResponse>
    {
        public Task<UpdateArtistCommandResponse> Handle(UpdateArtistCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
 
}