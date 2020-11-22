using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiskInventory.Models
{
    public partial class Borrower
    {
        public Borrower()
        {
            BorrowedItem = new HashSet<BorrowedItem>();
        }

        public int BorrowerId { get; set; }

        [Required(ErrorMessage="Please enter a First Name.")]
        public string BorrowerFname { get; set; }

        //my BorrowerLname column in the database is set to allow nulls so cannot add a required statement
        public string BorrowerLname { get; set; }
        
        [Required(ErrorMessage = "Please enter a valid phone number.")]
        public string BorrowerPhone { get; set; }

        public virtual ICollection<BorrowedItem> BorrowedItem { get; set; }
    }
}
