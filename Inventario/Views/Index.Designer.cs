namespace Inventario.Views
{
    partial class Index
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
            button1catergorias = new Button();
            button3proveedores = new Button();
            button4Salir = new Button();
            button5reportes = new Button();
            label1 = new Label();
            label2 = new Label();
            button2Producctos = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1catergorias
            // 
            button1catergorias.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1catergorias.Location = new Point(66, 200);
            button1catergorias.Margin = new Padding(4, 3, 4, 3);
            button1catergorias.Name = "button1catergorias";
            button1catergorias.Size = new Size(163, 55);
            button1catergorias.TabIndex = 5;
            button1catergorias.Text = "Categorías";
            button1catergorias.UseVisualStyleBackColor = true;
            button1catergorias.Click += button1catergorias_Click;
            // 
            // button3proveedores
            // 
            button3proveedores.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3proveedores.Location = new Point(625, 200);
            button3proveedores.Margin = new Padding(4, 3, 4, 3);
            button3proveedores.Name = "button3proveedores";
            button3proveedores.Size = new Size(163, 55);
            button3proveedores.TabIndex = 7;
            button3proveedores.Text = "Proveedores";
            button3proveedores.UseVisualStyleBackColor = true;
            button3proveedores.Click += button3proveedores_Click;
            // 
            // button4Salir
            // 
            button4Salir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4Salir.Location = new Point(832, 479);
            button4Salir.Margin = new Padding(4, 3, 4, 3);
            button4Salir.Name = "button4Salir";
            button4Salir.Size = new Size(88, 27);
            button4Salir.TabIndex = 8;
            button4Salir.Text = "Salir";
            button4Salir.UseVisualStyleBackColor = true;
            button4Salir.Click += button4Salir_Click;
            // 
            // button5reportes
            // 
            button5reportes.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5reportes.Location = new Point(366, 349);
            button5reportes.Margin = new Padding(4, 3, 4, 3);
            button5reportes.Name = "button5reportes";
            button5reportes.Size = new Size(163, 55);
            button5reportes.TabIndex = 9;
            button5reportes.Text = "Reportes";
            button5reportes.UseVisualStyleBackColor = true;
            button5reportes.Click += button5reportes_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(905, 42);
            label1.TabIndex = 10;
            label1.Text = "MENÚ PRINCIPAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Window;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(157, 98);
            label2.Name = "label2";
            label2.Size = new Size(600, 43);
            label2.TabIndex = 11;
            label2.Text = "Seleccione una de las opciones para entrar al modulo que desea visitar.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button2Producctos
            // 
            button2Producctos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2Producctos.Location = new Point(366, 202);
            button2Producctos.Name = "button2Producctos";
            button2Producctos.Size = new Size(163, 55);
            button2Producctos.TabIndex = 12;
            button2Producctos.Text = "Productos";
            button2Producctos.UseVisualStyleBackColor = true;
            button2Producctos.Click += button2Producctos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 407);
            label3.Name = "label3";
            label3.Size = new Size(218, 15);
            label3.TabIndex = 13;
            label3.Text = "Reportes aun no esta implementado tba";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 258);
            label4.Name = "label4";
            label4.Size = new Size(115, 17);
            label4.TabIndex = 14;
            label4.Text = "Lleva a Categorías";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(396, 260);
            label5.Name = "label5";
            label5.Size = new Size(111, 17);
            label5.TabIndex = 15;
            label5.Text = "Lleva a Productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(648, 258);
            label6.Name = "label6";
            label6.Size = new Size(127, 17);
            label6.TabIndex = 16;
            label6.Text = "Lleva a proveedores";
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2Producctos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5reportes);
            Controls.Add(button4Salir);
            Controls.Add(button3proveedores);
            Controls.Add(button1catergorias);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Index";
            Text = "Menu Principal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1catergorias;
        private System.Windows.Forms.Button button3proveedores;
        private System.Windows.Forms.Button button4Salir;
        private System.Windows.Forms.Button button5reportes;
        private Label label1;
        private Label label2;
        private Button button2Producctos;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}