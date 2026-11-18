using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Windows.Forms;

namespace DevTrack
{
    public partial class Consulta_Proyectos : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Proyecto> Proyectos { get; set; }
        private Proyecto proyectoSeleccionado;
        public Consulta_Proyectos()
        {
            InitializeComponent();
        }

        private void CargarProyectos()
        {
            dvgProyectos.DataSource = null;
            dvgProyectos.DataSource = Proyectos;
        }

        public void MostrarProyectos()
        {
            CargarProyectos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();

            if (nombre == "")
            {
                CargarProyectos();
            }
            else
            {
                var resultado = Proyectos.FindAll(p => p.Nombre.ToLower().Contains(nombre.ToLower()));

                dvgProyectos.DataSource = null;
                dvgProyectos.DataSource = resultado;
            }


        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (cmbOrdenar.Text == "Nombre")
            {
                Proyectos.Sort((p1, p2) =>
                p1.Nombre.CompareTo(p2.Nombre));

            }
            else if (cmbOrdenar.Text == "Fecha")
            {
                Proyectos.Sort((p1, p2) =>
                p1.FechaInicio.CompareTo(p2.FechaInicio));
            }

            CargarProyectos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dvgProyectos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proyecto para editar");
                return;
            }

            proyectoSeleccionado = (Proyecto)dvgProyectos.CurrentRow.DataBoundItem;

            txtNombre.Text = proyectoSeleccionado.Nombre;
            txtDescripcion.Text = proyectoSeleccionado.Descripcion;

            dtpFechaInicioEditar.Value = proyectoSeleccionado.FechaInicio;
            dtpFechaFinalEditar.Value = proyectoSeleccionado.FechaFinal;

            cmbEstadoEditar.Text = proyectoSeleccionado.Estado;

            btnGuardarCambios.Enabled = true;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (proyectoSeleccionado == null)
            {
                MessageBox.Show("Primero debe seleccionar un proyecto");
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del proyecto");
                txtNombre.Focus();
                return;
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la descripción del proyecto");
                txtDescripcion.Focus();
                return;
            }

            if (cmbEstadoEditar.Text == "")
            {
                MessageBox.Show("Seleccione un estado");
                cmbEstadoEditar.Focus();
                return;
            }

            if (dtpFechaFinalEditar.Value < dtpFechaInicioEditar.Value)
            {
                MessageBox.Show("La fecha final no puede ser anterior a la fecha de inicio");
                return;
            }

            proyectoSeleccionado.Nombre = txtNombre.Text;
            proyectoSeleccionado.Descripcion = txtDescripcion.Text;
            proyectoSeleccionado.FechaInicio = dtpFechaInicioEditar.Value;
            proyectoSeleccionado.FechaFinal = dtpFechaFinalEditar.Value;
            proyectoSeleccionado.Estado = cmbEstadoEditar.Text;

            CargarProyectos();

            MessageBox.Show("Proyecto actualizado correctamente");

            btnCancelar.PerformClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();

            dtpFechaInicioEditar.Value = DateTime.Today;
            dtpFechaFinalEditar.Value = DateTime.Today;

            cmbEstadoEditar.SelectedIndex = -1;

            proyectoSeleccionado = null;

            btnGuardarCambios.Enabled = false;
        }
    }
    



}
