using Inventario.Views;
using Inventario.Models;
using Inventario.Context;

namespace Inventario
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var context = new InventarioContext())
            {
                context.Database.EnsureCreated();
                if (!context.Categorias.Any())
                {
                    context.Categorias.AddRange(
                        new Categoria { Nombre = "Electr�nica", Descripcion = "Dispositivos electr�nicos como computadoras, tel�fonos, etc." },
                        new Categoria { Nombre = "Accesorios", Descripcion = "Accesorios para dispositivos electr�nicos como teclados, ratones, etc." },
                        new Categoria { Nombre = "Mobiliario", Descripcion = "Muebles y equipamiento de oficina." },
                        new Categoria { Nombre = "Iluminaci�n", Descripcion = "Productos de iluminaci�n como l�mparas y bombillas." }
                    );
                    context.SaveChanges();
                    Console.WriteLine("Datos iniciales insertados.");
                }
                if (!context.Proveedores.Any())
                {
                    context.Proveedores.AddRange(
                        new Proveedor { NombreEmpresa = "TechCorp", Contacto = "Juan P�rez", Telefono = "123-456-789", Direccion = "Calle Ficticia 123, Ciudad, Pa�s" },
    new Proveedor
    {
        NombreEmpresa = "AudioTech",
        Contacto = "Ana L�pez",
        Telefono = "987-654-321",
        Direccion = "Av. Principal 45, Ciudad, Pa�s"
    },
    new Proveedor
    {
        NombreEmpresa = "FurniturePlus",
        Contacto = "Carlos G�mez",
        Telefono = "555-123-456",
        Direccion = "Calle Mobiliario 789, Ciudad, Pa�s"
    },
    new Proveedor
    {
        NombreEmpresa = "LightingSolutions",
        Contacto = "Sof�a Mart�nez",
        Telefono = "333-777-999",
        Direccion = "Calle Luces 101, Ciudad, Pa�s"
    }
);
                    context.SaveChanges();
                    Console.WriteLine("Datos iniciales insertados.");
                }
                if (!context.Productos.Any())
                {
                    context.Productos.AddRange(
                        new Producto { Nombre = "Laptop Dell XPS 13", Codigo = "LPX13-DELL", CategoriaID = 1, Precio = 1200.00m, Existencia = 10, ProveedorID = 1 },
                        new Producto { Nombre = "Auriculares Sony WH-1000XM4", Codigo = "AUR-SONY-XM4", CategoriaID = 1, Precio = 350.00m, Existencia = 15, ProveedorID = 2 },
                        new Producto { Nombre = "Cargador port�til Anker PowerCore", Codigo = "CAR-ANKER-10000", CategoriaID = 2, Precio = 40.00m, Existencia = 30, ProveedorID = 1 },
                        new Producto { Nombre = "Teclado mec�nico Logitech G Pro", Codigo = "TECL-LOGI-GPRO", CategoriaID = 2, Precio = 130.00m, Existencia = 20, ProveedorID = 2 },
                        new Producto { Nombre = "Monitor LG 27\" 4K", Codigo = "MON-LG-27-4K", CategoriaID = 1, Precio = 400.00m, Existencia = 5, ProveedorID = 1 },
                        new Producto { Nombre = "Mouse inal�mbrico Logitech MX Master 3", Codigo = "MOU-LOGI-MX3", CategoriaID = 2, Precio = 100.00m, Existencia = 25, ProveedorID = 2 },
                        new Producto { Nombre = "Silla ergon�mica Herman Miller Aeron", Codigo = "SIL-HERMAN-AERON", CategoriaID = 3, Precio = 1200.00m, Existencia = 8, ProveedorID = 3 },
                        new Producto { Nombre = "Escritorio IKEA Hemnes", Codigo = "ESC-IKEA-HEMNES", CategoriaID = 3, Precio = 200.00m, Existencia = 12, ProveedorID = 3 },
                        new Producto { Nombre = "L�mpara de escritorio Philips Hue", Codigo = "LAM-PHILIPS-HUE", CategoriaID = 4, Precio = 60.00m, Existencia = 18, ProveedorID = 4 },
                        new Producto { Nombre = "Cable USB-C Anker", Codigo = "CAB-ANKER-USB-C", CategoriaID = 2, Precio = 10.00m, Existencia = 50, ProveedorID = 1 }
                    );
                    context.SaveChanges();
                    Console.WriteLine("Datos iniciales insertados.");
                }


            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Views.Index());
        }
    }
}