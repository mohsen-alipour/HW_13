using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp_HW_13.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LibraryID",
                table: "Amanats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Amanats_LibraryID",
                table: "Amanats",
                column: "LibraryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Amanats_Librarys_LibraryID",
                table: "Amanats",
                column: "LibraryID",
                principalTable: "Librarys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amanats_Librarys_LibraryID",
                table: "Amanats");

            migrationBuilder.DropIndex(
                name: "IX_Amanats_LibraryID",
                table: "Amanats");

            migrationBuilder.DropColumn(
                name: "LibraryID",
                table: "Amanats");
        }
    }
}
