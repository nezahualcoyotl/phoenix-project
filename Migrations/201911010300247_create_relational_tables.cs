namespace BackstageMusic.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class create_relational_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetCountries",
                c => new
                {
                    id_assetcountry = c.Int(nullable: false, identity: true),
                    id_asset = c.Int(nullable: false),
                    id_country = c.Int(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_assetcountry)
                .ForeignKey("dbo.Assets", t => t.id_asset, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.id_country, cascadeDelete: false)
                .Index(t => t.id_asset)
                .Index(t => t.id_country);

            CreateTable(
                "dbo.AssetGenres",
                c => new
                {
                    id_assetgenre = c.Int(nullable: false, identity: true),
                    id_asset = c.Int(nullable: false),
                    id_genre = c.Int(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_assetgenre)
                .ForeignKey("dbo.Assets", t => t.id_asset, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.id_genre, cascadeDelete: true)
                .Index(t => t.id_asset)
                .Index(t => t.id_genre);

            CreateTable(
                "dbo.AssetPlatforms",
                c => new
                {
                    id_assetplatform = c.Int(nullable: false, identity: true),
                    id_asset = c.Int(nullable: false),
                    id_genre = c.Int(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_assetplatform)
                .ForeignKey("dbo.Assets", t => t.id_asset, cascadeDelete: true)
                .ForeignKey("dbo.Platforms", t => t.id_genre, cascadeDelete: true)
                .Index(t => t.id_asset)
                .Index(t => t.id_genre);

            CreateTable(
                "dbo.Collaborations",
                c => new
                {
                    id_collaboration = c.Int(nullable: false, identity: true),
                    id_track = c.Int(nullable: false),
                    id_collaboratortype = c.Int(nullable: false),
                    name = c.String(nullable: false),
                    active = c.Boolean(nullable: false, defaultValue: true),
                    created_at = c.DateTime(defaultValueSql: "GETDATE()"),
                    updated_at = c.DateTime(),
                })
                .PrimaryKey(t => t.id_collaboration)
                .ForeignKey("dbo.CollaboratorTypes", t => t.id_collaboratortype, cascadeDelete: true)
                .ForeignKey("dbo.Tracks", t => t.id_track, cascadeDelete: true)
                .Index(t => t.id_track)
                .Index(t => t.id_collaboratortype);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Collaborations", "id_track", "dbo.Tracks");
            DropForeignKey("dbo.Collaborations", "id_collaboratortype", "dbo.CollaboratorTypes");
            DropForeignKey("dbo.AssetPlatforms", "id_genre", "dbo.Platforms");
            DropForeignKey("dbo.AssetPlatforms", "id_asset", "dbo.Assets");
            DropForeignKey("dbo.AssetGenres", "id_genre", "dbo.Genres");
            DropForeignKey("dbo.AssetGenres", "id_asset", "dbo.Assets");
            DropForeignKey("dbo.AssetCountries", "id_country", "dbo.Countries");
            DropForeignKey("dbo.AssetCountries", "id_asset", "dbo.Assets");
            DropIndex("dbo.Collaborations", new[] { "id_collaboratortype" });
            DropIndex("dbo.Collaborations", new[] { "id_track" });
            DropIndex("dbo.AssetPlatforms", new[] { "id_genre" });
            DropIndex("dbo.AssetPlatforms", new[] { "id_asset" });
            DropIndex("dbo.AssetGenres", new[] { "id_genre" });
            DropIndex("dbo.AssetGenres", new[] { "id_asset" });
            DropIndex("dbo.AssetCountries", new[] { "id_country" });
            DropIndex("dbo.AssetCountries", new[] { "id_asset" });
            DropTable("dbo.Collaborations");
            DropTable("dbo.AssetPlatforms");
            DropTable("dbo.AssetGenres");
            DropTable("dbo.AssetCountries");
        }
    }
}
