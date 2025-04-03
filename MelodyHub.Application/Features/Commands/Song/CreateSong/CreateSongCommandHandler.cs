using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Song.CreateSong
{
    public class CreateSongCommandHandler : IRequestHandler<CreateSongCommandRequest, CreateSongCommandResponse>
    {
        public Task<CreateSongCommandResponse> Handle(CreateSongCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}