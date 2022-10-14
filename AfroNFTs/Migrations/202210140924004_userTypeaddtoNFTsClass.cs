namespace AfroNFTs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userTypeaddtoNFTsClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NFTsClasses", "userType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NFTsClasses", "userType");
        }
    }
}
