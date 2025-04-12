using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Genre.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQueryRequest, GetByIdQueryResponse>
    {
        private readonly IGenreService _genreService;

        public GetByIdQueryHandler(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public async Task<GetByIdQueryResponse> Handle(GetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _genreService.GetGenreById(request.Id);

            return new()
            {
                Genre = response
            };
        }
    }
}