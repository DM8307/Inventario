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

        }

        private void Categorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }
    }
}
