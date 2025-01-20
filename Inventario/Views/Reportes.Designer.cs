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
            comboBoxCategorias = new ComboBox();
            comboBoxProveedores = new ComboBox();
            categoriaBindingSource = new BindingSource(components);
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Models.Categoria);
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
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxProveedores);
            Controls.Add(comboBoxCategorias);
            Controls.Add(dataGridViewReportes);
            Name = "Reportes";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
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
    }
}