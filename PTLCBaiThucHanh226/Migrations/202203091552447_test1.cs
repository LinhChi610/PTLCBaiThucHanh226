namespace PTLCBaiThucHanh226.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Demo",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        StudentName = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Demo");
        }
    }
}
