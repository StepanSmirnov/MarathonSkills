using Microsoft.EntityFrameworkCore.Migrations;

namespace MarathonSkills.Migrations
{
    public partial class AddRegistrationEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistrationEvents",
                columns: table => new
                {
                    RegistrationEventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(nullable: false),
                    EventId = table.Column<string>(maxLength: 6, nullable: false),
                    BibNumber = table.Column<int>(nullable: false),
                    RaceTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationEvents", x => x.RegistrationEventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationEvents");
        }
    }
}
