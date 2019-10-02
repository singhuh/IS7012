using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCountry.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Destination",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CityCode",
                table: "Destination",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 13);

            migrationBuilder.AddColumn<DateTime>(
                name: "TravelDate",
                table: "Destination",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TravelDate",
                table: "Destination");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Destination",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CityCode",
                table: "Destination",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3);
        }
    }
}
