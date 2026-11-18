using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevTrack
{
    public partial class FrmTareas : Form
    {
        // Clase para almacenar la información de las tareas
        class Tarea
        {
            public int Id;
            public string Nombre;
            public string Descripcion;
            public string Proyecto;
            public string Responsable;
            public DateTime FechaEntrega;
            public string Estado;
        }

        // Nodo de la lista enlazada
        class Nodo
        {
            public Tarea Datos;
            public Nodo Siguiente;

            public Nodo(Tarea tarea)
            {
                Datos = tarea;
                Siguiente = null;
            }
        }

        // Lista enlazada para almacenar tareas
        class ListaTareas
        {
            public Nodo Inicio;

            public void Agregar(Tarea tarea)
            {
                Nodo nuevo = new Nodo(tarea);

                if (Inicio == null)
                {
                    Inicio = nuevo;
                }
                else
                {
                    Nodo actual = Inicio;

                    while (actual.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                    }

                    actual.Siguiente = nuevo;
                }
            }

            public void Eliminar(int id)
            {
                if (Inicio == null)
                    return;

                if (Inicio.Datos.Id == id)
                {
                    Inicio = Inicio.Siguiente;
                    return;
                }

                Nodo actual = Inicio;

                while (actual.Siguiente != null)
                {
                    if (actual.Siguiente.Datos.Id == id)
                    {
                        actual.Siguiente = actual.Siguiente.Siguiente;
                        return;
                    }

                    actual = actual.Siguiente;
                }
            }

            public Tarea Buscar(int id)
            {
                Nodo actual = Inicio;

                while (actual != null)
                {
                    if (actual.Datos.Id == id)
                        return actual.Datos;

                    actual = actual.Siguiente;
                }

                return null;
            }
        }

        // Estructuras de datos
        ListaTareas lista = new ListaTareas();

        Queue<Tarea> colaRevision = new Queue<Tarea>();

        Stack<string> historial = new Stack<string>();

        int contador = 1;
        int idSeleccionado = -1;

        public FrmTareas()
        {
            InitializeComponent();

            // Estados de las tareas
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("En proceso");
            cmbEstado.Items.Add("Terminada");

            cmbEstado.SelectedIndex = 0;

            // Proyectos de ejemplo
            cmbProyecto.Items.Add("Proyecto 1");
            cmbProyecto.Items.Add("Proyecto 2");
            cmbProyecto.Items.Add("Proyecto 3");

            // Responsables
            cmbResponsable.Items.Add("Tayler Andrés Bello Barrantes");
            cmbResponsable.Items.Add("John Jeshua Moraga Chacón");
            cmbResponsable.Items.Add("Anthony Jiménez Oporta");

            // Configuración de la tabla
            dgvTareas.Columns.Add("Id", "ID");
            dgvTareas.Columns.Add("Nombre", "Nombre");
            dgvTareas.Columns.Add("Descripcion", "Descripción");
            dgvTareas.Columns.Add("Proyecto", "Proyecto");
            dgvTareas.Columns.Add("Responsable", "Responsable");
            dgvTareas.Columns.Add("Fecha", "Fecha de entrega");
            dgvTareas.Columns.Add("Estado", "Estado");

            dgvTareas.Columns["Id"].Visible = false;

            dgvTareas.ReadOnly = true;
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.MultiSelect = false;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTareas.CellClick += dgvTareas_CellClick;
        }

        // BOTÓN GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtDescripcion.Text.Trim() == "" ||
                cmbProyecto.SelectedIndex == -1 ||
                cmbResponsable.SelectedIndex == -1 ||
                cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Tarea nueva = new Tarea();

            nueva.Id = contador++;
            nueva.Nombre = txtNombre.Text;
            nueva.Descripcion = txtDescripcion.Text;
            nueva.Proyecto = cmbProyecto.Text;
            nueva.Responsable = cmbResponsable.Text;
            nueva.FechaEntrega = dtpFechaEntrega.Value;
            nueva.Estado = cmbEstado.Text;

            lista.Agregar(nueva);

            // Registrar acción en la pila
            historial.Push("Se agregó la tarea: " + nueva.Nombre);

            // Agregar a la cola si necesita revisión
            if (nueva.Estado == "Pendiente")
            {
                colaRevision.Enqueue(nueva);
            }

            MostrarTareas();
            LimpiarCampos();

            MessageBox.Show("Tarea guardada correctamente.");
        }

        // MOSTRAR TAREAS
        private void MostrarTareas()
        {
            dgvTareas.Rows.Clear();

            Nodo actual = lista.Inicio;

            while (actual != null)
            {
                Tarea tarea = actual.Datos;

                dgvTareas.Rows.Add(
                    tarea.Id,
                    tarea.Nombre,
                    tarea.Descripcion,
                    tarea.Proyecto,
                    tarea.Responsable,
                    tarea.FechaEntrega.ToShortDateString(),
                    tarea.Estado
                );

                actual = actual.Siguiente;
            }
        }

        // SELECCIONAR TAREA
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvTareas.Rows[e.RowIndex];

            idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();

            cmbProyecto.Text = fila.Cells["Proyecto"].Value.ToString();
            cmbResponsable.Text = fila.Cells["Responsable"].Value.ToString();
            cmbEstado.Text = fila.Cells["Estado"].Value.ToString();

            dtpFechaEntrega.Value = Convert.ToDateTime(
                fila.Cells["Fecha"].Value
            );
        }

        // BOTÓN EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Seleccione una tarea.");
                return;
            }

            if (txtNombre.Text.Trim() == "" ||
                txtDescripcion.Text.Trim() == "" ||
                cmbProyecto.SelectedIndex == -1 ||
                cmbResponsable.SelectedIndex == -1 ||
                cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Tarea tarea = lista.Buscar(idSeleccionado);

            if (tarea != null)
            {
                tarea.Nombre = txtNombre.Text;
                tarea.Descripcion = txtDescripcion.Text;
                tarea.Proyecto = cmbProyecto.Text;
                tarea.Responsable = cmbResponsable.Text;
                tarea.FechaEntrega = dtpFechaEntrega.Value;
                tarea.Estado = cmbEstado.Text;

                historial.Push("Se modificó la tarea: " + tarea.Nombre);

                MostrarTareas();
                LimpiarCampos();

                MessageBox.Show("Tarea modificada correctamente.");
            }
        }

        // BOTÓN ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Seleccione una tarea.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar esta tarea?",
                "Eliminar tarea",
                MessageBoxButtons.YesNo
            );

            if (respuesta == DialogResult.Yes)
            {
                Tarea tarea = lista.Buscar(idSeleccionado);

                if (tarea != null)
                {
                    historial.Push("Se eliminó la tarea: " + tarea.Nombre);
                }

                lista.Eliminar(idSeleccionado);

                MostrarTareas();
                LimpiarCampos();

                MessageBox.Show("Tarea eliminada correctamente.");
            }
        }

        // BOTÓN MOSTRAR
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarTareas();
        }

        // BOTÓN LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();

            cmbProyecto.SelectedIndex = -1;
            cmbResponsable.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;

            dtpFechaEntrega.Value = DateTime.Today;

            idSeleccionado = -1;

            dgvTareas.ClearSelection();
        }

        // BUSCAR TAREA
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim().ToLower();

            if (nombre == "")
            {
                MessageBox.Show("Escriba el nombre de la tarea.");
                return;
            }

            dgvTareas.Rows.Clear();

            Nodo actual = lista.Inicio;

            while (actual != null)
            {
                if (actual.Datos.Nombre.ToLower().Contains(nombre))
                {
                    Tarea tarea = actual.Datos;

                    dgvTareas.Rows.Add(
                        tarea.Id,
                        tarea.Nombre,
                        tarea.Descripcion,
                        tarea.Proyecto,
                        tarea.Responsable,
                        tarea.FechaEntrega.ToShortDateString(),
                        tarea.Estado
                    );
                }

                actual = actual.Siguiente;
            }

            if (dgvTareas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron tareas.");
            }
        }

        // MOSTRAR HISTORIAL
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (historial.Count == 0)
            {
                MessageBox.Show("No hay acciones registradas.");
                return;
            }

            string mensaje = "";

            foreach (string accion in historial)
            {
                mensaje += accion + "\n";
            }

            MessageBox.Show(mensaje, "Historial de acciones");
        }

        // MOSTRAR COLA DE REVISIÓN
        private void btnCola_Click(object sender, EventArgs e)
        {
            if (colaRevision.Count == 0)
            {
                MessageBox.Show("No hay tareas pendientes de revisión.");
                return;
            }

            string mensaje = "";

            foreach (Tarea tarea in colaRevision)
            {
                mensaje += tarea.Nombre + "\n";
            }

            MessageBox.Show(mensaje, "Cola de tareas");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}