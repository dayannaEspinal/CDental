using System; // Utiliza el espacio de nombres System
using System.Collections.Generic; // Utiliza el espacio de nombres System.Collections.Generic
using System.ComponentModel; // Utiliza el espacio de nombres System.ComponentModel
using System.Data; // Utiliza el espacio de nombres System.Data
using System.Drawing; // Utiliza el espacio de nombres System.Drawing
using System.Linq; // Utiliza el espacio de nombres System.Linq
using System.Text; // Utiliza el espacio de nombres System.Text
using System.Threading.Tasks; // Utiliza el espacio de nombres System.Threading.Tasks
using System.Windows.Forms; // Utiliza el espacio de nombres System.Windows.Forms

namespace CioDental1 // Define el espacio de nombres CioDental1
{
    public partial class BuscarCitas : Form // Define la clase parcial BuscarCitas que hereda de Form
    {
        // Constructor del formulario BuscarCitas
        public BuscarCitas()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        Conexión conexion = new Conexión(); // Instancia la clase Conexión

        // Evento que se ejecuta al cargar el formulario
        private void BuscarCitas_Load(object sender, EventArgs e)
        {
            // (No hay código en este evento actualmente)
        }

        // Evento que se ejecuta cuando se cambia el texto en el cuadro de búsqueda
        private void txtBuscarCitas_TextChanged(object sender, EventArgs e)
        {
            string nombrePaciente = txtBuscarCitas.Text; // Obtiene el texto ingresado en el cuadro de búsqueda
            conexion.BuscarCitasPorNombrePaciente(nombrePaciente, dgvListaCitas); // Llama al método para buscar citas por nombre de paciente y actualiza el DataGridView con los resultados
        }

        public Citas CitaSeleccionado { get; private set; } // Define una propiedad para almacenar la cita seleccionada

        // Evento que se ejecuta cuando se hace clic en una celda del DataGridView
        private void dgvListaCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvListaCitas.Rows[e.RowIndex]; // Obtiene la fila seleccionada

            // Obtiene los datos de la cita seleccionada desde la fila
            int codigo = Convert.ToInt32(filaSeleccionada.Cells["idCitDataGridViewTextBoxColumn"].Value); // Convierte el valor de la celda "idCitDataGridViewTextBoxColumn" a int
            string nombre = filaSeleccionada.Cells["nomPacDataGridViewTextBoxColumn"].Value.ToString(); // Convierte el valor de la celda "nomPacDataGridViewTextBoxColumn" a string
            string apellido = filaSeleccionada.Cells["apePacDataGridViewTextBoxColumn"].Value.ToString(); // Convierte el valor de la celda "apePacDataGridViewTextBoxColumn" a string

            CitaSeleccionado = new Citas(codigo, nombre, apellido); // Crea una nueva instancia de Citas con los datos obtenidos

            this.Close(); // Cierra el formulario
        }

        // Evento que se ejecuta cuando cambia el origen de datos del BindingSource
        private void citasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            // (No hay código en este evento actualmente)
        }

        // Evento que se ejecuta para formatear las celdas del DataGridView
        private void dgvListaCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica que el índice de columna y fila sean válidos
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtiene el valor del estado de la cita
                bool estado = Convert.ToBoolean(dgvListaCitas.Rows[e.RowIndex].Cells["estCitDataGridViewCheckBoxColumn"].Value); // Convierte el valor de la celda "estCitDataGridViewCheckBoxColumn" a bool

                // Aplica color de fondo a la fila basada en el estado de la cita
                if (estado)
                {
                    dgvListaCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkCyan; // Aplica color de fondo DarkCyan si el estado es verdadero
                }
                else
                {
                    dgvListaCitas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray; // Aplica color de fondo Gray si el estado es falso
                }
            }
        }
    }
}
