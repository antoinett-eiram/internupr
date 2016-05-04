namespace internUPR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Internships", "contactName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Internships", "contactName");
        }
    }
}
