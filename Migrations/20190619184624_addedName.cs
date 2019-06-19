using Microsoft.EntityFrameworkCore.Migrations;

namespace willywonkaapi.Migrations
{
    public partial class addedName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipesTableName",
                table: "RecipesTableName");

            migrationBuilder.RenameTable(
                name: "RecipesTableName",
                newName: "RecipeTableName");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RecipeTableName",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeTableName",
                table: "RecipeTableName",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeTableName",
                table: "RecipeTableName");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RecipeTableName");

            migrationBuilder.RenameTable(
                name: "RecipeTableName",
                newName: "RecipesTableName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipesTableName",
                table: "RecipesTableName",
                column: "Id");
        }
    }
}
