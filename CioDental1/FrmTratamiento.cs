using System; // Importa el espacio de nombres System, que contiene clases fundamentales y servicios del tiempo de ejecución.
using System.Collections.Generic; // Importa el espacio de nombres System.Collections.Generic, que proporciona interfaces y clases que definen colecciones genéricas.
using System.ComponentModel; // Importa el espacio de nombres System.ComponentModel, que contiene interfaces que se utilizan para implementar el comportamiento de componentes y controles.
using System.Data; // Importa el espacio de nombres System.Data, que proporciona acceso a clases que representan la arquitectura de datos ADO.NET.
using System.Data.SqlClient; // Importa el espacio de nombres System.Data.SqlClient, que proporciona clases específicas para interactuar con SQL Server.
using System.Drawing; // Importa el espacio de nombres System.Drawing, que proporciona acceso a GDI+ básico.
using System.Linq; // Importa el espacio de nombres System.Linq, que proporciona clases y extensiones que admiten consultas que utilizan LINQ.
using System.Text; // Importa el espacio de nombres System.Text, que contiene clases que representan codificaciones de caracteres Unicode y ANSI, así como clases para manipular cadenas de texto y bytes.
using System.Threading.Tasks; // Importa el espacio de nombres System.Threading.Tasks, que proporciona clases e interfaces que permiten la implementación de programación asincrónica y paralela.
using System.Windows.Forms; // Importa el espacio de nombres System.Windows.Forms, que contiene clases para crear aplicaciones de Windows que aprovechan las características y capacidades de la plataforma Windows.
using static CioDental1.Conexión; // Importa la clase estática Conexión del espacio de nombres CioDental1.

namespace CioDental1 // Declara un espacio de nombres llamado CioDental1.
{
    public partial class FrmTratamiento : Form // Declara una clase parcial llamada FrmTratamiento que hereda de Form.
    {
        public FrmTratamiento() // Define un constructor para la clase FrmTratamiento.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        Conexión conexion = new Conexión(); // Crea una instancia de la clase Conexión.

        private void Autonum() // Define un método llamado Autonum.
        {
            SqlDataReader reader = null; // Declara una variable para almacenar los resultados de la consulta.
            string query = "SELECT IdTra FROM TRATAMIENTOS"; // Define la consulta SQL para obtener el último ID de tratamiento.
            if (conexion.val(query) == true) // Comprueba si la consulta retorna resultados.
            {
                query = "SELECT MAX(IdTra) FROM TRATAMIENTOS"; // Define la consulta SQL para obtener el máximo ID de tratamiento.
                reader = conexion.leerdato(query); // Ejecuta la consulta y almacena los resultados en el lector de datos.
                while (reader.Read()) // Itera sobre los resultados del lector de datos.
                {
                    lblCodTra.Text = Convert.ToString(Convert.ToInt32(reader.GetValue(0)) + 1); // Asigna el siguiente ID de tratamiento en el formulario.
                }
                reader.Close(); // Cierra el lector de datos.
            }
            else // Si la consulta no retorna resultados.
            {
                lblCodTra.Text = "1"; // Asigna el ID 1 como el primer tratamiento.
            }
        }

        private void btnEliminarTratamiento_Click(object sender, EventArgs e) // Define un método para manejar el evento Click del botón btnEliminarTratamiento.
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR este tratamiento?", "Eliminar tratamiento", MessageBoxButtons.YesNo) == DialogResult.Yes) // Muestra un mensaje de confirmación para eliminar el tratamiento.
            {
                int CodTra = int.Parse(lblCodTra.Text); // Obtiene el ID del tratamiento a eliminar.
                conexion.Modificaciones("exec Eliminar_Tratamientos '" + CodTra + "'"); // Ejecuta el procedimiento almacenado para eliminar el tratamiento en la base de datos.
                MessageBox.Show("El tratamiento ha sido ELIMINADO"); // Muestra un mensaje de éxito.
                Autonum(); // Actualiza el número de tratamiento en el formulario.

                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena.
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena.
                string accion = "Se eliminó un tratamiento"; // Define la acción realizada.
                string usuario = "Wilson19"; // Define el nombre de usuario (¡Reemplazar con la lógica de autenticación real!).

                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Inserta una entrada en la tabla de bitácoras.
                conexion.Busquedas("exec VistaTratamientos", dgvTratamiento, "DesTra LIKE '%" + txtBuscarTratamiento.Text + "%*' "); // Realiza una búsqueda y muestra los resultados en el DataGridView.
            }
        }

        private void btnGuardarTratamiento_Click(object sender, EventArgs e) // Define un método para manejar el evento Click del botón btnGuardarTratamiento.
        {
            // Verifica si los campos obligatorios están vacíos.
            if (txtDescripcionTratamiento.Text == "" || txtCostoTratamiento.Text == "")
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje de advertencia.
                return; // Sale del método.
            }
            else
            {
                // No se necesita realizar ninguna acción en caso de que los campos estén completos.
            }

            // Obtiene los valores de los campos.
            int CodTra = int.Parse(lblCodTra.Text); // Obtiene el código del tratamiento.
            string DesTra = txtDescripcionTratamiento.Text; // Obtiene la descripción del tratamiento.
            int CosTra = int.Parse(txtCostoTratamiento.Text); // Obtiene el costo del tratamiento.

            // Ejecuta el procedimiento almacenado para insertar el tratamiento en la base de datos.
            conexion.Modificaciones("exec Insertar_Tratamientos '" + CodTra + " ', ' " + DesTra + " ', ' " + CosTra + " ' ");
            MessageBox.Show("El tratamiento ha sido GUARDADO correctamente"); // Muestra un mensaje de éxito.
            Autonum(); // Actualiza el número de tratamiento en el formulario.
            txtDescripcionTratamiento.Clear(); // Limpia el cuadro de texto de descripción del tratamiento.
            txtCostoTratamiento.Clear(); // Limpia el cuadro de texto de costo del tratamiento.

            // Registra la acción en la bitácora.
            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena.
            string accion = "Se guardó un tratamiento"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actual.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Inserta una entrada en la tabla de bitácoras.
            conexion.Busquedas("exec VistaTratamientos", dgvTratamiento, "DesTra LIKE '%" + txtBuscarTratamiento.Text + "%*' "); // Realiza una búsqueda y muestra los resultados en el DataGridView.
        }

        private void btnModificarTratamiento_Click(object sender, EventArgs e) // Define un método para manejar el evento Click del botón btnModificarTratamiento.
        {
            // Verifica si el usuario tiene permisos de administrador.
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado))
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje de advertencia.
                return; // Sale del método.
            }

            // Verifica si los campos obligatorios están vacíos.
            if (txtDescripcionTratamiento.Text == "" || txtCostoTratamiento.Text == "")
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje de advertencia.
                return; // Sale del método.
            }
            else
            {
                // No se necesita realizar ninguna acción en caso de que los campos estén completos.
            }

            // Obtiene los valores de los campos.
            int CodTra = int.Parse(lblCodTra.Text); // Obtiene el código del tratamiento.
            string DesTra = txtDescripcionTratamiento.Text; // Obtiene la descripción del tratamiento.
            int CosTra = int.Parse(txtCostoTratamiento.Text); // Obtiene el costo del tratamiento.

            // Ejecuta el procedimiento almacenado para actualizar el tratamiento en la base de datos.
            conexion.Modificaciones("exec Actualizar_Tratamientos '" + CodTra + " ', ' " + DesTra + " ', ' " + CosTra + " ' ");
            MessageBox.Show("El tratamiento ha sido ACTUALIZADO correctamente"); // Muestra un mensaje de éxito.
            Autonum(); // Actualiza el número de tratamiento en el formulario.
            txtDescripcionTratamiento.Clear(); // Limpia el cuadro de texto de descripción del tratamiento.
            txtCostoTratamiento.Clear(); // Limpia el cuadro de texto de costo del tratamiento.
            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena.
            string accion = "Se actualizó un tratamiento"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actual.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Inserta una entrada en la tabla de bitácoras.
            conexion.Busquedas("exec VistaTratamientos", dgvTratamiento, "DesTra LIKE '%" + txtBuscarTratamiento.Text + "%*' "); // Realiza una búsqueda y muestra los resultados en el DataGridView.
        }

        private void txtBuscarTratamiento_TextChanged(object sender, EventArgs e) // Define un método para manejar el evento TextChanged del cuadro de texto txtBuscarTratamiento.
        {
            conexion.Busquedas("exec VistaTratamientos", dgvTratamiento, "DesTra LIKE '%" + txtBuscarTratamiento.Text + "%*' "); // Realiza una búsqueda de tratamientos en la base de datos según el texto ingresado en el cuadro de búsqueda y muestra los resultados en el DataGridView dgvTratamiento.
        }

        private void btnSalirTratamiento_Click(object sender, EventArgs e) // Define un método para manejar el evento Click del botón btnSalirTratamiento.
        {
            Form TT = new FrmMenuPrincipal(); // Crea una instancia del formulario FrmMenuPrincipal.
            TT.Show(); // Muestra el formulario FrmMenuPrincipal.
        }

        private void dgvTratamiento_CellContentClick(object sender, DataGridViewCellEventArgs e) // Define un método para manejar el evento CellContentClick del DataGridView dgvTratamiento.
        {
            try
            {
                // Intenta obtener los valores de la fila actual del DataGridView y los asigna a los controles correspondientes en el formulario.
                lblCodTra.Text = dgvTratamiento.CurrentRow.Cells[0].Value.ToString(); // Obtiene y asigna el valor de la primera celda de la fila actual al control lblCodTra.
                txtDescripcionTratamiento.Text = dgvTratamiento.CurrentRow.Cells[1].Value.ToString(); // Obtiene y asigna el valor de la segunda celda de la fila actual al cuadro de texto txtDescripcionTratamiento.
                txtCostoTratamiento.Text = dgvTratamiento.CurrentRow.Cells[2].Value.ToString(); // Obtiene y asigna el valor de la tercera celda de la fila actual al cuadro de texto txtCostoTratamiento.
            }
            catch
            {
                // Maneja cualquier excepción que ocurra durante el proceso.
            }
        }

        private void FrmTratamiento_Load(object sender, EventArgs e) // Define un método para manejar el evento Load del formulario FrmTratamiento.
        {
            Autonum(); // Llama al método Autonum para cargar el número de tratamiento.
        }

        private void txtCostoTratamiento_KeyPress(object sender, KeyPressEventArgs e) // Define un método para manejar el evento KeyPress del cuadro de texto txtCostoTratamiento.
        {
            Conexión.SoloNumeros(e); // Llama al método SoloNumeros de la clase Conexión para permitir solo la entrada de números en el cuadro de texto.
        }

    }
}
