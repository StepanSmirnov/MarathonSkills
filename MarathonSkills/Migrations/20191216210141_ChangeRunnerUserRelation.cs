using Microsoft.EntityFrameworkCore.Migrations;

namespace MarathonSkills.Migrations
{
    public partial class ChangeRunnerUserRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Runners",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_Runners_UserId",
                table: "Runners",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Runners_AspNetUsers_UserId",
                table: "Runners",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Runners_AspNetUsers_UserId",
                table: "Runners");

            migrationBuilder.DropIndex(
                name: "IX_Runners_UserId",
                table: "Runners");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Runners",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
