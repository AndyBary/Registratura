namespace Поликлиника_лаба_3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Uchastok");
            AddColumn("dbo.Doctor", "vremya", c => c.Int(nullable: false));
            AddColumn("dbo.Uchastok", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Uchastok", "ID");
            DropColumn("dbo.Uchastok", "Uchastok_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uchastok", "Uchastok_ID", c => c.Int());
            DropPrimaryKey("dbo.Uchastok");
            DropColumn("dbo.Uchastok", "ID");
            DropColumn("dbo.Doctor", "vremya");
            AddPrimaryKey("dbo.Uchastok", "Uchastok_number");
        }
    }
}
