using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMC.Models.Entidades
{
    public class Socios
    {
        [Key]
        public int IdSocio { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Participacao { get; set; }
        public string Telefone { get; set; }
    }
}