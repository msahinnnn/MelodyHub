using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Genre.GetById
{
    public class GetByIdQueryRequest : IRequest<GetByIdQueryResponse>
    {
        public int Id { get; set; }
    }
}