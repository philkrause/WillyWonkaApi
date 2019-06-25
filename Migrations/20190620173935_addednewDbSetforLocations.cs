using Microsoft.EntityFrameworkCore.Migrations;

namespace willywonkaapi.Migrations
{
    public partial class addednewDbSetforLocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTableName_LocationTableStructure_LocationId",
                table: "RecipeTableName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationTableStructure",
                table: "LocationTableStructure");

            migrationBuilder.RenameTable(
                name: "LocationTableStructure",
                newName: "LocaitonTableName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocaitonTableName",
                table: "LocaitonTableName",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTableName_LocaitonTableName_LocationId",
                table: "RecipeTableName",
                column: "LocationId",
                principalTable: "LocaitonTableName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTableName_LocaitonTableName_LocationId",
                table: "RecipeTableName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocaitonTableName",
                table: "LocaitonTableName");

            migrationBuilder.RenameTable(
                name: "LocaitonTableName",
                newName: "LocationTableStructure");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationTableStructure",
                table: "LocationTableStructure",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTableName_LocationTableStructure_LocationId",
                table: "RecipeTableName",
                column: "LocationId",
                principalTable: "LocationTableStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
