using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Photo.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQueryRequest, GetAllQueryResponse>
    {
        private readonly IPhotoService _photoService;

        public GetAllQueryHandler(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<GetAllQueryResponse> Handle(GetAllQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _photoService.GetAllPhotos(request.Skip, request.Take);

            return new GetAllQueryResponse
            {
                Photos = response
            };
        }
    }
}