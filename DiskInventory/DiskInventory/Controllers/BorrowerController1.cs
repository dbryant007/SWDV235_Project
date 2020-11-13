using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiskInventory.Models;

namespace DiskInventory.Controllers
{
    public class BorrowerController : Controller                                //updated BorrowerController Class
    { 
        private disk_inventorydbContext context { get; set; }
        
        public BorrowerController(disk_inventorydbContext ctx)
        {
            context = ctx;
        }
        public IActionResult List()
        {
            List<Borrower> borrowers = context.Borrower.OrderBy(a => a.BorrowerLname).ToList();
            return View(borrowers);
        }
    }
}
