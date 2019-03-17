using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMC.Models
{
    public class Empresas
    {

        public int Id { get; set; }
        public DateTime Criacao { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
    }
}