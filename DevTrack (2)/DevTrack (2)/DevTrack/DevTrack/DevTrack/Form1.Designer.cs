namespace DevTrack
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
            btnProyectos = new Button();
            btnTareas = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 35);
            label1.TabIndex = 0;
            label1.Text = "DevTrack";
            // 
            // btnProyectos
            // 
            btnProyectos.BackColor = SystemColors.ControlLightLight;
            btnProyectos.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyectos.Location = new Point(318, 100);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(163, 48);
            btnProyectos.TabIndex = 1;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = false;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // btnTareas
            // 
            btnTareas.BackColor = SystemColors.ControlLightLight;
            btnTareas.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTareas.Location = new Point(318, 185);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(163, 48);
            btnTareas.TabIndex = 2;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = false;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLightLight;
            btnSalir.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(318, 287);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(163, 48);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 444);
            Controls.Add(btnSalir);
            Controls.Add(btnTareas);
            Controls.Add(btnProyectos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProyectos;
        private Button btnTareas;
        private Button btnSalir;
    }
}
