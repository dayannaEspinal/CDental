using System; // Importa el espacio de nombres System
using System.Collections.Generic; // Importa el espacio de nombres System.Collections.Generic
using System.ComponentModel; // Importa el espacio de nombres System.ComponentModel
using System.Data; // Importa el espacio de nombres System.Data
using System.Data.SqlClient; // Importa el espacio de nombres System.Data.SqlClient
using System.Drawing; // Importa el espacio de nombres System.Drawing
using System.Linq; // Importa el espacio de nombres System.Linq
using System.Text; // Importa el espacio de nombres System.Text
using System.Threading.Tasks; // Importa el espacio de nombres System.Threading.Tasks
using System.Windows.Forms; // Importa el espacio de nombres System.Windows.Forms
using static CioDental1.Conexión; // Importa el tipo estático Conexión del espacio de nombres CioDental1

namespace CioDental1 // Espacio de nombres CioDental1
{
    public partial class FrmMarcas : Form // Clase FrmMarcas que hereda de Form
    {
        public FrmMarcas() // Constructor de la clase FrmMarcas
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        Conexión conexion = new Conexión(); // Instancia de la clase Conexión

        // Método para autonumerar el código de marca
        private void Autonum() // Define el método Autonum
        {
            SqlDataReader reader = null; // Declara una variable para leer datos del tipo SqlDataReader
            string query = "SELECT IdMar FROM MARCAS"; // Define una consulta SQL para seleccionar el Id de marca

            // Verifica si hay registros en la tabla de marcas
            if (conexion.val(query) == true) // Comprueba si la conexión tiene valores
            {
                query = "SELECT MAX(IdMar) FROM MARCAS"; // Define una consulta SQL para seleccionar el máximo Id de marca
                reader = conexion.leerdato(query); // Ejecuta la consulta y guarda los resultados en el lector
                while (reader.Read()) // Mientras haya filas en el lector
                {
                    lblCodMarca.Text = Convert.ToString(Convert.ToInt32(reader.GetValue(0))+1); // Obtiene y establece el siguiente número de marca
                }
                reader.Close(); // Cierra el lector
            }
            else // Si no hay registros en la tabla de marcas
            {
                lblCodMarca.Text = "1"; // Establece el primer número de marca si la tabla está vacía
            }
        }

        // Evento click del botón "Guardar Marca"
        private void btnGuardarMarca_Click(object sender, EventArgs e) // Define el evento click del botón btnGuardarMarca
        {
            if (txtNombreMarca.Text == "") // Si el campo de nombre de marca está vacío
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje de advertencia
                return; // Sale del método
            }
            else // Si el campo de nombre de marca no está vacío
            {

            }

            int IdMar = int.Parse(lblCodMarca.Text); // Obtiene el Id de la marca
            string NomMar = txtNombreMarca.Text; // Obtiene el nombre de la marca

            conexion.Modificaciones("exec Insertar_Marcas '" + IdMar + " ', ' " + NomMar + " ' "); // Ejecuta el procedimiento almacenado para insertar una marca en la base de datos
            MessageBox.Show("La marca ha sido GUARDADA correctamente"); // Muestra un mensaje de éxito
            Autonum(); // Llama al método para autonumerar el código de marca
            txtNombreMarca.Clear(); // Limpia el campo de texto para el nombre de la marca

            // Obtiene la fecha y hora actual
            string hora = DateTime.Now.ToLongTimeString();  // Obtiene la hora  actual
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha  actual
            string accion = "Se guardó una marca"; // Obtiene la acción actual que en este caso es guardar un registro de marca
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario logueado

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Registra la acción en la bitácora

            conexion.Busquedas("exec VistaMarcas", dgvMarca, "NomMar LIKE '%" + txtBuscarMarca.Text + "%*' "); // Ejecuta el procedimiento almacenado para buscar marcas y actualiza el DataGridView
        }

        private void btnModificarMarca_Click(object sender, EventArgs e) //Evento para modificar marca
        {
            // Verifica si el usuario logueado es administrador
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado))
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje de advertencia
                return; // Sale del método
            }

            // Verifica si el campo de nombre de marca está vacío
            if (txtNombreMarca.Text == "")
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje de advertencia
                return; // Sale del método
            }
            else
            {

            }

            int IdMar = int.Parse(lblCodMarca.Text); // Obtiene el Id de la marca
            string NomMar = txtNombreMarca.Text; // Obtiene el nombre de la marca

            // Ejecuta el procedimiento almacenado para actualizar una marca en la base de datos
            conexion.Modificaciones("exec Actualizar_Marcas '" + IdMar + " ', ' " + NomMar + " ' ");
            MessageBox.Show("La marca ha sido ACTUALIZADA correctamente"); // Muestra un mensaje de éxito
            Autonum(); // Llama al método para autonumerar el código de marca
            txtNombreMarca.Clear(); // Limpia el campo de texto para el nombre de la marca

            // Obtiene la fecha y hora actual
            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena
            string accion = "Se actualizó una marca"; // Define la acción realizada como actualización de una marca
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario logueado

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta el procedimiento almacenado para registrar la acción en la bitácora
            conexion.Busquedas("exec VistaMarcas", dgvMarca, "NomMar LIKE '%" + txtBuscarMarca.Text + "%*' "); // Realiza una búsqueda en la vista de marcas basada en el texto ingresado en el cuadro de búsqueda
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e) //Evento para eliminar marca
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR esta marca?", "Eliminar marca", MessageBoxButtons.YesNo) == DialogResult.Yes) // Pregunta al usuario si está seguro de eliminar la marca
            {
                int IdMar = int.Parse(lblCodMarca.Text); // Obtiene el Id de la marca
                conexion.Modificaciones("exec Eliminar_Marcas '" + IdMar + "'"); // Ejecuta el procedimiento almacenado para eliminar la marca
                MessageBox.Show("La marca ha sido ELIMINADA"); // Muestra un mensaje de éxito
                Autonum(); // Llama al método para autonumerar el código de marca

                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena
                string accion = "Se eliminó una marca"; // Define la acción realizada como eliminación de una marca
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario logueado

                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta el procedimiento almacenado para registrar la acción en la bitácora
                conexion.Busquedas("exec VistaMarcas", dgvMarca, "NomMar LIKE '%" + txtBuscarMarca.Text + "%*' "); // Realiza una búsqueda en la vista de marcas basada en el texto ingresado en el cuadro de búsqueda
            }
        }

        private void txtBuscarMarca_TextChanged(object sender, EventArgs e) //Evento para buscar una marca en funcion al texto ingresado y actualiza el datagriv
        {
            conexion.Busquedas("exec VistaMarcas", dgvMarca, "NomMar LIKE '%" + txtBuscarMarca.Text + "%*' "); // Realiza una búsqueda de marcas en función del texto ingresado en el campo de búsqueda y actualiza el DataGridView
        }

        private void btnSalirMarca_Click(object sender, EventArgs e) //Evento para salir 
        {
            Form M = new FrmMenuPrincipal(); // Crea una instancia del formulario del menú principal
            M.Show(); // Muestra el formulario del menú principal
        }

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e) // Maneja el evento de clic en el contenido de la celda del DataGridView de marcas
        {
            try
            {
                lblCodMarca.Text = dgvMarca.CurrentRow.Cells[0].Value.ToString(); // Obtiene y muestra el Id de la marca seleccionada en el DataGridView
                txtNombreMarca.Text = dgvMarca.CurrentRow.Cells[1].Value.ToString(); // Obtiene y muestra el nombre de la marca seleccionada en el DataGridView
            }
            catch
            {

            }
        }

        private void FrmMarcas_Load(object sender, EventArgs e) // Maneja el evento de carga del formulario de marcas, llamando al método para autonumerar el código de marca
        {
            Autonum(); // Llama al método para autonumerar el código de marca cuando se carga el formulario
        }

    }
}
