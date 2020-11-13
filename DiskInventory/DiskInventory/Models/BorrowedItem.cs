using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class BorrowedItem
    {
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BorrowerId { get; set; }
        public int ItemId { get; set; }

        public virtual Borrower Borrower { get; set; }
        public virtual Inventory Item { get; set; }
    }
}
