using System;
using System.Collections.Generic;

namespace Infrastructure.Models;

public partial class Producto
{
    public int Idproducto { get; set; }

    public string Nombreproducto { get; set; } = null!;

    public int Cantidadproducto { get; set; }
}
