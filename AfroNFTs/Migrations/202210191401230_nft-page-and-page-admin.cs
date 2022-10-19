namespace AfroNFTs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nftpageandpageadmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "Admin_Id", c => c.Int());
            CreateIndex("dbo.Pages", "Admin_Id");
            AddForeignKey("dbo.Pages", "Admin_Id", "dbo.admin", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "Admin_Id", "dbo.admin");
            DropIndex("dbo.Pages", new[] { "Admin_Id" });
            DropColumn("dbo.Pages", "Admin_Id");
        }
    }
}
