using Microsoft.EntityFrameworkCore.Migrations;

namespace willywonkaapi.Migrations
{
    public partial class addednewuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTableName_LocationTableName_LocationId",
                table: "RecipeTableName");

            migrationBuilder.DropIndex(
                name: "IX_RecipeTableName_LocationId",
                table: "RecipeTableName");

            migrationBuilder.AddColumn<int>(
                name: "LocationTableNameId",
                table: "RecipeTableName",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTableName_LocationTableNameId",
                table: "RecipeTableName",
                column: "LocationTableNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTableName_LocationTableName_LocationTableNameId",
                table: "RecipeTableName",
                column: "LocationTableNameId",
                principalTable: "LocationTableName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTableName_LocationTableName_LocationTableNameId",
                table: "RecipeTableName");

            migrationBuilder.DropIndex(
                name: "IX_RecipeTableName_LocationTableNameId",
                table: "RecipeTableName");

            migrationBuilder.DropColumn(
                name: "LocationTableNameId",
                table: "RecipeTableName");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTableName_LocationId",
                table: "RecipeTableName",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTableName_LocationTableName_LocationId",
                table: "RecipeTableName",
                column: "LocationId",
                principalTable: "LocationTableName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
