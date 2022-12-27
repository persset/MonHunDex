using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class ChangeMonsterTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonsterAilments_SuperHeroes_MonsterId",
                table: "MonsterAilments");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterElements_SuperHeroes_MonsterId",
                table: "MonsterElements");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterLocations_SuperHeroes_MonsterId",
                table: "MonsterLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterMoves_SuperHeroes_MonsterId",
                table: "MonsterMoves");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterTitles_SuperHeroes_MonsterID",
                table: "MonsterTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterWeaknesses_SuperHeroes_MonsterId",
                table: "MonsterWeaknesses");

            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_Behaviors_BehaviorId",
                table: "SuperHeroes");

            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_MonsterClasses_MonsterClassId",
                table: "SuperHeroes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperHeroes",
                table: "SuperHeroes");

            migrationBuilder.RenameTable(
                name: "SuperHeroes",
                newName: "Monsters");

            migrationBuilder.RenameIndex(
                name: "IX_SuperHeroes_MonsterClassId",
                table: "Monsters",
                newName: "IX_Monsters_MonsterClassId");

            migrationBuilder.RenameIndex(
                name: "IX_SuperHeroes_BehaviorId",
                table: "Monsters",
                newName: "IX_Monsters_BehaviorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterAilments_Monsters_MonsterId",
                table: "MonsterAilments",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterElements_Monsters_MonsterId",
                table: "MonsterElements",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterLocations_Monsters_MonsterId",
                table: "MonsterLocations",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterMoves_Monsters_MonsterId",
                table: "MonsterMoves",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monsters_Behaviors_BehaviorId",
                table: "Monsters",
                column: "BehaviorId",
                principalTable: "Behaviors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monsters_MonsterClasses_MonsterClassId",
                table: "Monsters",
                column: "MonsterClassId",
                principalTable: "MonsterClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterTitles_Monsters_MonsterID",
                table: "MonsterTitles",
                column: "MonsterID",
                principalTable: "Monsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterWeaknesses_Monsters_MonsterId",
                table: "MonsterWeaknesses",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonsterAilments_Monsters_MonsterId",
                table: "MonsterAilments");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterElements_Monsters_MonsterId",
                table: "MonsterElements");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterLocations_Monsters_MonsterId",
                table: "MonsterLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterMoves_Monsters_MonsterId",
                table: "MonsterMoves");

            migrationBuilder.DropForeignKey(
                name: "FK_Monsters_Behaviors_BehaviorId",
                table: "Monsters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monsters_MonsterClasses_MonsterClassId",
                table: "Monsters");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterTitles_Monsters_MonsterID",
                table: "MonsterTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterWeaknesses_Monsters_MonsterId",
                table: "MonsterWeaknesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters");

            migrationBuilder.RenameTable(
                name: "Monsters",
                newName: "SuperHeroes");

            migrationBuilder.RenameIndex(
                name: "IX_Monsters_MonsterClassId",
                table: "SuperHeroes",
                newName: "IX_SuperHeroes_MonsterClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Monsters_BehaviorId",
                table: "SuperHeroes",
                newName: "IX_SuperHeroes_BehaviorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperHeroes",
                table: "SuperHeroes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterAilments_SuperHeroes_MonsterId",
                table: "MonsterAilments",
                column: "MonsterId",
                principalTable: "SuperHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterElements_SuperHeroes_MonsterId",
                table: "MonsterElements",
                column: "MonsterId",
                principalTable: "SuperHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterLocations_SuperHeroes_MonsterId",
                table: "MonsterLocations",
                column: "MonsterId",
                principalTable: "SuperHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterMoves_SuperHeroes_MonsterId",
                table: "MonsterMoves",
                column: "MonsterId",
                principalTable: "SuperHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterTitles_SuperHeroes_MonsterID",
                table: "MonsterTitles",
                column: "MonsterID",
                principalTable: "SuperHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterWeaknesses_SuperHeroes_MonsterId",
                table: "MonsterWeaknesses",
                column: "MonsterId",
                principalTable: "SuperHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_Behaviors_BehaviorId",
                table: "SuperHeroes",
                column: "BehaviorId",
                principalTable: "Behaviors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_MonsterClasses_MonsterClassId",
                table: "SuperHeroes",
                column: "MonsterClassId",
                principalTable: "MonsterClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
