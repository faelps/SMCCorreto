namespace SMC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReferenciasComerciais : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReferenciasComerciais", "Cidade", c => c.String(maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReferenciasComerciais", "Cidade");
        }
    }
}
