using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMC.Models
{
    public class Permissoes
    {
        public int IdPermissao { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}