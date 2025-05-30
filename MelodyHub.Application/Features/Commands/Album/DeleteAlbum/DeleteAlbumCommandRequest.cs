﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Album.DeleteAlbum
{
    public class DeleteAlbumCommandRequest : IRequest<DeleteAlbumCommandResponse>
    {
        public int Id { get; set; }
    }
}