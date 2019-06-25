using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace willywonkaapi.Migrations
{
    public partial class addedLoccationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "RecipeTableName",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "RecipeTableName",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LocationTableStructure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Created_Time = table.Column<DateTime>(nullable: false),
                    ManagerName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationTableStructure", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTableName_LocationId",
                table: "RecipeTableName",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeTableName_LocationTableStructure_LocationId",
                table: "RecipeTableName",
                column: "LocationId",
                principalTable: "LocationTableStructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeTableName_LocationTableStructure_LocationId",
                table: "RecipeTableName");

            migrationBuilder.DropTable(
                name: "LocationTableStructure");

            migrationBuilder.DropIndex(
                name: "IX_RecipeTableName_LocationId",
                table: "RecipeTableName");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "RecipeTableName");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "RecipeTableName",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
