namespace SMC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResponsavelPelaEmpresa1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResponsavelPelaEmpresa", "NomeDoPai", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.ResponsavelPelaEmpresa", "NomeDaMae", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.ResponsavelPelaEmpresa", "Naturalidade", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.ResponsavelPelaEmpresa", "Nacionalidade", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.ResponsavelPelaEmpresa", "Profissao", c => c.String(maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResponsavelPelaEmpresa", "Profissao");
            DropColumn("dbo.ResponsavelPelaEmpresa", "Nacionalidade");
            DropColumn("dbo.ResponsavelPelaEmpresa", "Naturalidade");
            DropColumn("dbo.ResponsavelPelaEmpresa", "NomeDaMae");
            DropColumn("dbo.ResponsavelPelaEmpresa", "NomeDoPai");
        }
    }
}
