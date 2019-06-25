using Microsoft.EntityFrameworkCore.Migrations;

namespace willywonkaapi.Migrations
{
    public partial class addednewDbSetforLocationsFIX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTableName_LocaitonTableName_LocationId",
                table: "RecipeTableName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocaitonTableName",
                table: "LocaitonTableName");

            migrationBuilder.RenameTable(
                name: "LocaitonTableName",
                newName: "LocationTableName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationTableName",
                table: "LocationTableName",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTableName_LocationTableName_LocationId",
                table: "RecipeTableName",
                column: "LocationId",
                principalTable: "LocationTableName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTableName_LocationTableName_LocationId",
                table: "RecipeTableName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationTableName",
                table: "LocationTableName");

            migrationBuilder.RenameTable(
                name: "LocationTableName",
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
    }
}
