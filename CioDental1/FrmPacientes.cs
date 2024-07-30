using System; // Importa el namespace System que contiene clases fundamentales.
using System.Collections.Generic; // Importa el namespace para trabajar con colecciones genéricas.
using System.ComponentModel; // Importa el namespace que permite el manejo de componentes.
using System.Data; // Importa el namespace que contiene clases para trabajar con datos.
using System.Data.SqlClient; // Importa el namespace para trabajar con SQL Server.
using System.Drawing; // Importa el namespace para trabajar con gráficos.
using System.Linq; // Importa el namespace para trabajar con consultas LINQ.
using System.Text; // Importa el namespace para trabajar con operaciones de texto.
using System.Threading.Tasks; // Importa el namespace para trabajar con tareas asíncronas.
using System.Windows.Forms; // Importa el namespace para trabajar con formularios de Windows.
using System.Windows.Shapes; // Importa el namespace para trabajar con formas gráficas.
using static CioDental1.Conexión; // Importa la clase Conexión de forma estática para acceder a sus miembros directamente.

namespace CioDental1 // Define el namespace CioDental1.
{
    public partial class FrmPacientes : Form // Define la clase FrmPacientes que hereda de Form.
    {
        public FrmPacientes() // Define el constructor de la clase FrmPacientes.
        {
            InitializeComponent(); // Llama al método InitializeComponent para inicializar los componentes del formulario.
        }
        Conexión conexion = new Conexión(); // Crea una instancia de la clase Conexión.

        private void Autonum() // Define el método Autonum para generar el ID del paciente automáticamente.
        {
            SqlDataReader reader = null; // Declara un objeto SqlDataReader y lo inicializa en null.
            string query = "SELECT IdPac FROM PACIENTES"; // Define una consulta SQL para seleccionar IdPac de la tabla PACIENTES.
            if (conexion.val(query) == true) // Verifica si la consulta devuelve algún resultado.
            {
                query = "SELECT MAX(IdPac) FROM PACIENTES"; // Define una consulta SQL para seleccionar el máximo IdPac de la tabla PACIENTES.
                reader = conexion.leerdato(query); // Ejecuta la consulta y obtiene el resultado en el objeto reader.
                while (reader.Read()) // Lee el resultado de la consulta.
                {
                    lblCodPac.Text = Convert.ToString(Convert.ToInt32(reader.GetValue(0))+1); // Convierte el valor obtenido a entero, le suma 1 y lo asigna a lblCodPac.
                }
                reader.Close(); // Cierra el objeto reader.
            }
            else
            {
                lblCodPac.Text = "1"; // Si no hay resultados, asigna "1" a lblCodPac.
            }
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e) // Define el evento click del botón btnGuardarPaciente.
        {
            if (txtNombrePaciente.Text == "" || txtApellidoPaciente.Text == "" || txtDireccionPaciente.Text=="" || txtTelefonoPaciente.Text == "" || txtCorreoPaciente.Text == "") // Verifica si alguno de los campos está vacío.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje si algún campo está vacío.
                return; // Sale del método.
            }
            else
            {
                // Aquí podría ir alguna lógica adicional en caso de que todos los campos estén completos.
            }

            string IdPac = lblCodPac.Text; // Asigna el valor de lblCodPac a la variable IdPac.
            string NomPac = txtNombrePaciente.Text; // Asigna el texto de txtNombrePaciente a la variable NomPac.
            string ApePac = txtApellidoPaciente.Text; // Asigna el texto de txtApellidoPaciente a la variable ApePac.
            string GenPac; // Declara la variable GenPac.
            GenPac = "Masculino"; // Inicializa GenPac con "Masculino".
            if (cbxGeneroPaciente.Text=="Masculino") // Verifica si el texto de cbxGeneroPaciente es "Masculino".
            {
                GenPac="Masculino"; // Asigna "Masculino" a GenPac.
            }
            else if (cbxGeneroPaciente.Text=="Femenino") // Verifica si el texto de cbxGeneroPaciente es "Femenino".
            {
                GenPac="Femenino"; // Asigna "Femenino" a GenPac.
            }
            DateTime FecNacPac = dtpFechaNacPaciente.Value; // Asigna el valor de dtpFechaNacPaciente a FecNacPac.
            string DirPac = txtDireccionPaciente.Text; // Asigna el texto de txtDireccionPaciente a la variable DirPac.
            int TelPac = int.Parse(txtTelefonoPaciente.Text); // Convierte el texto de txtTelefonoPaciente a entero y lo asigna a TelPac.
            string EmlPac = txtCorreoPaciente.Text; // Asigna el texto de txtCorreoPaciente a la variable EmlPac.

            conexion.Modificaciones("exec Insertar_Pacientes '" + IdPac + " ', ' " + NomPac + " ', ' " + ApePac + " ', ' " + GenPac + " ', ' " + FecNacPac +" ', ' " + DirPac + " ', ' " + TelPac + " ', ' " + EmlPac + " ' "); // Ejecuta la consulta para insertar un nuevo paciente en la base de datos.
            MessageBox.Show("El paciente ha sido GUARDADO correctamente"); // Muestra un mensaje indicando que el paciente ha sido guardado.
            Autonum(); // Llama al método Autonum para actualizar el ID del paciente.
            txtNombrePaciente.Clear(); // Limpia el texto de txtNombrePaciente.
            txtApellidoPaciente.Clear(); // Limpia el texto de txtApellidoPaciente.
            dtpFechaNacPaciente.ResetText(); // Resetea el texto de dtpFechaNacPaciente.
            txtDireccionPaciente.Clear(); // Limpia el texto de txtDireccionPaciente.
            txtTelefonoPaciente.Clear(); // Limpia el texto de txtTelefonoPaciente.
            txtCorreoPaciente.Clear(); // Limpia el texto de txtCorreoPaciente.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual y la asigna a la variable hora.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual y la asigna a la variable fecha.
            string accion = "Se agregó un paciente"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado y lo asigna a la variable usuario.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar una nueva bitácora en la base de datos.
            conexion.Busquedas("exec VistaPacientes", dgvPacientes, "NomPac LIKE '%" + txtBuscarPacientes.Text + "%*' "); // Ejecuta la consulta para buscar pacientes y mostrar el resultado en dgvPacientes.
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e) // Define el evento click del botón btnModificarPaciente.
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Verifica si el usuario logueado es administrador.
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje si el usuario no tiene permiso.
                return; // Sale del método.
            }

            if (txtNombrePaciente.Text == "" || txtApellidoPaciente.Text == "" || txtDireccionPaciente.Text == "" || txtTelefonoPaciente.Text == "" || txtCorreoPaciente.Text == "") // Verifica si alguno de los campos está vacío.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje si algún campo está vacío.
                return; // Sale del método.
            }
            else
            {
                // Aquí podría ir alguna lógica adicional en caso de que todos los campos estén completos.
            }

            int IdPac = int.Parse(lblCodPac.Text); // Convierte el texto de lblCodPac a entero y lo asigna a IdPac.
            string NomPac = txtNombrePaciente.Text; // Asigna el texto de txtNombrePaciente a la variable NomPac.
            string ApePac = txtApellidoPaciente.Text; // Asigna el texto de txtApellidoPaciente a la variable ApePac.
            string GenPac; // Declara la variable GenPac.
            GenPac = "Masculino"; // Inicializa GenPac con "Masculino".
            if (cbxGeneroPaciente.Text == "Masculino") // Verifica si el texto de cbxGeneroPaciente es "Masculino".
            {
                GenPac = "Masculino"; // Asigna "Masculino" a GenPac.
            }
            else if (cbxGeneroPaciente.Text == "Femenino") // Verifica si el texto de cbxGeneroPaciente es "Femenino".
            {
                GenPac = "Femenino"; // Asigna "Femenino" a GenPac.
            }
            DateTime FecNacPac = dtpFechaNacPaciente.Value; // Asigna el valor de dtpFechaNacPaciente a FecNacPac.
            string DirPac = txtDireccionPaciente.Text; // Asigna el texto de txtDireccionPaciente a la variable DirPac.
            int TelPac = int.Parse(txtTelefonoPaciente.Text); // Convierte el texto de txtTelefonoPaciente a entero y lo asigna a TelPac.
            string EmlPac = txtCorreoPaciente.Text; // Asigna el texto de txtCorreoPaciente a la variable EmlPac.

            conexion.Modificaciones("exec Actualizar_Pacientes '" + IdPac + " ', ' " + NomPac + " ', ' " + ApePac + " ', ' " + GenPac + " ', ' " + FecNacPac + " ', ' " + DirPac + " ', ' " + TelPac + " ', ' " + EmlPac + " ' "); // Ejecuta la consulta para actualizar el paciente en la base de datos.
            MessageBox.Show("El paciente ha sido ACTUALIZADO correctamente"); // Muestra un mensaje indicando que el paciente ha sido actualizado.
            Autonum(); // Llama al método Autonum para actualizar el ID del paciente.
            txtNombrePaciente.Clear(); // Limpia el texto de txtNombrePaciente.
            txtApellidoPaciente.Clear(); // Limpia el texto de txtApellidoPaciente.
            dtpFechaNacPaciente.ResetText(); // Resetea el texto de dtpFechaNacPaciente.
            txtDireccionPaciente.Clear(); // Limpia el texto de txtDireccionPaciente.
            txtTelefonoPaciente.Clear(); // Limpia el texto de txtTelefonoPaciente.
            txtCorreoPaciente.Clear(); // Limpia el texto de txtCorreoPaciente.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual y la asigna a la variable hora.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual y la asigna a la variable fecha.
            string accion = "Se actualizó un paciente"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado y lo asigna a la variable usuario.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar una nueva bitácora en la base de datos.
            conexion.Busquedas("exec VistaPacientes", dgvPacientes, "NomPac LIKE '%" + txtBuscarPacientes.Text + "%*' "); // Ejecuta la consulta para buscar pacientes y mostrar el resultado en dgvPacientes.
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e) // Define el evento click del botón btnEliminarPaciente.
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR este paciente?", "Eliminar paciente", MessageBoxButtons.YesNo) == DialogResult.Yes) // Muestra un mensaje de confirmación para eliminar el paciente.
            {
                string IdPac = lblCodPac.Text; // Asigna el valor de lblCodPac a la variable IdPac.
                conexion.Modificaciones("exec Eliminar_Pacientes '" + IdPac + "'"); // Ejecuta la consulta para eliminar el paciente de la base de datos.
                MessageBox.Show("El paciente ha sido ELIMINADO"); // Muestra un mensaje indicando que el paciente ha sido eliminado.
                Autonum(); // Llama al método Autonum para actualizar el ID del paciente.

                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual y la asigna a la variable hora.
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual y la asigna a la variable fecha.
                string accion = "Se eliminó un paciente"; // Define la acción realizada.
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado y lo asigna a la variable usuario.

                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar una nueva bitácora en la base de datos.
                conexion.Busquedas("exec VistaPacientes", dgvPacientes, "NomPac LIKE '%" + txtBuscarPacientes.Text + "%*' "); // Ejecuta la consulta para buscar pacientes y mostrar el resultado en dgvPacientes.
            }
        }

        private void txtBuscarPacientes_TextChanged(object sender, EventArgs e) // Define el evento TextChanged del textbox txtBuscarPacientes.
        {
            string[] nombres = txtBuscarPacientes.Text.Split(' '); // Divide el texto del textbox en palabras.
            string nombre = nombres.Length > 0 ? nombres[0] : ""; // Asigna la primera palabra a la variable nombre.
            string apellido = nombres.Length > 1 ? nombres[1] : ""; // Asigna la segunda palabra a la variable apellido si existe.

            conexion.Busquedas("exec VistaPacientes", dgvPacientes, "NomPac LIKE '%" + nombre + "%' AND ApePac LIKE '%" + apellido + "%'"); // Ejecuta la consulta para buscar pacientes y mostrar el resultado en dgvPacientes.
        }

        private void btnSalirPaciente_Click(object sender, EventArgs e) // Define el evento click del botón btnSalirPaciente.
        {
            Form MP = new FrmMenuPrincipal(); // Crea una instancia del formulario FrmMenuPrincipal.
            MP.Show(); // Muestra el formulario FrmMenuPrincipal.
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e) // Define el evento CellContentClick del DataGridView dgvPacientes.
        {
            try // Inicia un bloque try para manejar excepciones.
            {
                lblCodPac.Text = dgvPacientes.CurrentRow.Cells[0].Value.ToString(); // Asigna el valor de la primera celda de la fila seleccionada a lblCodPac.
                txtNombrePaciente.Text = dgvPacientes.CurrentRow.Cells[1].Value.ToString(); // Asigna el valor de la segunda celda a txtNombrePaciente.
                txtApellidoPaciente.Text = dgvPacientes.CurrentRow.Cells[2].Value.ToString(); // Asigna el valor de la tercera celda a txtApellidoPaciente.
                cbxGeneroPaciente.SelectedValue = dgvPacientes.CurrentRow.Cells[3].Value; // Asigna el valor de la cuarta celda a cbxGeneroPaciente.
                dtpFechaNacPaciente.Value = (DateTime)dgvPacientes.CurrentRow.Cells[4].Value; // Asigna el valor de la quinta celda a dtpFechaNacPaciente.
                txtDireccionPaciente.Text = dgvPacientes.CurrentRow.Cells[5].Value.ToString(); // Asigna el valor de la sexta celda a txtDireccionPaciente.
                txtTelefonoPaciente.Text = dgvPacientes.CurrentRow.Cells[6].Value.ToString(); // Asigna el valor de la séptima celda a txtTelefonoPaciente
                txtCorreoPaciente.Text = dgvPacientes.CurrentRow.Cells[7].Value.ToString(); // Asigna el valor de la octava celda a txtCorreoPaciente.
            }
            catch // Inicia un bloque catch para manejar excepciones que puedan ocurrir en el bloque try.
            {
                // Maneja cualquier excepción que ocurra en el bloque try. Actualmente está vacío, lo cual significa que se ignoran las excepciones.
            }
        }

        private void FrmPacientes_Load(object sender, EventArgs e) // Define el evento Load del formulario FrmPacientes.
        {
            Autonum(); // Llama al método Autonum para inicializar el ID del paciente cuando el formulario se carga.
        }

        private void txtTelefonoPaciente_KeyPress(object sender, KeyPressEventArgs e) // Define el evento KeyPress del textbox txtTelefonoPaciente.
        {
            Conexión.SoloNumeros(e); // Llama al método SoloNumeros de la clase Conexión para permitir solo la entrada de números en txtTelefonoPaciente.
        }
    }
}
