using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Genre.GetByUrl
{
    public class GetByUrlQueryHandler : IRequestHandler<GetByUrlQueryRequest, GetByUrlQueryResponse>
    {
        private readonly IGenreService _genreService;

        public GetByUrlQueryHandler(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public async Task<GetByUrlQueryResponse> Handle(GetByUrlQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _genreService.GetGenreByUrl(request.Url);

            return new()
            {
                Genre = response
            };
        }
    }
}