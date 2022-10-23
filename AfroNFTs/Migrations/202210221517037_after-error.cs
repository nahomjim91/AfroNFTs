namespace AfroNFTs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aftererror : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.admin", "profileImage", c => c.Binary());
            AddColumn("dbo.users", "profileImage", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "profileImage");
            DropColumn("dbo.admin", "profileImage");
        }
    }
}
