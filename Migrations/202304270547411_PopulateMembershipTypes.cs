namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFree, DuretionInMonth, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFree, DuretionInMonth, DiscountRate) VALUES (2, 10, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFree, DuretionInMonth, DiscountRate) VALUES (3, 30, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFree, DuretionInMonth, DiscountRate) VALUES (4, 100, 12, 25)");
        }
        
        public override void Down()
        {
        }
    }
}
