namespace lab3_trang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Lecturer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "Lecturer_Id" });
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "Lecturer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Lecturer_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Courses", "IsCanceled");
            CreateIndex("dbo.Courses", "Lecturer_Id");
            AddForeignKey("dbo.Courses", "Lecturer_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
