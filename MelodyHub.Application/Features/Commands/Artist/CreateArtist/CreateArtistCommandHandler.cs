using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Artist.CreateArtist
{
    public class CreateArtistCommandHandler : IRequestHandler<CreateArtistCommandRequest, CreateArtistCommandResponse>
    {
        private readonly IArtistService _artistService;

        public CreateArtistCommandHandler(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public async Task<CreateArtistCommandResponse> Handle(CreateArtistCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _artistService.CreateArtist(new()
            {
                Name = request.Name,
                About = request.About
            });

            response.Url = UrlHelper.GetArtistUrl(response.Id);

            var updateUrlRes = await _artistService.UpdateArtist(response);

            return new CreateArtistCommandResponse
            {
                Artist = updateUrlRes
            };
        }
    }
}