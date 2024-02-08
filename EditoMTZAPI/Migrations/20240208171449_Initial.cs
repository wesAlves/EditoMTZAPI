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
                    EbookID = table.Column<Guid>(type: "uuid", nullable: false),
                    EbookName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ebooks", x => x.EbookID);
                });

            migrationBuilder.InsertData(
                table: "Ebooks",
                columns: new[] { "EbookID", "EbookName" },
                values: new object[,]
                {
                    { new Guid("06dc8af0-cdf1-498c-a021-5d5a4e3d4040"), "One" },
                    { new Guid("3db46b91-a907-42b6-9a34-11d88640562f"), "Two" }
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
