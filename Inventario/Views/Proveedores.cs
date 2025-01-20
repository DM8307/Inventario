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
    public partial class Proveedores : Form
    {
        private InventarioContext _context;
        public Proveedores()
        {
            InitializeComponent();
            _context = new InventarioContext();
        }
        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores(); // Llamamos al método al cargar el formulario
        }

        private void CargarProveedores()
        {
            try
            {
                // Obtiene los proveedores de la base de datos
                var proveedores = _context.Proveedores
                    .Select(p => new
                    {
                        p.ID,
                        p.NombreEmpresa,
                        p.Contacto,
                        p.Telefono,
                        p.Direccion
                    })
                    .ToList();

                // Asigna los datos al DataGridView
                dataGridView2.DataSource = proveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}");
            }
        }

        private void Proveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Liberar recursos del contexto
            _context.Dispose();
        }
        private void button4Volver_a_inicio_Click(object sender, EventArgs e)
        {
            // Volver al menú principal
            this.Close(); // Cierra el formulario de proveedores
        }

        private void button1agregarproductos_Click(object sender, EventArgs e)
        {
            //boton para agregar proveedores
            var agregarProveedorForm = new AgregarProveedorForm();
            if (agregarProveedorForm.ShowDialog() == DialogResult.OK)
            {
                // Recargar la lista de proveedores después de agregar uno nuevo
                CargarProveedores();
            }
        }

        private void button2eliminarproductos_Click(object sender, EventArgs e)
        {
            //boton para eliminar proveedores
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int idProveedor = (int)dataGridView2.SelectedRows[0].Cells["ID"].Value;

                var proveedor = _context.Proveedores.Find(idProveedor);
                if (proveedor != null)
                {
                    _context.Proveedores.Remove(proveedor);
                    _context.SaveChanges();
                    CargarProveedores(); // Recargar la lista de proveedores después de eliminar
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor para eliminar.");
            }
        }

        private void button3editarproductos_Click(object sender, EventArgs e)
        {
            //boton para editar proveedores
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int idProveedor = (int)dataGridView2.SelectedRows[0].Cells["ID"].Value;
                var proveedor = _context.Proveedores.Find(idProveedor);

                if (proveedor != null)
                {
                    var editarProveedorForm = new EditarProveedorForm();
                    if (editarProveedorForm.ShowDialog() == DialogResult.OK)
                    {
                        _context.SaveChanges(); // Guardar los cambios en la base de datos
                        CargarProveedores(); // Recargar la lista de proveedores después de editar
                    }
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor para editar.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
