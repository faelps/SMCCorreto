using SMC.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SMC.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto() : base("SMC")
        {

        }

        public DbSet<Empresa> EmpresaDb { get; set; }
        public DbSet<ReferenciasBancarias> ReferenciasBancariasDb { get; set; }
        public DbSet<ReferenciasComerciais> ReferenciasComerciaisDB { get; set; }
        public DbSet<ResponsavelPelaEmpresa> ResponsavelPelaEmpresasDb { get; set; }
        public DbSet<Socios> SociosDb { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConve‌​ntion>();
            modelBuilder.Properties<string>()
              .Configure(p => p.HasColumnType("varchar"));
            //Configura toda entidade do tipo string com o maximo de 200 caracteres
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(200));
            base.OnModelCreating(modelBuilder);
        }
    }
}