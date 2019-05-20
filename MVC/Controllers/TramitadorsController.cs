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
    public class TramitadorsController : Controller
    {
        private ConexionBD db = new ConexionBD();

        // GET: Tramitadors
        public ActionResult Index()
        {
            return View(db.Tramitador.ToList());
        }

        // GET: Tramitadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramitador tramitador = db.Tramitador.Find(id);
            if (tramitador == null)
            {
                return HttpNotFound();
            }
            return View(tramitador);
        }

        // GET: Tramitadors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tramitadors/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CedulaT,Nombres,Apellidos,Privilegios,Telefono,Email,Direccion,ContraseñaT,Fecha_nacimiento,Pasado_judicial,Descripcion,Experiencia,Tipo_vehiculo")] Tramitador tramitador)
        {
            if (ModelState.IsValid)
            {
                db.Tramitador.Add(tramitador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tramitador);
        }

        // GET: Tramitadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramitador tramitador = db.Tramitador.Find(id);
            if (tramitador == null)
            {
                return HttpNotFound();
            }
            return View(tramitador);
        }

        // POST: Tramitadors/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CedulaT,Nombres,Apellidos,Privilegios,Telefono,Email,Direccion,ContraseñaT,Fecha_nacimiento,Pasado_judicial,Descripcion,Experiencia,Tipo_vehiculo")] Tramitador tramitador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tramitador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tramitador);
        }

        // GET: Tramitadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramitador tramitador = db.Tramitador.Find(id);
            if (tramitador == null)
            {
                return HttpNotFound();
            }
            return View(tramitador);
        }

        // POST: Tramitadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tramitador tramitador = db.Tramitador.Find(id);
            db.Tramitador.Remove(tramitador);
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
