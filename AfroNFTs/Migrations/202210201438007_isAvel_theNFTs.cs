namespace AfroNFTs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isAvel_theNFTs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NFTsClasses", "IsAvel", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NFTsClasses", "IsAvel");
        }
    }
}
