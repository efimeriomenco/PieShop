using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PiesCategories",
                columns: table => new
                {
                    pieCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pieCategoryName = table.Column<string>(nullable: true),
                    pieCategoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PiesCategories", x => x.pieCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Pies",
                columns: table => new
                {
                    pieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pieName = table.Column<string>(nullable: true),
                    piePrice = table.Column<decimal>(nullable: false),
                    pieImageUrl = table.Column<string>(nullable: true),
                    pieImageThumbnailUrl = table.Column<string>(nullable: true),
                    pieWeidth = table.Column<int>(nullable: false),
                    pieIsFavourite = table.Column<bool>(nullable: false),
                    pieShortDesc = table.Column<string>(nullable: true),
                    pieLongDesc = table.Column<string>(nullable: true),
                    pieCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pies", x => x.pieId);
                    table.ForeignKey(
                        name: "FK_Pies_PiesCategories_pieCategoryId",
                        column: x => x.pieCategoryId,
                        principalTable: "PiesCategories",
                        principalColumn: "pieCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pies_pieCategoryId",
                table: "Pies",
                column: "pieCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pies");

            migrationBuilder.DropTable(
                name: "PiesCategories");
        }
    }
}
