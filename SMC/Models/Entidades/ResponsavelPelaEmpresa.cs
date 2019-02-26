using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMC.Models.Entidades
{
    public class ResponsavelPelaEmpresa
    {
        [Key]
        public int IdResponsavel { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string OrgaoExpeditor { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string DataDeNascimento { get; set; }
        public string NomeDoPai { get; set; }
        public string NomeDaMae { get; set; }
        public string Naturalidade { get; set; }
        public string Nacionalidade { get; set; }
        public string Profissao { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
    }
}