using MelodyHub.Domain.Entitites.Cammon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Domain.Entitites
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
