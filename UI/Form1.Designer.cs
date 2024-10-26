namespace UI
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
            dvgPeliculas = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtDuracion = new TextBox();
            btnDarDeAlta = new Button();
            dtpFechaAlta = new DateTimePicker();
            nudCalificacion = new NumericUpDown();
            cmbCategoria = new ComboBox();
            txtTitulo = new TextBox();
            txtDescripcion = new TextBox();
            label7 = new Label();
            txtAnioLanzamiento = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtIdEliminar = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            btnModificar = new Button();
            nudNuevaCalificacion = new NumericUpDown();
            label10 = new Label();
            txtIdModificar = new TextBox();
            label9 = new Label();
            btnTransaction = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgPeliculas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCalificacion).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNuevaCalificacion).BeginInit();
            SuspendLayout();
            // 
            // dvgPeliculas
            // 
            dvgPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPeliculas.Location = new Point(385, 23);
            dvgPeliculas.Name = "dvgPeliculas";
            dvgPeliculas.Size = new Size(643, 395);
            dvgPeliculas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 29);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Titulo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTransaction);
            groupBox1.Controls.Add(txtDuracion);
            groupBox1.Controls.Add(btnDarDeAlta);
            groupBox1.Controls.Add(dtpFechaAlta);
            groupBox1.Controls.Add(nudCalificacion);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtAnioLanzamiento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 395);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva Pelicula";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(131, 206);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(215, 23);
            txtDuracion.TabIndex = 14;
            // 
            // btnDarDeAlta
            // 
            btnDarDeAlta.Location = new Point(12, 332);
            btnDarDeAlta.Name = "btnDarDeAlta";
            btnDarDeAlta.Size = new Size(127, 46);
            btnDarDeAlta.TabIndex = 13;
            btnDarDeAlta.Text = "Dar de alta";
            btnDarDeAlta.UseVisualStyleBackColor = true;
            btnDarDeAlta.Click += btnDarDeAlta_Click;
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Location = new Point(131, 293);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(215, 23);
            dtpFechaAlta.TabIndex = 3;
            // 
            // nudCalificacion
            // 
            nudCalificacion.Location = new Point(131, 252);
            nudCalificacion.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudCalificacion.Name = "nudCalificacion";
            nudCalificacion.Size = new Size(215, 23);
            nudCalificacion.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(131, 71);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(215, 23);
            cmbCategoria.TabIndex = 11;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(134, 26);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(215, 23);
            txtTitulo.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(131, 116);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(215, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 299);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 8;
            label7.Text = "Fecha de alta:";
            // 
            // txtAnioLanzamiento
            // 
            txtAnioLanzamiento.Location = new Point(131, 161);
            txtAnioLanzamiento.Name = "txtAnioLanzamiento";
            txtAnioLanzamiento.Size = new Size(215, 23);
            txtAnioLanzamiento.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 254);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 6;
            label6.Text = "Calificacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 209);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 5;
            label5.Text = "Duracion (en horas):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 164);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 4;
            label4.Text = "Anio de lanzamiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 119);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Categoria:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(txtIdEliminar);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(18, 435);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 164);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar Pelicula";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(137, 91);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(161, 46);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(105, 35);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(235, 23);
            txtIdEliminar.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 38);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 0;
            label8.Text = "ID de la pelicula:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnModificar);
            groupBox3.Controls.Add(nudNuevaCalificacion);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtIdModificar);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(406, 435);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 164);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Modificar Calificacion";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(121, 131);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(183, 27);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // nudNuevaCalificacion
            // 
            nudNuevaCalificacion.Location = new Point(121, 89);
            nudNuevaCalificacion.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNuevaCalificacion.Name = "nudNuevaCalificacion";
            nudNuevaCalificacion.Size = new Size(183, 23);
            nudNuevaCalificacion.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 91);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 2;
            label10.Text = "Nueva Calificacion:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(121, 35);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(183, 23);
            txtIdModificar.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 38);
            label9.Name = "label9";
            label9.Size = new Size(93, 15);
            label9.TabIndex = 0;
            label9.Text = "ID de la pelicula:";
            // 
            // btnTransaction
            // 
            btnTransaction.Location = new Point(177, 332);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(127, 46);
            btnTransaction.TabIndex = 15;
            btnTransaction.Text = "Ejecutar Transacción";
            btnTransaction.UseVisualStyleBackColor = true;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 611);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dvgPeliculas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgPeliculas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCalificacion).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNuevaCalificacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgPeliculas;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtAnioLanzamiento;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDarDeAlta;
        private DateTimePicker dtpFechaAlta;
        private NumericUpDown nudCalificacion;
        private ComboBox cmbCategoria;
        private TextBox txtTitulo;
        private TextBox txtDescripcion;
        private Label label7;
        private TextBox txtDuracion;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private TextBox txtIdEliminar;
        private Label label8;
        private GroupBox groupBox3;
        private NumericUpDown nudNuevaCalificacion;
        private Label label10;
        private TextBox txtIdModificar;
        private Label label9;
        private Button btnModificar;
        private Button btnTransaction;
    }
}
