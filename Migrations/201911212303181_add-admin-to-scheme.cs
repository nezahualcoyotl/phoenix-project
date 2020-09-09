namespace BackstageMusic.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addadmintoscheme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                {
                    id_admin = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    id_user = c.Int(nullable: false),
                    active = c.Boolean(nullable: false),
                    created_at = c.DateTime(),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_admin)
                .ForeignKey("dbo.Users", t => t.id_user, cascadeDelete: false)
                .Index(t => t.id_user);

            AddColumn("dbo.Assets", "id_admin", c => c.Int(nullable: false));
            CreateIndex("dbo.Assets", "id_admin");
            AddForeignKey("dbo.Assets", "id_admin", "dbo.Admins", "id_admin", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Assets", "id_admin", "dbo.Admins");
            DropForeignKey("dbo.Admins", "id_user", "dbo.Users");
            DropIndex("dbo.Assets", new[] { "id_admin" });
            DropIndex("dbo.Admins", new[] { "id_user" });
            DropColumn("dbo.Assets", "id_admin");
            DropTable("dbo.Admins");
        }
    }
}
