using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Photo.GetByUrl
{
    public class GetByUrlQueryHandler : IRequestHandler<GetByUrlQueryRequest, GetByUrlQueryResponse>
    {
        private readonly IPhotoService _photoService;

        public GetByUrlQueryHandler(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<GetByUrlQueryResponse> Handle(GetByUrlQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _photoService.GetPhotoByUrl(request.Url);

            return new()
            {
                Photo = response
            };
        }
    }
}