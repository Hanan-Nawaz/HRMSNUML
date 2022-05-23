namespace HRMSNUML.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesCreationAwards : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Awards", "Award_CategoryID", c => c.Int(nullable: false));
            DropColumn("dbo.Awards", "Award_Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Awards", "Award_Category", c => c.String());
            DropColumn("dbo.Awards", "Award_CategoryID");
        }
    }
}
