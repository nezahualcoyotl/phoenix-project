namespace BackstageMusic.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class update_user_table : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "primary_address", c => c.String());
            AlterColumn("dbo.Users", "city", c => c.String());
            AlterColumn("dbo.Users", "voucher", c => c.String());
        }

        public override void Down()
        {
            AlterColumn("dbo.Users", "voucher", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "city", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "primary_address", c => c.String(nullable: false));
        }
    }
}
