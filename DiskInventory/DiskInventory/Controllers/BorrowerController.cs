using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiskInventory.Models;

namespace DiskInventory.Controllers
{
    public class BorrowerController : Controller                                
    { 
        private disk_inventorydbContext context { get; set; }
        
        public BorrowerController(disk_inventorydbContext ctx)
        {
            context = ctx;
        }
        public IActionResult List()                                              //creates the initial list of borrowers from the database
        {
            List<Borrower> borrowers = context.Borrower.OrderBy(a => a.BorrowerLname).ThenBy(a => a.BorrowerFname).ToList();
            return View(borrowers);
        }

        [HttpGet]                                               
        public IActionResult Add()                                              //adds an item to the database/list
        {
            ViewBag.Action = "Add";
            return View("Edit", new Borrower());
        }

        [HttpGet]
        public IActionResult Edit(int id)                                       //reads rows from the database/list to be edited
        {
            ViewBag.Action = "Edit";
            var borrower = context.Borrower.Find(id);
            return View(borrower);
        }

        [HttpPost]
        public IActionResult Edit(Borrower borrower)                            //writes edited rows to the database/list
        {
            if (ModelState.IsValid)
            {
                if (borrower.BorrowerId == 0)
                {
                    context.Borrower.Add(borrower);
                }
                else
                {
                    context.Borrower.Update(borrower);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Borrower");
            }
            else
            {
                ViewBag.Action = (borrower.BorrowerId == 0) ? "Add" : "Edit";
                return View(borrower);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)                                     //reads rows from the database/list to be deleted
        {
            var borrower = context.Borrower.Find(id);
            return View(borrower);
        }

        [HttpPost]
        public IActionResult Delete(Borrower borrower)                          //deletes rows from the database/list
        {
            context.Borrower.Remove(borrower);
            context.SaveChanges();
            return RedirectToAction("List", "Borrower");
        }
    }
}
