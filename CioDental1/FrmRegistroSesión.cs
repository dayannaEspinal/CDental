using System; // Importa el espacio de nombres System, que contiene clases fundamentales y servicios del tiempo de ejecución.
using System.Collections.Generic; // Importa el espacio de nombres System.Collections.Generic, que proporciona interfaces y clases que definen colecciones genéricas.
using System.ComponentModel; // Importa el espacio de nombres System.ComponentModel, que contiene interfaces que se utilizan para implementar el comportamiento de componentes y controles.
using System.Data; // Importa el espacio de nombres System.Data, que proporciona acceso a clases que representan la arquitectura de datos ADO.NET.
using System.Drawing; // Importa el espacio de nombres System.Drawing, que proporciona acceso a GDI+ básico.
using System.Linq; // Importa el espacio de nombres System.Linq, que proporciona clases y interfaces que admiten consultas que utilizan LINQ.
using System.Text; // Importa el espacio de nombres System.Text, que contiene clases que representan codificaciones de caracteres Unicode y ANSI, así como clases para manipular cadenas de texto y bytes.
using System.Threading.Tasks; // Importa el espacio de nombres System.Threading.Tasks, que proporciona clases e interfaces que permiten la implementación de programación asincrónica y paralela.
using System.Windows.Forms; // Importa el espacio de nombres System.Windows.Forms, que contiene clases para crear aplicaciones de Windows que aprovechan las características y capacidades de la plataforma Windows.

using static CioDental1.Conexión; // Importa la clase Conexión del espacio de nombres CioDental1 como estática.

namespace CioDental1 // Declara un espacio de nombres llamado CioDental1.
{
    public partial class FrmRegistroSesión : Form // Declara una clase parcial llamada FrmRegistroSesión que hereda de Form.
    {
        public FrmRegistroSesión() // Define un constructor para la clase FrmRegistroSesión.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }
        Conexión conexion = new Conexión(); // Crea una instancia de la clase Conexión.

        private void btnRegresarRegistros_Click(object sender, EventArgs e) // Define un método para manejar el evento Click del botón btnRegresarRegistros.
        {
            Form R = new FrmMenuPrincipal(); // Crea una nueva instancia del formulario FrmMenuPrincipal y la asigna a la variable R.
            R.Show(); // Muestra el formulario R.
        }

        private void btnRegistrarseRegistros_Click(object sender, EventArgs e) // Define un método para manejar el evento Click del botón btnRegistrarseRegistros.
        {
            string Usuario = txtNombreRegistro.Text; // Obtiene el texto del cuadro de texto txtNombreRegistro y lo asigna a la variable Usuario.
            string Contraseña = txtContraseñaRegistro.Text; // Obtiene el texto del cuadro de texto txtContraseñaRegistro y lo asigna a la variable Contraseña.
            bool Estado = true; // Define un valor booleano verdadero y lo asigna a la variable Estado.
            string RolUsuario; // Declara una variable llamada RolUsuario.
            RolUsuario= "Administrador"; // Asigna "Administrador" a la variable RolUsuario.
            if (cbxRolUsuario.Text=="Administrador") // Comprueba si el texto seleccionado en cbxRolUsuario es "Administrador".
            {
                RolUsuario="Administrador"; // Si es así, asigna "Administrador" a la variable RolUsuario.
            }
            else if (cbxRolUsuario.Text=="Colaborador") // Comprueba si el texto seleccionado en cbxRolUsuario es "Colaborador".
            {
                RolUsuario="Colaborador"; // Si es así, asigna "Colaborador" a la variable RolUsuario.
            }
            conexion.Modificaciones("exec Insertar_Usuarios  '" + Usuario + "','" + Contraseña + "', '" + Estado + "','"+ RolUsuario +"'"); // Llama al método Modificaciones de la instancia de la clase Conexión para insertar un usuario en la base de datos.
            MessageBox.Show("Su usuario se ha guardado satisfactoriamente"); // Muestra un mensaje de éxito.
            txtNombreRegistro.Clear(); // Borra el texto del cuadro de texto txtNombreRegistro.
            txtContraseñaRegistro.Clear(); // Borra el texto del cuadro de texto txtContraseñaRegistro.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena y la asigna a la variable hora.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena y la asigna a la variable fecha.
            string accion = "Se registró un usuario"; // Define una cadena que describe la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actualmente autenticado y lo asigna a la variable usuario.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Llama al método Modificaciones de la instancia de la clase Conexión para insertar una entrada en la tabla de bitácoras.
            conexion.Busquedas("exec VistaUsuario", dgvUsuario, "NomUsr LIKE '%" + txtBuscarUsuario.Text + "%*' "); // Realiza una búsqueda en la base de datos y muestra los resultados en el control DataGridView dgvUsuario.
        }

        private void btnModificarRegistros_Click(object sender, EventArgs e) // Define un método para manejar el evento Click del botón btnModificarRegistros.
        {
            string Usuario = txtNombreRegistro.Text; // Obtiene el texto del cuadro de texto txtNombreRegistro y lo asigna a la variable Usuario.
            string Contraseña = txtContraseñaRegistro.Text; // Obtiene el texto del cuadro de texto txtContraseñaRegistro y lo asigna a la variable Contraseña.
            bool Estado = true; // Define un valor booleano verdadero y lo asigna a la variable Estado.
            string RolUsuario; // Declara una variable llamada RolUsuario.
            RolUsuario= "Administrador"; // Asigna "Administrador" a la variable RolUsuario.
            if (cbxRolUsuario.Text=="Administrador") // Comprueba si el texto seleccionado en cbxRolUsuario es "Administrador".
            {
                RolUsuario="Administrador"; // Si es así, asigna "Administrador" a la variable RolUsuario.
            }
            else if (cbxRolUsuario.Text=="Colaborador") // Comprueba si el texto seleccionado en cbxRolUsuario es "Colaborador".
            {
                RolUsuario="Colaborador"; // Si es así, asigna "Colaborador" a la variable RolUsuario.
            }
            conexion.Modificaciones("exec Actualizar_Usuarios  '" + Usuario + "','" + Contraseña + "', '" + Estado + "','"+ RolUsuario +"'"); // Llama al método Modificaciones de la instancia de la clase Conexión para actualizar un usuario en la base de datos.
            MessageBox.Show("El usuario se ha actualizado satisfactoriamente"); // Muestra un mensaje de éxito.
            txtNombreRegistro.Clear(); // Borra el texto del cuadro de texto txtNombreRegistro.
            txtContraseñaRegistro.Clear(); // Borra el texto del cuadro de texto txtContraseñaRegistro.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena y la asigna a la variable hora.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena y la asigna a la variable fecha.
            string accion = "Se actualizó un usuario"; // Define una cadena que describe la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actualmente autenticado y lo asigna a la variable usuario.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Llama al método Modificaciones de la instancia de la clase Conexión para insertar una entrada en la tabla de bitácoras.
            conexion.Busquedas("exec VistaUsuario", dgvUsuario, "NomUsr LIKE '%" + txtBuscarUsuario.Text + "%*' "); // Realiza una búsqueda en la base de datos y muestra los resultados en el control DataGridView dgvUsuario.
        }

        private void btnBorrarRegistros_Click(object sender, EventArgs e) // Define un método para manejar el evento Click del botón btnBorrarRegistros.
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes) // Muestra un mensaje de confirmación para confirmar la eliminación del usuario.
            {
                string Nombre = txtNombreRegistro.Text; // Obtiene el texto del cuadro de texto txtNombreRegistro y lo asigna a la variable Nombre.
                conexion.Modificaciones("exec Eliminar_Usuarios '" + Nombre + "'"); // Llama al método Modificaciones de la instancia de la clase Conexión para eliminar un usuario de la base de datos.
                MessageBox.Show("El Usuario ha sido eliminado"); // Muestra un mensaje de éxito.
                txtNombreRegistro.Clear(); // Borra el texto del cuadro de texto txtNombreRegistro.

                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena y la asigna a la variable hora.
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena y la asigna a la variable fecha.
                string accion = "Se eliminó un usuario"; // Define una cadena que describe la acción realizada.
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actualmente autenticado y lo asigna a la variable usuario.

                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Llama al método Modificaciones de la instancia de la clase Conexión para insertar una entrada en la tabla de bitácoras.
            }
        }

        private void cbEstRegUsr_CheckedChanged(object sender, EventArgs e)
        {
            // Este método maneja el evento CheckedChanged del CheckBox cbEstRegUsr.
            // No realiza ninguna operación específica en este momento.
        }

        private void FrmRegistroSesión_Load(object sender, EventArgs e)
        {
            // Este método maneja el evento Load del formulario FrmRegistroSesión.
            // No realiza ninguna operación específica en este momento.
        }

        private void btnDesactivarUsuario_Click(object sender, EventArgs e)
        {
            // Este método maneja el evento Click del botón btnDesactivarUsuario.
            string Usuario = txtNombreRegistro.Text; // Obtiene el texto del cuadro de texto txtNombreRegistro y lo asigna a la variable Usuario.
            string Contraseña = txtContraseñaRegistro.Text; // Obtiene el texto del cuadro de texto txtContraseñaRegistro y lo asigna a la variable Contraseña.
            bool Estado = false; // Define un valor booleano falso y lo asigna a la variable Estado.
            string RolUsuario; // Declara una variable llamada RolUsuario.
            RolUsuario = "Administrador"; // Asigna "Administrador" a la variable RolUsuario.
            if (cbxRolUsuario.Text == "Administrador") // Comprueba si el texto seleccionado en cbxRolUsuario es "Administrador".
            {
                RolUsuario = "Administrador"; // Si es así, asigna "Administrador" a la variable RolUsuario.
            }
            else if (cbxRolUsuario.Text == "Colaborador") // Comprueba si el texto seleccionado en cbxRolUsuario es "Colaborador".
            {
                RolUsuario = "Colaborador"; // Si es así, asigna "Colaborador" a la variable RolUsuario.
            }
            conexion.Modificaciones("exec Desactivar_Usuarios  '" + Usuario + "','" + Contraseña + "', '" + Estado + "','" + RolUsuario + "'"); // Llama al método Modificaciones de la instancia de la clase Conexión para desactivar un usuario en la base de datos.
            MessageBox.Show("El usuario se ha DESACTIVADO satisfactoriamente"); // Muestra un mensaje de éxito.
            txtNombreRegistro.Clear(); // Borra el texto del cuadro de texto txtNombreRegistro.
            txtContraseñaRegistro.Clear(); // Borra el texto del cuadro de texto txtContraseñaRegistro.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena y la asigna a la variable hora.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena y la asigna a la variable fecha.
            string accion = "Se desactivó un usuario"; // Define una cadena que describe la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actualmente autenticado y lo asigna a la variable usuario.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Llama al método Modificaciones de la instancia de la clase Conexión para insertar una entrada en la tabla de bitácoras.
            conexion.Busquedas("exec VistaUsuario", dgvUsuario, "NomUsr LIKE '%" + txtBuscarUsuario.Text + "%*' "); // Realiza una búsqueda en la base de datos y muestra los resultados en el control DataGridView dgvUsuario.
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Este método maneja el evento TextChanged del cuadro de texto textBox1.
        {
            conexion.Busquedas("exec VistaUsuario", dgvUsuario, "NomUsr LIKE '%" + txtBuscarUsuario.Text + "%*' "); // Realiza una búsqueda en la base de datos y muestra los resultados en el control DataGridView dgvUsuario.
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e) // Este método maneja el evento CellClick del control DataGridView dgvUsuario.
        {
            try
            {
                // Intenta obtener los valores de las celdas seleccionadas en el DataGridView.
                txtNombreRegistro.Text = dgvUsuario.CurrentRow.Cells[0].Value.ToString(); // Obtiene el nombre del usuario de la celda seleccionada y lo muestra en el cuadro de texto txtNombreRegistro.
                txtContraseñaRegistro.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString(); // Obtiene la contraseña del usuario de la celda seleccionada y la muestra en el cuadro de texto txtContraseñaRegistro.
                cbxRolUsuario.SelectedValue = dgvUsuario.CurrentRow.Cells[3].Value; // Obtiene el rol del usuario de la celda seleccionada y lo muestra en el ComboBox cbxRolUsuario.
            }
            catch
            {
                // Captura cualquier excepción que pueda ocurrir.
            }
        }

        private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) // Este método maneja el evento CellFormatting del control DataGridView dgvUsuario.
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0) // Cambia el color de fondo de las filas del DataGridView dependiendo del estado del usuario (activo o inactivo).
            {
                bool estado = Convert.ToBoolean(dgvUsuario.Rows[e.RowIndex].Cells["estUsrDataGridViewCheckBoxColumn"].Value); // Obtiene el estado del usuario de la celda seleccionada.

                if (estado)
                {
                    dgvUsuario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkCyan; // Si el usuario está activo, establece el color de fondo de la fila en Color.DarkCyan.
                }
                else
                {
                    dgvUsuario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray; // Si el usuario está inactivo, establece el color de fondo de la fila en Color.Gray.
                }
            }
        }
    }
}
