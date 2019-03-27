using SMC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SMC.Repositorio.Mapeamento
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {

        public EnderecoMap()
        {
            ToTable("endereco");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Rua)
                .HasColumnName("rua")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(150);

            Property(x => x.Numero)
                .HasColumnName("numero")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(6);

            Property(x => x.Complemento)
                .HasColumnName("complemento")
                .HasColumnType("varchar")
                .IsOptional()
                .HasMaxLength(100);

            Property(x => x.Estado)
                .HasColumnName("estado")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(2);

            Property(x => x.Cep)
                .HasColumnName("cep")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(8);

            Property(x => x.Cidade)
            .HasColumnName("cidade")
            .HasColumnType("varchar")
            .IsRequired()
            .HasMaxLength(100);

            Property(x => x.Bairro)
                .HasColumnName("bairro")
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(150);

          

          
        }
    }
}