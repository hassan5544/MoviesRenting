namespace MoviesRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        NumberOfStocks = c.Int(nullable: false),
                        GenresId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenresId, cascadeDelete: true)
                .Index(t => t.GenresId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenresId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenresId" });
            DropTable("dbo.Movies");
        }
    }
}
