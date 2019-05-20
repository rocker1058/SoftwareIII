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
    public class Tramite_condineroController : Controller
    {
        private ConexionBD db = new ConexionBD();

        // GET: Tramite_condinero
        public ActionResult Index()
        {
            return View(db.Tramite_condinero.ToList());
        }

        // GET: Tramite_condinero/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite_condinero tramite_condinero = db.Tramite_condinero.Find(id);
            if (tramite_condinero == null)
            {
                return HttpNotFound();
            }
            return View(tramite_condinero);
        }

        // GET: Tramite_condinero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tramite_condinero/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_tramite,Estado_tramite,Nombre_tramite,Tipo_tramite,Fecha_tramite,Transporte,Tiempo_tramite,Descripcion,Lugar_origen,Lugar_Destino,Monto,Costo_total")] Tramite_condinero tramite_condinero)
        {
            if (ModelState.IsValid)
            {
                db.Tramite_condinero.Add(tramite_condinero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tramite_condinero);
        }

        // GET: Tramite_condinero/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite_condinero tramite_condinero = db.Tramite_condinero.Find(id);
            if (tramite_condinero == null)
            {
                return HttpNotFound();
            }
            return View(tramite_condinero);
        }

        // POST: Tramite_condinero/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_tramite,Estado_tramite,Nombre_tramite,Tipo_tramite,Fecha_tramite,Transporte,Tiempo_tramite,Descripcion,Lugar_origen,Lugar_Destino,Monto,Costo_total")] Tramite_condinero tramite_condinero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tramite_condinero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tramite_condinero);
        }

        // GET: Tramite_condinero/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite_condinero tramite_condinero = db.Tramite_condinero.Find(id);
            if (tramite_condinero == null)
            {
                return HttpNotFound();
            }
            return View(tramite_condinero);
        }

        // POST: Tramite_condinero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tramite_condinero tramite_condinero = db.Tramite_condinero.Find(id);
            db.Tramite_condinero.Remove(tramite_condinero);
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
