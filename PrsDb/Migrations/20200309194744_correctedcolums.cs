using Microsoft.EntityFrameworkCore.Migrations;

namespace PrsDb.Migrations
{
    public partial class correctedcolums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Request",
                nullable: false,
                defaultValue: "NEW",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "NEW");

            migrationBuilder.AlterColumn<string>(
                name: "RejectionReason",
                table: "Request",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMode",
                table: "Request",
                maxLength: 20,
                nullable: false,
                defaultValue: "Pickup",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValue: "Pickup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Request",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "NEW",
                oldClrType: typeof(string),
                oldDefaultValue: "NEW");

            migrationBuilder.AlterColumn<string>(
                name: "RejectionReason",
                table: "Request",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMode",
                table: "Request",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValue: "Pickup",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValue: "Pickup");
        }
    }
}
