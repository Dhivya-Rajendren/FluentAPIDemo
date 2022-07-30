using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPIDemo.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Lms");

            migrationBuilder.CreateTable(
                name: "tbl_Books",
                schema: "Lms",
                columns: table => new
                {
                    Book_code = table.Column<string>(type: "Char(20)", maxLength: 20, nullable: false),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    SupplierId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Books", x => x.Book_code);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Suppliers",
                schema: "Lms",
                columns: table => new
                {
                    SupplierId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Suppliers", x => x.SupplierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Books",
                schema: "Lms");

            migrationBuilder.DropTable(
                name: "tbl_Suppliers",
                schema: "Lms");
        }
    }
}
