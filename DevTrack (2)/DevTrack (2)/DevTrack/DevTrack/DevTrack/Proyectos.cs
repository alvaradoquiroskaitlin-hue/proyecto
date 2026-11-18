using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevTrack
{
    public partial class Proyectos : Form
    {
        private List<Proyecto> proyectos = new List<Proyecto>();

        public Proyectos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();

            Registro_proyectos registro = new Registro_proyectos();

            registro.Proyectos = proyectos;

            registro.TopLevel = false;

            registro.FormBorderStyle = FormBorderStyle.None;

            registro.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(registro);
            registro.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();

            Consulta_Proyectos consulta = new Consulta_Proyectos();

            consulta.Proyectos = proyectos;

            consulta.TopLevel = false;

            consulta.FormBorderStyle = FormBorderStyle.None;

            consulta.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(consulta);
            consulta.Show();

            consulta.MostrarProyectos();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();

            pnlContenido.Controls.Add(pnlInicio);
            pnlInicio.Visible = true;
        }
    }
    public class Proyecto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Estado { get; set; }
    }
}
