# Inventario
Este es el repositorio para el proeyecto final de un inventario de nuestras materias de desarrollo de software I y su coorespondiente laboratorio.

Inventario es un sistema de gestión de inventarios desarrollado en C# utilizando Windows Forms y SQLite como base de datos. Este proyecto incluye funcionalidades para administrar categorías, productos, proveedores y reportes, con un menú principal para acceder a las diferentes vistas.

Características principales

Vistas del sistema:

Menú principal: Navegación central hacia las diferentes secciones del sistema.

Categorías: Gestione las categorías de productos.

Proveedores: Administre los proveedores.

Productos: Controle el inventario de productos.

Reportes: Genere y visualice informes del inventario. (WIP)

Base de datos:

SQLite con el archivo de base de datos InventarioDH.db, almacenado en la carpeta Database dentro del proyecto.

Conexion configurada en el archivo ContextInventario.cs.

Clases principales:

Categoria: Modelo para categorías de productos.

Producto: Modelo para la gestión de productos.

Proveedor: Modelo para los proveedores.

ContextInventario: Configura la conexión a la base de datos y define los DbSets correspondientes.

Frameworks utilizados:

Entity Framework Core para el manejo de datos.

Windows Forms para la interfaz de usuario.

Instalación

Requisitos previos

Visual Studio 2019 o superior.

.NET Framework 9.0 o compatible.

Paquetes NuGet instalados:

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Sqlite

SQLitePCLRaw.bundle_e_sqlite3

Configuración inicial

Clona este repositorio:

git clone https://github.com/tu-usuario/Inventario.git

Abre el proyecto en Visual Studio.

La base de datos si no es copiada o agregada de manera externa, se creara automaticamente y se le agregaran valores por defecto.

Restaura los paquetes NuGet necesarios ejecutando:

dotnet restore

Ejecuta el proyecto desde Visual Studio presionando F5 o seleccionando Iniciar depuración.

Estructura del proyecto

Carpeta principal

Program.cs: Archivo de entrada principal que inicializa la base de datos, configura la interfaz y ejecuta el menú principal.

Carpeta Models

Contiene las clases principales del sistema:

Categoria.cs

Producto.cs

Proveedor.cs

Carpeta Context

ContextInventario.cs: Configura la conexión con la base de datos y define los DbSets para las tablas del sistema.

se creara la base de datos en esta ruta si no existe: "Inventario\Inventario\bin\Debug\net9.0-windows\InventarioDH.db"
InventarioDH.db: Archivo de base de datos SQLite que contiene las tablas y los datos iniciales del sistema.

Vistas del sistema

Categorías: Administrar categorías de productos.

Proveedores: Administrar proveedores.

Productos: Administrar inventario de productos.

Reportes: Visualizar y generar reportes. (WIP)

Datos iniciales

Al ejecutar el programa por primera vez, se crean las siguientes categorías iniciales si no existen:

Electrónico: Productos electrónicos.

Ropa: Ropa y accesorios.

Estos datos son insertados automáticamente por el código en Program.cs.

Uso del sistema

Al iniciar el programa, se cargará el menú principal con opciones para acceder a las diferentes vistas.

Navegue por las secciones para administrar las categorías, proveedores, productos y reportes.

Los cambios realizados se guardan automáticamente en la base de datos SQLite.

# Contribución

Si deseas contribuir a este proyecto, por favor sigue estos pasos:

Haz un fork del repositorio.

Crea una rama con la función o corrección que desees realizar: git checkout -b mi-funcion.

Realiza tus cambios y haz commit: git commit -m "Agregé mi nueva función".

Envía un pull request.

