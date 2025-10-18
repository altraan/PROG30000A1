using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assign1PROG30000.Migrations
{
    /// <inheritdoc />
    public partial class FixEquipmentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_EquipmentId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Requests");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Requests",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Requests",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentType",
                table: "Requests",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestDetails",
                table: "Requests",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "EquipmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "EquipmentType",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequestDetails",
                table: "Requests");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Requests",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Requests",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Requests",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_EquipmentId",
                table: "Requests",
                column: "EquipmentId");
        }
    }
}
