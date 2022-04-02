using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2019ZH601_PRACTICA0204;

namespace _2019ZH601_PRACTICA0204.Controllers
{
    public class ColoresController : Controller
    {
        private ProductosEntities db = new ProductosEntities();

        // GET: Colores
        public ActionResult Index()
        {
            return View(db.Colores.ToList());
        }

        // GET: Colores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colore colore = db.Colores.Find(id);
            if (colore == null)
            {
                return HttpNotFound();
            }
            return View(colore);
        }

        // GET: Colores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,color,estado")] Colore colore)
        {
            if (ModelState.IsValid)
            {
                db.Colores.Add(colore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colore);
        }

        // GET: Colores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colore colore = db.Colores.Find(id);
            if (colore == null)
            {
                return HttpNotFound();
            }
            return View(colore);
        }

        // POST: Colores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,color,estado")] Colore colore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colore);
        }

        // GET: Colores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colore colore = db.Colores.Find(id);
            if (colore == null)
            {
                return HttpNotFound();
            }
            return View(colore);
        }

        // POST: Colores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Colore colore = db.Colores.Find(id);
            db.Colores.Remove(colore);
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
