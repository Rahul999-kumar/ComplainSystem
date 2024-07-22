using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplainSystemApp.Migrations
{
    public partial class AddTables_16July24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentMaster",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentMaster", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "FlatMaster",
                columns: table => new
                {
                    FlatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocietyId = table.Column<int>(type: "int", nullable: false),
                    TowerId = table.Column<int>(type: "int", nullable: false),
                    FloorId = table.Column<int>(type: "int", nullable: false),
                    FlatNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatMaster", x => x.FlatId);
                });

            migrationBuilder.CreateTable(
                name: "FloorMaster",
                columns: table => new
                {
                    FloorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocietyId = table.Column<int>(type: "int", nullable: false),
                    TowerId = table.Column<int>(type: "int", nullable: false),
                    FloorNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorMaster", x => x.FloorId);
                });

            migrationBuilder.CreateTable(
                name: "SocietyMaster",
                columns: table => new
                {
                    SocietyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocietyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocietyMaster", x => x.SocietyId);
                });

            migrationBuilder.CreateTable(
                name: "TowerMaster",
                columns: table => new
                {
                    TowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocietyId = table.Column<int>(type: "int", nullable: false),
                    TowerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowerMaster", x => x.TowerId);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AlternateMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.UserProfileId);
                });

            migrationBuilder.CreateTable(
                name: "UserRegistration",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegistration", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentMaster");

            migrationBuilder.DropTable(
                name: "FlatMaster");

            migrationBuilder.DropTable(
                name: "FloorMaster");

            migrationBuilder.DropTable(
                name: "SocietyMaster");

            migrationBuilder.DropTable(
                name: "TowerMaster");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "UserRegistration");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
