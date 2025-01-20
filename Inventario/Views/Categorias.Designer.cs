namespace Inventario.Views
{
    partial class Categorias
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
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            button4 = new Button();
            dtgvCategorias = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaBindingSource1 = new BindingSource(components);
            categoriaBindingSource = new BindingSource(components);
            label1 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblNombre = new Label();
            txtProductos = new TextBox();
            lblProductos = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(51, 378);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 60);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(209, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 60);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button2_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(367, 378);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(152, 60);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(636, 378);
            button4.Name = "button4";
            button4.Size = new Size(152, 60);
            button4.TabIndex = 3;
            button4.Text = "Volver a inicio";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dtgvCategorias
            // 
            dtgvCategorias.AutoGenerateColumns = false;
            dtgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategorias.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, productosDataGridViewTextBoxColumn });
            dtgvCategorias.DataSource = categoriaBindingSource1;
            dtgvCategorias.Location = new Point(126, 75);
            dtgvCategorias.Name = "dtgvCategorias";
            dtgvCategorias.Size = new Size(343, 297);
            dtgvCategorias.TabIndex = 4;
            dtgvCategorias.CellContentClick += dtgvCategorias_CellContentClick;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // productosDataGridViewTextBoxColumn
            // 
            productosDataGridViewTextBoxColumn.DataPropertyName = "Productos";
            productosDataGridViewTextBoxColumn.HeaderText = "Productos";
            productosDataGridViewTextBoxColumn.Name = "productosDataGridViewTextBoxColumn";
            // 
            // categoriaBindingSource1
            // 
            categoriaBindingSource1.DataSource = typeof(Models.Categoria);
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Models.Categoria);
            categoriaBindingSource.CurrentChanged += categoriaBindingSource_CurrentChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, -5);
            label1.Name = "label1";
            label1.Size = new Size(268, 65);
            label1.TabIndex = 5;
            label1.Text = "Categorias";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(613, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 9;
            txtNombre.TextChanged += textBox2_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(613, 124);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(175, 23);
            txtDescripcion.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(538, 127);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(556, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre";
            // 
            // txtProductos
            // 
            txtProductos.Location = new Point(613, 176);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(175, 23);
            txtProductos.TabIndex = 16;
            txtProductos.TextChanged += textBox1_TextChanged;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(538, 179);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(61, 15);
            lblProductos.TabIndex = 15;
            lblProductos.Text = "Productos";
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProductos);
            Controls.Add(lblProductos);
            Controls.Add(lblNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dtgvCategorias);
            Controls.Add(button4);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Name = "Categorias";
            Text = ".";
            Load += Categorias_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button button4;
        private DataGridView dtgvCategorias;
        private BindingSource categoriaBindingSource;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productosDataGridViewTextBoxColumn;
        private Label lblNombre;
        private TextBox txtProductos;
        private Label lblProductos;
        private BindingSource categoriaBindingSource1;
    }
}