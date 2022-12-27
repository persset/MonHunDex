using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class CreateMonsterMovesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonsterMoves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    MoveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterMoves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonsterMoves_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterMoves_SuperHeroes_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "SuperHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterMoves_MonsterId",
                table: "MonsterMoves",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterMoves_MoveId",
                table: "MonsterMoves",
                column: "MoveId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterMoves");
        }
    }
}
