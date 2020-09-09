namespace BackstageMusic.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class create_catalogs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetTypes",
                c => new
                {
                    id_assettype = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_assettype);

            CreateTable(
                "dbo.CollaboratorTypes",
                c => new
                {
                    id_collaboratortype = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_collaboratortype);

            CreateTable(
                "dbo.Continents",
                c => new
                {
                    id_continent = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_continent);

            CreateTable(
                "dbo.Countries",
                c => new
                {
                    id_country = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    id_continent = c.Int(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_country)
                .ForeignKey("dbo.Continents", t => t.id_continent, cascadeDelete: true)
                .Index(t => t.id_continent);

            CreateTable(
                "dbo.Genres",
                c => new
                {
                    id_genre = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_genre);

            CreateTable(
                "dbo.Languages",
                c => new
                {
                    id_language = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_language);

            CreateTable(
                "dbo.Platforms",
                c => new
                {
                    id_platform = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    photo_url = c.String(),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_platform);

            CreateTable(
                "dbo.Products",
                c => new
                {
                    id_product = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    photo_url = c.String(),
                    price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_product);

            CreateTable(
                "dbo.Status",
                c => new
                {
                    id_status = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_status);

            CreateTable(
                "dbo.UserTypes",
                c => new
                {
                    id_usertype = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_usertype);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Countries", "id_continent", "dbo.Continents");
            DropIndex("dbo.Countries", new[] { "id_continent" });
            DropTable("dbo.UserTypes");
            DropTable("dbo.Status");
            DropTable("dbo.Products");
            DropTable("dbo.Platforms");
            DropTable("dbo.Languages");
            DropTable("dbo.Genres");
            DropTable("dbo.Countries");
            DropTable("dbo.Continents");
            DropTable("dbo.CollaboratorTypes");
            DropTable("dbo.AssetTypes");
        }
    }
}
