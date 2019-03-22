﻿using SMC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SMC.Repositorio.Mapeamento
{
    public class EmpresaMap : EntityTypeConfiguration<Empresas>
    {
        public EmpresaMap()
        {
            ToTable("empresa");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NomeFantasia)
                .HasColumnName("nomeFantasia")
                .IsRequired()
                .HasMaxLength(200);

            Property(x => x.RazaoSocial)
                .HasColumnName("razaoSocial")
                .IsRequired()
                .HasMaxLength(200);

            Property(x => x.Criacao)
                .HasColumnName("criacao")
                .IsRequired();

            Property(x => x.IdEndereco)
                .HasColumnName("idEndereco")
                   .IsRequired();

           
           



        }
    }
}