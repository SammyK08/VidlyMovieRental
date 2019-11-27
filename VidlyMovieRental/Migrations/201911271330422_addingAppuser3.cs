﻿namespace VidlyMovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingAppuser3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "UserId", c => c.Int(nullable: false));
        }
    }
}
