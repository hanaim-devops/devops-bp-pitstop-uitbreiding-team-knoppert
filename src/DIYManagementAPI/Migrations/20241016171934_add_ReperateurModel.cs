using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DIYManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class add_ReperateurModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "DIYAvondModels",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.CreateTable(
                name: "Reparateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reparateurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DIYAvondModelReparateur",
                columns: table => new
                {
                    DIYAvondenId = table.Column<int>(type: "int", nullable: false),
                    ReparateursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIYAvondModelReparateur", x => new { x.DIYAvondenId, x.ReparateursId });
                    table.ForeignKey(
                        name: "FK_DIYAvondModelReparateur_DIYAvondModels_DIYAvondenId",
                        column: x => x.DIYAvondenId,
                        principalTable: "DIYAvondModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DIYAvondModelReparateur_Reparateurs_ReparateursId",
                        column: x => x.ReparateursId,
                        principalTable: "Reparateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DIYAvondModelReparateur_ReparateursId",
                table: "DIYAvondModelReparateur",
                column: "ReparateursId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DIYAvondModelReparateur");

            migrationBuilder.DropTable(
                name: "Reparateurs");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndDate",
                table: "DIYAvondModels",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
