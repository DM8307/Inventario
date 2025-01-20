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
    public partial class Reportes : Form
    {
        private InventarioContext _context;

        public Reportes()
        {
            InitializeComponent();
            _context = new InventarioContext();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarProveedores();
        }

        private void CargarCategorias()
        {
            var categorias = _context.Categorias.ToList();
            comboBoxCategorias.DataSource = categorias;
            comboBoxCategorias.DisplayMember = "Nombre";
            comboBoxCategorias.ValueMember = "ID";
        }

        private void CargarProveedores()
        {
            var proveedores = _context.Proveedores.ToList();
            comboBoxProveedores.DataSource = proveedores;
            comboBoxProveedores.DisplayMember = "NombreEmpresa";
            comboBoxProveedores.ValueMember = "ID";
        }

        // Filtrar productos por categoría seleccionada
        private void buttonFiltrarPorCategoria_Click(object sender, EventArgs e)
        {
            int categoriaId = (int)comboBoxCategorias.SelectedValue;
            var productosPorCategoria = _context.Productos
                .Where(p => p.CategoriaID == categoriaId)
                .Select(p => new
                {
                    p.Nombre,
                    p.Codigo,
                    p.Precio,
                    p.Existencia
                })
                .ToList();

            dataGridViewReportes.DataSource = productosPorCategoria;
        }

        // Filtrar productos por proveedor seleccionado
        private void buttonFiltrarPorProveedor_Click(object sender, EventArgs e)
        {
            int proveedorId = (int)comboBoxProveedores.SelectedValue;
            var productosPorProveedor = _context.Productos
                .Where(p => p.ProveedorID == proveedorId)
                .Select(p => new
                {
                    p.Nombre,
                    p.Codigo,
                    p.Precio,
                    p.Existencia
                })
                .ToList();

            dataGridViewReportes.DataSource = productosPorProveedor;
        }

        // Mostrar productos con stock bajo (menos de 10 unidades)
        private void buttonStockBajo_Click(object sender, EventArgs e)
        {
            var productosStockBajo = _context.Productos
                .Where(p => p.Existencia < 10)
                .Select(p => new
                {
                    p.Nombre,
                    p.Codigo,
                    p.Precio,
                    p.Existencia
                })
                .ToList();

            dataGridViewReportes.DataSource = productosStockBajo;
        }

        private void Reportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
        }

        private void dataGridViewReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
