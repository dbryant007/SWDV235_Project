using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class ArtistItem
    {
        public int ArtistId { get; set; }
        public int ItemId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Inventory Item { get; set; }
    }
}
