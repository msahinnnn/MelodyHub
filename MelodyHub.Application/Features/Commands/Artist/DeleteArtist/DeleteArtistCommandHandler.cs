using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Artist.DeleteArtist
{
    public class DeleteArtistCommandHandler : IRequestHandler<DeleteArtistCommandRequest, DeleteArtistCommandResponse>
    {
        private readonly IArtistService _artistService;

        public DeleteArtistCommandHandler(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public async Task<DeleteArtistCommandResponse> Handle(DeleteArtistCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _artistService.DeleteArtist(request.ArtistId);

            return new DeleteArtistCommandResponse
            {
                Artist = response
            };
        }
    }
  
}