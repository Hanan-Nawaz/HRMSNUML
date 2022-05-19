namespace HRMSNUML.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.IPRights", "IPFormCopy", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IPRights", "IPFormCopy", c => c.String(nullable: false));
        }
    }
}
