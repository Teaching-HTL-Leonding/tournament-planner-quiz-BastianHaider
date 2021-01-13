using Microsoft.EntityFrameworkCore.Migrations;

namespace TournamentPlanner.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Players_WinnerID",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_WinnerID",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "WinnerID",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Players",
                newName: "PhoneNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Players",
                newName: "Phone");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WinnerID",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WinnerID",
                table: "Matches",
                column: "WinnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Players_WinnerID",
                table: "Matches",
                column: "WinnerID",
                principalTable: "Players",
                principalColumn: "ID");
        }
    }
}
