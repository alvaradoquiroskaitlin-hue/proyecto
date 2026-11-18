namespace DevTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            Proyectos pro = new Proyectos();
            pro.Owner = this;
            pro.Show();
            this.Hide();
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            FrmTareas tar = new FrmTareas();
            tar.Owner = this;
            tar.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "Estas seguro de salir?",
                "Cerrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
