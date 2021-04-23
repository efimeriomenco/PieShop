using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PiesCategories",
                columns: new[] { "pieCategoryId", "pieCategoryDescription", "pieCategoryName" },
                values: new object[] { 1, "Very delicious and good taste with freshest fruits.", "Fruit pies" });

            migrationBuilder.InsertData(
                table: "PiesCategories",
                columns: new[] { "pieCategoryId", "pieCategoryDescription", "pieCategoryName" },
                values: new object[] { 2, "Cheesy all the way.", "Cheese pies" });

            migrationBuilder.InsertData(
                table: "PiesCategories",
                columns: new[] { "pieCategoryId", "pieCategoryDescription", "pieCategoryName" },
                values: new object[] { 3, "Get in the mood for seasonal pie.", "Seasonal pies" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "pieId", "pieCategoryId", "pieImageThumbnailUrl", "pieImageUrl", "pieIsFavourite", "pieLongDesc", "pieName", "piePrice", "pieShortDesc", "pieWeidth" },
                values: new object[,]
                {
                    { 1, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Strawberry pie", 15.9m, "Tastes Good", 200 },
                    { 4, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Pumpkin pie", 11.0m, "Tastes Good", 120 },
                    { 2, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", false, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Cheesecake pie", 16.3m, "Tastes Good", 150 },
                    { 3, 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", true, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Rhurbarb pie", 14.6m, "Tastes Good", 170 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "pieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "pieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "pieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "pieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PiesCategories",
                keyColumn: "pieCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PiesCategories",
                keyColumn: "pieCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PiesCategories",
                keyColumn: "pieCategoryId",
                keyValue: 3);
        }
    }
}
