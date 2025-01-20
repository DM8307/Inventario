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
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreEmpresa.Text) ||
                string.IsNullOrWhiteSpace(txtContacto.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor ingresa todos los datos del proveedor.");
                return;
            }

            // Crear una nueva instancia del proveedor
            var nuevoProveedor = new Proveedor
            {
                NombreEmpresa = txtNombreEmpresa.Text,
                Contacto = txtContacto.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            // Agregar el nuevo proveedor al contexto
            _context.Proveedores.Add(nuevoProveedor);

            try
            {
                // Guardar los cambios en la base de datos
                _context.SaveChanges();

                // Limpiar los campos de texto
                txtNombreEmpresa.Clear();
                txtContacto.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();

                // Recargar los proveedores en el DataGridView
                CargarProveedores();

                MessageBox.Show("Proveedor agregado correctamente.");
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar un mensaje
                MessageBox.Show($"Error al agregar proveedor: {ex.Message}");
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
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Obtener el ID del proveedor seleccionado
                int idProveedor = (int)dataGridView2.SelectedRows[0].Cells["ID"].Value;

                var proveedor = _context.Proveedores.Find(idProveedor);
                if (proveedor != null)
                {
                    // Cuando el usuario edita los datos y hace clic en el botón Guardar
                    // Guardamos los cambios realizados en los campos de texto
                    proveedor.NombreEmpresa = txtNombreEmpresa.Text;
                    proveedor.Contacto = txtContacto.Text;
                    proveedor.Telefono = txtTelefono.Text;
                    proveedor.Direccion = txtDireccion.Text;

                    try
                    {
                        // Guardar los cambios en la base de datos
                        _context.SaveChanges();

                        // Recargar la lista de proveedores después de editar
                        CargarProveedores();

                        MessageBox.Show("Proveedor editado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        // Si ocurre un error, mostrar un mensaje
                        MessageBox.Show($"Error al editar proveedor: {ex.Message}");
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

        private void txtNombreEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
