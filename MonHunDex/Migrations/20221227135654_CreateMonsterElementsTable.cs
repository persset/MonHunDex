using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class CreateMonsterElementsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonsterElements",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    ElementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterElements", x => new { x.ElementId, x.MonsterId });
                    table.ForeignKey(
                        name: "FK_MonsterElements_Elements_ElementId",
                        column: x => x.ElementId,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterElements_SuperHeroes_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "SuperHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterElements_MonsterId",
                table: "MonsterElements",
                column: "MonsterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterElements");
        }
    }
}
