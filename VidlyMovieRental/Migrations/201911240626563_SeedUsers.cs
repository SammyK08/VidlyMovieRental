namespace VidlyMovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'191b03fd-4dfa-4053-92de-c91cf6d41b75', N'Guest@Vidly.com', 0, N'APvsluApaJGlOFF4kgSH9omfj2lGlNPuOf34854KssiGe74wyiKZSqLDAKxFt9nYBA==', N'5459a671-5994-4acd-9f51-177d36db9a9e', NULL, 0, 0, NULL, 1, 0, N'Guest@Vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1c064881-3fd7-4270-9be6-25f7be3971a7', N'Admin@Vidly.com', 0, N'ALWDIo/p4zLlTWx9E314mj68JLkzg/zU+Hp+vWr5WTk92xtDQIrkiVFFywGMliRanA==', N'f239b01e-7853-49b5-953d-c3f4efe553d2', NULL, 0, 0, NULL, 1, 0, N'Admin@Vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c7ecc4e9-036e-4b45-a608-59ed711c4af3', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1c064881-3fd7-4270-9be6-25f7be3971a7', N'c7ecc4e9-036e-4b45-a608-59ed711c4af3')

");
        }
        
        public override void Down()
        {
        }
    }
}
