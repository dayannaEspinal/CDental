using System; // Importa el espacio de nombres System, que contiene clases fundamentales para el desarrollo .NET.
using System.Collections.Generic; // Importa el espacio de nombres para colecciones genéricas.
using System.ComponentModel; // Importa el espacio de nombres para componentes.
using System.Data; // Importa el espacio de nombres para el manejo de datos.
using System.Data.SqlClient; // Importa el espacio de nombres para conectarse a SQL Server.
using System.Drawing; // Importa el espacio de nombres para el manejo de gráficos.
using System.Linq; // Importa el espacio de nombres para consultas de datos.
using System.Text; // Importa el espacio de nombres para el manejo de texto.
using System.Threading.Tasks; // Importa el espacio de nombres para tareas asincrónicas.
using System.Windows.Forms; // Importa el espacio de nombres para el manejo de formularios.
using static CioDental1.Conexión; // Importa la clase Conexión estáticamente, para acceder a sus miembros directamente.

namespace CioDental1 // Define el espacio de nombres del proyecto.
{
    public partial class FrmProveedores : Form // Define la clase FrmProveedores que hereda de Form.
    {
        public FrmProveedores() // Constructor del formulario FrmProveedores.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        Conexión conexion = new Conexión(); // Crea una instancia de la clase Conexión para manejar la base de datos.

        private void Autonum() // Método para generar automáticamente el próximo ID de proveedor.
        {
            SqlDataReader reader = null; // Declara un SqlDataReader para leer datos de la base de datos.
            string query = "SELECT IdProv FROM PROVEEDORES"; // Define la consulta para obtener los IDs de proveedores.
            if (conexion.val(query) == true) // Verifica si la consulta devuelve resultados.
            {
                query = "SELECT MAX(IdProv) FROM PROVEEDORES"; // Define la consulta para obtener el ID máximo de proveedores.
                reader = conexion.leerdato(query); // Ejecuta la consulta y obtiene los datos.
                while (reader.Read()) // Lee los resultados de la consulta.
                {
                    lblCodProv.Text = Convert.ToString(Convert.ToInt32(reader.GetValue(0)) + 1); // Asigna el siguiente ID de proveedor al label.
                }
                reader.Close(); // Cierra el SqlDataReader.
            }
            else
            {
                lblCodProv.Text = "1"; // Asigna "1" si no hay proveedores en la base de datos.
            }
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e) // Evento click del botón btnGuardarProveedor.
        {
            if (txtNombreProveedor.Text == "" || txtTelefonoProveedor.Text == "" || txtDireccionProveedor.Text == "" || txtCorreoProveedor.Text == "") // Verifica si los campos están vacíos.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje si los datos están incompletos.
                return; // Sale del método.
            }

            int IdProv = int.Parse(lblCodProv.Text); // Convierte el texto de lblCodProv a entero y lo asigna a IdProv.
            string NomProv = txtNombreProveedor.Text; // Asigna el texto de txtNombreProveedor a la variable NomProv.
            int TelProv = int.Parse(txtTelefonoProveedor.Text); // Convierte el texto de txtTelefonoProveedor a entero y lo asigna a TelProv.
            string DirProv = txtDireccionProveedor.Text; // Asigna el texto de txtDireccionProveedor a la variable DirProv.
            string EmlProv = txtCorreoProveedor.Text; // Asigna el texto de txtCorreoProveedor a la variable EmlProv.
            string RTNProv = txtRTNProveedor.Text; // Asigna el texto de txtRTNProveedor a la variable RTNProv.
            bool EstProv = true; // Asigna true al estado del proveedor.

            // Ejecuta la consulta para insertar un nuevo proveedor en la base de datos.
            conexion.Modificaciones("exec Insertar_Proveedores '" + IdProv + " ', ' " + NomProv + " ', ' " + TelProv + " ', ' " + DirProv + " ', ' " + EmlProv + " ', ' " + RTNProv + " ', ' " + EstProv + " '  ");
            MessageBox.Show("El proveedor ha sido GUARDADO correctamente"); // Muestra un mensaje indicando que el proveedor ha sido guardado.
            Autonum(); // Llama al método Autonum para actualizar el ID del proveedor.
                       // Limpia los campos de entrada.
            txtNombreProveedor.Clear(); // Limpia el campo de texto del nombre del proveedor.
            txtTelefonoProveedor.Clear(); // Limpia el campo de texto del teléfono del proveedor.
            txtDireccionProveedor.Clear(); // Limpia el campo de texto de la dirección del proveedor.
            txtCorreoProveedor.Clear(); // Limpia el campo de texto del correo electrónico del proveedor.
            txtRTNProveedor.Clear(); // Limpia el campo de texto del RTN del proveedor.

            // Registra la acción en la bitácora.
            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
            string accion = "Se guardó un proveedor"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar el registro en la bitácora.

            conexion.Busquedas("exec VistaProveedores", dgvProveedor, "NomProv LIKE '%" + txtBuscarProveedor.Text + "%*' "); // Ejecuta la consulta para buscar y mostrar los proveedores en el DataGridView.
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e) // Evento click del botón btnModificarProveedor.
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Verifica si el usuario logueado es un administrador.
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje si el usuario no tiene permisos.
                return; // Sale del método.
            }

            if (txtNombreProveedor.Text == "" || txtTelefonoProveedor.Text == "" || txtDireccionProveedor.Text == "" || txtCorreoProveedor.Text == "") // Verifica si los campos están vacíos.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje si los datos están incompletos.
                return; // Sale del método.
            }

            int IdProv = int.Parse(lblCodProv.Text); // Convierte el texto de lblCodProv a entero y lo asigna a IdProv.
            string NomProv = txtNombreProveedor.Text; // Asigna el texto de txtNombreProveedor a la variable NomProv.
            int TelProv = int.Parse(txtTelefonoProveedor.Text); // Convierte el texto de txtTelefonoProveedor a entero y lo asigna a TelProv.
            string DirProv = txtDireccionProveedor.Text; // Asigna el texto de txtDireccionProveedor a la variable DirProv.
            string EmlProv = txtCorreoProveedor.Text; // Asigna el texto de txtCorreoProveedor a la variable EmlProv.
            string RTNProv = txtRTNProveedor.Text; // Asigna el texto de txtRTNProveedor a la variable RTNProv.
            bool EstProv = true; // Asigna true al estado del proveedor.

            // Ejecuta la consulta para actualizar el proveedor en la base de datos.
            conexion.Modificaciones("exec Actualizar_Proveedores '" + IdProv + " ', ' " + NomProv + " ', ' " + TelProv + " ', ' " + DirProv + " ', ' " + EmlProv + " ', ' " + RTNProv + " ', ' " + EstProv + " '  ");
            MessageBox.Show("El proveedor ha sido ACTUALIZADO correctamente"); // Muestra un mensaje indicando que el proveedor ha sido actualizado.
            Autonum(); // Llama al método Autonum para actualizar el ID del proveedor.

            txtNombreProveedor.Clear(); // Limpia el campo de texto del nombre del proveedor.
            txtTelefonoProveedor.Clear(); // Limpia el campo de texto del teléfono del proveedor.
            txtDireccionProveedor.Clear(); // Limpia el campo de texto de la dirección del proveedor.
            txtCorreoProveedor.Clear(); // Limpia el campo de texto del correo electrónico del proveedor.
            txtRTNProveedor.Clear(); // Limpia el campo de texto del RTN del proveedor.

            // Registra la acción en la bitácora.
            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
            string accion = "Se modificó un proveedor"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar el registro en la bitácora.

            conexion.Busquedas("exec VistaProveedores", dgvProveedor, "NomProv LIKE '%" + txtBuscarProveedor.Text + "%*' "); // Ejecuta la consulta para buscar y mostrar los proveedores en el DataGridView.

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e) // Evento click del botón btnEliminarProveedor.
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR este proveedor?", "Eliminar proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes) // Muestra un mensaje de confirmación para eliminar el proveedor.
            {
                int IdProv = int.Parse(lblCodProv.Text); // Convierte el texto de lblCodProv a entero y lo asigna a IdProv.
                conexion.Modificaciones("exec Eliminar_Proveedores '" + IdProv + "'"); // Ejecuta la consulta para eliminar el proveedor de la base de datos.
                MessageBox.Show("El proveedor ha sido ELIMINADO"); // Muestra un mensaje indicando que el proveedor ha sido eliminado.
                Autonum(); // Llama al método Autonum para actualizar el ID del proveedor.

                // Registra la acción en la bitácora.
                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
                string accion = "Se eliminó un proveedor"; // Define la acción realizada.
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.
                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar el registro en la bitácora.

                // Actualiza el DataGridView con los proveedores.
                conexion.Busquedas("exec VistaProveedores", dgvProveedor, "NomProv LIKE '%" + txtBuscarProveedor.Text + "%*' "); // Ejecuta la consulta para buscar y mostrar los proveedores en el DataGridView.
            }
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e) // Evento que se dispara cuando el texto en txtBuscarProveedor cambia.
        {
            conexion.Busquedas("exec VistaProveedores", dgvProveedor, "NomProv LIKE '%" + txtBuscarProveedor.Text + "%*' "); // Ejecuta la consulta para buscar proveedores y mostrar el resultado en dgvProveedor.
        }

        private void btnSalirProveedor_Click(object sender, EventArgs e) // Evento click del botón btnSalirProveedor.
        {
            Form Q = new FrmMenuPrincipal(); // Crea una nueva instancia del formulario FrmMenuPrincipal.
            Q.Show(); // Muestra el formulario FrmMenuPrincipal.
        }

        private void btnConProv_Prov_Click(object sender, EventArgs e) // Evento click del botón btnConProv_Prov.
        {
            Form G = new FrmContactoProveedor(); // Crea una nueva instancia del formulario FrmContactoProveedor.
            G.Show(); // Muestra el formulario FrmContactoProveedor.
        }

        private void cbProv_CheckedChanged(object sender, EventArgs e) // Evento que se dispara cuando el estado del CheckBox cbProv cambia.
        {
            // Actualmente vacío, puedes agregar lógica aquí si es necesario.
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e) // Evento que se dispara cuando se hace clic en una celda de dgvProveedor.
        {
            try
            {
                // Asigna los valores de las celdas de la fila seleccionada a los controles correspondientes.
                lblCodProv.Text = dgvProveedor.CurrentRow.Cells[0].Value.ToString(); // Obtiene y asigna el valor de la primera celda de la fila seleccionada al lblCodProv.
                txtNombreProveedor.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString(); // Obtiene y asigna el valor de la segunda celda de la fila seleccionada al txtNombreProveedor.
                txtTelefonoProveedor.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString(); // Obtiene y asigna el valor de la tercera celda de la fila seleccionada al txtTelefonoProveedor.
                txtDireccionProveedor.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString(); // Obtiene y asigna el valor de la cuarta celda de la fila seleccionada al txtDireccionProveedor.
                txtCorreoProveedor.Text = dgvProveedor.CurrentRow.Cells[4].Value.ToString(); // Obtiene y asigna el valor de la quinta celda de la fila seleccionada al txtCorreoProveedor.
                txtRTNProveedor.Text = dgvProveedor.CurrentRow.Cells[5].Value.ToString(); // Obtiene y asigna el valor de la sexta celda de la fila seleccionada al txtRTNProveedor.
            }
            catch
            {
                // Manejo de excepciones vacío.
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e) // Evento que se dispara cuando el formulario FrmProveedores se carga.
        {
            Autonum(); // Llama al método Autonum para actualizar el ID del proveedor.
        }

        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e) // Evento que se dispara cuando se presiona una tecla en txtTelefonoProveedor.
        {
            Conexión.SoloNumeros(e); // Llama al método SoloNumeros de la clase Conexión para permitir solo números en el campo.
        }

        private void btnDesactivarProveedores_Click(object sender, EventArgs e) // Evento click del botón btnDesactivarProveedores.
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Verifica si el usuario logueado es un administrador.
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje si el usuario no tiene permisos.
                return; // Sale del método.
            }

            if (txtNombreProveedor.Text == "" || txtTelefonoProveedor.Text == "" || txtDireccionProveedor.Text == "" || txtCorreoProveedor.Text == "") // Verifica si los campos están vacíos.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje si los datos están incompletos.
                return; // Sale del método.
            }

            int IdProv = int.Parse(lblCodProv.Text); // Convierte el texto de lblCodProv a entero y lo asigna a IdProv.
            string NomProv = txtNombreProveedor.Text; // Asigna el texto de txtNombreProveedor a la variable NomProv.
            int TelProv = int.Parse(txtTelefonoProveedor.Text); // Convierte el texto de txtTelefonoProveedor a entero y lo asigna a TelProv.
            string DirProv = txtDireccionProveedor.Text; // Asigna el texto de txtDireccionProveedor a la variable DirProv.
            string EmlProv = txtCorreoProveedor.Text; // Asigna el texto de txtCorreoProveedor a la variable EmlProv.
            string RTNProv = txtRTNProveedor.Text; // Asigna el texto de txtRTNProveedor a la variable RTNProv.
            bool EstProv = false; // Asigna false al estado del proveedor para desactivarlo.

            // Ejecuta la consulta para desactivar el proveedor en la base de datos.
            conexion.Modificaciones("exec Desactivar_Proveedores '" + IdProv + " ', ' " + NomProv + " ', ' " + TelProv + " ', ' " + DirProv + " ', ' " + EmlProv + " ', ' " + RTNProv + " ', ' " + EstProv + " '  ");
            MessageBox.Show("El proveedor ha sido DESACTIVADO correctamente"); // Muestra un mensaje indicando que el proveedor ha sido desactivado.
            Autonum(); // Llama al método Autonum para actualizar el ID del proveedor.
                       // Limpia los campos de entrada.
            txtNombreProveedor.Clear(); // Limpia el campo de texto txtNombreProveedor.
            txtTelefonoProveedor.Clear(); // Limpia el campo de texto txtTelefonoProveedor.
            txtDireccionProveedor.Clear(); // Limpia el campo de texto txtDireccionProveedor.
            txtCorreoProveedor.Clear(); // Limpia el campo de texto txtCorreoProveedor.
            txtRTNProveedor.Clear(); // Limpia el campo de texto txtRTNProveedor.

            // Registra la acción en la bitácora.
            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual y la asigna a la variable hora.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual y la asigna a la variable fecha.
            string accion = "Se desactivó un proveedor"; // Define la acción realizada como "Se desactivó un proveedor".
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario logueado y lo asigna a la variable usuario.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Registra la acción en la bitácora.

            // Actualiza el DataGridView con los proveedores.
            conexion.Busquedas("exec VistaProveedores", dgvProveedor, "NomProv LIKE '%" + txtBuscarProveedor.Text + "%*' "); // Actualiza el DataGridView con los proveedores según el criterio de búsqueda.
        }

        private void dgvProveedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) // Evento que se dispara cuando se formatea una celda de dgvProveedor.
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0) // Verifica que los índices de columna y fila sean válidos.
            {
                bool estado = Convert.ToBoolean(dgvProveedor.Rows[e.RowIndex].Cells["estProvDataGridViewCheckBoxColumn"].Value); // Obtiene el valor de la celda estProvDataGridViewCheckBoxColumn.

                if (estado) // Si el estado es verdadero.
                {
                    dgvProveedor.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkCyan; // Asigna el color DarkCyan a la fila.
                }
                else // Si el estado es falso.
                {
                    dgvProveedor.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray; // Asigna el color Gray a la fila.
                }
            }
        }
    }
}
