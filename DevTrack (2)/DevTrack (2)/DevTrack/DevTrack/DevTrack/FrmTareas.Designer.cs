namespace DevTrack
{
    partial class FrmTareas
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
            
            lblTitulo = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblNombre = new Label();
            lblProyecto = new Label();
            cmbProyecto = new ComboBox();
            lblResponsable = new Label();
            cmbResponsable = new ComboBox();
            lblFecha = new Label();
            dtpFechaEntrega = new DateTimePicker();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            txtNombre = new TextBox();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnVolver = new Button();
            dgvTareas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            SuspendLayout();
            // 
            // dgvTareas
            // 
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(31, 409);
            dgvTareas.MultiSelect = false;
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.RowHeadersWidth = 51;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.Size = new Size(563, 150);
            dgvTareas.TabIndex = 18;
            dgvTareas.CellContentClick += dgvTareas_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(244, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(244, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "\tADMINISTRACIÓN DE TAREAS";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(21, 168);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(233, 29);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.TextChanged += textBox1_TextChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(93, 138);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(102, 23);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(69, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(163, 23);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre de la tarea:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Location = new Point(93, 208);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(78, 23);
            lblProyecto.TabIndex = 5;
            lblProyecto.Text = "Proyecto";
            // 
            // cmbProyecto
            // 
            cmbProyecto.FormattingEnabled = true;
            cmbProyecto.Location = new Point(43, 238);
            cmbProyecto.Name = "cmbProyecto";
            cmbProyecto.Size = new Size(175, 29);
            cmbProyecto.TabIndex = 6;
            cmbProyecto.SelectedIndexChanged += cmbProyecto_SelectedIndexChanged;
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.Location = new Point(589, 78);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(110, 23);
            lblResponsable.TabIndex = 7;
            lblResponsable.Text = "Responsable:";
            lblResponsable.Click += lblResponsable_Click;
            // 
            // cmbResponsable
            // 
            cmbResponsable.FormattingEnabled = true;
            cmbResponsable.Location = new Point(533, 113);
            cmbResponsable.Name = "cmbResponsable";
            cmbResponsable.Size = new Size(175, 29);
            cmbResponsable.TabIndex = 8;
            cmbResponsable.SelectedIndexChanged += cmbResponsable_SelectedIndexChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(57, 287);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(147, 23);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "Fecha de entrega:";
            lblFecha.Click += lblFecha_Click;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(31, 320);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(200, 29);
            dtpFechaEntrega.TabIndex = 10;
            dtpFechaEntrega.ValueChanged += dtpFechaEntrega_ValueChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(381, 78);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(65, 23);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado:";
            lblEstado.Click += lblEstado_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(314, 113);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(175, 29);
            cmbEstado.TabIndex = 12;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(326, 225);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 38);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(518, 225);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 38);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(326, 287);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 38);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(518, 287);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 38);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(381, 347);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(211, 38);
            btnMostrar.TabIndex = 17;
            btnMostrar.Text = "Mostrar tareas";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(21, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 29);
            txtNombre.TabIndex = 19;
            txtNombre.TextChanged += txtNombre_TextChanged_1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(326, 171);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(65, 23);
            lblBuscar.TabIndex = 20;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(381, 168);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(233, 29);
            txtBuscar.TabIndex = 21;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(222, 582);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(211, 38);
            btnVolver.TabIndex = 22;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmTareas
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(720, 653);
            Controls.Add(btnVolver);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(txtNombre);
            Controls.Add(dgvTareas);
            Controls.Add(btnMostrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(lblFecha);
            Controls.Add(cmbResponsable);
            Controls.Add(lblResponsable);
            Controls.Add(cmbProyecto);
            Controls.Add(lblProyecto);
            Controls.Add(lblNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmTareas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTareas";
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {
           
        }

        private void dtpFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lblResponsable_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private Label lblNombre;
        private Label lblProyecto;
        private ComboBox cmbProyecto;
        private Label lblTitulo;
        private TextBox txtDescripcion;
        private Label lblResponsable;
        private ComboBox cmbResponsable;
        private Label lblFecha;
        private DateTimePicker dtpFechaEntrega;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnEditar;
        private Button button1;
        private Button button2;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnMostrar;
        private DataGridView dgvTareas;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnVolver;
    }
}