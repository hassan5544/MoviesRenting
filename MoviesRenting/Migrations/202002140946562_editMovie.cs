namespace MoviesRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editMovie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenresId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenresId" });
            AddColumn("dbo.Movies", "Genres_Id", c => c.Byte());
            AlterColumn("dbo.Movies", "GenresId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Genres_Id");
            AddForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genres_Id" });
            AlterColumn("dbo.Movies", "GenresId", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "Genres_Id");
            CreateIndex("dbo.Movies", "GenresId");
            AddForeignKey("dbo.Movies", "GenresId", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
