using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class FKeyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_UserType",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "Users",
                newName: "UserTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserType",
                table: "Users",
                newName: "IX_Users_UserTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "UserTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_UserTypeId",
                table: "Users",
                column: "UserTypeId",
                principalTable: "UserTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_UserTypeId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserTypeId",
                table: "Users",
                newName: "UserType");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                newName: "IX_Users_UserType");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "UserTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_UserType",
                table: "Users",
                column: "UserType",
                principalTable: "UserTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
