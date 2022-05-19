namespace HRMSNUML.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        IPRightCategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.IPRightCategoryId);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        DesignationId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Status = c.Byte(nullable: false),
                        Scale = c.String(),
                        DesignationType = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.DesignationId);
            
            CreateTable(
                "dbo.IPRights",
                c => new
                    {
                        IPID = c.Int(nullable: false, identity: true),
                        IPInventerName = c.String(nullable: false),
                        IPLeadInventer = c.String(nullable: false),
                        DesignationId = c.Int(nullable: false),
                        IPTitle = c.String(nullable: false),
                        IPRightCategoryId = c.Int(nullable: false),
                        IPDevelopmentStatus = c.Int(nullable: false),
                        IPKey_S_Aspects = c.String(nullable: false),
                        IPCommericalPartner = c.String(),
                        IPFormCopy = c.String(nullable: false),
                        IPType = c.String(nullable: false),
                        IPF_Support = c.String(nullable: false),
                        IPDescription = c.String(),
                        IPStatus = c.String(nullable: false),
                        IPApprovalDate = c.DateTime(),
                        IPRegisterDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.IPID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IPRights");
            DropTable("dbo.Designations");
            DropTable("dbo.Categories");
        }
    }
}
