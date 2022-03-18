using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class EngRenameRepMacAddManufacturerRemoveCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Machines",
                newName: "SerialId");

            migrationBuilder.RenameColumn(
                name: "PrimaryRep",
                table: "Engineers",
                newName: "Rep");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SerialId",
                table: "Machines",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "Rep",
                table: "Engineers",
                newName: "PrimaryRep");
        }
    }
}
