using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplainSystemApp.Migrations
{
    public partial class addchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegistrationId",
                table: "UserRegistration",
                newName: "UserRegistrationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserRegistrationId",
                table: "UserRegistration",
                newName: "RegistrationId");
        }
    }
}
