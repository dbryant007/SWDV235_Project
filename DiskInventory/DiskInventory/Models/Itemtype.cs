using System;
using System.Collections.Generic;

namespace DiskInventory.Models
{
    public partial class Itemtype
    {
        public Itemtype()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int ItemTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
