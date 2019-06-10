namespace PeopleSearcher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeagenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Age", c => c.Int(nullable: false));
        }
    }
}
