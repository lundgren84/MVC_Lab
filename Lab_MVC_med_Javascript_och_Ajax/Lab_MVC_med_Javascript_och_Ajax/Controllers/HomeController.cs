using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_MVC_med_Javascript_och_Ajax.Controllers
{
    public class HomeController : Controller
    {
        GalleryDbContext db = new GalleryDbContext();
        public ActionResult Index()
        {
            var Albums = db.AlbumViewModels.ToList();
            return View(Albums);
        }
        public ActionResult Information()
        {
            return View();
        }
        public ActionResult Test() { Dictionary<string, object> data = new Dictionary<string, object>(); data.Add("Placeholder", "Placeholder"); return View(data); }


    }
}