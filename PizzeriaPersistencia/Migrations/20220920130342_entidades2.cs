using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzeriaPersistencia.Migrations
{
    public partial class entidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_cliente_Tb_producto_ProductoId",
                table: "Tb_cliente");

            migrationBuilder.DropIndex(
                name: "IX_Tb_cliente_ProductoId",
                table: "Tb_cliente");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Tb_cliente");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Tb_producto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_producto_ClienteId",
                table: "Tb_producto",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_producto_Tb_cliente_ClienteId",
                table: "Tb_producto",
                column: "ClienteId",
                principalTable: "Tb_cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_producto_Tb_cliente_ClienteId",
                table: "Tb_producto");

            migrationBuilder.DropIndex(
                name: "IX_Tb_producto_ClienteId",
                table: "Tb_producto");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Tb_producto");

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Tb_cliente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_cliente_ProductoId",
                table: "Tb_cliente",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_cliente_Tb_producto_ProductoId",
                table: "Tb_cliente",
                column: "ProductoId",
                principalTable: "Tb_producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
