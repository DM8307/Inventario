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
            var agregarForm = new AgregarProductoForm(); 
            if (agregarForm.ShowDialog() == DialogResult.OK)
            {
                CargarProductos(); // Recargar los productos después de agregar
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

        

        private void button3editarproductos_Click(object sender, EventArgs e)
        {
            //boton para editar productos
            // Editar el producto seleccionado
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                var producto = _context.Productos.Find(id);

                if (producto != null)
                {
                    var editarForm = new EditarProductoForm(); 
                    if (editarForm.ShowDialog() == DialogResult.OK)
                    {
                        CargarProductos(); // Recargar los productos después de editar
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para editar.");
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
    }
}
