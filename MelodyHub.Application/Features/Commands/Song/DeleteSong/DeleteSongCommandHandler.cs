using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Song.DeleteSong
{
    public class DeleteSongCommandHandler : IRequestHandler<DeleteSongCommandRequest, DeleteSongCommandResponse>
    {
        public Task<DeleteSongCommandResponse> Handle(DeleteSongCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
 
}