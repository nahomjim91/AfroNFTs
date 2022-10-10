namespace AfroNFTs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin_NFTsClass_NormalUser_Page : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        email = c.String(),
                        password = c.String(),
                        balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NFTsClasses",
                c => new
                    {
                        NFtsClassId = c.Int(nullable: false, identity: true),
                        NftsPicture = c.Binary(),
                        IDNFTs = c.Int(nullable: false),
                        OwnerID = c.Int(nullable: false),
                        NFTsName = c.String(),
                        Group = c.String(),
                        description = c.String(),
                        NFTsprice = c.Double(nullable: false),
                        NFTsRate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.NFtsClassId);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        email = c.String(),
                        password = c.String(),
                        balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageId = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.PageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pages");
            DropTable("dbo.users");
            DropTable("dbo.NFTsClasses");
            DropTable("dbo.admin");
        }
    }
}
