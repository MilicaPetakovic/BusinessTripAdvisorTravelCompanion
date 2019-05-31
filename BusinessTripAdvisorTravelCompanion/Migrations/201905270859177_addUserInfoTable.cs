namespace BusinessTripAdvisorTravelCompanion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserInfoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        AspNetUserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUserId, cascadeDelete: true)
                .Index(t => t.AspNetUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "AspNetUserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserInfoes", new[] { "AspNetUserId" });
            DropTable("dbo.UserInfoes");
        }
    }
}
