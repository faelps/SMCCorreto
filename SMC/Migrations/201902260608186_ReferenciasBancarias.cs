namespace SMC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReferenciasBancarias : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReferenciasBancarias", "Cidade", c => c.String(maxLength: 200, unicode: false));
            DropColumn("dbo.ReferenciasBancarias", "GerenteDaConta");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReferenciasBancarias", "GerenteDaConta", c => c.String(maxLength: 200, unicode: false));
            DropColumn("dbo.ReferenciasBancarias", "Cidade");
        }
    }
}
