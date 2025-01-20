namespace Inventario.Views
{
    partial class Proveedores
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
            label1 = new Label();
            button4Volver_a_inicio = new Button();
            button3editarproductos = new Button();
            button2eliminarproductos = new Button();
            button1agregarproductos = new Button();
            dataGridView2 = new DataGridView();
            nombreEmpresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proveedorBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(190, 40);
            label1.TabIndex = 10;
            label1.Text = "Proveedores";
            // 
            // button4Volver_a_inicio
            // 
            button4Volver_a_inicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4Volver_a_inicio.Location = new Point(629, 408);
            button4Volver_a_inicio.Name = "button4Volver_a_inicio";
            button4Volver_a_inicio.Size = new Size(158, 36);
            button4Volver_a_inicio.TabIndex = 9;
            button4Volver_a_inicio.Text = "Volver a inicio";
            button4Volver_a_inicio.UseVisualStyleBackColor = true;
            button4Volver_a_inicio.Click += button4Volver_a_inicio_Click;
            // 
            // button3editarproductos
            // 
            button3editarproductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3editarproductos.Location = new Point(388, 374);
            button3editarproductos.Name = "button3editarproductos";
            button3editarproductos.Size = new Size(158, 70);
            button3editarproductos.TabIndex = 8;
            button3editarproductos.Text = "Editar";
            button3editarproductos.UseVisualStyleBackColor = true;
            button3editarproductos.Click += button3editarproductos_Click;
            // 
            // button2eliminarproductos
            // 
            button2eliminarproductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2eliminarproductos.Location = new Point(205, 374);
            button2eliminarproductos.Name = "button2eliminarproductos";
            button2eliminarproductos.Size = new Size(158, 70);
            button2eliminarproductos.TabIndex = 7;
            button2eliminarproductos.Text = "Eliminar";
            button2eliminarproductos.UseVisualStyleBackColor = true;
            button2eliminarproductos.Click += button2eliminarproductos_Click;
            // 
            // button1agregarproductos
            // 
            button1agregarproductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1agregarproductos.Location = new Point(14, 374);
            button1agregarproductos.Name = "button1agregarproductos";
            button1agregarproductos.Size = new Size(158, 70);
            button1agregarproductos.TabIndex = 6;
            button1agregarproductos.Text = "Agregar";
            button1agregarproductos.UseVisualStyleBackColor = true;
            button1agregarproductos.Click += button1agregarproductos_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nombreEmpresaDataGridViewTextBoxColumn, contactoDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, productosDataGridViewTextBoxColumn });
            dataGridView2.DataSource = proveedorBindingSource;
            dataGridView2.Location = new Point(14, 99);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(543, 269);
            dataGridView2.TabIndex = 11;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // nombreEmpresaDataGridViewTextBoxColumn
            // 
            nombreEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpresa";
            nombreEmpresaDataGridViewTextBoxColumn.HeaderText = "NombreEmpresa";
            nombreEmpresaDataGridViewTextBoxColumn.Name = "nombreEmpresaDataGridViewTextBoxColumn";
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // productosDataGridViewTextBoxColumn
            // 
            productosDataGridViewTextBoxColumn.DataPropertyName = "Productos";
            productosDataGridViewTextBoxColumn.HeaderText = "Productos";
            productosDataGridViewTextBoxColumn.Name = "productosDataGridViewTextBoxColumn";
            // 
            // proveedorBindingSource
            // 
            proveedorBindingSource.DataSource = typeof(Models.Proveedor);
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 456);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(button4Volver_a_inicio);
            Controls.Add(button3editarproductos);
            Controls.Add(button2eliminarproductos);
            Controls.Add(button1agregarproductos);
            Name = "Proveedores";
            Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4Volver_a_inicio;
        private Button button3editarproductos;
        private Button button2eliminarproductos;
        private Button button1agregarproductos;
        private DataGridView dataGridView2;
        private BindingSource proveedorBindingSource;
        private DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productosDataGridViewTextBoxColumn;
    }
}