namespace internUPR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Internships", "departmentID", "dbo.Departments");
            DropIndex("dbo.Internships", new[] { "departmentID" });
            AlterColumn("dbo.Internships", "departmentID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Internships", "departmentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Internships", "departmentID");
            AddForeignKey("dbo.Internships", "departmentID", "dbo.Departments", "departmentID", cascadeDelete: true);
        }
    }
}
