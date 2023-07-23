namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRental : DbMigration
    {
        /*public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Customer_id = c.Int(nullable: false),
                        Movie_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_id, cascadeDelete: true)
                .Index(t => t.Customer_id)
                .Index(t => t.Movie_id);
            
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Movie_id" });
            DropIndex("dbo.Rentals", new[] { "Customer_id" });
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.Movies", "NumberAvailable");
            DropTable("dbo.Rentals");
        }*/
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DateRented = c.DateTime(nullable: false),
                    DateReturned = c.DateTime(),
                    Customer_Id = c.Int(nullable: false),
                    Movie_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Movie_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropTable("dbo.Rentals");
        }
    }
}
