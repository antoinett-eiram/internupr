namespace internUPR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v23 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Internships", "requirement", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Internships", "requirement");
        }
    }
}
