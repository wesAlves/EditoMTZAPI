using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EditoMTZAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ebooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    SubTitle = table.Column<string>(type: "text", nullable: false),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ebooks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ebooks",
                columns: new[] { "Id", "Description", "Language", "SubTitle", "Subject", "Title" },
                values: new object[,]
                {
                    { new Guid("afec3f04-c005-40ba-94ae-5d128c0600fc"), "", "", "", "", "One" },
                    { new Guid("eb13d5c2-f370-49e9-8fb7-d605a196422c"), "", "", "", "", "Two" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ebooks");
        }
    }
}
