using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TotalDebtPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_people_categories_CategoryId",
                table: "people");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "people",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "people",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "people",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<float>(
                name: "TotalDebt",
                table: "people",
                type: "real",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_people_categories_CategoryId",
                table: "people",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_people_categories_CategoryId",
                table: "people");

            migrationBuilder.DropColumn(
                name: "TotalDebt",
                table: "people");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "people",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "people",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "people",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_people_categories_CategoryId",
                table: "people",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
