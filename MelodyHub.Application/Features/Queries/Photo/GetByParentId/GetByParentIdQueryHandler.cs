using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Photo.GetByParentId
{
    public class GetByParentIdQueryHandler : IRequestHandler<GetByParentIdQueryRequest, GetByParentIdQueryResponse>
    {
        private readonly IPhotoService _photoService;

        public GetByParentIdQueryHandler(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<GetByParentIdQueryResponse> Handle(GetByParentIdQueryRequest request, CancellationToken cancellationToken)
        {
           var response = await _photoService.GetPhotosByParentId(request.ParentId);

            return new GetByParentIdQueryResponse
            {
                Photos = response
            };
        }
    }
}