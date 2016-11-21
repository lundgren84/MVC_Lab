using InterfaceDLL;
using MVC_PictureGallery_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PictureGallery_Lab.Controllers
{
   
    public class HomeController : Controller
    {
        ICrud db = new FakeDB();
      



        // GET: Home
        public ActionResult Index()
        {
            List<PictureViewModel> Pictures = (db.Read("Picture"))as List<PictureViewModel>;
            return View();
        }
    }
}