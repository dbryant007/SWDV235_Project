using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int GenreId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
