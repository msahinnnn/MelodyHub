﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Genre.CreateGenre
{
    public class CreateGenreCommandRequest : IRequest<CreateGenreCommandResponse>
    {
        public string Name { get; set; }
    }
}