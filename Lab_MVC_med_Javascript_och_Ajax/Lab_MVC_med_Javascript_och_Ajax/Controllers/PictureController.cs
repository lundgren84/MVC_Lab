using Lab_MVC_med_Javascript_och_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Lab_MVC_med_Javascript_och_Ajax.Controllers
{
    public class PictureController : Controller
   {

        private GalleryDbContext db = new GalleryDbContext();



        // GET: Pictures

        public ActionResult Index()

        {

            return View(db.Pictures.ToList());

        }

        public ActionResult Change(int? id)

        {

            return View();

        }



        // GET: Pictures/Details/5

        public ActionResult Details(int? id)

        {

            if (id == null)

            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Picture picture = db.Pictures.Find(id);

            if (picture == null)

            {

                return HttpNotFound();

            }

            return View(picture);

        }



        // GET: Pictures/Create

        public ActionResult Create()

        {

            return View();

        }



        // POST: Pictures/Create

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Create(Picture picture, HttpPostedFileBase file)

        {

            if (ModelState.IsValid)

            {

                file.SaveAs(Path.Combine(Server.MapPath("~/Saves"), file.FileName));

                picture.url = $@"/Saves/" + file.FileName;

                picture.Size = file.ContentLength;

                db.Pictures.Add(picture);

                db.SaveChanges();

                return RedirectToAction("Index", "Gallery");

            }



            return View(picture);

        }



        // GET: Pictures/Edit/5

        public ActionResult Edit(int? id)

        {

            if (id == null)

            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Picture picture = db.Pictures.Find(id);

            if (picture == null)

            {

                return HttpNotFound();

            }

            return View(picture);

        }



        // POST: Pictures/Edit/5

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Edit([Bind(Include = "id,Title,url,Size")] Picture picture)

        {

            if (ModelState.IsValid)

            {

                db.Entry(picture).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(picture);

        }



        // GET: Pictures/Delete/5

        public ActionResult Delete(int? id)

        {

            if (id == null)

            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Picture picture = db.Pictures.Find(id);

            if (picture == null)

            {

                return HttpNotFound();

            }

            return View(picture);

        }



        // POST: Pictures/Delete/5

        [HttpPost, ActionName("Delete")]

        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)

        {

            Picture picture = db.Pictures.Find(id);

            var comments = db.Comments.Where(x => x.PictureRefID == id);

            //Delete all comments from db

            foreach (var item in comments)

            {

                db.Comments.Remove(item);

            }

            // Här använder jag min metod Theres (Delete the picturefile from server)

            RemoveFileFromServer((db.Pictures.FirstOrDefault(x => x.id == id).url));

            //delete Picture from db

            db.Pictures.Remove(picture);

            db.SaveChanges();



            return RedirectToAction("Index,Gallery");

        }



        protected override void Dispose(bool disposing)

        {

            if (disposing)

            {

                db.Dispose();

            }

            base.Dispose(disposing);

        }

        private bool RemoveFileFromServer(string path)

        {

            var fullPath = Request.MapPath(path);

            if (!System.IO.File.Exists(fullPath)) return false;



            try 

            {

                System.IO.File.Delete(fullPath);

                return true;

            }

            catch (Exception e)

            {

              //  Debug.WriteLine(e.Message);

            }

            return false;

        }

    }
}