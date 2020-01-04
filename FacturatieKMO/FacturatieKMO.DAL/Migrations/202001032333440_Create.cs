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
                        IsDeleted = c.Boolean(nullable: false),
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
                        InvoiceCode = c.String(maxLength: 100, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CustomerName = c.String(),
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
                        Invoice_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoice", t => t.Invoice_Id, cascadeDelete: true)
                .Index(t => t.Invoice_Id);
            
            CreateStoredProcedure(
                "dbo.Invoice_Insert",
                p => new
                    {
                        CompanyInfo = p.String(maxLength: 100, unicode: false),
                        CustomerInfo = p.String(maxLength: 100, unicode: false),
                        InvoiceDate = p.DateTime(storeType: "date"),
                        InvoiceStatus = p.Int(),
                        InvoiceCode = p.String(maxLength: 100, unicode: false),
                        IsDeleted = p.Boolean(),
                        CustomerName = p.String(),
                        Customer_Id = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Invoice]([CompanyInfo], [CustomerInfo], [InvoiceDate], [InvoiceStatus], [InvoiceCode], [IsDeleted], [CustomerName], [Customer_Id])
                      VALUES (@CompanyInfo, @CustomerInfo, @InvoiceDate, @InvoiceStatus, @InvoiceCode, @IsDeleted, @CustomerName, @Customer_Id)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Invoice]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Invoice] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.Invoice_Update",
                p => new
                    {
                        Id = p.Int(),
                        CompanyInfo = p.String(maxLength: 100, unicode: false),
                        CustomerInfo = p.String(maxLength: 100, unicode: false),
                        InvoiceDate = p.DateTime(storeType: "date"),
                        InvoiceStatus = p.Int(),
                        InvoiceCode = p.String(maxLength: 100, unicode: false),
                        IsDeleted = p.Boolean(),
                        CustomerName = p.String(),
                        Customer_Id = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Invoice]
                      SET [CompanyInfo] = @CompanyInfo, [CustomerInfo] = @CustomerInfo, [InvoiceDate] = @InvoiceDate, [InvoiceStatus] = @InvoiceStatus, [InvoiceCode] = @InvoiceCode, [IsDeleted] = @IsDeleted, [CustomerName] = @CustomerName, [Customer_Id] = @Customer_Id
                      WHERE (([Id] = @Id) AND ([Customer_Id] = @Customer_Id))"
            );
            
            CreateStoredProcedure(
                "dbo.Invoice_Delete",
                p => new
                    {
                        Id = p.Int(),
                        Customer_Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Invoice]
                      WHERE (([Id] = @Id) AND ([Customer_Id] = @Customer_Id))"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Invoice_Delete");
            DropStoredProcedure("dbo.Invoice_Update");
            DropStoredProcedure("dbo.Invoice_Insert");
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
