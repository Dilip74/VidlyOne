namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'34144c2f-9955-4cb0-83fd-0e3f0fb954c0', N'dilipkumarr04@gmail.com', 0, N'AFg9JZmLgbtfdhoeWjX3W1nI1KkA70QdM/CsZQD+lgZA5J+x60AWuqOzhOV4xyxQpA==', N'a66f143c-551c-420a-9ba9-7d96adaebdc4', NULL, 0, 0, NULL, 1, 0, N'dilipkumarr04@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'35c0ec78-040c-4a90-b2fc-60154c804d8f', N'admin@vidly.com', 0, N'ABQUCdPr1owvvkQpTBkA/smYLMkwR3PTCCwiEktL8UqmjN6Yxu1wxYGAf1UEmGD1KQ==', N'37f02709-2abd-4dab-8c21-6462031b50b5', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd9394d44-bcf9-4080-8d49-db545921bf07', N'Guest@vidly.com', 0, N'AFHA3BdeqnZnYAzwtPgw9Ya3REqd4tId9klldGnuSghIOGbcf2+csav/dfKwiJU3vg==', N'c2a69e6d-081c-4464-b3b6-315bee301520', NULL, 0, 0, NULL, 1, 0, N'Guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f18439ca-a565-42b2-ab39-7d2d46690b81', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'35c0ec78-040c-4a90-b2fc-60154c804d8f', N'f18439ca-a565-42b2-ab39-7d2d46690b81')

");
        }
        
        public override void Down()
        {
        }
    }
}
