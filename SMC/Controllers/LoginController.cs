using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMC.Controllers
{
    public class LoginController : Controller
    {

        Models.DadosPessoais DadosPessoais = new Models.DadosPessoais();

        public LoginController() {
            Models.Autenticacao Autenticacao = new Models.Autenticacao();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // POST

       // public ActionResult Index(Models.Autenticacao autenticacao) {
         //   return View(autenticacao);
        //}

        public ActionResult Painel() {
            return View();
        }


    }
}