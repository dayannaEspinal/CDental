//using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel; // Comentado, no se utiliza

using System; // Utiliza el espacio de nombres System
using System.Collections.Generic; // Utiliza el espacio de nombres System.Collections.Generic
using System.ComponentModel; // Utiliza el espacio de nombres System.ComponentModel
using System.Data; // Utiliza el espacio de nombres System.Data
using System.Data.SqlClient; // Utiliza el espacio de nombres System.Data.SqlClient
using System.Drawing; // Utiliza el espacio de nombres System.Drawing
using System.Linq; // Utiliza el espacio de nombres System.Linq
using System.Security.Cryptography; // Utiliza el espacio de nombres System.Security.Cryptography
using System.Text; // Utiliza el espacio de nombres System.Text
using System.Threading.Tasks; // Utiliza el espacio de nombres System.Threading.Tasks
using System.Windows.Forms; // Utiliza el espacio de nombres System.Windows.Forms
using static CioDental1.Conexión; // Utiliza miembros estáticos de la clase Conexión

namespace CioDental1 // Define el espacio de nombres CioDental1
{
    public partial class FrmCitas : Form // Define la clase parcial FrmCitas que hereda de Form
    {
        public FrmCitas() // Constructor del formulario FrmCitas
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        Conexión conexion = new Conexión(); // Instancia de la clase Conexión

        private void Autonum() // Método para asignar un número automático
        {
            SqlDataReader reader = null; // Declara un SqlDataReader inicializado a null
            string query = "SELECT IdCit FROM CITAS"; // Define la consulta SQL

            if (conexion.val(query) == true) // Verifica si la consulta devuelve resultados
            {
                query = "SELECT MAX(IdCit) FROM CITAS"; // Consulta para obtener el valor máximo de IdCit
                reader = conexion.leerdato(query); // Ejecuta la consulta y almacena el resultado en reader

                while (reader.Read()) // Lee los datos del reader
                {
                    lblCodCit.Text = Convert.ToString(Convert.ToInt32(reader.GetValue(0)) + 1); // Asigna el valor de IdCit + 1 a lblCodCit
                }

                reader.Close(); // Cierra el reader
            }
            else
            {
                lblCodCit.Text = "1"; // Asigna 1 a lblCodCit si no hay resultados
            }
        }

        private void btnGuardarCitas_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en btnGuardarCitas
        {
            int IdCit = int.Parse(lblCodCit.Text); // Obtiene el valor de lblCodCit y lo convierte a entero
            int IdPac = (int)cbxCodPac.SelectedValue; // Obtiene el valor seleccionado de cbxCodPac y lo convierte a entero
            DateTime FecCit = dtpFechaCitas.Value; // Obtiene el valor de dtpFechaCitas
            DateTime HorCit = dtpHoraCita.Value; // Obtiene el valor de dtpHoraCita
            bool EstCit = true; // Define el estado de la cita como true

            conexion.Modificaciones("exec Insertar_Citas '" + IdCit + " ', ' " + IdPac + " ', ' " + FecCit + " ', ' " + HorCit + " ', ' " + EstCit + " ' "); // Inserta la cita en la base de datos
            MessageBox.Show("La cita ha sido GUARDADA correctamente"); // Muestra un mensaje de confirmación
            Autonum(); // Llama al método Autonum
            dtpFechaCitas.ResetText(); // Reinicia el texto de dtpFechaCitas
            dtpHoraCita.ResetText(); // Reinicia el texto de dtpHoraCita

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual
            string accion = "Se realizó una cita"; // Define la acción realizada
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado

            conexion.Modificaciones("exec Insertar_Bitacoras CAST(  '" + fecha + "' AS Date), CAST('" + hora + "' AS Time), '" + accion + "','" + usuario + "' "); // Inserta la acción en la bitácora
            conexion.Grids("exec VistaCitas", dgvCitas); // Actualiza el DataGridView con las citas
            string nombrePaciente = txtBuscarCitas.Text; // Obtiene el texto de búsqueda
            conexion.BuscarCitasPorNombrePaciente(nombrePaciente, dgvCitas); // Busca citas por nombre de paciente
        }

        private void btnSalirCitas_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en btnSalirCitas
        {
            Form C = new FrmMenuPrincipal(); // Crea una nueva instancia de FrmMenuPrincipal
            C.Show(); // Muestra el formulario FrmMenuPrincipal
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e) // Evento que se ejecuta al hacer clic en una celda de dgvCitas
        {
            try
            {
                lblCodCit.Text = dgvCitas.CurrentRow.Cells[0].Value.ToString(); // Asigna el valor de la celda seleccionada a lblCodCit
                cbxCodPac.SelectedValue = dgvCitas.CurrentRow.Cells[1].Value; // Asigna el valor de la celda seleccionada a cbxCodPac
                dtpFechaCitas.Value = (DateTime)dgvCitas.CurrentRow.Cells[2].Value; // Asigna el valor de la celda seleccionada a dtpFechaCitas
                dtpHoraCita.Value = (DateTime)dgvCitas.CurrentRow.Cells[3].Value; // Asigna el valor de la celda seleccionada a dtpHoraCita
            }
            catch
            {
                // Manejo de excepciones
            }
        }

        private void btnModificarCitas_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en btnModificarCitas
        {
            int IdCit = int.Parse(lblCodCit.Text); // Obtiene el valor de lblCodCit y lo convierte a entero
            int IdPac = (int)cbxCodPac.SelectedValue; // Obtiene el valor seleccionado de cbxCodPac y lo convierte a entero
            DateTime FecCit = dtpFechaCitas.Value; // Obtiene el valor de dtpFechaCitas
            DateTime HorCit = dtpHoraCita.Value; // Obtiene el valor de dtpHoraCita
            bool EstCit = true; // Define el estado de la cita como true

            conexion.Modificaciones("exec Actualizar_Citas '" + IdCit + " ', ' " + IdPac + " ', ' " + FecCit + " ', ' " + HorCit + " ', ' " + EstCit + " ' "); // Actualiza la cita en la base de datos
            MessageBox.Show("La cita ha sido ACTUALIZADA correctamente"); // Muestra un mensaje de confirmación
            Autonum(); // Llama al método Autonum
            dtpFechaCitas.ResetText(); // Reinicia el texto de dtpFechaCitas
            dtpHoraCita.ResetText(); // Reinicia el texto de dtpHoraCita

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual
            string accion = "Se actualizó una cita"; // Define la acción realizada
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado

            conexion.Modificaciones("exec Insertar_Bitacoras CAST(  '" + fecha + "' AS Date), CAST('" + hora + "' AS Time), '" + accion + "','" + usuario + "' "); // Inserta la acción en la bitácora
            string nombrePaciente = txtBuscarCitas.Text; // Obtiene el texto de búsqueda
            conexion.BuscarCitasPorNombrePaciente(nombrePaciente, dgvCitas); // Busca citas por nombre de paciente
        }

        private void btnEliminarCitas_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en btnEliminarCitas
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR esta cita?", "Eliminar cita", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirma la eliminación de la cita
            {
                int IdCit = int.Parse(lblCodCit.Text); // Obtiene el valor de lblCodCit y lo convierte a entero
                conexion.Modificaciones("exec Eliminar_Citas '" + IdCit + "'"); // Elimina la cita en la base de datos
                MessageBox.Show("La cita ha sido ELIMINADA"); // Muestra un mensaje de confirmación
                Autonum(); // Llama al método Autonum

                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual
                string accion = "Se eliminó una cita"; // Define la acción realizada
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado

                conexion.Modificaciones("exec Insertar_Bitacoras CAST(  '" + fecha + "' AS Date), CAST('" + hora + "' AS Time), '" + accion + "','" + usuario + "' "); // Inserta la acción en la bitácora
                string nombrePaciente = txtBuscarCitas.Text; // Obtiene el texto de búsqueda
                conexion.BuscarCitasPorNombrePaciente(nombrePaciente, dgvCitas); // Busca citas por nombre de paciente
            }
        }

        private void txtBuscarCitas_TextChanged(object sender, EventArgs e) // Evento que se ejecuta al cambiar el texto en txtBuscarCitas
        {
            string nombrePaciente = txtBuscarCitas.Text; // Obtiene el texto ingresado en txtBuscarCitas
            conexion.BuscarCitasPorNombrePaciente(nombrePaciente, dgvCitas); // Busca citas por nombre de paciente y actualiza el DataGridView
        }

        private void FrmCitas_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario FrmCitas
        {
            Autonum(); // Llama al método Autonum para asignar un número automático
            conexion.mostraspacientes(cbxCodPac); // Muestra los pacientes en el ComboBox cbxCodPac
        }

        private void cbCit_CheckedChanged(object sender, EventArgs e) // Evento que se ejecuta al cambiar el estado de cbCit (no se utiliza)
        {
            // No se utiliza actualmente
        }

        private void btnDesactivarProveedores_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en btnDesactivarProveedores
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Verifica si el usuario no es administrador
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje de error
                return; // Sale del método
            }

            int IdCit = int.Parse(lblCodCit.Text); // Obtiene el valor de lblCodCit y lo convierte a entero
            int IdPac = (int)cbxCodPac.SelectedValue; // Obtiene el valor seleccionado de cbxCodPac y lo convierte a entero
            DateTime FecCit = dtpFechaCitas.Value; // Obtiene el valor de dtpFechaCitas
            DateTime HorCit = dtpHoraCita.Value; // Obtiene el valor de dtpHoraCita
            bool EstCit = false; // Define el estado de la cita como false

            conexion.Modificaciones("exec Desactivar_Citas '" + IdCit + " ', ' " + IdPac + " ', ' " + FecCit + " ', ' " + HorCit + " ', ' " + EstCit + " ' "); // Desactiva la cita en la base de datos
            MessageBox.Show("La cita ha sido DESACTIVADA correctamente"); // Muestra un mensaje de confirmación
            Autonum(); // Llama al método Autonum
            dtpFechaCitas.ResetText(); // Reinicia el texto de dtpFechaCitas
            dtpHoraCita.ResetText(); // Reinicia el texto de dtpHoraCita

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual
            string accion = "Se desactivó una cita"; // Define la acción realizada
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado

            conexion.Modificaciones("exec Insertar_Bitacoras CAST(  '" + fecha + "' AS Date), CAST('" + hora + "' AS Time), '" + accion + "','" + usuario + "' "); // Inserta la acción en la bitácora
            string nombrePaciente = txtBuscarCitas.Text; // Obtiene el texto de búsqueda
            conexion.BuscarCitasPorNombrePaciente(nombrePaciente, dgvCitas); // Busca citas por nombre de paciente
        }

        private void dgvCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) // Evento que se ejecuta al dar formato a las celdas de dgvCitas
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0) // Verifica que la celda no sea de encabezado
            {
                bool estado = Convert.ToBoolean(dgvCitas.Rows[e.RowIndex].Cells["estCitDataGridViewCheckBoxColumn"].Value); // Obtiene el valor booleano de la celda

                if (estado) // Si el estado es verdadero
                {
                    dgvCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkCyan; // Establece el color de fondo de la fila como DarkCyan
                }
                else // Si el estado es falso
                {
                    dgvCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray; // Establece el color de fondo de la fila como Gray
                }
            }
        }
    }
}
