namespace ombtwebapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        PhoneNo = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        WalletAmnt = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        CartId = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        SeatNo = c.String(),
                        CustomerId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Amnt = c.Double(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CartId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        PhoneNo = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        WalletAmnt = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false, identity: true),
                        Movie_Name = c.String(),
                        Movie_language = c.String(),
                        Movie_location = c.String(),
                        Movie_gener = c.String(),
                        Movie_time = c.DateTime(nullable: false),
                        Movie_Imagepath = c.String(),
                        Atickets = c.Int(nullable: false),
                        Movie_Description = c.String(),
                    })
                .PrimaryKey(t => t.Movie_Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        SeatNo = c.String(),
                        CustomerId = c.Int(nullable: false),
                        ShowTime = c.DateTime(nullable: false),
                        NoOfTickets = c.Int(nullable: false),
                        Amnt = c.Double(nullable: false),
                        MovieId = c.Int(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.TicketId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
            DropTable("dbo.Movies");
            DropTable("dbo.Customers");
            DropTable("dbo.Carts");
            DropTable("dbo.Admins");
        }
    }
}
