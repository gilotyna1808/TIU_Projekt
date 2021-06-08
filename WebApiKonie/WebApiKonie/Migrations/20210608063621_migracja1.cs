using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiKonie.Migrations
{
    public partial class migracja1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autoryzacja",
                columns: table => new
                {
                    ID_Autoryzacja = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rola = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autoryzacja", x => x.ID_Autoryzacja);
                });

            migrationBuilder.CreateTable(
                name: "Konie",
                columns: table => new
                {
                    ID_Konia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wiek = table.Column<int>(type: "int", nullable: false),
                    Kraj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kondycja = table.Column<int>(type: "int", nullable: false),
                    Predkosc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konie", x => x.ID_Konia);
                });

            migrationBuilder.CreateTable(
                name: "Przebiegi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_wyscigu = table.Column<int>(type: "int", nullable: false),
                    ID_konia = table.Column<int>(type: "int", nullable: false),
                    Krok = table.Column<int>(type: "int", nullable: false),
                    Dystans = table.Column<int>(type: "int", nullable: false),
                    DystansSuma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przebiegi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    ID_Klienta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Autoryzacja = table.Column<int>(type: "int", nullable: true),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wiek = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StanKonta = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.ID_Klienta);
                    table.ForeignKey(
                        name: "FK_Klienci_Autoryzacja_ID_Autoryzacja",
                        column: x => x.ID_Autoryzacja,
                        principalTable: "Autoryzacja",
                        principalColumn: "ID_Autoryzacja",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkladyWyscigow",
                columns: table => new
                {
                    ID_Skladu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Wyscigu = table.Column<int>(type: "int", nullable: false),
                    Kon1ID_Konia = table.Column<int>(type: "int", nullable: true),
                    Kon2ID_Konia = table.Column<int>(type: "int", nullable: true),
                    Kon3ID_Konia = table.Column<int>(type: "int", nullable: true),
                    Kon4ID_Konia = table.Column<int>(type: "int", nullable: true),
                    Kon5ID_Konia = table.Column<int>(type: "int", nullable: true),
                    KursKon1 = table.Column<int>(type: "int", nullable: false),
                    KursKon2 = table.Column<int>(type: "int", nullable: false),
                    KursKon3 = table.Column<int>(type: "int", nullable: false),
                    KursKon4 = table.Column<int>(type: "int", nullable: false),
                    KursKon5 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkladyWyscigow", x => x.ID_Skladu);
                    table.ForeignKey(
                        name: "FK_SkladyWyscigow_Konie_Kon1ID_Konia",
                        column: x => x.Kon1ID_Konia,
                        principalTable: "Konie",
                        principalColumn: "ID_Konia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkladyWyscigow_Konie_Kon2ID_Konia",
                        column: x => x.Kon2ID_Konia,
                        principalTable: "Konie",
                        principalColumn: "ID_Konia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkladyWyscigow_Konie_Kon3ID_Konia",
                        column: x => x.Kon3ID_Konia,
                        principalTable: "Konie",
                        principalColumn: "ID_Konia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkladyWyscigow_Konie_Kon4ID_Konia",
                        column: x => x.Kon4ID_Konia,
                        principalTable: "Konie",
                        principalColumn: "ID_Konia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkladyWyscigow_Konie_Kon5ID_Konia",
                        column: x => x.Kon5ID_Konia,
                        principalTable: "Konie",
                        principalColumn: "ID_Konia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wyscigi",
                columns: table => new
                {
                    ID_Wyscigu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Zakonczony = table.Column<bool>(type: "bit", nullable: false),
                    WygranyID_Konia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wyscigi", x => x.ID_Wyscigu);
                    table.ForeignKey(
                        name: "FK_Wyscigi_Konie_WygranyID_Konia",
                        column: x => x.WygranyID_Konia,
                        principalTable: "Konie",
                        principalColumn: "ID_Konia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zaklady",
                columns: table => new
                {
                    ID_Zakladu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Klienta = table.Column<int>(type: "int", nullable: false),
                    ID_Wyscigu = table.Column<int>(type: "int", nullable: false),
                    Kurs = table.Column<double>(type: "float", nullable: false),
                    Wygrany = table.Column<bool>(type: "bit", nullable: false),
                    Wyplacony = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaklady", x => x.ID_Zakladu);
                    table.ForeignKey(
                        name: "FK_Zaklady_Klienci_ID_Klienta",
                        column: x => x.ID_Klienta,
                        principalTable: "Klienci",
                        principalColumn: "ID_Klienta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zaklady_Wyscigi_ID_Wyscigu",
                        column: x => x.ID_Wyscigu,
                        principalTable: "Wyscigi",
                        principalColumn: "ID_Wyscigu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Klienci_ID_Autoryzacja",
                table: "Klienci",
                column: "ID_Autoryzacja");

            migrationBuilder.CreateIndex(
                name: "IX_SkladyWyscigow_Kon1ID_Konia",
                table: "SkladyWyscigow",
                column: "Kon1ID_Konia");

            migrationBuilder.CreateIndex(
                name: "IX_SkladyWyscigow_Kon2ID_Konia",
                table: "SkladyWyscigow",
                column: "Kon2ID_Konia");

            migrationBuilder.CreateIndex(
                name: "IX_SkladyWyscigow_Kon3ID_Konia",
                table: "SkladyWyscigow",
                column: "Kon3ID_Konia");

            migrationBuilder.CreateIndex(
                name: "IX_SkladyWyscigow_Kon4ID_Konia",
                table: "SkladyWyscigow",
                column: "Kon4ID_Konia");

            migrationBuilder.CreateIndex(
                name: "IX_SkladyWyscigow_Kon5ID_Konia",
                table: "SkladyWyscigow",
                column: "Kon5ID_Konia");

            migrationBuilder.CreateIndex(
                name: "IX_Wyscigi_WygranyID_Konia",
                table: "Wyscigi",
                column: "WygranyID_Konia");

            migrationBuilder.CreateIndex(
                name: "IX_Zaklady_ID_Klienta",
                table: "Zaklady",
                column: "ID_Klienta");

            migrationBuilder.CreateIndex(
                name: "IX_Zaklady_ID_Wyscigu",
                table: "Zaklady",
                column: "ID_Wyscigu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Przebiegi");

            migrationBuilder.DropTable(
                name: "SkladyWyscigow");

            migrationBuilder.DropTable(
                name: "Zaklady");

            migrationBuilder.DropTable(
                name: "Klienci");

            migrationBuilder.DropTable(
                name: "Wyscigi");

            migrationBuilder.DropTable(
                name: "Autoryzacja");

            migrationBuilder.DropTable(
                name: "Konie");
        }
    }
}
