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
    public class EmpresaController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Empresa
        public ActionResult Index()
        {
            var empresaDb = db.EmpresaDb.Include(e => e.ResponsavelPelaEmpresa);
            return View(empresaDb.ToList());
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = db.EmpresaDb.Find(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            ViewBag.IdResponsavel = new SelectList(db.ResponsavelPelaEmpresasDb, "IdResponsavel", "Nome");
            return View();
        }

        // POST: Empresa/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEmpresa,RazaoSocial,NomeFantasia,AtividadePrincipal,Cnpj,InscricaoEstadual,CapitalRegistrado,PatrimonioLiquido,IdResponsavel,EnderecoRua,EnderecoNumero,EnderecoBairro,EnderecoCidade,EnderecoEstado,EndercoCep,EnderecoComplemento,Telefone,Email,Celular")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                db.EmpresaDb.Add(empresa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdResponsavel = new SelectList(db.ResponsavelPelaEmpresasDb, "IdResponsavel", "Nome", empresa.IdResponsavel);
            return View(empresa);
        }

        // GET: Empresa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = db.EmpresaDb.Find(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdResponsavel = new SelectList(db.ResponsavelPelaEmpresasDb, "IdResponsavel", "Nome", empresa.IdResponsavel);
            return View(empresa);
        }

        // POST: Empresa/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEmpresa,RazaoSocial,NomeFantasia,AtividadePrincipal,Cnpj,InscricaoEstadual,CapitalRegistrado,PatrimonioLiquido,IdResponsavel,EnderecoRua,EnderecoNumero,EnderecoBairro,EnderecoCidade,EnderecoEstado,EndercoCep,EnderecoComplemento,Telefone,Email,Celular")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdResponsavel = new SelectList(db.ResponsavelPelaEmpresasDb, "IdResponsavel", "Nome", empresa.IdResponsavel);
            return View(empresa);
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = db.EmpresaDb.Find(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        // POST: Empresa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empresa empresa = db.EmpresaDb.Find(id);
            db.EmpresaDb.Remove(empresa);
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
