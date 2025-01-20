using System;
using System.Collections.Generic;

namespace Inventario.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }

        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}