using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevTrack
{
    public partial class Registro_proyectos : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Proyecto> Proyectos {  get; set; }
        public Registro_proyectos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del proyecto");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar la descripcion del proyecto");
                txtDescripcion.Focus();
                return;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado");
                cmbEstado.Focus();
                return;
            }

            if (dtpFechaFinal.Value < dtpFechaInicio.Value) 
            {
                MessageBox.Show("La fecha final no puede ser anterior a la fecha de inicio");
                return;
            }
            Proyecto nuevo = new Proyecto();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.FechaInicio = dtpFechaInicio.Value;
            nuevo.FechaFinal = dtpFechaFinal.Value;
            nuevo.Estado = cmbEstado.Text;

            Proyectos.Add(nuevo);

            MessageBox.Show("Proyecto registrado correctamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();

            cmbEstado.SelectedIndex = -1;

            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;
        }
    }
}
