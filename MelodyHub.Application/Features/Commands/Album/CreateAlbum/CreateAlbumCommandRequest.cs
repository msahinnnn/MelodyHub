﻿using Amazon.Runtime.Internal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Album.CreateAlbum
{
    public class CreateAlbumCommandRequest : IRequest<CreateAlbumCommandResponse>
    {
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
    }
}