using Microsoft.EntityFrameworkCore.Migrations;

namespace willywonkaapi.Migrations
{
    public partial class fixingStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "RecipeTableName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "RecipeTableName",
                nullable: true);
        }
    }
}
