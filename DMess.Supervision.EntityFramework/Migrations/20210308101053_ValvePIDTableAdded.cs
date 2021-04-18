using Microsoft.EntityFrameworkCore.Migrations;

namespace DMess.Supervision.EntityFramework.Migrations
{
    public partial class ValvePIDTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "ClimaticModification",
                table: "PIDs",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ConnectionType",
                table: "PIDs",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Diameter",
                table: "PIDs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "PIDs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "DriveType",
                table: "PIDs",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "PressureDifference",
                table: "PIDs",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "PressureLimit",
                table: "PIDs",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "SeismicStability",
                table: "PIDs",
                type: "tinyint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClimaticModification",
                table: "PIDs");

            migrationBuilder.DropColumn(
                name: "ConnectionType",
                table: "PIDs");

            migrationBuilder.DropColumn(
                name: "Diameter",
                table: "PIDs");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "PIDs");

            migrationBuilder.DropColumn(
                name: "DriveType",
                table: "PIDs");

            migrationBuilder.DropColumn(
                name: "PressureDifference",
                table: "PIDs");

            migrationBuilder.DropColumn(
                name: "PressureLimit",
                table: "PIDs");

            migrationBuilder.DropColumn(
                name: "SeismicStability",
                table: "PIDs");
        }
    }
}
