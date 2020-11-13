using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiskInventory.Models;

namespace DiskInventory.Controllers
{
    public class InventoryController : Controller                               //updated InventoryController Class
    {
        private disk_inventorydbContext context { get; set; }

        public InventoryController(disk_inventorydbContext ctx)
        {
            context = ctx;
        }
        public IActionResult List()
        {
            List<Inventory> inventory_items = context.Inventory.OrderBy(a => a.ItemName).ToList();
            return View(inventory_items);
        }
    }
}
