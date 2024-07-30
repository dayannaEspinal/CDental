using System; // Importa el espacio de nombres System.
using System.Collections.Generic; // Importa el espacio de nombres System.Collections.Generic.
using System.ComponentModel; // Importa el espacio de nombres System.ComponentModel.
using System.Data; // Importa el espacio de nombres System.Data.
using System.Data.SqlClient; // Importa el espacio de nombres System.Data.SqlClient.
using System.Drawing; // Importa el espacio de nombres System.Drawing.
using System.Linq; // Importa el espacio de nombres System.Linq.
using System.Text; // Importa el espacio de nombres System.Text.
using System.Threading.Tasks; // Importa el espacio de nombres System.Threading.Tasks.
using System.Windows.Forms; // Importa el espacio de nombres System.Windows.Forms.
using static CioDental1.Conexión; // Importa miembros estáticos de la clase Conexión.

namespace CioDental1 // Define el espacio de nombres CioDental1.
{
    public partial class FrmContactoProveedor : Form // Define la clase FrmContactoProveedor que hereda de Form.
    {
        public FrmContactoProveedor() // Constructor de la clase FrmContactoProveedor.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }
        Conexión conexion = new Conexión(); // Crea una nueva instancia de la clase Conexión.

        private void Autonum() // Método para autoincrementar el ID de contacto proveedor.
        {
            SqlDataReader reader = null; // Declara un lector de datos SQL.
            string query = "SELECT IdConProv FROM ContactoProveedor"; // Define la consulta SQL.
            if (conexion.val(query) == true) // Verifica si la consulta tiene resultados.
            {
                query = "SELECT MAX(IdConProv) FROM ContactoProveedor"; // Cambia la consulta para obtener el valor máximo de IdConProv.
                reader = conexion.leerdato(query); // Ejecuta la consulta y asigna el resultado al lector.
                while (reader.Read()) // Lee los datos del lector.
                {
                    lblCodContProv.Text = Convert.ToString(Convert.ToInt32(reader.GetValue(0)) + 1); // Incrementa el valor y lo asigna al label lblCodContProv.
                }
                reader.Close(); // Cierra el lector.
            }
            else
            {
                lblCodContProv.Text = "1"; // Si no hay resultados, asigna "1" al label lblCodContProv.
            }
        }

        private void btnGuardarContProveedor_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de guardar contacto proveedor.
        {
            if (txtNombreContProveedor.Text == "" || txtTelefonoContProveedor.Text == "" || txtDireccionContProveedor.Text == "") // Verifica si alguno de los campos está vacío.
            {
                MessageBox.Show("Datos Incompletos"); // Muestra un mensaje de error.
                return; // Termina la ejecución del método.
            }
            else
            {

            }

            int IdConProv = int.Parse(lblCodContProv.Text); // Convierte el texto del label lblCodContProv a entero.
            string NomConProv = txtNombreContProveedor.Text; // Asigna el texto del campo txtNombreContProveedor a una variable.
            int TelConProv = int.Parse(txtTelefonoContProveedor.Text); // Convierte el texto del campo txtTelefonoContProveedor a entero.
            string EmlConProv = txtDireccionContProveedor.Text; // Asigna el texto del campo txtDireccionContProveedor a una variable.
            bool EstConProv = true; // Asigna true a la variable EstConProv.
            int IdProv_ConProv = (int)cbxCodProv_ConProv.SelectedValue; // Convierte el valor seleccionado del combo box a entero.

            conexion.Modificaciones("exec Insertar_ContactoProveedores '" + IdConProv + " ', ' " + NomConProv + " ', ' " + TelConProv + " ', ' " + EmlConProv + " ', ' " + EstConProv + " ', ' " + IdProv_ConProv + " '  "); // Ejecuta la consulta para insertar el contacto proveedor.
            MessageBox.Show("El contacto proveedor ha sido GUARDADO correctamente"); // Muestra un mensaje de confirmación.
            Autonum(); // Llama al método Autonum para actualizar el ID.
            txtNombreContProveedor.Clear(); // Limpia el campo txtNombreContProveedor.
            txtTelefonoContProveedor.Clear(); // Limpia el campo txtTelefonoContProveedor.
            txtDireccionContProveedor.Clear(); // Limpia el campo txtDireccionContProveedor.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
            string accion = "Se agregó un contacto proveedor"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar en la bitácora.
            conexion.Busquedas("exec VisContactoProveedor", dgvContProveedor, "NombConProv LIKE '%" + txtBuscarContProveedor.Text + "%*' "); // Ejecuta la consulta para buscar y mostrar los contactos proveedores.
        }

        private void btnModificarContProveedor_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de modificar contacto proveedor.
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Verifica si el usuario logueado es administrador.
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje de error si no tiene permisos.
                return; // Termina la ejecución del método.
            }

            if (txtNombreContProveedor.Text == "" || txtTelefonoContProveedor.Text == "" || txtDireccionContProveedor.Text == "") // Verifica si alguno de los campos está vacío.
            {
                MessageBox.Show("Datos Incompletos"); // Muestra un mensaje de error.
                return; // Termina la ejecución del método.
            }
            else
            {

            }
            int IdConProv = int.Parse(lblCodContProv.Text); // Convierte el texto del label lblCodContProv a entero.
            string NomConProv = txtNombreContProveedor.Text; // Asigna el texto del campo txtNombreContProveedor a una variable.
            int TelConProv = int.Parse(txtTelefonoContProveedor.Text); // Convierte el texto del campo txtTelefonoContProveedor a entero.
            string EmlConProv = txtDireccionContProveedor.Text; // Asigna el texto del campo txtDireccionContProveedor a una variable.
            bool EstConProv = true; // Asigna true a la variable EstConProv.
            int IdProv_ConProv = (int)cbxCodProv_ConProv.SelectedValue; // Convierte el valor seleccionado del combo box a entero.

            conexion.Modificaciones("exec Actualizar_ContactoProveedores '" + IdConProv + " ', ' " + NomConProv + " ', ' " + TelConProv + " ', ' " + EmlConProv + " ', ' " + EstConProv + " ', ' " + IdProv_ConProv + " ' "); // Ejecuta la consulta para actualizar el contacto proveedor.
            MessageBox.Show("El contacto proveedor ha sido ACTUALIZADO correctamente"); // Muestra un mensaje de confirmación.
            Autonum(); // Llama al método Autonum para actualizar el ID.
            txtNombreContProveedor.Clear(); // Limpia el campo txtNombreContProveedor.
            txtTelefonoContProveedor.Clear(); // Limpia el campo txtTelefonoContProveedor.
            txtDireccionContProveedor.Clear(); // Limpia el campo txtDireccionContProveedor.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
            string accion = "Se actualizó un contacto proveedor"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar en la bitácora.
            conexion.Busquedas("exec VisContactoProveedor", dgvContProveedor, "NombConProv LIKE '%" + txtBuscarContProveedor.Text + "%*' "); // Ejecuta la consulta para buscar y mostrar los contactos proveedores.
        }

        private void btnEliminarContProveedor_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de eliminar contacto proveedor.
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR este contacto proveedor?", "Eliminar contacto proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes) // Muestra un mensaje de confirmación.
            {
                int IdConProv = int.Parse(lblCodContProv.Text); // Obtiene el ID del contacto proveedor desde el label.
                conexion.Modificaciones("exec Eliminar_ContactoProveedores '" + IdConProv + "'"); // Ejecuta la consulta para eliminar el contacto proveedor.
                MessageBox.Show("El contacto proveedor ha sido ELIMINADO"); // Muestra un mensaje de confirmación.
                Autonum(); // Actualiza el ID del contacto proveedor.

                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
                string accion = "Se eliminó un contacto proveedor"; // Define la acción realizada.
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.

                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Registra la acción en la bitácora.
                conexion.Busquedas("exec VisContactoProveedor", dgvContProveedor, "NombConProv LIKE '%" + txtBuscarContProveedor.Text + "%*' "); // Actualiza la vista de contactos proveedores.
            }
        }

        private void txtBuscarContProveedor_TextChanged(object sender, EventArgs e) // Evento que se dispara al cambiar el texto en el campo de búsqueda de contactos proveedores.
        {
            conexion.Busquedas("exec VisContactoProveedor", dgvContProveedor, "NombConProv LIKE '%" + txtBuscarContProveedor.Text + "%*' "); // Realiza una búsqueda según el texto ingresado.
        }

        private void cbxCodProv_ConProv_SelectedIndexChanged(object sender, EventArgs e) // Evento que se dispara al cambiar la selección en el combo box de códigos de proveedores.
        {
            // No hay acciones específicas en este evento.
        }

        private void FrmContactoProveedor_Load(object sender, EventArgs e) // Evento que se dispara al cargar el formulario de contacto proveedor.
        {
            Autonum(); // Actualiza el ID del contacto proveedor.
            conexion.mostrasproveedores(cbxCodProv_ConProv); // Muestra los proveedores en el combo box.
        }

        private void btnRegresarProveedores_ContProv_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de regresar a proveedores.
        {
            Form G = new FrmProveedores(); // Crea una instancia del formulario de proveedores.
            G.Show(); // Muestra el formulario de proveedores.
        }

        private void cbConProv_CheckedChanged(object sender, EventArgs e) // Evento que se dispara al cambiar el estado del checkbox de contacto proveedor.
        {
            // No hay acciones específicas en este evento.
        }

        private void dgvContProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e) // Evento que se dispara al hacer clic en el contenido de una celda en el DataGridView de contactos proveedores.
        {
            try
            {
                lblCodContProv.Text = dgvContProveedor.CurrentRow.Cells[0].Value.ToString(); // Obtiene el ID del contacto proveedor seleccionado.
                txtNombreContProveedor.Text = dgvContProveedor.CurrentRow.Cells[1].Value.ToString(); // Obtiene el nombre del contacto proveedor seleccionado.
                txtTelefonoContProveedor.Text = dgvContProveedor.CurrentRow.Cells[2].Value.ToString(); // Obtiene el teléfono del contacto proveedor seleccionado.
                txtDireccionContProveedor.Text = dgvContProveedor.CurrentRow.Cells[3].Value.ToString(); // Obtiene la dirección del contacto proveedor seleccionado.
                cbxCodProv_ConProv.SelectedValue = dgvContProveedor.CurrentRow.Cells[5].Value; // Selecciona el código del proveedor relacionado con el contacto proveedor seleccionado.
            }
            catch
            {

            }
        }

        private void txtTelefonoContProveedor_KeyPress(object sender, KeyPressEventArgs e) // Evento que se dispara al presionar una tecla en el campo de teléfono del contacto proveedor.
        {
            Conexión.SoloNumeros(e); // Permite solo la entrada de números en el campo de teléfono.
        }

        private void btnDesactivaContProveedores_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de desactivar contacto proveedor.
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado))  // Verifica si el usuario actual es administrador.
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje de advertencia.
                return; // Finaliza el método.
            }

            if (txtNombreContProveedor.Text == "" || txtTelefonoContProveedor.Text == "" || txtDireccionContProveedor.Text == "") // Verifica si los campos de nombre, teléfono y dirección del contacto proveedor están vacíos.
            {
                MessageBox.Show("Datos Incompletos"); // Muestra un mensaje de advertencia.
                return; // Finaliza el método.
            }
            else
            {
                // No hace nada si los campos no están vacíos.
            }

            int IdConProv = int.Parse(lblCodContProv.Text); // Obtiene el ID del contacto proveedor.
            string NomConProv = txtNombreContProveedor.Text;  // Obtiene el nombre del contacto proveedor.
            int TelConProv = int.Parse(txtTelefonoContProveedor.Text); // Obtiene el teléfono del contacto proveedor.
            string EmlConProv = txtDireccionContProveedor.Text;  // Obtiene la dirección del contacto proveedor.
            bool EstConProv = false; // Establece el estado del contacto proveedor como inactivo.
            int IdProv_ConProv = (int)cbxCodProv_ConProv.SelectedValue; // Obtiene el ID del proveedor del contacto proveedor.

            // Ejecuta la consulta para desactivar el contacto proveedor.
            conexion.Modificaciones("exec Desactivar_ContactoProveedores '" + IdConProv + " ', ' " + NomConProv + " ', ' " + TelConProv + " ', ' " + EmlConProv + " ', ' " + EstConProv + " ', ' " + IdProv_ConProv + " ' "); 
            MessageBox.Show("El contacto proveedor ha sido DESACTIVADO correctamente"); // Muestra un mensaje de éxito.
            Autonum(); // Actualiza el número de identificación del contacto proveedor.
            txtNombreContProveedor.Clear(); // Limpia el campo de nombre del contacto proveedor.
            txtTelefonoContProveedor.Clear(); // Limpia el campo de teléfono del contacto proveedor.
            txtDireccionContProveedor.Clear(); // Limpia el campo de dirección del contacto proveedor.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
            string accion = "Se desactivó un contacto proveedor"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actual.

            // Registra la acción en la bitácora.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");
            // Realiza una búsqueda y actualiza el DataGridView de contactos proveedores.
            conexion.Busquedas("exec VisContactoProveedor", dgvContProveedor, "NombConProv LIKE '%" + txtBuscarContProveedor.Text + "%*' ");
        }

        private void dgvContProveedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) // Este evento se dispara cuando se formatea una celda en el DataGridView dgvContProveedor.
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0) // Verifica si el índice de la columna y fila es válido.
            {
                bool estado = Convert.ToBoolean(dgvContProveedor.Rows[e.RowIndex].Cells["estConProvDataGridViewCheckBoxColumn"].Value); // Obtiene el estado del contacto proveedor de la celda.

                if (estado) // Asigna un color de fondo diferente según el estado del contacto proveedor.
                {
                    dgvContProveedor.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkCyan; // Establece el color de fondo como cian oscuro.
                }
                else
                {
                    dgvContProveedor.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray; // Establece el color de fondo como gris.
                }
            }
        }
    }
}
