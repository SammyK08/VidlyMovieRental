namespace VidlyMovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addimAvilabilityToMovieDomain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Avilability", c => c.Int(nullable: false));

            Sql("Update Movies Set  Avilability = NumberInStock");
        }
       
        public override void Down()
        {
            DropColumn("dbo.Movies", "Avilability");
        }
    }
}
