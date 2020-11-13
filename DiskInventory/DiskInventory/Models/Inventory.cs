using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class Inventory
    {
        public Inventory()
        {
            ArtistItem = new HashSet<ArtistItem>();
            BorrowedItem = new HashSet<BorrowedItem>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public int ItemStatusId { get; set; }
        public int ItemTypeId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ItemStatus ItemStatus { get; set; }
        public virtual Itemtype ItemType { get; set; }
        public virtual ICollection<ArtistItem> ArtistItem { get; set; }
        public virtual ICollection<BorrowedItem> BorrowedItem { get; set; }
    }
}
