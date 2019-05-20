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
    public class Calificar_clienteController : Controller
    {
        private ConexionBD db = new ConexionBD();

        // GET: Calificar_cliente
        public ActionResult Index()
        {
            return View(db.Calificar_cliente.ToList());
        }

        // GET: Calificar_cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificar_cliente calificar_cliente = db.Calificar_cliente.Find(id);
            if (calificar_cliente == null)
            {
                return HttpNotFound();
            }
            return View(calificar_cliente);
        }

        // GET: Calificar_cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calificar_cliente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombres,Fecha,Tipo,Descripcion,Estado,Calificacion,Comentarios")] Calificar_cliente calificar_cliente)
        {
            if (ModelState.IsValid)
            {
                db.Calificar_cliente.Add(calificar_cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calificar_cliente);
        }

        // GET: Calificar_cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificar_cliente calificar_cliente = db.Calificar_cliente.Find(id);
            if (calificar_cliente == null)
            {
                return HttpNotFound();
            }
            return View(calificar_cliente);
        }

        // POST: Calificar_cliente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombres,Fecha,Tipo,Descripcion,Estado,Calificacion,Comentarios")] Calificar_cliente calificar_cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificar_cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calificar_cliente);
        }

        // GET: Calificar_cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificar_cliente calificar_cliente = db.Calificar_cliente.Find(id);
            if (calificar_cliente == null)
            {
                return HttpNotFound();
            }
            return View(calificar_cliente);
        }

        // POST: Calificar_cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calificar_cliente calificar_cliente = db.Calificar_cliente.Find(id);
            db.Calificar_cliente.Remove(calificar_cliente);
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
