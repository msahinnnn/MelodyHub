using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Album.DeleteAlbum
{
    public class DeleteAlbumCommandHandler : IRequestHandler<DeleteAlbumCommandRequest, DeleteAlbumCommandResponse>
    {
        private readonly IAlbumService _albumService;

        public DeleteAlbumCommandHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }
        public async Task<DeleteAlbumCommandResponse> Handle(DeleteAlbumCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _albumService.DeleteAlbum(request.Id);

            return new DeleteAlbumCommandResponse
            {
                Album = response
            };
        }
    }

}