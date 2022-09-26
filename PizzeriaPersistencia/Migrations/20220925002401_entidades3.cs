using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzeriaPersistencia.Migrations
{
    public partial class entidades3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Tb_producto",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Tb_producto");
        }
    }
}
