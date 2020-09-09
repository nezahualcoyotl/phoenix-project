namespace BackstageMusic.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class change_user_structure : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "username", c => c.String(nullable: false));
            DropColumn("dbo.Users", "name");
            DropColumn("dbo.Users", "email");
        }

        public override void Down()
        {
            AddColumn("dbo.Users", "email", c => c.String(nullable: false));
            AddColumn("dbo.Users", "name", c => c.String(nullable: false));
            DropColumn("dbo.Users", "username");
        }
    }
}
