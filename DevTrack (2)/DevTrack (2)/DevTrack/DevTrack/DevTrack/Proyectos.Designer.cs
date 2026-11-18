namespace DevTrack
{
    partial class Proyectos
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
            pnlMenu = new Panel();
            btnVolver = new Button();
            btnProyectos = new Button();
            btnRegistrar = new Button();
            btnInicio = new Button();
            label1 = new Label();
            pnlContenido = new Panel();
            label3 = new Label();
            label2 = new Label();
            pnlInicio = new Panel();
            pnlMenu.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlInicio.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnVolver);
            pnlMenu.Controls.Add(btnProyectos);
            pnlMenu.Controls.Add(btnRegistrar);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 717);
            pnlMenu.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Black;
            btnVolver.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(44, 424);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(163, 98);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver al menu principal";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.BackColor = Color.Black;
            btnProyectos.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyectos.ForeColor = SystemColors.ButtonHighlight;
            btnProyectos.Location = new Point(44, 315);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(163, 65);
            btnProyectos.TabIndex = 4;
            btnProyectos.Text = "Proyectos Registrados";
            btnProyectos.UseVisualStyleBackColor = false;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Black;
            btnRegistrar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(42, 206);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(163, 62);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar Proyecto";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Black;
            btnInicio.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = SystemColors.ButtonHighlight;
            btnInicio.Location = new Point(42, 119);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(163, 48);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 23);
            label1.Name = "label1";
            label1.Size = new Size(136, 35);
            label1.TabIndex = 1;
            label1.Text = "DevTrack";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.DarkGray;
            pnlContenido.Controls.Add(pnlInicio);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(250, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(723, 717);
            pnlContenido.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(114, 173);
            label3.Name = "label3";
            label3.Size = new Size(524, 140);
            label3.TabIndex = 7;
            label3.Text = "Bienvenido a DevTrack, el sistema de \r\nparte del proyecto permitiendo registrar,\r\n organizar y administrar proyectos\r\n de desarrollo de software\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(228, 23);
            label2.Name = "label2";
            label2.Size = new Size(286, 35);
            label2.TabIndex = 6;
            label2.Text = "Gestion de proyectos ";
            // 
            // pnlInicio
            // 
            pnlInicio.Controls.Add(label3);
            pnlInicio.Controls.Add(label2);
            pnlInicio.Dock = DockStyle.Fill;
            pnlInicio.Location = new Point(0, 0);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(723, 717);
            pnlInicio.TabIndex = 8;
            // 
            // Proyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 717);
            Controls.Add(pnlContenido);
            Controls.Add(pnlMenu);
            Name = "Proyectos";
            Text = "Proyectos";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlInicio.ResumeLayout(false);
            pnlInicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlContenido;
        private Label label1;
        private Button btnInicio;
        private Button btnVolver;
        private Button btnProyectos;
        private Button btnRegistrar;
        private Label label3;
        private Label label2;
        private Panel pnlInicio;
    }
}