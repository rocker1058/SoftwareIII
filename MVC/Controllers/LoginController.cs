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
    public class LoginController : Controller
    {
        private ConexionBD db = new ConexionBD();

        // GET: Login
        public ActionResult IndexV()
        {
            return View();
        }
        public ActionResult IndexLogT()
        {
            return View();
        }
        public ActionResult IndexLogA()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }
        public ActionResult DetailsA(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrador administrador = db.Administrador.Find(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            return View(administrador);
        }
        public ActionResult DetailsT(int? id)
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



        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorized(MVC.Models.Cliente usermodel1)
        {
            using (ConexionBD db = new ConexionBD())
            {
                var userDetails = db.Cliente.Where(x => x.CedulaC == usermodel1.CedulaC && x.Contraseña == usermodel1.Contraseña).FirstOrDefault();
                if (userDetails==null)
                {
                    
                    
                    return View("IndexV");
                }
                else
                {
                    Session["UserID"] = userDetails.CedulaC;
                    Session["UserName"] = userDetails.Nombres;
                    return RedirectToAction("Index", "Home");
                }
            }
                return View();
        }
        public ActionResult AuthorizedA(MVC.Models.Administrador usermodel1)
        {
            using (ConexionBD db = new ConexionBD())
            {
                var userDetails = db.Administrador.Where(x => x.CedulaA == usermodel1.CedulaA && x.Contraseña == usermodel1.Contraseña).FirstOrDefault();
                if (userDetails == null)
                {


                    return View("IndexLogA");
                }
                else
                {
                    Session["UserID"] = userDetails.CedulaA;
                    Session["UserName"] = userDetails.Nombres;
                    return RedirectToAction("IndexA", "Home");
                }
            }
            return View();
        }
        public ActionResult AuthorizedT(MVC.Models.Tramitador usermodel1)
        {
            using (ConexionBD db = new ConexionBD())
            {
                var userDetails = db.Tramitador.Where(x => x.CedulaT == usermodel1.CedulaT && x.ContraseñaT == usermodel1.ContraseñaT).FirstOrDefault();
                if (userDetails == null)
                {


                    return View("IndexLogT");
                }
                else
                {
                    Session["UserID"] = userDetails.CedulaT;
                    Session["UserName"] = userDetails.Nombres;
                    return RedirectToAction("IndexT", "Home");
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            int userid = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("IndexV", "Login");
        }
        // POST: Login/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CedulaC,Nombres,Apellidos,Correo,Contraseña,Telefono,Direccion")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Cliente.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Login/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CedulaC,Nombres,Apellidos,Correo,Contraseña,Telefono,Direccion")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Cliente.Find(id);
            db.Cliente.Remove(cliente);
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
