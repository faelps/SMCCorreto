using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMC.Models.Entidades
{
    public class ReferenciasBancarias
    {
        [Key]
        public int IdReferencia { get; set; }
        public string NomeDoBanco { get; set; }
        public string GerenteDaConta { get; set; }
        public string Telefone { get; set; }
    }
}