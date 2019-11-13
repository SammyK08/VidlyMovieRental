namespace VidlyMovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) Values('Action')");
            Sql("INSERT INTO Genres(Name) Values( 'Drama')");
            Sql("INSERT INTO Genres(Name) Values( 'Thriller')");
            Sql("INSERT INTO Genres(Name) Values( 'Romance')");
            Sql("INSERT INTO Genres(Name) Values( 'Horror')");

        }
        
        public override void Down()
        {
        }
    }
}
