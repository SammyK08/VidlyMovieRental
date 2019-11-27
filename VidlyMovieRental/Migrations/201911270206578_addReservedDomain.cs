namespace VidlyMovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReservedDomain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reserves",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ReservedDate = c.DateTime(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reserves", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Reserves", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Reserves", new[] { "Movie_Id" });
            DropIndex("dbo.Reserves", new[] { "Customer_Id" });
            DropTable("dbo.Reserves");
        }
    }
}
