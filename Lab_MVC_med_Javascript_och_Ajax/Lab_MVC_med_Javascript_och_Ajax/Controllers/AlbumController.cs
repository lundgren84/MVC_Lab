using Lab_MVC_med_Javascript_och_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_MVC_med_Javascript_och_Ajax.Controllers
{
    public class AlbumController : Controller
    {
        GalleryDbContext db = new GalleryDbContext();
        // GET: Album
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AlbumViewModels Album)
        {
            Album.Id = new Guid();
            if (ModelState.IsValid)
            {
                db.AlbumViewModels.Add(Album);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(Album);
        }
    }
}