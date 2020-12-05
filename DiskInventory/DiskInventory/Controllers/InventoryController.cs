using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiskInventory.Models;
using Microsoft.EntityFrameworkCore;

namespace DiskInventory.Controllers
{
    public class InventoryController : Controller                               
    {
        private disk_inventorydbContext context { get; set; }

        public InventoryController(disk_inventorydbContext ctx)
        {
            context = ctx;
        }
        public IActionResult List()                                             //creates the initial list of items from the database
        {
            List<Inventory> inventory_items = context.Inventory.OrderBy(a => a.ItemName).Include(g => g.Genre).Include(s => s.ItemStatus).Include(t => t.ItemType).ToList();
            return View(inventory_items);
        }

        [HttpGet]
        public IActionResult Add()                                              //adds an item to the database/list
        {
            ViewBag.Action = "Add";
            ViewBag.Genres = context.Genre.OrderBy(t => t.Description).ToList();                //for Genre dropdown box
            ViewBag.ItemStatuses = context.ItemStatus.OrderBy(t => t.Description).ToList();     //for Item Status dropdown box
            ViewBag.ItemTypes = context.ItemType.OrderBy(t => t.Description).ToList();          //for Item Type dropdown box
            return View("Edit", new Inventory());
        }

        [HttpGet]                                       
        public IActionResult Edit(int id)                                       //reads rows from the database/list to be edited
        {
            ViewBag.Action = "Edit";
            ViewBag.Genres = context.Genre.OrderBy(t => t.Description).ToList();                //for Genre dropdown box
            ViewBag.ItemStatuses = context.ItemStatus.OrderBy(t => t.Description).ToList();     //for Item Status dropdown box
            ViewBag.ItemTypes = context.ItemType.OrderBy(t => t.Description).ToList();          //for Item Type dropdown box
            var inventory = context.Inventory.Find(id);
            return View(inventory);
        }

        [HttpPost]
        public IActionResult Edit(Inventory inventory)                          //writes edited rows to the database/list
        {
            if (ModelState.IsValid)
            {
                if (inventory.ItemId == 0)
                {
                    context.Inventory.Add(inventory);
                }
                else
                {
                    context.Inventory.Update(inventory);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Inventory");
            }
            else
            {
                ViewBag.Action = (inventory.ItemId == 0) ? "Add" : "Edit";
                ViewBag.Genres = context.Genre.OrderBy(t => t.Description).ToList();                //for Genre dropdown box
                ViewBag.ItemStatuses = context.ItemStatus.OrderBy(t => t.Description).ToList();     //for Item Status dropdown box
                ViewBag.ItemTypes = context.ItemType.OrderBy(t => t.Description).ToList();          //for Item Type dropdown box
                return View(inventory);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)                                     //reads rows from the database/list to be deleted
        {
            var inventory = context.Inventory.Find(id);
            return View(inventory);
        }

        [HttpPost]
        public IActionResult Delete(Inventory inventory)                        //deletes rows from the database/list
        {
            context.Inventory.Remove(inventory);
            context.SaveChanges();
            return RedirectToAction("List", "Inventory");
        }
    }
}
