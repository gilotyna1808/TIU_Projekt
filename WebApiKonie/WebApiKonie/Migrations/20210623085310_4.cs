using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiKonie.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zaklady_Konie_ID_Konia",
                table: "Zaklady");

            migrationBuilder.AlterColumn<int>(
                name: "ID_Konia",
                table: "Zaklady",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Zaklady_Konie_ID_Konia",
                table: "Zaklady",
                column: "ID_Konia",
                principalTable: "Konie",
                principalColumn: "ID_Konia",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zaklady_Konie_ID_Konia",
                table: "Zaklady");

            migrationBuilder.AlterColumn<int>(
                name: "ID_Konia",
                table: "Zaklady",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Zaklady_Konie_ID_Konia",
                table: "Zaklady",
                column: "ID_Konia",
                principalTable: "Konie",
                principalColumn: "ID_Konia",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
