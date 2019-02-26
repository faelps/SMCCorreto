namespace SMC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResponsavelPelaEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResponsavelPelaEmpresa", "OrgaoExpeditor", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.ResponsavelPelaEmpresa", "Celular", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.ResponsavelPelaEmpresa", "Email", c => c.String(maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResponsavelPelaEmpresa", "Email");
            DropColumn("dbo.ResponsavelPelaEmpresa", "Celular");
            DropColumn("dbo.ResponsavelPelaEmpresa", "OrgaoExpeditor");
        }
    }
}
