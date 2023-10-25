using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorECommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class editProductTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ProductTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ProductTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Deleted", "Visible" },
                values: new object[] { false, true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ProductTypes");
        }
    }
}
