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
    public class ReferenciasComerciaisController : Controller
    {
        private Contexto db = new Contexto();

        // GET: ReferenciasComerciais
        public ActionResult Index()
        {
            return View(db.ReferenciasComerciaisDB.ToList());
        }

        // GET: ReferenciasComerciais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasComerciais referenciasComerciais = db.ReferenciasComerciaisDB.Find(id);
            if (referenciasComerciais == null)
            {
                return HttpNotFound();
            }
            return View(referenciasComerciais);
        }

        // GET: ReferenciasComerciais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferenciasComerciais/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdReferenciaComercial,NomeDaLoja,Telefone")] ReferenciasComerciais referenciasComerciais)
        {
            if (ModelState.IsValid)
            {
                db.ReferenciasComerciaisDB.Add(referenciasComerciais);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referenciasComerciais);
        }

        // GET: ReferenciasComerciais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasComerciais referenciasComerciais = db.ReferenciasComerciaisDB.Find(id);
            if (referenciasComerciais == null)
            {
                return HttpNotFound();
            }
            return View(referenciasComerciais);
        }

        // POST: ReferenciasComerciais/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdReferenciaComercial,NomeDaLoja,Telefone")] ReferenciasComerciais referenciasComerciais)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referenciasComerciais).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referenciasComerciais);
        }

        // GET: ReferenciasComerciais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferenciasComerciais referenciasComerciais = db.ReferenciasComerciaisDB.Find(id);
            if (referenciasComerciais == null)
            {
                return HttpNotFound();
            }
            return View(referenciasComerciais);
        }

        // POST: ReferenciasComerciais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferenciasComerciais referenciasComerciais = db.ReferenciasComerciaisDB.Find(id);
            db.ReferenciasComerciaisDB.Remove(referenciasComerciais);
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
