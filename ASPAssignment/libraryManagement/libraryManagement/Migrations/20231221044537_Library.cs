using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace libraryManagement.Migrations
{
    /// <inheritdoc />
    public partial class Library : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<int>(type: "int", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedYear = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "BookId", "AuthorName", "BookName", "CategoryName", "IsDeleted", "Price", "PublishedYear", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Balaguruswamy", "C++", 1, false, 500, 2001, new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Mazidi", "Microcontrollers", 2, false, 550, 2002, new DateTime(2019, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Sebastian", "Robotics", 3, false, 600, 2003, new DateTime(2019, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Jacques Heyman", "Structural Engineering", 4, false, 800, 2004, new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Michael Faraday", "DC Motors", 5, false, 400, 2004, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Nassim Nicholas", "Economics", 6, true, 300, 2005, new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "-", "Data Structure", 1, false, 430, 2006, new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Abraham Silberschatz", "Operating Systems", 1, true, 560, 2007, new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Wikliam Gothmann", "Digital Electronics", 2, false, 730, 2005, new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
