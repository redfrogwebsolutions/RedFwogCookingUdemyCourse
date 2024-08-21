using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedFrogCooking.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTextsToWebsiteTexts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Texts");

            migrationBuilder.CreateTable(
                name: "WebsiteTexts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsitePageId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebsiteTexts_WebsitePages_WebsitePageId",
                        column: x => x.WebsitePageId,
                        principalTable: "WebsitePages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_WebsiteTexts_WebsitePageId",
                table: "WebsiteTexts",
                column: "WebsitePageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebsiteTexts");

            migrationBuilder.CreateTable(
                name: "Texts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsitePageId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Texts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Texts_WebsitePages_WebsitePageId",
                        column: x => x.WebsitePageId,
                        principalTable: "WebsitePages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Texts_WebsitePageId",
                table: "Texts",
                column: "WebsitePageId");
        }
    }
}
