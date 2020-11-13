using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class ViewIndividualArtist
    {
        public int ArtistId { get; set; }
        public string ArtistFname { get; set; }
        public string ArtistLname { get; set; }
        public int ArtistTypeId { get; set; }
    }
}
