namespace Inventario.Views
{
    public partial class Index : Form
    {
        // Declarar variables estáticas para controlar las instancias de formularios
        private static Categorias? categoriasForm;
        private static Productos? productosForm;
        private static Proveedores? proveedoresForm;
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //formload?
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // intrucciones de uso
        }

        private void button1catergorias_Click(object sender, EventArgs e)
        {
            //boton que llevara a la vista de
            //
            // Abrir la vista de Categorías y cerrar este formulario
            if (categoriasForm == null || categoriasForm.IsDisposed)
            {
                categoriasForm = new Categorias();
                categoriasForm.FormClosed += (s, args) => this.Show(); // Mostrar este formulario al cerrar Categorías
                this.Hide(); // Ocultar el formulario actual
                categoriasForm.Show();
            }
            else
            {
                categoriasForm.BringToFront(); // Llevar la ventana existente al frente
            }
        
        }

        private void button3proveedores_Click(object sender, EventArgs e)
        {
            //boton que llevara a proveedores
            // Abrir la vista de Proveedores y cerrar este formulario
            if (proveedoresForm == null || proveedoresForm.IsDisposed)
            {
                proveedoresForm = new Proveedores();
                proveedoresForm.FormClosed += (s, args) => this.Show(); // Mostrar este formulario al cerrar Proveedores
                this.Hide(); // Ocultar el formulario actual
                proveedoresForm.Show();
            }
            else
            {
                proveedoresForm.BringToFront(); // Llevar la ventana existente al frente
            }
        
        }

        private void button5reportes_Click(object sender, EventArgs e)
        {
            //boton llevara a reportes
            // Ejemplo de transición a la vista de Reportes
            MessageBox.Show("El formulario de Reportes aún no está implementado.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Menu principal
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // intrucciones de uso
        }

        private void button2Producctos_Click(object sender, EventArgs e)
        {
            //boton que llevara a la vista de producctos
            // Abrir la vista de Productos y cerrar este formulario
            if (productosForm == null || productosForm.IsDisposed)
            {
                productosForm = new Productos();
                productosForm.FormClosed += (s, args) => this.Show(); // Mostrar este formulario al cerrar Productos
                this.Hide(); // Ocultar el formulario actual
                productosForm.Show();
            }
            else
            {
                productosForm.BringToFront(); // Llevar la ventana existente al frente
            }
        }

        private void button4Salir_Click(object sender, EventArgs e)
        {
            //boton para salir del programa
            var result = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Salir de la aplicación
            }
        }
    }
}
