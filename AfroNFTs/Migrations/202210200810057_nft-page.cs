namespace AfroNFTs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nftpage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NFTsClasses", "pageId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NFTsClasses", "pageId");
        }
    }
}
