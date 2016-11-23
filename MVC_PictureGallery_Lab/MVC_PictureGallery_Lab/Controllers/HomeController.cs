
using ConnectionLayer;
using ConnectionLayer.Tables;
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
      //  GalleryCrud db = new FakeDb();
      

           

        // GET: Home
        public ActionResult Index()
        {
            var db = new Crud();
            db.AddAccount(new tbl_Account() { Fistname = "a", Lastname = "b" });
           
        //    List<PictureViewModel> Pictures = (db.GetPictures())as List<PictureViewModel>;
            return View();
        }
    }
}