using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiciosRestaurantes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiciosRestaurantes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Restaurante> Restaurante { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<OrdenProducto> Venta { get; set; }
    }
}
