using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMC.Models
{
    public class Autenticacao
    {
        public Autenticacao(DadosPessoais objDados) {

        }

        public int Id { get; set; }
        public int IdDadosPessoais { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public TipoUsuario EnumTipo { get; set; }


    }
}