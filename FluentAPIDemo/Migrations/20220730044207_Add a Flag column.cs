using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPIDemo.Migrations
{
    public partial class AddaFlagcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsActive",
                schema: "Lms",
                table: "tbl_Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "Lms",
                table: "tbl_Suppliers");
        }
    }
}
