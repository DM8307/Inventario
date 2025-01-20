namespace Inventario.Views
{
    partial class Reportes
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
            dataGridViewReportes = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaBindingSource = new BindingSource(components);
            comboBoxCategorias = new ComboBox();
            comboBoxProveedores = new ComboBox();
            lblCategorias = new Label();
            lblProveedores = new Label();
            button4Volver_a_inicio = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReportes
            // 
            dataGridViewReportes.AutoGenerateColumns = false;
            dataGridViewReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReportes.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, productosDataGridViewTextBoxColumn });
            dataGridViewReportes.DataSource = categoriaBindingSource;
            dataGridViewReportes.Location = new Point(129, 94);
            dataGridViewReportes.Name = "dataGridViewReportes";
            dataGridViewReportes.Size = new Size(522, 150);
            dataGridViewReportes.TabIndex = 0;
            dataGridViewReportes.CellContentClick += dataGridViewReportes_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
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
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Models.Categoria);
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(129, 65);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(121, 23);
            comboBoxCategorias.TabIndex = 1;
            // 
            // comboBoxProveedores
            // 
            comboBoxProveedores.FormattingEnabled = true;
            comboBoxProveedores.Location = new Point(530, 65);
            comboBoxProveedores.Name = "comboBoxProveedores";
            comboBoxProveedores.Size = new Size(121, 23);
            comboBoxProveedores.TabIndex = 2;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(151, 47);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(63, 15);
            lblCategorias.TabIndex = 3;
            lblCategorias.Text = "Categorias";
            // 
            // lblProveedores
            // 
            lblProveedores.AutoSize = true;
            lblProveedores.Location = new Point(559, 47);
            lblProveedores.Name = "lblProveedores";
            lblProveedores.Size = new Size(72, 15);
            lblProveedores.TabIndex = 4;
            lblProveedores.Text = "Proveedores";
            // 
            // button4Volver_a_inicio
            // 
            button4Volver_a_inicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4Volver_a_inicio.Location = new Point(630, 402);
            button4Volver_a_inicio.Name = "button4Volver_a_inicio";
            button4Volver_a_inicio.Size = new Size(158, 36);
            button4Volver_a_inicio.TabIndex = 5;
            button4Volver_a_inicio.Text = "Volver a inicio";
            button4Volver_a_inicio.UseVisualStyleBackColor = true;
            button4Volver_a_inicio.Click += button4Volver_a_inicio_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4Volver_a_inicio);
            Controls.Add(lblProveedores);
            Controls.Add(lblCategorias);
            Controls.Add(comboBoxProveedores);
            Controls.Add(comboBoxCategorias);
            Controls.Add(dataGridViewReportes);
            Name = "Reportes";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReportes;
        private ComboBox comboBoxCategorias;
        private ComboBox comboBoxProveedores;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productosDataGridViewTextBoxColumn;
        private BindingSource categoriaBindingSource;
        private Label lblCategorias;
        private Label lblProveedores;
        private Button button4Volver_a_inicio;
    }
}