namespace Mini_projekat_2___Entity_Framework_MVVM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        cName = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        sFirstName = c.String(nullable: false, maxLength: 50),
                        sLastName = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false),
                        Address1 = c.String(nullable: false, maxLength: 200),
                        City = c.String(nullable: false, maxLength: 100),
                        Country = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Students", t => t.AddressId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.StudentCourse",
                c => new
                    {
                        StudentRefId = c.Int(nullable: false),
                        CourseRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentRefId, t.CourseRefId })
                .ForeignKey("dbo.Students", t => t.StudentRefId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseRefId, cascadeDelete: true)
                .Index(t => t.StudentRefId)
                .Index(t => t.CourseRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourse", "CourseRefId", "dbo.Courses");
            DropForeignKey("dbo.StudentCourse", "StudentRefId", "dbo.Students");
            DropForeignKey("dbo.Addresses", "AddressId", "dbo.Students");
            DropIndex("dbo.StudentCourse", new[] { "CourseRefId" });
            DropIndex("dbo.StudentCourse", new[] { "StudentRefId" });
            DropIndex("dbo.Addresses", new[] { "AddressId" });
            DropTable("dbo.StudentCourse");
            DropTable("dbo.Addresses");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
