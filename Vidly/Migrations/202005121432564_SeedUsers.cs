namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'77a77291-15bd-45fd-9be6-061c4c78607b', N'guest@vidly.com', 0, N'AGYRUqD1ht55y8L5532E9uBScz5yHqic5lhjN0F890k1IjyC49duXck5nRlS2NjCwg==', N'b9462539-fb9c-4da9-ad0c-1a8d29210a8d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a44a6a2f-5121-4718-8927-fb54dbb595bc', N'oscarponteuk@gmail.com', 0, N'AJkOrwlZ9V/icFh8RF9oGOfLk6WfKhEQLPAUq4hyZ8uYOeiaDvIIPaR5iDN3CQcf8A==', N'6fc26029-6f9c-4b92-85cb-e2b1510a2256', NULL, 0, 0, NULL, 1, 0, N'oscarponteuk@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cf90a1f9-987a-4e4f-86c3-3ff51b6a94e9', N'admin@vidly.com', 0, N'AKXtxVLuoZmTYZQdCwRlSrxVQcOvNKQRxtgBj1q2u5m0ERRTM68VFeHutO64MzFJsg==', N'cbec3094-edd4-471f-8187-c4c682aad1be', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'295f1492-d4f1-4f55-af33-0fa801dc9e6d', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cf90a1f9-987a-4e4f-86c3-3ff51b6a94e9', N'295f1492-d4f1-4f55-af33-0fa801dc9e6d')

");
        }
        
        public override void Down()
        {
        }
    }
}
