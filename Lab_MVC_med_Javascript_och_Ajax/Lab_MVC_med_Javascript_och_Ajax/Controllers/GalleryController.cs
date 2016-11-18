using Lab_MVC_med_Javascript_och_Ajax.DBConnection;
using Lab_MVC_med_Javascript_och_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_MVC_med_Javascript_och_Ajax.Controllers
{
    public class GalleryController : Controller
    {    
        List<Picture> Pictures = CRUD.GetPictures();
        private GalleryDbContext db = new GalleryDbContext();
        public ActionResult Index()
        {
           
            return View(Pictures);
        }
        public ActionResult Uppload()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Show(int id)
        {
            var model = GetPictureFromDB(id);
            return View(model);
        }
        public ActionResult Comment(int id)
        {                  
            return View(((GetPictureFromDB(id)).FillAllData()));
        }

        private Picture GetPictureFromDB(int id)
        {
            return  Pictures.FirstOrDefault(x=> x.id == id);           
        }
    }
}