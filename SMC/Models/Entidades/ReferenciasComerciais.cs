using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMC.Models.Entidades
{
    public class ReferenciasComerciais
    {
        [Key]
        public int IdReferenciaComercial { get; set; }
        public string NomeDaLoja { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }

    }
}