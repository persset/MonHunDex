using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class CreateMonsterWeaknessesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonsterWeaknesses",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    ElementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterWeaknesses", x => new { x.MonsterId, x.ElementId });
                    table.ForeignKey(
                        name: "FK_MonsterWeaknesses_Elements_ElementId",
                        column: x => x.ElementId,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterWeaknesses_SuperHeroes_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "SuperHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterWeaknesses_ElementId",
                table: "MonsterWeaknesses",
                column: "ElementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterWeaknesses");
        }
    }
}
