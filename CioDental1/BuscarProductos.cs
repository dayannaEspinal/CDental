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
    public partial class BuscarProductos : Form // Define la clase parcial BuscarProductos que hereda de Form
    {
        // Constructor del formulario BuscarProductos
        public BuscarProductos()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        Conexión conexion = new Conexión(); // Instancia de la clase Conexión

        private void BuscarProductos_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
        {
            // (No hay código en este evento actualmente)
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e) // Evento que se ejecuta cuando se cambia el texto en el cuadro de búsqueda de productos
        {
            conexion.Busquedas("exec VisProducto", dgvListaProd, "NomPro LIKE '%" + txtBuscarProducto.Text + "%' "); // Llama al método para buscar productos por nombre y actualiza el DataGridView con los resultados
        }

        private void dgvListaProd_CellClick(object sender, DataGridViewCellEventArgs e) // Evento que se ejecuta cuando se hace clic en una celda del DataGridView (este evento no se utiliza)
        {
            // (No hay código en este evento actualmente)
        }

        public Producto ProductoSeleccionado { get; private set; } // Propiedad para almacenar el producto seleccionado

        private void dgvListaProd_CellClick_1(object sender, DataGridViewCellEventArgs e) // Evento que se ejecuta cuando se hace clic en una celda del DataGridView
        {
            DataGridViewRow filaSeleccionada = dgvListaProd.Rows[e.RowIndex]; // Obtiene la fila seleccionada

            int codigo = Convert.ToInt32(filaSeleccionada.Cells["idProDataGridViewTextBoxColumn"].Value); // Convierte el valor de la celda "idProDataGridViewTextBoxColumn" a int
            string nombre = filaSeleccionada.Cells["nomProDataGridViewTextBoxColumn"].Value.ToString(); // Convierte el valor de la celda "nomProDataGridViewTextBoxColumn" a string
            int precio = Convert.ToInt32(filaSeleccionada.Cells["preProDataGridViewTextBoxColumn"].Value); // Convierte el valor de la celda "preProDataGridViewTextBoxColumn" a int

            ProductoSeleccionado = new Producto(codigo, nombre, precio); // Crea una nueva instancia de Producto con los datos obtenidos

            this.Close(); // Cierra el formulario
        }
    }
}
