using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiskInventory.Models;
using Microsoft.EntityFrameworkCore;

namespace DiskInventory.Controllers
{
    public class BorrowedItemController : Controller
    {
        private disk_inventorydbContext context { get; set; }

        public BorrowedItemController(disk_inventorydbContext ctx)
        {
            context = ctx;
        }
        public IActionResult List()                                         //creates the initial list of borrowed items from the database
        {
            List<BorrowedItem> borroweditems = context.BorrowedItem.OrderBy(db => db.BorrowDate).ThenBy(d => d.BorrowerId)
                .Include(d => d.Item).Include(b => b.Borrower).ToList();
            return View(borroweditems);
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Inventories = context.Inventory.OrderBy(d => d.ItemName).ToList();
            ViewBag.Borrowers = context.Borrower.OrderBy(b => b.BorrowerFname).ToList();
            return View("Edit", new BorrowedItem());
        }
                
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Inventories = context.Inventory.OrderBy(d => d.ItemName).ToList();
            ViewBag.Borrowers = context.Borrower.OrderBy(b => b.BorrowerFname).ToList();
            var borroweditem = context.BorrowedItem.Find(id);
            return View(borroweditem);
        }

        [HttpPost]
        public IActionResult Edit(BorrowedItem borroweditem)
        {
            if (ModelState.IsValid)
            {
                if (borroweditem.BorrowedItemID == 0)
                    context.BorrowedItem.Add(borroweditem);
                else
                    context.BorrowedItem.Update(borroweditem);
                context.SaveChanges();
                return RedirectToAction("List", "BorrowedItem");
            }
            else
            {
                ViewBag.Action = (borroweditem.BorrowedItemID == 0) ? "Add" : "Edit";
                ViewBag.Inventories = context.Inventory.OrderBy(d => d.ItemName).ToList();
                ViewBag.Borrowers = context.Borrower.OrderBy(b => b.BorrowerLname).ToList();
                return View(borroweditem);
            }
        }
    }
}
