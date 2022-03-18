using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class RenameEngCompanyAddMacCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Engineers",
                newName: "Company");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Machines");

            migrationBuilder.RenameColumn(
                name: "Company",
                table: "Engineers",
                newName: "CompanyName");
        }
    }
}
