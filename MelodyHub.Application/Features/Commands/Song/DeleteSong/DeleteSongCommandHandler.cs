using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Abstractions.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Song.DeleteSong
{
    public class DeleteSongCommandHandler : IRequestHandler<DeleteSongCommandRequest, DeleteSongCommandResponse>
    {
        private readonly ISongService _songService;
        private readonly IAudioStorageService _audioStorageService;
        public DeleteSongCommandHandler(ISongService songService, IAudioStorageService audioStorageService)
        {
            _songService = songService;
            _audioStorageService = audioStorageService;
        }
        public Task<DeleteSongCommandResponse> Handle(DeleteSongCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
 
}