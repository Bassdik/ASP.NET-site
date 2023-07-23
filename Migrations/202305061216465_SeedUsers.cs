namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'100266db-17b8-4624-b500-14a34bdf387d', N'danilhlapov@gmail.com', 0, N'AHVDZnrtI1kmQz14uTIkB+chiTDYYuq5YJ2U19V3pXAIQg3WOJMdaQoupUKmJkZbIQ==', N'495b7746-f32f-4b1f-b7f9-acf212f9d0b7', NULL, 0, 0, NULL, 1, 0, N'danilhlapov@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'26ea24e3-15f5-46c2-8d3e-de91be3c247a', N'AdminFirst@web2.com', 0, N'ACUrZt/HuljRuc+wKkCxme0NohLF1q7cbL2liONbEo1EM8XO2mBMMXJd/fztLo5ILQ==', N'c4154a23-70e4-414d-bc08-8bb4940503b8', NULL, 0, 0, NULL, 1, 0, N'AdminFirst@web2.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'70f5bd0f-08ac-4fef-b530-ebb9e4c427a6', N'Admin@web2.com', 0, N'ALh0Jhu3ItNlt7c5uexZKpo+nfDmQz1py4GBQIj2nvwuPASMl749oHbPlhRaab1BTg==', N'2895d56a-9434-40b7-8dc7-6853a4635a80', NULL, 0, 0, NULL, 1, 0, N'Admin@web2.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7c3adf9b-451f-4411-b4a6-e8d77b68d8e6', N'Guest@web2.com', 0, N'AMaO0yAcSPOZpmqRyNEVu0U6oHpsmvmnQIn7rV2U8DI/3xMu70yWGW80pXVKt2uD0A==', N'7bfd8217-7bce-457c-9069-088ebaa76f04', NULL, 0, 0, NULL, 1, 0, N'Guest@web2.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cd85c60e-b5c4-48dc-a6b8-527866a469b6', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'26ea24e3-15f5-46c2-8d3e-de91be3c247a', N'cd85c60e-b5c4-48dc-a6b8-527866a469b6')

                ");
        }

        public override void Down()
        {
        }
    }
}
