using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class Artisttype
    {
        public Artisttype()
        {
            Artist = new HashSet<Artist>();
        }

        public int ArtistTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Artist> Artist { get; set; }
    }
}
