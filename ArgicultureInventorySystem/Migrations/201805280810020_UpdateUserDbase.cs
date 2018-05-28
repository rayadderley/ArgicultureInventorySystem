namespace ArgicultureInventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserDbase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "IdNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "IdNumber", c => c.String());
        }
    }
}
