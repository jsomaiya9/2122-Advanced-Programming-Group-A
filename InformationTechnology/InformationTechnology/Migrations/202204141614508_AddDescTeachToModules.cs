namespace InformationTechnology.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescTeachToModules : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modules", "ModuleDescription", c => c.String());
            AddColumn("dbo.Modules", "ModuleTeacher", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Modules", "ModuleTeacher");
            DropColumn("dbo.Modules", "ModuleDescription");
        }
    }
}
