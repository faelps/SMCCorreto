namespace SMC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicialized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        IdEmpresa = c.Int(nullable: false, identity: true),
                        RazaoSocial = c.String(maxLength: 200, unicode: false),
                        NomeFantasia = c.String(maxLength: 200, unicode: false),
                        AtividadePrincipal = c.String(maxLength: 200, unicode: false),
                        Cnpj = c.String(maxLength: 200, unicode: false),
                        InscricaoEstadual = c.String(maxLength: 200, unicode: false),
                        CapitalRegistrado = c.String(maxLength: 200, unicode: false),
                        PatrimonioLiquido = c.String(maxLength: 200, unicode: false),
                        IdResponsavel = c.Int(nullable: false),
                        EnderecoRua = c.String(maxLength: 200, unicode: false),
                        EnderecoNumero = c.String(maxLength: 200, unicode: false),
                        EnderecoBairro = c.String(maxLength: 200, unicode: false),
                        EnderecoCidade = c.String(maxLength: 200, unicode: false),
                        EnderecoEstado = c.String(maxLength: 200, unicode: false),
                        EndercoCep = c.String(maxLength: 200, unicode: false),
                        EnderecoComplemento = c.String(maxLength: 200, unicode: false),
                        Telefone = c.String(maxLength: 200, unicode: false),
                        Email = c.String(maxLength: 200, unicode: false),
                        Celular = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.IdEmpresa)
                .ForeignKey("dbo.ResponsavelPelaEmpresa", t => t.IdResponsavel, cascadeDelete: true)
                .Index(t => t.IdResponsavel);
            
            CreateTable(
                "dbo.ReferenciasBancarias",
                c => new
                    {
                        IdReferencia = c.Int(nullable: false, identity: true),
                        NomeDoBanco = c.String(maxLength: 200, unicode: false),
                        GerenteDaConta = c.String(maxLength: 200, unicode: false),
                        Telefone = c.String(maxLength: 200, unicode: false),
                        Empresa_IdEmpresa = c.Int(),
                    })
                .PrimaryKey(t => t.IdReferencia)
                .ForeignKey("dbo.Empresa", t => t.Empresa_IdEmpresa)
                .Index(t => t.Empresa_IdEmpresa);
            
            CreateTable(
                "dbo.ReferenciasComerciais",
                c => new
                    {
                        IdReferenciaComercial = c.Int(nullable: false, identity: true),
                        NomeDaLoja = c.String(maxLength: 200, unicode: false),
                        Telefone = c.String(maxLength: 200, unicode: false),
                        Empresa_IdEmpresa = c.Int(),
                    })
                .PrimaryKey(t => t.IdReferenciaComercial)
                .ForeignKey("dbo.Empresa", t => t.Empresa_IdEmpresa)
                .Index(t => t.Empresa_IdEmpresa);
            
            CreateTable(
                "dbo.ResponsavelPelaEmpresa",
                c => new
                    {
                        IdResponsavel = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 200, unicode: false),
                        Cpf = c.String(maxLength: 200, unicode: false),
                        Rg = c.String(maxLength: 200, unicode: false),
                        Telefone = c.String(maxLength: 200, unicode: false),
                        DataDeNascimento = c.String(maxLength: 200, unicode: false),
                        Sexo = c.Int(nullable: false),
                        EstadoCivil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdResponsavel);
            
            CreateTable(
                "dbo.Socios",
                c => new
                    {
                        IdSocio = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 200, unicode: false),
                        Cargo = c.String(maxLength: 200, unicode: false),
                        Participacao = c.String(maxLength: 200, unicode: false),
                        Telefone = c.String(maxLength: 200, unicode: false),
                        Empresa_IdEmpresa = c.Int(),
                    })
                .PrimaryKey(t => t.IdSocio)
                .ForeignKey("dbo.Empresa", t => t.Empresa_IdEmpresa)
                .Index(t => t.Empresa_IdEmpresa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Socios", "Empresa_IdEmpresa", "dbo.Empresa");
            DropForeignKey("dbo.Empresa", "IdResponsavel", "dbo.ResponsavelPelaEmpresa");
            DropForeignKey("dbo.ReferenciasComerciais", "Empresa_IdEmpresa", "dbo.Empresa");
            DropForeignKey("dbo.ReferenciasBancarias", "Empresa_IdEmpresa", "dbo.Empresa");
            DropIndex("dbo.Socios", new[] { "Empresa_IdEmpresa" });
            DropIndex("dbo.ReferenciasComerciais", new[] { "Empresa_IdEmpresa" });
            DropIndex("dbo.ReferenciasBancarias", new[] { "Empresa_IdEmpresa" });
            DropIndex("dbo.Empresa", new[] { "IdResponsavel" });
            DropTable("dbo.Socios");
            DropTable("dbo.ResponsavelPelaEmpresa");
            DropTable("dbo.ReferenciasComerciais");
            DropTable("dbo.ReferenciasBancarias");
            DropTable("dbo.Empresa");
        }
    }
}
