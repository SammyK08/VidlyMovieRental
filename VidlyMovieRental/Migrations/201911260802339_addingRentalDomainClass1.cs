﻿namespace VidlyMovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingRentalDomainClass1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Rentals", new[] { "customer_Id" });
            CreateIndex("dbo.Rentals", "Customer_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            CreateIndex("dbo.Rentals", "customer_Id");
        }
    }
}
