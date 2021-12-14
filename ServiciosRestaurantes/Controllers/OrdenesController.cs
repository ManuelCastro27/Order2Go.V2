using Microsoft.AspNetCore.Mvc;
using ServiciosRestaurantes.Data;
using ServiciosRestaurantes.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace ServiciosRestaurantes.Controllers
{
    public class OrdenesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdenesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult NuevaOrden()
        {
            var vistaOrden = new VistaOrden();
            vistaOrden.Restaurante = new Restaurante();
            vistaOrden.Productos = new List<OrdenProducto>();
            //Session["vistaOrden"] = vistaOrden;


            var lista = _context.Restaurante.ToList();
            lista.Add(new Restaurante { IdRestaurante = 0, Nombre = "[Seleccione un Restaurante...]" });
            lista = lista.OrderBy(c => c.Nombre).ToList();
            ViewBag.restaurantes = new SelectList(lista, "IdRestaurante", "Nombre");

            return View(vistaOrden);
        }

        [HttpPost]
        public IActionResult NuevaOrden(VistaOrden vistaOrden)
        {
            return View(vistaOrden);
        }


        public IActionResult AgregarProducto()
        {

            var lista = _context.Producto.ToList();
            lista.Add(new Producto { IdProducto = 0, Nombre = "[Seleccione un Producto...]" });
            lista = lista.OrderBy(c => c.Nombre).ToList();
            ViewBag.productos = new SelectList(lista, "IdProducto", "Nombre");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AgregarProducto(OrdenProducto ordenProducto)
        {
                return View(ordenProducto);
        }
    }
}
