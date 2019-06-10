namespace PeopleSearcher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesignature : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "PicUrl", c => c.String());
            DropColumn("dbo.Interests", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Interests", "Description", c => c.String());
            AlterColumn("dbo.People", "PicUrl", c => c.Int(nullable: false));
        }
    }
}
