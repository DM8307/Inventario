namespace Inventario.Views
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            existenciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoBindingSource = new BindingSource(components);
            inventarioContextBindingSource1 = new BindingSource(components);
            inventarioContextBindingSource = new BindingSource(components);
            button1agregarproductos = new Button();
            button2eliminarproductos = new Button();
            button4Volver_a_inicio = new Button();
            label1 = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtExistencia = new TextBox();
            lblExistencia = new Label();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            txtProveedor = new TextBox();
            lblProveedor = new Label();
            button3editarproductos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventarioContextBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventarioContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, existenciaDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, proveedorDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productoBindingSource;
            dataGridView1.Location = new Point(28, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 303);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            existenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia";
            existenciaDataGridViewTextBoxColumn.HeaderText = "Existencia";
            existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Models.Producto);
            // 
            // inventarioContextBindingSource1
            // 
            inventarioContextBindingSource1.DataSource = typeof(Context.InventarioContext);
            // 
            // inventarioContextBindingSource
            // 
            inventarioContextBindingSource.DataSource = typeof(Context.InventarioContext);
            // 
            // button1agregarproductos
            // 
            button1agregarproductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1agregarproductos.Location = new Point(28, 375);
            button1agregarproductos.Name = "button1agregarproductos";
            button1agregarproductos.Size = new Size(158, 70);
            button1agregarproductos.TabIndex = 1;
            button1agregarproductos.Text = "Agregar";
            button1agregarproductos.UseVisualStyleBackColor = true;
            button1agregarproductos.Click += button1agregarproductos_Click;
            // 
            // button2eliminarproductos
            // 
            button2eliminarproductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2eliminarproductos.Location = new Point(192, 375);
            button2eliminarproductos.Name = "button2eliminarproductos";
            button2eliminarproductos.Size = new Size(158, 70);
            button2eliminarproductos.TabIndex = 2;
            button2eliminarproductos.Text = "Eliminar";
            button2eliminarproductos.UseVisualStyleBackColor = true;
            button2eliminarproductos.Click += button2eliminarproductos_Click;
            // 
            // button4Volver_a_inicio
            // 
            button4Volver_a_inicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4Volver_a_inicio.Location = new Point(668, 409);
            button4Volver_a_inicio.Name = "button4Volver_a_inicio";
            button4Volver_a_inicio.Size = new Size(158, 36);
            button4Volver_a_inicio.TabIndex = 4;
            button4Volver_a_inicio.Text = "Volver a inicio";
            button4Volver_a_inicio.UseVisualStyleBackColor = true;
            button4Volver_a_inicio.Click += button4Volver_a_inicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 40);
            label1.TabIndex = 5;
            label1.Text = "Productos";
            label1.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(732, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(689, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(137, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(689, 103);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(137, 23);
            txtCodigo.TabIndex = 9;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(732, 85);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "Codigo";
            lblCodigo.Click += label2_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(689, 159);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(137, 23);
            txtPrecio.TabIndex = 11;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(738, 141);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio";
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(689, 217);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(137, 23);
            txtExistencia.TabIndex = 13;
            // 
            // lblExistencia
            // 
            lblExistencia.AutoSize = true;
            lblExistencia.Location = new Point(732, 199);
            lblExistencia.Name = "lblExistencia";
            lblExistencia.Size = new Size(58, 15);
            lblExistencia.TabIndex = 12;
            lblExistencia.Text = "Existencia";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(689, 276);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(137, 23);
            txtCategoria.TabIndex = 15;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(732, 258);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categoria";
            lblCategoria.Click += label2_Click_1;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(689, 332);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(137, 23);
            txtProveedor.TabIndex = 17;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(729, 314);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(61, 15);
            lblProveedor.TabIndex = 16;
            lblProveedor.Text = "Proveedor";
            // 
            // button3editarproductos
            // 
            button3editarproductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3editarproductos.Location = new Point(356, 375);
            button3editarproductos.Name = "button3editarproductos";
            button3editarproductos.Size = new Size(158, 70);
            button3editarproductos.TabIndex = 18;
            button3editarproductos.Text = "Editar";
            button3editarproductos.UseVisualStyleBackColor = true;
            button3editarproductos.Click += button1_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 457);
            Controls.Add(button3editarproductos);
            Controls.Add(txtProveedor);
            Controls.Add(lblProveedor);
            Controls.Add(txtCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtExistencia);
            Controls.Add(lblExistencia);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(button4Volver_a_inicio);
            Controls.Add(button2eliminarproductos);
            Controls.Add(button1agregarproductos);
            Controls.Add(dataGridView1);
            Name = "Productos";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventarioContextBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventarioContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource productoBindingSource;
        private BindingSource inventarioContextBindingSource;
        private Button button1agregarproductos;
        private Button button2eliminarproductos;
        private Button button4Volver_a_inicio;
        private Label label1;
        private BindingSource inventarioContextBindingSource1;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtExistencia;
        private Label lblExistencia;
        private TextBox txtCategoria;
        private Label lblCategoria;
        private TextBox txtProveedor;
        private Label lblProveedor;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private Button button3editarproductos;
    }
}