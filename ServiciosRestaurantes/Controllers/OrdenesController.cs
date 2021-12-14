using Microsoft.AspNetCore.Mvc;
using ServiciosRestaurantes.Data;
using ServiciosRestaurantes.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ServiciosRestaurantes.Controllers
{
    public class OrdenesController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public IActionResult NuevaOrden()
        {
            var vistaOrden = new VistaOrden();
            vistaOrden.Restaurantes = new Restaurante();
            vistaOrden.Productos = new List<OrdenProducto>();


            var lista = _context.Restaurante;
            lista.Add(new Restaurante { IdRestaurante = 0, Nombre = "[Seleccione un Restaurante...]" });
            IOrderedQueryable<Restaurante> restaurantes = lista.OrderBy(c => c.Nombre);
            lista = (Microsoft.EntityFrameworkCore.DbSet<Restaurante>)restaurantes;
            ViewBag.restaurantes = new SelectList(lista, "IdRestaurante", "Nombre");

            return View(vistaOrden);
        }

        [HttpPost]
        public IActionResult NuevaOrden(VistaOrden vistaOrden)
        {
            return View(vistaOrden);
        }


        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.IdProducto == id);
        }
    }
}
