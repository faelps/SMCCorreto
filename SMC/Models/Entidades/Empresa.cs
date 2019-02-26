using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SMC.Models.Entidades
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string AtividadePrincipal { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string CapitalRegistrado { get; set; }
        public string PatrimonioLiquido { get; set; }

       
        public int IdResponsavel { get; set; }
        [ForeignKey("IdResponsavel")]
        public virtual ResponsavelPelaEmpresa ResponsavelPelaEmpresa { get; set; }

        public string EnderecoRua { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoCidade { get; set; }
        public string EnderecoEstado { get; set; }
        public string EndercoCep { get; set; }
        public string EnderecoComplemento { get; set; }


        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        public virtual IList<ReferenciasBancarias> ReferenciasBancarias { get; set; }
        public virtual IList<ReferenciasComerciais> ReferenciasComerciais { get; set; }
        public virtual IList<Socios> Socios { get; set; }

    }
}