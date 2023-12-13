using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfficeLeagueAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Points",
                table: "Disciplines",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contestants",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Contestants",
                columns: new[] { "ContestantId", "Age", "Email", "FirstName", "Image", "IsAdmin", "LastName", "Nickname" },
                values: new object[,]
                {
                    { 1, 25, null, "Jaksa", null, true, "Cukic", "Caksa" },
                    { 2, 23, null, "Gligorije", null, true, "Petrovic", "Gypsy king" },
                    { 3, 26, null, "Srdjan", null, true, "Todorovic", "Srdzan" },
                    { 4, 23, null, "Vuk", null, true, "Trifunovic", "Csni" }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "DisciplineId", "DailyLimit", "Description", "Image", "Name", "Points" },
                values: new object[,]
                {
                    { 10, 1, "3UP description", null, "3UP", 1.5f },
                    { 11, 1, "Football Dice description", null, "Footbal Dice", 1.25f },
                    { 12, 4, "Uno description", null, "Uno", 1f },
                    { 13, 1, "Darts description", null, "Darts", 1f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contestants",
                keyColumn: "ContestantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contestants",
                keyColumn: "ContestantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contestants",
                keyColumn: "ContestantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contestants",
                keyColumn: "ContestantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "DisciplineId",
                keyValue: 13);

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "Disciplines",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contestants",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
