namespace HRMSNUML.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skill : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.skills",
                c => new
                    {
                        SkillId = c.Int(nullable: false, identity: true),
                        skillCategoryID = c.Int(nullable: false),
                        SkillSubCategoryId = c.Int(nullable: false),
                        BreifBiography = c.String(),
                    })
                .PrimaryKey(t => t.SkillId);
            
            CreateTable(
                "dbo.skillcategories",
                c => new
                    {
                        SkillCategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.SkillCategoryId);
            
            CreateTable(
                "dbo.SkillSubCategories",
                c => new
                    {
                        SkillSubCategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SkillCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillSubCategoryId)
                .ForeignKey("dbo.skillcategories", t => t.SkillCategoryId, cascadeDelete: true)
                .Index(t => t.SkillCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SkillSubCategories", "SkillCategoryId", "dbo.skillcategories");
            DropIndex("dbo.SkillSubCategories", new[] { "SkillCategoryId" });
            DropTable("dbo.SkillSubCategories");
            DropTable("dbo.skillcategories");
            DropTable("dbo.skills");
        }
    }
}
