using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Data.Migrations.Initial
{
    /// <inheritdoc />
    public partial class newMigrationFixes4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Weapon",
                columns: new[] { "weaponId", "abilityDamageModifier", "attackSpeed", "attackValue", "dps", "flavourText", "imgURL", "name", "price" },
                values: new object[,]
                {
                    { 8, 290.0, 0.75, 50, 37.5, "Staff imbued with a medium amount of arcane power, ideal for students studying the magical arts", "Y5tHLvN", "Arcane apprentice staff", 700 },
                    { 9, 600.0, 0.5, 70, 35.0, "Staff imbued with a large amount of destructive fire magic, dangerous in the hands of an unskilled wizard, deadly in the hands of a skilled one.", "mQbqS1A", "Staff of destructive oblivion", 2900 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "weaponId",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "Weapon",
                columns: new[] { "weaponId", "abilityDamageModifier", "attackSpeed", "attackValue", "dps", "flavourText", "imgURL", "name", "price" },
                values: new object[,]
                {
                    { 6, 290.0, 0.75, 50, 37.5, "Staff imbued with a medium amount of arcane power, ideal for students studying the magical arts", "Y5tHLvN", "Arcane apprentice staff", 700 },
                    { 7, 600.0, 0.5, 70, 35.0, "Staff imbued with a large amount of destructive fire magic, dangerous in the hands of an unskilled wizard, deadly in the hands of a skilled one.", "mQbqS1A", "Staff of destructive oblivion", 2900 }
                });
        }
    }
}
