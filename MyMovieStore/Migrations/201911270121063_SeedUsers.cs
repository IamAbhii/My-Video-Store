namespace MyMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b3477053-5c91-4ef3-87ac-c24dcf105eaf', N'admin@gamil.com', 0, N'AMyNXwpdmYoZRJi4AIxtSUzg78rK7G6HqWyqnZ7on4wTQzsXdojJ5vHrVm8plAuzdw==', N'b5f1a1f2-a7d2-4e7f-833b-20a712ba2054', NULL, 0, 0, NULL, 1, 0, N'admin@gamil.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'daf92dda-bef1-492a-8b32-3e9f9fe69ca6', N'guest@gmail.com', 0, N'AFPVCzWVOQwxQQ/587Ccwi2spPfhTNBbNFTGXVQhzmcckVxU51hK9vV9IhhgbIrlCQ==', N'039d6a22-a25c-49cc-bd51-0df5820875d9', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3f660106-2249-48f4-815d-e81db3f956dd', N'CanManageMovies')
            
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b3477053-5c91-4ef3-87ac-c24dcf105eaf', N'3f660106-2249-48f4-815d-e81db3f956dd')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
