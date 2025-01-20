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
    public partial class Categorias : Form
    {
        private InventarioContext _context;
        public Categorias()
        {
            InitializeComponent();
            _context = new InventarioContext();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }
        private void CargarCategorias()
        {
            // Cargar las categorías desde la base de datos
            var categorias = _context.Categorias.ToList();

            // Asignar las categorías al BindingSource
            categoriaBindingSource.DataSource = categorias;

            // Vincular el BindingSource al DataGridView
            dtgvCategorias.DataSource = categoriaBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Desvincular la data
            //dtgvCategorias.DataSource = null;

            //// agregar renglon
            //int n = dtgvCategorias.Rows.Add();

            ////Colocar informacion
            //dtgvCategorias.Rows.Add(txtNombre.Text, txtDescripcion.Text, txtProductos.Text);

            ////Limpiar txt
            ////txtNombre.Text = "";
            //txtDescripcion.Text = "";
            //txtProductos.Text = "";


            ////Vincular la data
            //dtgvCategorias.DataSource = categoriaBindingSource1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoriaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4Volver_a_inicio_Click(object sender, EventArgs e)
        {
            // Volver al menú principal
            this.Close(); // Cierra el formulario de categorias
        }

        private void button1agregarproductos_Click(object sender, EventArgs e)
        {
            // Verificar si los campos no están vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor ingresa el nombre y la descripción de la categoría.");
                return;
            }

            // Crear una nueva instancia de Categoria
            var nuevaCategoria = new Categoria
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text
            };

            // Agregar la nueva categoría al contexto
            _context.Categorias.Add(nuevaCategoria);

            // Guardar los cambios en la base de datos
            _context.SaveChanges();

            // Limpiar los campos de texto
            txtNombre.Clear();
            txtDescripcion.Clear();

            // Recargar las categorías en el DataGridView
            CargarCategorias();

            MessageBox.Show("Categoría agregada correctamente.");
        }

        private void Categorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }

        private void button2eliminarproductos_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dtgvCategorias.CurrentRow != null)
            {
                // Obtener el ID de la categoría seleccionada
                int id = (int)dtgvCategorias.CurrentRow.Cells["ID"].Value;

                // Buscar la categoría en la base de datos
                var categoria = _context.Categorias.Find(id);

                // Verificar si la categoría existe
                if (categoria != null)
                {
                    // Eliminar la categoría
                    _context.Categorias.Remove(categoria);
                    _context.SaveChanges();

                    // Recargar las categorías en el DataGridView
                    CargarCategorias();

                    MessageBox.Show("Categoría eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría para eliminar.");
            }
        }

        private void button3editarproductos_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dtgvCategorias.CurrentRow != null)
            {
                // Obtener el ID de la categoría seleccionada
                int id = (int)dtgvCategorias.CurrentRow.Cells["ID"].Value;

                // Buscar la categoría en la base de datos
                var categoria = _context.Categorias.Find(id);

                // Verificar si la categoría existe
                if (categoria != null)
                {
                

                    // Permitir que el usuario edite y guarde los cambios
                    if (MessageBox.Show("¿Deseas editar esta categoría?", "Editar Categoría", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Modificar la categoría con los nuevos valores
                        categoria.Nombre = txtNombre.Text;
                        categoria.Descripcion = txtDescripcion.Text;

                        // Guardar los cambios
                        _context.SaveChanges();

                        // Recargar las categorías en el DataGridView
                        CargarCategorias();

                        MessageBox.Show("Categoría editada correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría para editar.");
            }
        }
    }
}
