﻿using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IProductoRepository
    {
        Task<Producto?> ObtenerPorId(int idProducto);
        Task<int> ActualizarCantidad(int idProducto, int cantidad);
        Task<List<Producto>> ObtenerInventario();
    }
}
