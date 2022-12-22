using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class CreateMonsterLocationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonsterLocations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonsterID = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterLocations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterLocations_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterLocations_SuperHeroes_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "SuperHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLocations_LocationID",
                table: "MonsterLocations",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLocations_MonsterID",
                table: "MonsterLocations",
                column: "MonsterID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterLocations");
        }
    }
}
