namespace DevTrack
{
    partial class Registro_proyectos
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            lblInicio = new Label();
            lblFinal = new Label();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFinal = new DateTimePicker();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(360, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(248, 35);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Registrar proyecto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(69, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(275, 34);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre del proyecto:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(69, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(782, 30);
            txtNombre.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 173);
            label1.Name = "label1";
            label1.Size = new Size(164, 34);
            label1.TabIndex = 5;
            label1.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(69, 225);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(772, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.BackColor = Color.Transparent;
            lblInicio.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInicio.Location = new Point(69, 275);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(202, 34);
            lblInicio.TabIndex = 7;
            lblInicio.Text = "Fecha de inicio:";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.BackColor = Color.Transparent;
            lblFinal.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinal.Location = new Point(69, 381);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(273, 34);
            lblFinal.TabIndex = 8;
            lblFinal.Text = "Fecha de finalizacion:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(69, 326);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(312, 27);
            dtpFechaInicio.TabIndex = 9;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(69, 418);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(312, 27);
            dtpFechaFinal.TabIndex = 10;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(71, 490);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(249, 34);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado del proyecto";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "En desarrollo", "En revision ", "Finalizacion" });
            cmbEstado.Location = new Point(71, 547);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(296, 28);
            cmbEstado.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(240, 646);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(163, 48);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(513, 646);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(163, 48);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Registro_proyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(970, 745);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(dtpFechaFinal);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblFinal);
            Controls.Add(lblInicio);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "Registro_proyectos";
            Text = "Registro_proyectos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtDescripcion;
        private Label lblInicio;
        private Label lblFinal;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFinal;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}