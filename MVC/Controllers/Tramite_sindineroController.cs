using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class Tramite_sindineroController : Controller
    {
        private ConexionBD db = new ConexionBD();

        // GET: Tramite_sindinero
        public ActionResult Index()
        {
            return View(db.Tramite_sindinero.ToList());
        }

        // GET: Tramite_sindinero/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite_sindinero tramite_sindinero = db.Tramite_sindinero.Find(id);
            if (tramite_sindinero == null)
            {
                return HttpNotFound();
            }
            return View(tramite_sindinero);
        }

        // GET: Tramite_sindinero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tramite_sindinero/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_tramite,Estado_tramite,Nombre_tramite,Tipo_tramite,Fecha_tramite,Transporte,Tiempo_tramite,Descripcion,Lugar_origen,Lugar_Destino,Costo_total")] Tramite_sindinero tramite_sindinero)
        {
            if (ModelState.IsValid)
            {
                db.Tramite_sindinero.Add(tramite_sindinero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tramite_sindinero);
        }

        // GET: Tramite_sindinero/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite_sindinero tramite_sindinero = db.Tramite_sindinero.Find(id);
            if (tramite_sindinero == null)
            {
                return HttpNotFound();
            }
            return View(tramite_sindinero);
        }

        // POST: Tramite_sindinero/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_tramite,Estado_tramite,Nombre_tramite,Tipo_tramite,Fecha_tramite,Transporte,Tiempo_tramite,Descripcion,Lugar_origen,Lugar_Destino,Costo_total")] Tramite_sindinero tramite_sindinero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tramite_sindinero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tramite_sindinero);
        }

        // GET: Tramite_sindinero/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite_sindinero tramite_sindinero = db.Tramite_sindinero.Find(id);
            if (tramite_sindinero == null)
            {
                return HttpNotFound();
            }
            return View(tramite_sindinero);
        }

        // POST: Tramite_sindinero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tramite_sindinero tramite_sindinero = db.Tramite_sindinero.Find(id);
            db.Tramite_sindinero.Remove(tramite_sindinero);
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
