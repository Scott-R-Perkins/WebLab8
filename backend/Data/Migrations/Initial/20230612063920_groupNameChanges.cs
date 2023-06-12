using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Data.Migrations.Initial
{
    /// <inheritdoc />
    public partial class groupNameChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armour",
                columns: table => new
                {
                    armourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    physicalDefenceValue = table.Column<int>(type: "int", nullable: true),
                    magicalDefenceValue = table.Column<int>(type: "int", nullable: true),
                    flavourText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    imgURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armour", x => x.armourId);
                });

            migrationBuilder.CreateTable(
                name: "Potion",
                columns: table => new
                {
                    potionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    potionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    potionPotencyValue = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    imgURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potion", x => x.potionId);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    weaponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attackValue = table.Column<int>(type: "int", nullable: true),
                    attackSpeed = table.Column<double>(type: "float", nullable: true),
                    dps = table.Column<double>(type: "float", nullable: true),
                    abilityDamageModifier = table.Column<double>(type: "float", nullable: true),
                    flavourText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    imgURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.weaponId);
                });

            migrationBuilder.InsertData(
                table: "Armour",
                columns: new[] { "armourId", "flavourText", "imgURL", "magicalDefenceValue", "name", "physicalDefenceValue", "price" },
                values: new object[,]
                {
                    { 1, "Strong plate armour capable of withstanding strong physical blows.", "T3vSkoI", 230, "Platemail of the Sturdy Soldier", 690, 680 },
                    { 2, "Robes imbued with magical wards to boost both magical offense and defense.", "S6MLT0P", 550, "Robe of the Wizened Wizard", 190, 700 },
                    { 3, "Flexible armour allowing freedom of movement for quick strikes while providing a balanced defense.", "GDE6NHc", 390, "Leather armour of the Dextrous Striker", 430, 650 }
                });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "Name",
                value: "memes");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "Name",
                value: "memes");

            migrationBuilder.InsertData(
                table: "Potion",
                columns: new[] { "potionId", "imgURL", "name", "potionDescription", "potionPotencyValue", "price" },
                values: new object[,]
                {
                    { 1, "BtFkFWn", "Minor Health Potion", "Drink to restore a small amount of health, Heal potency: ", 75, 20 },
                    { 2, "hQU0HQG", "Health Potion", "Drink to restore a medium amount of health, Heal potency: ", 150, 70 },
                    { 3, "hOL3mew", "Major Health Potion", "Drink to restore a large amount of health, Heal potency: ", 250, 200 },
                    { 4, "OBV95Xr", "Minor Strength Potion", "Drink boost your strength a small amount, Boost potency: ", 75, 20 },
                    { 5, "lajwEJd", "Strength Potion", "Drink boost your strength a medium amount, Boost potency: ", 150, 70 },
                    { 6, "ZwNIHHE", "Major Strength Potion", "Drink boost your strength a large amount, Boost potency: ", 250, 200 },
                    { 7, "RCosYt9", "Minor Intellect Potion", "Drink boost your intelligence a small amount, Boost potency: ", 75, 20 },
                    { 8, "MEUkEX7", "Intellect Potion", "Drink boost your intelligence a medium amount, Boost potency: ", 150, 70 },
                    { 9, "5JKaqbG", "Major Intellect Potion", "Drink boost your intelligence a large amount, Boost potency: ", 250, 200 },
                    { 10, "TC4TKiW", "Minor Dextrous Potion", "Drink boost your dexterity a small amount, Boost potency: ", 75, 20 },
                    { 11, "teGVnVo", "Dextrous Potion", "Drink boost your dexterity a medium amount, Boost potency: ", 150, 70 },
                    { 12, "Mu7z0Dq", "Major Dextrous Potion", "Drink boost your dexterity a large amount, Boost potency: ", 250, 200 }
                });

            migrationBuilder.InsertData(
                table: "Weapon",
                columns: new[] { "weaponId", "abilityDamageModifier", "attackSpeed", "attackValue", "dps", "flavourText", "imgURL", "name", "price" },
                values: new object[,]
                {
                    { 1, 140.0, 1.6499999999999999, 170, 280.5, "Sword forged in imitation of the sword of the late king and traitor, Augustus, VII", "HXe6HWw", "Faux sword of the late kings deceit", 650 },
                    { 2, 170.0, 1.1000000000000001, 220, 242.00000000000003, "A monstrous mace with the power to shatter shields and cave in skulls.", "DJjnBts", "Mace of sundering", 400 },
                    { 3, 160.0, 2.5, 75, 187.5, "Twin curved daggers build for attacking quickly from the shadows.", "yHx2Lc5", "Dagger of the twin serpents", 250 },
                    { 4, 290.0, 0.75, 50, 37.5, "Staff imbued with a medium amount of arcane power, ideal for students studying the magical arts", "", "Arcane apprentice staff", 700 },
                    { 5, 600.0, 0.5, 70, 35.0, "Staff imbued with a large amount of destructive fire magic, dangerous in the hands of an unskilled wizard, deadly in the hands of a skilled one.", "", "Staff of destructive oblivion", 2900 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armour");

            migrationBuilder.DropTable(
                name: "Potion");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "Name",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "Name",
                value: "user");
        }
    }
}
