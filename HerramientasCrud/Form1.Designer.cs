    namespace HerramientasCrud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtMarca = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtResultado = new TextBox();
            numericUpDownID = new NumericUpDown();
            guardar = new Button();
            nombre = new Button();
            cortar = new Button();
            label6 = new Label();
            label7 = new Label();
            editar = new Button();
            borrar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre:\r\n";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(161, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 89);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(161, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 3;
            label2.Text = "Descripción:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 139);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(161, 23);
            txtMarca.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 5;
            label3.Text = "Marca:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 192);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(161, 23);
            txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 7;
            label4.Text = "Precio:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(12, 245);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(161, 23);
            txtStock.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 9;
            label5.Text = "Stock:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(66, 407);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(149, 23);
            txtResultado.TabIndex = 12;
            // 
            // numericUpDownID
            // 
            numericUpDownID.Location = new Point(13, 407);
            numericUpDownID.Name = "numericUpDownID";
            numericUpDownID.Size = new Size(47, 23);
            numericUpDownID.TabIndex = 13;
            // 
            // guardar
            // 
            guardar.Location = new Point(66, 274);
            guardar.Name = "guardar";
            guardar.Size = new Size(100, 32);
            guardar.TabIndex = 14;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = true;
            guardar.Click += guardar_Click;
            // 
            // nombre
            // 
            nombre.Location = new Point(13, 436);
            nombre.Name = "nombre";
            nombre.Size = new Size(98, 32);
            nombre.TabIndex = 15;
            nombre.Text = "Nombre";
            nombre.UseVisualStyleBackColor = true;
            nombre.Click += nombre_Click;
            // 
            // cortar
            // 
            cortar.Location = new Point(117, 436);
            cortar.Name = "cortar";
            cortar.Size = new Size(98, 32);
            cortar.TabIndex = 16;
            cortar.Text = "Cortar";
            cortar.UseVisualStyleBackColor = true;
            cortar.Click += cortar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 383);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 17;
            label6.Text = "Resultado:\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 383);
            label7.Name = "label7";
            label7.Size = new Size(31, 21);
            label7.TabIndex = 18;
            label7.Text = "ID:\r\n";
            // 
            // editar
            // 
            editar.Location = new Point(9, 312);
            editar.Name = "editar";
            editar.Size = new Size(98, 32);
            editar.TabIndex = 20;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            editar.Click += editar_Click;
            // 
            // borrar
            // 
            borrar.Location = new Point(126, 312);
            borrar.Name = "borrar";
            borrar.Size = new Size(98, 32);
            borrar.TabIndex = 21;
            borrar.Text = "Borrar";
            borrar.UseVisualStyleBackColor = true;
            borrar.Click += borrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(222, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(740, 294);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 490);
            Controls.Add(dataGridView1);
            Controls.Add(borrar);
            Controls.Add(editar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cortar);
            Controls.Add(nombre);
            Controls.Add(guardar);
            Controls.Add(numericUpDownID);
            Controls.Add(txtResultado);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtResultado;
        private NumericUpDown numericUpDownID;
        private Button guardar;
        private Button nombre;
        private Button cortar;
        private Label label6;
        private Label label7;
        private Button editar;
        private Button borrar;
        private DataGridView dataGridView1;
    }
}
