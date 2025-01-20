using System;
using System.Collections.Generic;

namespace Inventario.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public int ProveedorID { get; set; }
        public int CategoriaID { get; set; }

        public virtual Categoria? Categoria { get; set; }
        public virtual Proveedor? Proveedor { get; set; }
    }
}