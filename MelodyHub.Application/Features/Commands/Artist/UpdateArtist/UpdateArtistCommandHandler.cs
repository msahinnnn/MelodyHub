using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Features.Commands.Artist.CreateArtist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Artist.UpdateArtist
{
    public class UpdateArtistCommandHandler : IRequestHandler<UpdateArtistCommandRequest, UpdateArtistCommandResponse>
    {
        private readonly IArtistService _artistService;

        public UpdateArtistCommandHandler(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public async Task<UpdateArtistCommandResponse> Handle(UpdateArtistCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _artistService.GetArtistById(request.ArtistId);

            if (entity == null)
            {
                throw new Exception("Artist not found");
            }

            entity.Name = string.IsNullOrEmpty(request.Name) ? entity.Name : request.Name;
            entity.About = string.IsNullOrEmpty(request.About) ? entity.About : request.About;

            
            var response = await _artistService.UpdateArtist(entity);

            return new UpdateArtistCommandResponse
            {
                Artist = response
            };

           
        }
    }
 
}