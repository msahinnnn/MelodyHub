using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Photo.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQueryRequest, GetByIdQueryResponse>
    {
        private readonly IPhotoService _photoService;

        public GetByIdQueryHandler(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<GetByIdQueryResponse> Handle(GetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _photoService.GetPhotoById(request.Id);

            return new()
            {
                Photo = response
            };
        }
    }
 
}