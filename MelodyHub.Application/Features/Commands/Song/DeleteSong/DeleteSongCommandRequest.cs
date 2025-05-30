﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Song.DeleteSong
{
    public class DeleteSongCommandRequest : IRequest<DeleteSongCommandResponse>
    {
     public int Id { get; set; }
    }
    
}