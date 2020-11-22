using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        
        [Required(ErrorMessage = "Please enter an Item Name.")] 
        public string ItemName { get; set; }
        
        [Required(ErrorMessage = "Please enter a Release Date.")] 
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        [Required] 
        public int GenreId { get; set; }

        [Required]
        public int ItemStatusId { get; set; }

        [Required]
        public int ItemTypeId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ItemStatus ItemStatus { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual ICollection<ArtistItem> ArtistItem { get; set; }
        public virtual ICollection<BorrowedItem> BorrowedItem { get; set; }
    }
}
