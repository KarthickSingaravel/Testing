using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class FK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_UserType",
                table: "Users",
                column: "UserType");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_UserType",
                table: "Users",
                column: "UserType",
                principalTable: "UserTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_UserType",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserType",
                table: "Users");
        }
    }
}
