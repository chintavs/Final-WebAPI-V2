using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_WebAPI_V2.Migrations
{
    public partial class APIMigrationV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Team_Mem");

            migrationBuilder.RenameColumn(
                name: "TeamName",
                table: "Team_Mem",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Team_Mem",
                newName: "MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team_Mem",
                table: "Team_Mem",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Team_Mem",
                table: "Team_Mem");

            migrationBuilder.RenameTable(
                name: "Team_Mem",
                newName: "Team");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Team",
                newName: "TeamName");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Team",
                newName: "TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "TeamId");
        }
    }
}
