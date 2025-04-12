using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Genre.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQueryRequest, GetAllQueryResponse>
    {
        private readonly IGenreService _genreService;

        public GetAllQueryHandler(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public async Task<GetAllQueryResponse> Handle(GetAllQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _genreService.GetAllGenres(request.Skip, request.Take);
            return new()
            {
                Genres = response
            };
        }
    }

}