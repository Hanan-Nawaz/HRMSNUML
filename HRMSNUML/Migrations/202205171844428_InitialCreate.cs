namespace HRMSNUML.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConsultancyServices",
                c => new
                    {
                        CS_Id = c.Int(nullable: false, identity: true),
                        CS_Title = c.String(nullable: false, maxLength: 200),
                        CS_StartDate = c.DateTime(nullable: false),
                        CS_EndDate = c.DateTime(nullable: false),
                        CS_CompanyName = c.String(nullable: false, maxLength: 50),
                        CS_Description = c.String(nullable: false, maxLength: 400),
                        CS_Picture = c.String(),
                    })
                .PrimaryKey(t => t.CS_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConsultancyServices");
        }
    }
}
