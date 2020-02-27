using Microsoft.EntityFrameworkCore.Migrations;

namespace PrehistoricRealism.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dinosaurs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Diet = table.Column<int>(nullable: false),
                    NeedToKnow = table.Column<string>(nullable: false),
                    Behavior = table.Column<string>(nullable: false),
                    SocialInteraction = table.Column<string>(nullable: false),
                    PackLimits = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Additionalinfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinosaurs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dinosaurs");
        }
    }
}
