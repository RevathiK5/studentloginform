namespace LOGINFORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initall : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Course", c => c.String(nullable: false));
            AddColumn("dbo.Students", "FirstName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "FirstName");
            DropColumn("dbo.Students", "Course");
        }
    }
}
