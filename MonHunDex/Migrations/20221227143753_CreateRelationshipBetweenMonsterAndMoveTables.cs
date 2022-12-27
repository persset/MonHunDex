using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelationshipBetweenMonsterAndMoveTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterMoves",
                table: "MonsterMoves");

            migrationBuilder.DropIndex(
                name: "IX_MonsterMoves_MoveId",
                table: "MonsterMoves");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MonsterMoves",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterMoves",
                table: "MonsterMoves",
                columns: new[] { "MoveId", "MonsterId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterMoves",
                table: "MonsterMoves");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MonsterMoves",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterMoves",
                table: "MonsterMoves",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterMoves_MoveId",
                table: "MonsterMoves",
                column: "MoveId");
        }
    }
}
