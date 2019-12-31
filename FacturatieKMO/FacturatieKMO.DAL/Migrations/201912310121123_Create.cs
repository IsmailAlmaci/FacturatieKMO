namespace FacturatieKMO.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                        FirstName = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Address = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyInfo = c.String(maxLength: 100, unicode: false),
                        CustomerInfo = c.String(maxLength: 100, unicode: false),
                        InvoiceDate = c.DateTime(nullable: false, storeType: "date"),
                        InvoiceStatus = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.InvoiceDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Item = c.String(maxLength: 100, unicode: false),
                        PricePerUnit = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Amount = c.Int(nullable: false),
                        VAT = c.Double(nullable: false),
                        Invoice_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoice", t => t.Invoice_Id)
                .Index(t => t.Invoice_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoice", "Customer_Id", "dbo.Customer");
            DropForeignKey("dbo.InvoiceDetail", "Invoice_Id", "dbo.Invoice");
            DropIndex("dbo.InvoiceDetail", new[] { "Invoice_Id" });
            DropIndex("dbo.Invoice", new[] { "Customer_Id" });
            DropTable("dbo.InvoiceDetail");
            DropTable("dbo.Invoice");
            DropTable("dbo.Customer");
        }
    }
}
