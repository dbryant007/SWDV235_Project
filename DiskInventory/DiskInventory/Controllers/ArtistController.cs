using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiskInventory.Models;
using Microsoft.EntityFrameworkCore;

namespace DiskInventory.Controllers
{
    public class ArtistController : Controller                      
    {
        private disk_inventorydbContext context { get; set; }

        public ArtistController(disk_inventorydbContext ctx)
        {
            context = ctx;
        }
        public IActionResult List()                                         //creates the initial list of artists from the database
        {
            List<Artist> artists = context.Artist.OrderBy(a => a.ArtistLname).ThenBy(a => a.ArtistFname).Include(t => t.ArtistType).ToList();
            return View(artists);
        }

        [HttpGet]
        public IActionResult Add()                                          //adds an item to the database/list
        {
            ViewBag.Action = "Add";
            ViewBag.ArtistTypes = context.ArtistType.OrderBy(t => t.Description).ToList();  //for dropdown box
            return View("Edit", new Artist());
        }

        [HttpGet]
        public IActionResult Edit(int id)                                   //reads rows from the database/list to be edited
        {
            ViewBag.Action = "Edit";
            ViewBag.ArtistTypes = context.ArtistType.OrderBy(t => t.Description).ToList();  //for dropdown box
            var artist = context.Artist.Find(id);
            return View(artist);
        }

        [HttpPost]
        public IActionResult Edit(Artist artist)                            //writes edited rows to the database/list
        {
            if(ModelState.IsValid)
            {
                if (artist.ArtistId == 0)
                {
                    context.Artist.Add(artist);
                }
                else
                {
                    context.Artist.Update(artist);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Artist");
            }
            else
            {
                ViewBag.Action = (artist.ArtistId == 0) ? "Add" : "Edit";
                ViewBag.ArtistTypes = context.ArtistType.OrderBy(t => t.Description).ToList();  //for dropdown box
                return View(artist);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)                                  //reads rows from the database/list to be deleted
        {
            var artist = context.Artist.Find(id);
            return View(artist);
        }

        [HttpPost]
        public IActionResult Delete(Artist artist)                          //deletes rows from the database/list
        {
            context.Artist.Remove(artist);
            context.SaveChanges();
            return RedirectToAction("List", "Artist");
        }
    }
}
