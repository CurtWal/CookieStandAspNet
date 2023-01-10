using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookieStandAspNet.Migrations
{
    public partial class updatedcookie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CookieStand",
                columns: new[] { "Id", "Average_Cookies_Per_Sale", "Description", "Location", "Maximum_Customers_Per_Hour", "Minimum_Customers_Per_Hour", "Owner" },
                values: new object[] { "3aa1e0ec-0cc6-4d88-bfcd-4cb85cd6caae", 2.5m, "", "Barcelona", 7, 3, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CookieStand",
                keyColumn: "Id",
                keyValue: "3aa1e0ec-0cc6-4d88-bfcd-4cb85cd6caae");
        }
    }
}
