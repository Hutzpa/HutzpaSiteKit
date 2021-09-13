using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HutzpaSiteKit.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EntityExamples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExampleStringProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExampleNumericProperty = table.Column<int>(type: "int", nullable: false),
                    ExampleFloatProperty = table.Column<float>(type: "real", nullable: false),
                    ExampleDateTimeProperty = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExampleBoolProperty = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityExamples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompositeKeyEntityExamples",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityExampleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompositeKeyEntityExamples", x => new { x.EntityExampleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CompositeKeyEntityExamples_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompositeKeyEntityExamples_EntityExamples_EntityExampleId",
                        column: x => x.EntityExampleId,
                        principalTable: "EntityExamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompositeKeyEntityExamples_UserId",
                table: "CompositeKeyEntityExamples",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompositeKeyEntityExamples");

            migrationBuilder.DropTable(
                name: "EntityExamples");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");
        }
    }
}
