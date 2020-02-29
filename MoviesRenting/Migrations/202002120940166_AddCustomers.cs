namespace MoviesRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        BirthDate = c.DateTime(),
                        IsSubscribedToNewsFeed = c.Boolean(nullable: false),
                        MemberShipTypeId = c.Byte(nullable: false),
                        MemberShipType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MemberShipTypes", t => t.MemberShipType_Id)
                .Index(t => t.MemberShipType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            DropTable("dbo.Customers");
        }
    }
}
