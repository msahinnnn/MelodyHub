using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Photo.GetByParentId
{
    public class GetByParentIdQueryRequest : IRequest<GetByParentIdQueryResponse>
    {
        public int ParentId { get; set; }
    }
}