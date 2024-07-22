using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplainSystemApp.Migrations
{
    public partial class AddingGenderMasterTable_18July24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "UserProfile",
                newName: "GenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenderID",
                table: "UserProfile",
                newName: "Gender");
        }
    }
}
