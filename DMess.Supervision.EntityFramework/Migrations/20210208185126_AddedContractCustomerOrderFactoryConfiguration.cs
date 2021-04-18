using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DMess.Supervision.EntityFramework.Migrations
{
    public partial class AddedContractCustomerOrderFactoryConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "Subdivisions",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Subdivisions",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "SubdivisionDepartments",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "SubdivisionDepartments",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "Specifications",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Specifications",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "ProductTypes",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "ProductTypes",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "Posts",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Posts",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "PIDs",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "PIDs",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "Factories",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Factories",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "Employees",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Employees",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "Departments",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Departments",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "Customers",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Customers",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "Contracts",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Contracts",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatorName",
                table: "Accounts",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Accounts",
                newName: "UpdatedBy");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Subdivisions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Subdivisions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "SubdivisionDepartments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "SubdivisionDepartments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Specifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Specifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PIDs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "PIDs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Factories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Factories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Contracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Subdivisions");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Subdivisions");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SubdivisionDepartments");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "SubdivisionDepartments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Specifications");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Specifications");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PIDs");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "PIDs");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Factories");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Factories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Subdivisions",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Subdivisions",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "SubdivisionDepartments",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "SubdivisionDepartments",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Specifications",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Specifications",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "ProductTypes",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "ProductTypes",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Posts",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Posts",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PIDs",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "PIDs",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Factories",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Factories",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Employees",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Employees",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Departments",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Departments",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Customers",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Customers",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Contracts",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Contracts",
                newName: "CreatorName");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Accounts",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Accounts",
                newName: "CreatorName");

            migrationBuilder.AddColumn<byte>(
                name: "ClimaticModification",
                table: "PIDs",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "ConnectionType",
                table: "PIDs",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<int>(
                name: "Diameter",
                table: "PIDs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "DriveType",
                table: "PIDs",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "PressureDifference",
                table: "PIDs",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "PressureLimit",
                table: "PIDs",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "SeismicStability",
                table: "PIDs",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
