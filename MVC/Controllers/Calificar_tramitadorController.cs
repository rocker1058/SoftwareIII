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
    public class Calificar_tramitadorController : Controller
    {
        private ConexionBD db = new ConexionBD();

        // GET: Calificar_tramitador
        public ActionResult Index()
        {
            return View(db.Calificar_tramitador.ToList());
        }

        // GET: Calificar_tramitador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificar_tramitador calificar_tramitador = db.Calificar_tramitador.Find(id);
            if (calificar_tramitador == null)
            {
                return HttpNotFound();
            }
            return View(calificar_tramitador);
        }

        // GET: Calificar_tramitador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calificar_tramitador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombres,Fecha,Tipo,Descripcion,Estado,Calificacion,Comentarios")] Calificar_tramitador calificar_tramitador)
        {
            if (ModelState.IsValid)
            {
                db.Calificar_tramitador.Add(calificar_tramitador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calificar_tramitador);
        }

        // GET: Calificar_tramitador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificar_tramitador calificar_tramitador = db.Calificar_tramitador.Find(id);
            if (calificar_tramitador == null)
            {
                return HttpNotFound();
            }
            return View(calificar_tramitador);
        }

        // POST: Calificar_tramitador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombres,Fecha,Tipo,Descripcion,Estado,Calificacion,Comentarios")] Calificar_tramitador calificar_tramitador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificar_tramitador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calificar_tramitador);
        }

        // GET: Calificar_tramitador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificar_tramitador calificar_tramitador = db.Calificar_tramitador.Find(id);
            if (calificar_tramitador == null)
            {
                return HttpNotFound();
            }
            return View(calificar_tramitador);
        }

        // POST: Calificar_tramitador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calificar_tramitador calificar_tramitador = db.Calificar_tramitador.Find(id);
            db.Calificar_tramitador.Remove(calificar_tramitador);
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
