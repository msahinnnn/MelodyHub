using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Genre.GetByName
{
    public class GetByNameQueryHandler : IRequestHandler<GetByNameQueryRequest, GetByNameQueryResponse>
    {
        private readonly IGenreService _genreService;

        public GetByNameQueryHandler(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public async Task<GetByNameQueryResponse> Handle(GetByNameQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _genreService.GetGenreByName(request.Name);

            return new()
            {
                Genre = response
            };
        }
    }
}