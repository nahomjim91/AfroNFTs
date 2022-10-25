namespace AfroNFTs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPageImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "pageImage", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pages", "pageImage");
        }
    }
}
