using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Features.Commands.Artist.CreateArtist;
using MelodyHub.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Genre.CreateGenre
{
    public class CreateGenreCommandHandler : IRequestHandler<CreateGenreCommandRequest, CreateGenreCommandResponse>
    {
        private readonly IGenreService _genreService;

        public CreateGenreCommandHandler(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public async Task<CreateGenreCommandResponse> Handle(CreateGenreCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await _genreService.CreateGenre(new()
            {
                Name = request.Name
            });

            res.Url = UrlHelper.GetGenreUrl(res.Id);

            var updateUrlRes = await _genreService.UpdateGenre(res);

            return new CreateGenreCommandResponse
            {
                Genre = updateUrlRes
            };

        }
    }
}