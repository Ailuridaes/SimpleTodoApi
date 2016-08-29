namespace SimpleTodo.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCompleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "IsCompleted", c => c.Boolean(nullable: false, defaultValue: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "IsCompleted");
        }
    }
}
