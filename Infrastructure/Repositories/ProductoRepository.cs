using Infrastructure.Data;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly CclInventarioContext _context;

        public ProductoRepository(CclInventarioContext context)
        {
            _context = context;
        }

        public async Task<Producto?> ObtenerPorId(int idProducto)
        {
            var productoDb = await _context.Productos.FindAsync(idProducto);
            return productoDb ?? null;
        }

        public async Task<int> ActualizarCantidad(int idProducto, int cantidad)
        {
            var producto = await _context.Productos.FindAsync(idProducto);
            if (producto != null)
            {
                producto.Cantidadproducto = cantidad;
                return await _context.SaveChangesAsync();
            }
            else return 0;
        }

        public async Task<List<Producto>> ObtenerInventario()
        {
            return await _context.Productos.ToListAsync();
        }
    }
}
