﻿using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class Artist
    {
        public Artist()
        {
            ArtistItem = new HashSet<ArtistItem>();
        }

        public int ArtistId { get; set; }
        public string ArtistFname { get; set; }
        public string ArtistLname { get; set; }
        public int ArtistTypeId { get; set; }

        public virtual Artisttype ArtistType { get; set; }
        public virtual ICollection<ArtistItem> ArtistItem { get; set; }
    }
}
