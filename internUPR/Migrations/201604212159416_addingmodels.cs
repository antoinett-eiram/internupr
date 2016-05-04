namespace internUPR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "dptEmphasis", c => c.String());
            DropColumn("dbo.Departments", "dptcategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "dptcategory", c => c.String());
            DropColumn("dbo.Departments", "dptEmphasis");
        }
    }
}
