using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

       
        public int IdEndereco { get; set; }
        public virtual  Endereco Endereco { get; set; }
    }
}