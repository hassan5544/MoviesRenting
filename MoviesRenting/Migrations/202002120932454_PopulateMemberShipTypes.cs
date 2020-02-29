namespace MoviesRenting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes (Name,DiscountRate) VALUES ('Pay as you go ' , 0)");
            Sql("INSERT INTO MemberShipTypes (Name,DiscountRate) VALUES ('monthly ' , 10)");
            Sql("INSERT INTO MemberShipTypes (Name,DiscountRate) VALUES ('5 months ' , 15)");
            Sql("INSERT INTO MemberShipTypes (Name,DiscountRate) VALUES ('1 yeat ' , 20)");
        }
        
        public override void Down()
        {
        }
    }
}
