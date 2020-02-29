namespace MoviesRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            DropIndex("dbo.Movies", new[] { "Genres_Id" });
            DropColumn("dbo.Customers", "MemberShipTypeId");
            DropColumn("dbo.Movies", "GenresId");
            RenameColumn(table: "dbo.Customers", name: "MemberShipType_Id", newName: "MemberShipTypeId");
            RenameColumn(table: "dbo.Movies", name: "Genres_Id", newName: "GenresId");
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "GenresId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "GenresId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipTypeId");
            CreateIndex("dbo.Movies", "GenresId");
            AddForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Movies", "GenresId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenresId", "dbo.Genres");
            DropForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes");
            DropIndex("dbo.Movies", new[] { "GenresId" });
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            AlterColumn("dbo.Movies", "GenresId", c => c.Byte());
            AlterColumn("dbo.Movies", "GenresId", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Int());
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Movies", name: "GenresId", newName: "Genres_Id");
            RenameColumn(table: "dbo.Customers", name: "MemberShipTypeId", newName: "MemberShipType_Id");
            AddColumn("dbo.Movies", "GenresId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Genres_Id");
            CreateIndex("dbo.Customers", "MemberShipType_Id");
            AddForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes", "Id");
        }
    }
}
