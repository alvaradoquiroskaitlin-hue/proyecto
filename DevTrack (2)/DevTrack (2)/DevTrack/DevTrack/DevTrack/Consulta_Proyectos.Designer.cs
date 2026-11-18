namespace DevTrack
{
    partial class Consulta_Proyectos
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
            lblProyecto = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            lblOrdenar = new Label();
            cmbOrdenar = new ComboBox();
            btnOrdenar = new Button();
            lblLista = new Label();
            dvgProyectos = new DataGridView();
            btnEditar = new Button();
            btnGuardarCambios = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblInicio = new Label();
            dtpFechaInicioEditar = new DateTimePicker();
            lblFinal = new Label();
            dtpFechaFinalEditar = new DateTimePicker();
            lblEstado = new Label();
            cmbEstadoEditar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dvgProyectos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(330, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(295, 35);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Proyectos Registrados";
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.BackColor = Color.Transparent;
            lblProyecto.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProyecto.Location = new Point(12, 90);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(210, 34);
            lblProyecto.TabIndex = 4;
            lblProyecto.Text = "Buscar Proyecto";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(228, 90);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(178, 30);
            txtBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(435, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(163, 48);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblOrdenar
            // 
            lblOrdenar.AutoSize = true;
            lblOrdenar.BackColor = Color.Transparent;
            lblOrdenar.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrdenar.Location = new Point(12, 134);
            lblOrdenar.Name = "lblOrdenar";
            lblOrdenar.Size = new Size(161, 34);
            lblOrdenar.TabIndex = 15;
            lblOrdenar.Text = "Ordenar por";
            // 
            // cmbOrdenar
            // 
            cmbOrdenar.FormattingEnabled = true;
            cmbOrdenar.Items.AddRange(new object[] { "Nombre", "Fecha" });
            cmbOrdenar.Location = new Point(179, 142);
            cmbOrdenar.Name = "cmbOrdenar";
            cmbOrdenar.Size = new Size(227, 28);
            cmbOrdenar.TabIndex = 16;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.Black;
            btnOrdenar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.ForeColor = SystemColors.ButtonHighlight;
            btnOrdenar.Location = new Point(435, 142);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(163, 48);
            btnOrdenar.TabIndex = 17;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.BackColor = Color.Transparent;
            lblLista.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLista.Location = new Point(21, 204);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(230, 34);
            lblLista.TabIndex = 18;
            lblLista.Text = "Lista de proyectos";
            // 
            // dvgProyectos
            // 
            dvgProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProyectos.Location = new Point(21, 241);
            dvgProyectos.Name = "dvgProyectos";
            dvgProyectos.RowHeadersWidth = 51;
            dvgProyectos.Size = new Size(548, 244);
            dvgProyectos.TabIndex = 19;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(376, 795);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(163, 58);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.Black;
            btnGuardarCambios.Enabled = false;
            btnGuardarCambios.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarCambios.Location = new Point(772, 795);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(163, 58);
            btnGuardarCambios.TabIndex = 21;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(572, 795);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(163, 58);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar Cambios";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(130, 515);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 30);
            txtNombre.TabIndex = 23;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(3, 511);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 34);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(3, 591);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(164, 34);
            lblDescripcion.TabIndex = 25;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(12, 644);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(354, 30);
            txtDescripcion.TabIndex = 26;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.BackColor = Color.Transparent;
            lblInicio.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInicio.Location = new Point(423, 511);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(202, 34);
            lblInicio.TabIndex = 27;
            lblInicio.Text = "Fecha de inicio:";
            // 
            // dtpFechaInicioEditar
            // 
            dtpFechaInicioEditar.Location = new Point(631, 517);
            dtpFechaInicioEditar.Name = "dtpFechaInicioEditar";
            dtpFechaInicioEditar.Size = new Size(312, 27);
            dtpFechaInicioEditar.TabIndex = 28;
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.BackColor = Color.Transparent;
            lblFinal.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinal.Location = new Point(435, 578);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(190, 34);
            lblFinal.TabIndex = 29;
            lblFinal.Text = "Fecha de final:";
            // 
            // dtpFechaFinalEditar
            // 
            dtpFechaFinalEditar.Location = new Point(631, 585);
            dtpFechaFinalEditar.Name = "dtpFechaFinalEditar";
            dtpFechaFinalEditar.Size = new Size(312, 27);
            dtpFechaFinalEditar.TabIndex = 30;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(423, 644);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(103, 34);
            lblEstado.TabIndex = 31;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstadoEditar
            // 
            cmbEstadoEditar.FormattingEnabled = true;
            cmbEstadoEditar.Location = new Point(532, 647);
            cmbEstadoEditar.Name = "cmbEstadoEditar";
            cmbEstadoEditar.Size = new Size(375, 28);
            cmbEstadoEditar.TabIndex = 32;
            // 
            // Consulta_Proyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(947, 874);
            Controls.Add(cmbEstadoEditar);
            Controls.Add(lblEstado);
            Controls.Add(dtpFechaFinalEditar);
            Controls.Add(lblFinal);
            Controls.Add(dtpFechaInicioEditar);
            Controls.Add(lblInicio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnEditar);
            Controls.Add(dvgProyectos);
            Controls.Add(lblLista);
            Controls.Add(btnOrdenar);
            Controls.Add(cmbOrdenar);
            Controls.Add(lblOrdenar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblProyecto);
            Controls.Add(lblTitulo);
            Name = "Consulta_Proyectos";
            Text = "Consulta_Proyectos";
            ((System.ComponentModel.ISupportInitialize)dvgProyectos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblProyecto;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label lblOrdenar;
        private ComboBox cmbOrdenar;
        private Button btnOrdenar;
        private Label lblLista;
        private DataGridView dvgProyectos;
        private Button btnEditar;
        private Button btnGuardarCambios;
        private Button btnCancelar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblInicio;
        private DateTimePicker dtpFechaInicioEditar;
        private Label lblFinal;
        private DateTimePicker dtpFechaFinalEditar;
        private Label lblEstado;
        private ComboBox cmbEstadoEditar;
    }
}