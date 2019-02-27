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
      


        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //  public ActionResult Create(Empresa empresa)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.EmpresaDb.Add(empresa);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(empresa);
        //}

        // GET: Empresa/Edit/5
       
    }
}
