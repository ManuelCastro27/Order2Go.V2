using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiciosRestaurantes.Data.Migrations
{
    public partial class MigracinInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Restaurante_RestauranteIdRestaurante",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_RestauranteIdRestaurante",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "RestauranteIdRestaurante",
                table: "Producto");

            migrationBuilder.AddColumn<int>(
                name: "ProductoIdProducto",
                table: "Restaurante",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurante_ProductoIdProducto",
                table: "Restaurante",
                column: "ProductoIdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurante_Producto_ProductoIdProducto",
                table: "Restaurante",
                column: "ProductoIdProducto",
                principalTable: "Producto",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurante_Producto_ProductoIdProducto",
                table: "Restaurante");

            migrationBuilder.DropIndex(
                name: "IX_Restaurante_ProductoIdProducto",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "ProductoIdProducto",
                table: "Restaurante");

            migrationBuilder.AddColumn<int>(
                name: "RestauranteIdRestaurante",
                table: "Producto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_RestauranteIdRestaurante",
                table: "Producto",
                column: "RestauranteIdRestaurante");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Restaurante_RestauranteIdRestaurante",
                table: "Producto",
                column: "RestauranteIdRestaurante",
                principalTable: "Restaurante",
                principalColumn: "IdRestaurante",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
