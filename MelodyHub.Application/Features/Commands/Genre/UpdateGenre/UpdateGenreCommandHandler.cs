using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Features.Commands.Artist.UpdateArtist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Genre.UpdateGenre
{
    public class UpdateGenreCommandHandler : IRequestHandler<UpdateGenreCommandRequest, UpdateGenreCommandResponse>
    {
        private readonly IGenreService _genreService;

        public UpdateGenreCommandHandler(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public async Task<UpdateGenreCommandResponse> Handle(UpdateGenreCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _genreService.GetGenreById(request.GenreId);

            if (entity == null)
            {
                throw new Exception("Genre not found");
            }

            entity.Name = string.IsNullOrEmpty(request.Name) ? entity.Name : request.Name;



            var response = await _genreService.UpdateGenre(entity);

            return new UpdateGenreCommandResponse
            {
                Genre = response
            };
        }
    }

}