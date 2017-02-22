using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using slnPetAdmin.Models;

namespace slnPetAdmin.Controllers
{
    public class aniDataPicsController : Controller
    {
        private petstationEntities db = new petstationEntities();

        // GET: aniDataPics
        public ActionResult Index()
        {
            return View(db.aniDataPic.ToList());
        }

        // GET: aniDataPics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aniDataPic aniDataPic = db.aniDataPic.Find(id);
            if (aniDataPic == null)
            {
                return HttpNotFound();
            }
            return View(aniDataPic);
        }

        // GET: aniDataPics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: aniDataPics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "animalID,animalName,animalKind,animalType,animalColor,animalGender,animalAddress,animalAge,animalPicAddress,animalOwner_userID")] aniDataPic aniDataPic)
        {
            if (ModelState.IsValid)
            {
                db.aniDataPic.Add(aniDataPic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aniDataPic);
        }

        // GET: aniDataPics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aniDataPic aniDataPic = db.aniDataPic.Find(id);
            if (aniDataPic == null)
            {
                return HttpNotFound();
            }
            return View(aniDataPic);
        }

        // POST: aniDataPics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "animalID,animalName,animalKind,animalType,animalColor,animalGender,animalAddress,animalAge,animalPicAddress,animalOwner_userID")] aniDataPic aniDataPic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aniDataPic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aniDataPic);
        }

        // GET: aniDataPics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aniDataPic aniDataPic = db.aniDataPic.Find(id);
            if (aniDataPic == null)
            {
                return HttpNotFound();
            }
            return View(aniDataPic);
        }

        // POST: aniDataPics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            aniDataPic aniDataPic = db.aniDataPic.Find(id);
            db.aniDataPic.Remove(aniDataPic);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
