using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class FixMonsterLocationsAssociativeRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonsterLocations_Locations_LocationID",
                table: "MonsterLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterLocations_SuperHeroes_MonsterID",
                table: "MonsterLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterLocations",
                table: "MonsterLocations");

            migrationBuilder.DropIndex(
                name: "IX_MonsterLocations_LocationID",
                table: "MonsterLocations");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "MonsterLocations");

            migrationBuilder.RenameColumn(
                name: "MonsterID",
                table: "MonsterLocations",
                newName: "MonsterId");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "MonsterLocations",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterLocations_MonsterID",
                table: "MonsterLocations",
                newName: "IX_MonsterLocations_MonsterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterLocations",
                table: "MonsterLocations",
                columns: new[] { "LocationId", "MonsterId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterLocations_Locations_LocationId",
                table: "MonsterLocations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterLocations_SuperHeroes_MonsterId",
                table: "MonsterLocations",
                column: "MonsterId",
                principalTable: "SuperHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonsterLocations_Locations_LocationId",
                table: "MonsterLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterLocations_SuperHeroes_MonsterId",
                table: "MonsterLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterLocations",
                table: "MonsterLocations");

            migrationBuilder.RenameColumn(
                name: "MonsterId",
                table: "MonsterLocations",
                newName: "MonsterID");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "MonsterLocations",
                newName: "LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_MonsterLocations_MonsterId",
                table: "MonsterLocations",
                newName: "IX_MonsterLocations_MonsterID");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "MonsterLocations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterLocations",
                table: "MonsterLocations",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLocations_LocationID",
                table: "MonsterLocations",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterLocations_Locations_LocationID",
                table: "MonsterLocations",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterLocations_SuperHeroes_MonsterID",
                table: "MonsterLocations",
                column: "MonsterID",
                principalTable: "SuperHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
