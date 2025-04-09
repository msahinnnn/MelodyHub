using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Album.CreateAlbum
{
    public class CreateAlbumCommandHandler : IRequestHandler<CreateAlbumCommandRequest, CreateAlbumCommandResponse>
    {
        private readonly IAlbumService _albumService;

        public CreateAlbumCommandHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<CreateAlbumCommandResponse> Handle(CreateAlbumCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _albumService.CreateAlbum(new()
            {
                Name = request.Name,
                ArtistId = request.ArtistId,
                GenreId = request.GenreId
            });

            return new CreateAlbumCommandResponse
            {
                Album = response
            };
        }
    }

}