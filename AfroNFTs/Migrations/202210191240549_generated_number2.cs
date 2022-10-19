namespace AfroNFTs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class generated_number2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.admin", "generatedNumber", c => c.Int(nullable: false));
            AddColumn("dbo.users", "generatedNumber", c => c.Int(nullable: false));
            CreateIndex("dbo.admin", "email", unique: true);
            CreateIndex("dbo.users", "email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.users", new[] { "email" });
            DropIndex("dbo.admin", new[] { "email" });
            DropColumn("dbo.users", "generatedNumber");
            DropColumn("dbo.admin", "generatedNumber");
        }
    }
}
