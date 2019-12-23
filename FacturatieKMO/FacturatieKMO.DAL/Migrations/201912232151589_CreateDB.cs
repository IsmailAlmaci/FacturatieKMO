namespace FacturatieKMO.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                        FirstName = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Address = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Invoice",
                c => new
                    {
                        InvoiceNr = c.Int(nullable: false, identity: true),
                        CompanyInfo = c.String(maxLength: 100, unicode: false),
                        CustomerInfo = c.String(maxLength: 100, unicode: false),
                        InvoiceDate = c.DateTime(nullable: false, storeType: "date"),
                        InvoiceStatus = c.Int(nullable: false),
                        User_UserId = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceNr)
                .ForeignKey("dbo.User", t => t.User_UserId, cascadeDelete: true)
                .ForeignKey("dbo.Customer", t => t.Customer_CustomerId, cascadeDelete: true)
                .Index(t => t.User_UserId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.InvoiceDetail",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Item = c.String(maxLength: 100, unicode: false),
                        PricePerUnit = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Amount = c.Int(nullable: false),
                        VAT = c.Double(nullable: false),
                        Invoice_InvoiceNr = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Invoice", t => t.Invoice_InvoiceNr)
                .Index(t => t.Invoice_InvoiceNr);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                        FirstName = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Address = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 100, unicode: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.User", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoice", "Customer_CustomerId", "dbo.Customer");
            DropForeignKey("dbo.Role", "User_UserId", "dbo.User");
            DropForeignKey("dbo.Invoice", "User_UserId", "dbo.User");
            DropForeignKey("dbo.InvoiceDetail", "Invoice_InvoiceNr", "dbo.Invoice");
            DropIndex("dbo.Role", new[] { "User_UserId" });
            DropIndex("dbo.InvoiceDetail", new[] { "Invoice_InvoiceNr" });
            DropIndex("dbo.Invoice", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Invoice", new[] { "User_UserId" });
            DropTable("dbo.Role");
            DropTable("dbo.User");
            DropTable("dbo.InvoiceDetail");
            DropTable("dbo.Invoice");
            DropTable("dbo.Customer");
        }
    }
}
