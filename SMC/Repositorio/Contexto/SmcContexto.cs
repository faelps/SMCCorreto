using SMC.Models;
using SMC.Repositorio.Mapeamento;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SMC.Repositorio.Contexto
{
    public class SmcContexto: DbContext
    {
        public SmcContexto(): base("ConexaoBancoPostGree")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<SmcContexto>(null);
        }

        public DbSet<Endereco> EnderecoDb { get; set; }
        public DbSet<Empresas> EmpresaDb { get; set; }
        public DbSet<DadosPessoais> DadosPessoaisDb { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EnderecoMap());
      
        }


    }
}