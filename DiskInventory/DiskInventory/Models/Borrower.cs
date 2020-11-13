using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class Borrower
    {
        public Borrower()
        {
            BorrowedItem = new HashSet<BorrowedItem>();
        }

        public int BorrowerId { get; set; }
        public string BorrowerFname { get; set; }
        public string BorrowerLname { get; set; }
        public string BorrowerPhone { get; set; }

        public virtual ICollection<BorrowedItem> BorrowedItem { get; set; }
    }
}
