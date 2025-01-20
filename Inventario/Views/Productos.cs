using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Context;
using Inventario.Models;

namespace Inventario.Views
{
    public partial class Productos : Form
    {
        private readonly InventarioContext _context = new InventarioContext();
        public Productos()
        {
            InitializeComponent();
            CargarProductos();
        }
        private void CargarProductos()
        {
            // Cargar los productos desde la base de datos al DataGridView
            var productos = _context.Productos
                .Select(p => new
                {
                    p.ID,
                    p.Nombre,
                    p.Codigo,
                    Categoria = p.Categoria.Nombre, // Relación con Categoría
                    p.Precio,
                    p.Existencia,
                    Proveedor = p.Proveedor.NombreEmpresa // Relación con Proveedor
                }).ToList();

            dataGridView1.DataSource = productos;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //titulo productos
        }

        private void button1agregarproductos_Click(object sender, EventArgs e)
        {
            //boton para agregar productos
            // Mostrar un formulario o cuadro de entrada para agregar productos

            string nombre = txtNombre.Text;
            string codigo = txtCodigo.Text;
            decimal precio;
            int existencia = Convert.ToInt32(txtExistencia.Text);
            string categoria = txtCategoria.Text;
            string proveedor = txtProveedor.Text;

            // Validar que el precio sea un número válido
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Por favor ingrese un precio válido.");
                return;
            }

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(txtExistencia.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text) || string.IsNullOrWhiteSpace(txtProveedor.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            if (!int.TryParse(txtExistencia.Text, out existencia))
            {
                MessageBox.Show("Por favor ingrese una cantidad de existencia válida.");
                return;
            }

            // Crear un nuevo objeto Producto
            var nuevoProducto = new Producto
            {
                Nombre = nombre,
                Codigo = codigo,
                Precio = precio,
                Existencia = existencia,
                Categoria = _context.Categorias.FirstOrDefault(c => c.Nombre == txtCategoria.Text), // Relación con la categoría
                Proveedor = _context.Proveedores.FirstOrDefault(p => p.NombreEmpresa == txtProveedor.Text) // Relación con el proveedor
            };

            // Validar si la categoría y el proveedor existen en la base de datos
            if (nuevoProducto.Categoria == null)
            {
                MessageBox.Show("La categoría ingresada no existe.");
                return;
            }
            if (nuevoProducto.Proveedor == null)
            {
                MessageBox.Show("El proveedor ingresado no existe.");
                return;
            }

            // Agregar el nuevo producto a la base de datos
            _context.Productos.Add(nuevoProducto);

            try
            {
                // Guardar los cambios en la base de datos
                _context.SaveChanges();
                MessageBox.Show("Producto agregado correctamente.");
                CargarProductos(); // Recargar los productos después de agregar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private void button2eliminarproductos_Click(object sender, EventArgs e)
        {
            //boton para eliminar productos
            // Eliminar el producto seleccionado
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                var producto = _context.Productos.Find(id);

                if (producto != null)
                {
                    _context.Productos.Remove(producto);
                    _context.SaveChanges();
                    MessageBox.Show("Producto eliminado correctamente.");
                    CargarProductos(); // Recargar los productos después de eliminar
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data grid de producctos

        }

        private void button4Volver_a_inicio_Click(object sender, EventArgs e)
        {
            // Volver al menú principal
            this.Close(); // Cierra el formulario de productos
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un producto
            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el ID del producto seleccionado
                int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;

                // Buscar el producto con el ID
                var producto = _context.Productos.Find(id);

                // Verificar si el producto existe
                if (producto != null)
                {
                    // Actualizar las propiedades del producto con los valores de los controles
                    producto.Nombre = txtNombre.Text;
                    producto.Codigo = txtCodigo.Text;
                    producto.Precio = decimal.Parse(txtPrecio.Text); // Asegúrate de manejar posibles excepciones en la conversión
                    producto.Existencia = int.Parse(txtExistencia.Text); // Igualmente, maneja excepciones aquí

                    // Si la categoría y el proveedor son editables y pueden ser nulos, actualízalos si es necesario
                    if (producto.Categoria != null)
                        producto.Categoria.Nombre = txtCategoria.Text;
                    if (producto.Proveedor != null)
                        producto.Proveedor.NombreEmpresa = txtProveedor.Text;

                    // Guardar los cambios en la base de datos
                    _context.SaveChanges();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Producto actualizado correctamente.");

                    // Recargar los productos para reflejar los cambios
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para editar.");
            }
        }
    }
}
