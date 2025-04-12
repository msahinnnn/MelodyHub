using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Artist.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQueryRequest, GetByIdQueryResponse>
    {
        private readonly IArtistService _artistService;

        public GetByIdQueryHandler(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public async Task<GetByIdQueryResponse> Handle(GetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _artistService.GetArtistById(request.Id);

            return new()
            {
                Artist = response
            };
        }
    }
    
}