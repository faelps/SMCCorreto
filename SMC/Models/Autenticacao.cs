using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMC.Models
{
    public class Autenticacao
    {
        public Autenticacao() {

        }

        public int Id { get; set; }
        public int DadosPessoaisId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public TipoUsuario EnumTipo { get; set; }


    }
}