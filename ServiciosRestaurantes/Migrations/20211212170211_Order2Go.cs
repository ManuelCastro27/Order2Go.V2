using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiciosRestaurantes.Migrations
{
    public partial class Order2Go : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurante_Producto_ProductoIdProducto",
                table: "Restaurante");

            migrationBuilder.DropIndex(
                name: "IX_Restaurante_ProductoIdProducto",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "ProductoIdProducto",
                table: "Restaurante");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantesIdRestaurante",
                table: "Producto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_RestaurantesIdRestaurante",
                table: "Producto",
                column: "RestaurantesIdRestaurante");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Restaurante_RestaurantesIdRestaurante",
                table: "Producto",
                column: "RestaurantesIdRestaurante",
                principalTable: "Restaurante",
                principalColumn: "IdRestaurante",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Restaurante_RestaurantesIdRestaurante",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_RestaurantesIdRestaurante",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "RestaurantesIdRestaurante",
                table: "Producto");

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Restaurante",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
