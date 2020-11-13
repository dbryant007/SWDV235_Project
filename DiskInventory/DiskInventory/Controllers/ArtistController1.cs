using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiskInventory.Models;

namespace DiskInventory.Controllers
{
    public class ArtistController : Controller                      //updated ArtistController Class
    {
        private disk_inventorydbContext context { get; set; }
        public ArtistController(disk_inventorydbContext ctx)
        {
            context = ctx;
        }
        public IActionResult List()
        {
            List<Artist> artists = context.Artist.OrderBy(a => a.ArtistLname).ToList();
            return View(artists);
        }
    }
}
