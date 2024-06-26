using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWeb_LeVanTeo.Migrations
{
    public partial class ThemDuLieuLanDau : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, "A", 12000.0, 10, "PHP" },
                    { 2, "A", 12000.0, 15, "C#" },
                    { 3, "A", 12000.0, 10, "Quản trị SQL Server" },
                    { 4, "A", 12000.0, 15, "Lập trình Node.js" },
                    { 5, "A", 12000.0, 10, "ASP.Net Core MVC" },
                    { 6, "A", 12000.0, 15, "Cấu trúc dữ liệu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
