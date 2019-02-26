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
    public class ResponsavelPelaEmpresaController : Controller
    {
        private Contexto db = new Contexto();

        // GET: ResponsavelPelaEmpresa
        public ActionResult Index()
        {
            return View(db.ResponsavelPelaEmpresasDb.ToList());
        }

        // GET: ResponsavelPelaEmpresa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResponsavelPelaEmpresa responsavelPelaEmpresa = db.ResponsavelPelaEmpresasDb.Find(id);
            if (responsavelPelaEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(responsavelPelaEmpresa);
        }

        // GET: ResponsavelPelaEmpresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResponsavelPelaEmpresa/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ResponsavelPelaEmpresa responsavelPelaEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.ResponsavelPelaEmpresasDb.Add(responsavelPelaEmpresa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(responsavelPelaEmpresa);
        }

        // GET: ResponsavelPelaEmpresa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResponsavelPelaEmpresa responsavelPelaEmpresa = db.ResponsavelPelaEmpresasDb.Find(id);
            if (responsavelPelaEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(responsavelPelaEmpresa);
        }

        // POST: ResponsavelPelaEmpresa/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdResponsavel,Nome,Cpf,Rg,Telefone,DataDeNascimento,Sexo,EstadoCivil")] ResponsavelPelaEmpresa responsavelPelaEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(responsavelPelaEmpresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(responsavelPelaEmpresa);
        }

        // GET: ResponsavelPelaEmpresa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResponsavelPelaEmpresa responsavelPelaEmpresa = db.ResponsavelPelaEmpresasDb.Find(id);
            if (responsavelPelaEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(responsavelPelaEmpresa);
        }

        // POST: ResponsavelPelaEmpresa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResponsavelPelaEmpresa responsavelPelaEmpresa = db.ResponsavelPelaEmpresasDb.Find(id);
            db.ResponsavelPelaEmpresasDb.Remove(responsavelPelaEmpresa);
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
