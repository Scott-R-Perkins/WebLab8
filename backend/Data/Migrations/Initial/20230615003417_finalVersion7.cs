using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Data.Migrations.Initial
{
    /// <inheritdoc />
    public partial class finalVersion7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 4,
                column: "imgURL",
                value: "Y5tHLvN");

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 5,
                column: "imgURL",
                value: "mQbqS1A");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 4,
                column: "imgURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 5,
                column: "imgURL",
                value: "");
        }
    }
}
