using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Genre.DeleteGenre
{
    public class DeleteGenreCommandHandler : IRequestHandler<DeleteGenreCommandRequest, DeleteGenreCommandResponse>
    {
        private readonly IGenreService _genreService;

        public DeleteGenreCommandHandler(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public async Task<DeleteGenreCommandResponse> Handle(DeleteGenreCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _genreService.DeleteGenre(request.GenreId);

            return new DeleteGenreCommandResponse
            {
                Genre = response
            };
        }
    }
}