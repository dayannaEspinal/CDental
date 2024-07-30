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
    public partial class BuscarTratamiento : Form // Define la clase parcial BuscarTratamiento que hereda de Form
    {
        public Tratamiento TratamientoSeleccionado { get; private set; } // Propiedad para almacenar el tratamiento seleccionado

        public BuscarTratamiento() // Constructor del formulario BuscarTratamiento
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        Conexión conexion = new Conexión(); // Instancia de la clase Conexión

        private void BuscarTratamiento_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
        {
            // (No hay código en este evento actualmente)
        }

        private void txtBuscarTratamiento_TextChanged(object sender, EventArgs e) // Evento que se ejecuta cuando se cambia el texto en el cuadro de búsqueda de tratamientos
        {
            conexion.Busquedas("exec VistaTratamientos", dgvListaTra, "DesTra LIKE '%" + txtBuscarTratamiento.Text + "%' "); // Llama al método para buscar tratamientos por descripción y actualiza el DataGridView con los resultados
        }

        private void dgvListaTra_CellClick(object sender, DataGridViewCellEventArgs e) // Evento que se ejecuta cuando se hace clic en una celda del DataGridView
        {
            DataGridViewRow filaSeleccionada = dgvListaTra.Rows[e.RowIndex]; // Obtiene la fila seleccionada

            int codigo = Convert.ToInt32(filaSeleccionada.Cells["idTraDataGridViewTextBoxColumn"].Value); // Convierte el valor de la celda "idTraDataGridViewTextBoxColumn" a int
            string nombre = filaSeleccionada.Cells["desTraDataGridViewTextBoxColumn"].Value.ToString(); // Convierte el valor de la celda "desTraDataGridViewTextBoxColumn" a string
            int precio = Convert.ToInt32(filaSeleccionada.Cells["cosTraDataGridViewTextBoxColumn"].Value); // Convierte el valor de la celda "cosTraDataGridViewTextBoxColumn" a int

            TratamientoSeleccionado = new Tratamiento(codigo, nombre, precio); // Crea una nueva instancia de Tratamiento con los datos obtenidos

            this.Close(); // Cierra el formulario
        }
    }
}
