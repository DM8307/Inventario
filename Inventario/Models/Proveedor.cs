using System;
using System.Collections.Generic;

namespace Inventario.Models
{
    public class Proveedor
    {
        public int ID { get; set; }
        public string NombreEmpresa { get; set; } = string.Empty;
        public string? Contacto { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }

        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}