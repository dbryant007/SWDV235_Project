using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiskInventory.Models;
using System.ComponentModel.DataAnnotations;                            // added for Project 4

namespace DiskInventory.Models
{
    public partial class BorrowedItem
    {
        public int BorrowedItemID { get; set; }                         // added for Project 4
        
        [Required(ErrorMessage = "Please enter a borrower.")]            // added for Project 4
        public int BorrowerId { get; set; }
        public virtual Borrower Borrower { get; set; }

        [Required(ErrorMessage = "Please enter an item.")]             // added for Project 4
        public int ItemId { get; set; }
        public virtual Inventory Item { get; set; }

        [Required(ErrorMessage = "Please enter a borrowed date.")]      // added for Project 4
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }

}
