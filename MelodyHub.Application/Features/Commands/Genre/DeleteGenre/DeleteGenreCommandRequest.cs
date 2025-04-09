using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Genre.DeleteGenre
{
    public class DeleteGenreCommandRequest : IRequest<DeleteGenreCommandResponse>
    {
        public int GenreId { get; set; }
    }
}