using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class CreateMonsterAilmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonsterAilments",
                columns: table => new
                {
                    MonsterId = table.Column<int>(type: "int", nullable: false),
                    AilmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterAilments", x => new { x.AilmentId, x.MonsterId });
                    table.ForeignKey(
                        name: "FK_MonsterAilments_Ailments_AilmentId",
                        column: x => x.AilmentId,
                        principalTable: "Ailments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterAilments_SuperHeroes_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "SuperHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAilments_MonsterId",
                table: "MonsterAilments",
                column: "MonsterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterAilments");
        }
    }
}
