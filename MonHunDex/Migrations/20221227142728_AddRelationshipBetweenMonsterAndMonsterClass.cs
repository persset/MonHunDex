using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationshipBetweenMonsterAndMonsterClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonsterClassId",
                table: "SuperHeroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SuperHeroes_MonsterClassId",
                table: "SuperHeroes",
                column: "MonsterClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_MonsterClasses_MonsterClassId",
                table: "SuperHeroes",
                column: "MonsterClassId",
                principalTable: "MonsterClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_MonsterClasses_MonsterClassId",
                table: "SuperHeroes");

            migrationBuilder.DropIndex(
                name: "IX_SuperHeroes_MonsterClassId",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "MonsterClassId",
                table: "SuperHeroes");
        }
    }
}
