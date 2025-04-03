using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Genre.CreateGenre
{
    public class CreateGenreCommandHandler : IRequestHandler<CreateGenreCommandRequest, CreateGenreCommandResponse>
    {
        public Task<CreateGenreCommandResponse> Handle(CreateGenreCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}