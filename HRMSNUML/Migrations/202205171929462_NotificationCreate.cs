namespace HRMSNUML.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotificationCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        NTF_Id = c.Int(nullable: false, identity: true),
                        NTF_Title = c.String(nullable: false, maxLength: 200),
                        NTFDate = c.DateTime(nullable: false),
                        NFT_Remarks = c.String(nullable: false, maxLength: 50),
                        NFT_Picture = c.String(),
                    })
                .PrimaryKey(t => t.NTF_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notifications");
        }
    }
}
