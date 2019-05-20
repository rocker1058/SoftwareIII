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
    public class TramitesController : Controller
    {
        private ConexionBD db = new ConexionBD();

        // GET: Tramites
        public ActionResult Index()
        {
            var tramite = db.Tramite.Include(t => t.Cliente).Include(t => t.Tramitador);
            return View(tramite.ToList());
        }

        // GET: Tramites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite tramite = db.Tramite.Find(id);
            if (tramite == null)
            {
                return HttpNotFound();
            }
            return View(tramite);
        }

        // GET: Tramites/Create
        public ActionResult Create()
        {
            ViewBag.Idcliente = new SelectList(db.Cliente, "CedulaC", "Nombres");
            ViewBag.idtramitador = new SelectList(db.Tramitador, "CedulaT", "Nombres");
            return View();
        }

        // POST: Tramites/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtramite,Idcliente,idtramitador,estado")] Tramite tramite)
        {
            if (ModelState.IsValid)
            {
                db.Tramite.Add(tramite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Idcliente = new SelectList(db.Cliente, "CedulaC", "Nombres", tramite.Idcliente);
            ViewBag.idtramitador = new SelectList(db.Tramitador, "CedulaT", "Nombres", tramite.idtramitador);
            return View(tramite);
        }

        // GET: Tramites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite tramite = db.Tramite.Find(id);
            if (tramite == null)
            {
                return HttpNotFound();
            }
            ViewBag.Idcliente = new SelectList(db.Cliente, "CedulaC", "Nombres", tramite.Idcliente);
            ViewBag.idtramitador = new SelectList(db.Tramitador, "CedulaT", "Nombres", tramite.idtramitador);
            return View(tramite);
        }

        // POST: Tramites/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtramite,Idcliente,idtramitador,estado")] Tramite tramite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tramite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Idcliente = new SelectList(db.Cliente, "CedulaC", "Nombres", tramite.Idcliente);
            ViewBag.idtramitador = new SelectList(db.Tramitador, "CedulaT", "Nombres", tramite.idtramitador);
            return View(tramite);
        }

        // GET: Tramites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite tramite = db.Tramite.Find(id);
            if (tramite == null)
            {
                return HttpNotFound();
            }
            return View(tramite);
        }

        // POST: Tramites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tramite tramite = db.Tramite.Find(id);
            db.Tramite.Remove(tramite);
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
