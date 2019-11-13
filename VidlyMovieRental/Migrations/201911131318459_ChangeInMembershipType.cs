namespace VidlyMovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());

            Sql("UPDATE MembershipTypes set Name='pay as you go' Where Id=1 ");
            Sql("UPDATE MembershipTypes set Name='monthly' Where Id=2 ");
            Sql("UPDATE MembershipTypes set Name='quaterly' Where Id=3 ");
            Sql("UPDATE MembershipTypes set Name='yearly' Where Id=4 ");
        }


        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
