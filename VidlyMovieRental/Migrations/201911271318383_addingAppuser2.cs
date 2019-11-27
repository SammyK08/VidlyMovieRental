namespace VidlyMovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingAppuser2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Customers", new[] { "User_Id" });
            DropColumn("dbo.Customers", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Customers", "User_Id");
            AddForeignKey("dbo.Customers", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
