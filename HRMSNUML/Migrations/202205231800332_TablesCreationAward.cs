namespace HRMSNUML.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesCreationAward : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Awards",
                c => new
                    {
                        Award_Id = c.Int(nullable: false, identity: true),
                        Award_Title = c.String(),
                        Award_Date = c.DateTime(nullable: false),
                        Award_Category = c.String(),
                        Award_Description = c.String(),
                        Award_Type = c.String(),
                        Award_Picture = c.String(),
                    })
                .PrimaryKey(t => t.Award_Id);
            
            CreateTable(
                "dbo.AwardsCategories",
                c => new
                    {
                        AwardCategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Status = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.AwardCategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AwardsCategories");
            DropTable("dbo.Awards");
        }
    }
}
