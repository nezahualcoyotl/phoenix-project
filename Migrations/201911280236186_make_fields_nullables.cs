namespace BackstageMusic.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class make_fields_nullables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Artists", "id_manager", "dbo.Managers");
            DropForeignKey("dbo.Managers", "id_label", "dbo.Labels");
            DropForeignKey("dbo.Assets", "id_orderdetail", "dbo.OrderDetails");
            DropIndex("dbo.Artists", new[] { "id_manager" });
            DropIndex("dbo.Managers", new[] { "id_label" });
            DropIndex("dbo.Assets", new[] { "id_orderdetail" });
            AlterColumn("dbo.Artists", "id_manager", c => c.Int());
            AlterColumn("dbo.Managers", "id_label", c => c.Int());
            AlterColumn("dbo.Assets", "id_orderdetail", c => c.Int());
            AlterColumn("dbo.Payments", "voucher", c => c.String());
            CreateIndex("dbo.Artists", "id_manager");
            CreateIndex("dbo.Managers", "id_label");
            CreateIndex("dbo.Assets", "id_orderdetail");
            AddForeignKey("dbo.Artists", "id_manager", "dbo.Managers", "id_manager");
            AddForeignKey("dbo.Managers", "id_label", "dbo.Labels", "id_label");
            AddForeignKey("dbo.Assets", "id_orderdetail", "dbo.OrderDetails", "id_orderdetail");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Assets", "id_orderdetail", "dbo.OrderDetails");
            DropForeignKey("dbo.Managers", "id_label", "dbo.Labels");
            DropForeignKey("dbo.Artists", "id_manager", "dbo.Managers");
            DropIndex("dbo.Assets", new[] { "id_orderdetail" });
            DropIndex("dbo.Managers", new[] { "id_label" });
            DropIndex("dbo.Artists", new[] { "id_manager" });
            AlterColumn("dbo.Payments", "voucher", c => c.String(nullable: false));
            AlterColumn("dbo.Assets", "id_orderdetail", c => c.Int(nullable: false));
            AlterColumn("dbo.Managers", "id_label", c => c.Int(nullable: false));
            AlterColumn("dbo.Artists", "id_manager", c => c.Int(nullable: false));
            CreateIndex("dbo.Assets", "id_orderdetail");
            CreateIndex("dbo.Managers", "id_label");
            CreateIndex("dbo.Artists", "id_manager");
            AddForeignKey("dbo.Assets", "id_orderdetail", "dbo.OrderDetails", "id_orderdetail", cascadeDelete: true);
            AddForeignKey("dbo.Managers", "id_label", "dbo.Labels", "id_label", cascadeDelete: true);
            AddForeignKey("dbo.Artists", "id_manager", "dbo.Managers", "id_manager", cascadeDelete: true);
        }
    }
}
