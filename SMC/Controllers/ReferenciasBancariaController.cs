using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SMC.Models.Contexto;
using SMC.Models.Entidades;

namespace SMC.Controllers
{
    public class ReferenciasBancariaController : Controller
    {
        private Contexto db = new Contexto();

        // GET: ReferenciasBancaria
        public ActionResult Index()
        {
            return View(db.ReferenciasBancariasDb.ToList());
        }

        // GET: ReferenciasBancaria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasBancarias referenciasBancarias = db.ReferenciasBancariasDb.Find(id);
            if (referenciasBancarias == null)
            {
                return HttpNotFound();
            }
            return View(referenciasBancarias);
        }

        // GET: ReferenciasBancaria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferenciasBancaria/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdReferencia,NomeDoBanco,GerenteDaConta,Telefone")] ReferenciasBancarias referenciasBancarias)
        {
            if (ModelState.IsValid)
            {
                db.ReferenciasBancariasDb.Add(referenciasBancarias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referenciasBancarias);
        }

        // GET: ReferenciasBancaria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasBancarias referenciasBancarias = db.ReferenciasBancariasDb.Find(id);
            if (referenciasBancarias == null)
            {
                return HttpNotFound();
            }
            return View(referenciasBancarias);
        }

        // POST: ReferenciasBancaria/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdReferencia,NomeDoBanco,GerenteDaConta,Telefone")] ReferenciasBancarias referenciasBancarias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referenciasBancarias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referenciasBancarias);
        }

        // GET: ReferenciasBancaria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasBancarias referenciasBancarias = db.ReferenciasBancariasDb.Find(id);
            if (referenciasBancarias == null)
            {
                return HttpNotFound();
            }
            return View(referenciasBancarias);
        }

        // POST: ReferenciasBancaria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferenciasBancarias referenciasBancarias = db.ReferenciasBancariasDb.Find(id);
            db.ReferenciasBancariasDb.Remove(referenciasBancarias);
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
