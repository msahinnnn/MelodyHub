using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Song.UpdateSong
{
    public class UpdateSongCommandHandler : IRequestHandler<UpdateSongCommandRequest, UpdateSongCommandResponse>
    {
        public Task<UpdateSongCommandResponse> Handle(UpdateSongCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}