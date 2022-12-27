using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonHunDex.Migrations
{
    /// <inheritdoc />
    public partial class AddBehaviorTableRelationshipToMonsterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Behavior",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<int>(
                name: "BehaviorId",
                table: "SuperHeroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SuperHeroes_BehaviorId",
                table: "SuperHeroes",
                column: "BehaviorId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_Behaviors_BehaviorId",
                table: "SuperHeroes",
                column: "BehaviorId",
                principalTable: "Behaviors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_Behaviors_BehaviorId",
                table: "SuperHeroes");

            migrationBuilder.DropIndex(
                name: "IX_SuperHeroes_BehaviorId",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "BehaviorId",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<string>(
                name: "Behavior",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
