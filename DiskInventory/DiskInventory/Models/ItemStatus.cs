using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class ItemStatus
    {
        public ItemStatus()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int ItemStatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
