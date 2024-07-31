using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; 
using System.Data.SqlClient; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement; 
using static CioDental1.Conexión; 

namespace CioDental1 
{
    public partial class FrmInicioSesión : Form
    {
        public FrmInicioSesión() 
        {
            InitializeComponent(); 
        }

        Conexión conexion = new Conexión(); 

        SqlConnection sqlCon = new SqlConnection("Data Source=localhost; Initial Catalog=CioDental1; Integrated Security=true"); 

        private void btnRegistrarse_Click(object sender, EventArgs e) 
        {
            
            Form I = new FrmRegistroSesión(); 
            I.Show(); 
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e) 
        {
            sqlCon.Open(); 
            string consulta = "Select * from Usuarios where NomUsr='" + txtUsuario.Text + "' and ConUsr='" + txtContraseña.Text + "'"; // Consulta SQL para buscar el usuario y contraseña ingresados
            SqlCommand comando = new SqlCommand(consulta, sqlCon); 
            SqlDataReader lector; 
            lector = comando.ExecuteReader(); 

            if (lector.HasRows == true) 
            {
                MessageBox.Show("Los datos ingresados son correctos"); 
                SistemaAutenticacion.EstablecerUsuarioLogueado(txtUsuario.Text); 

                
                string hora = DateTime.Now.ToLongTimeString(); 
                string fecha = DateTime.Now.ToShortDateString(); 
                string accion = "Ha iniciado sesión correctamente"; 
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; 

                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Registra la acción en la base de datos

                
                Form menucs = new FrmMenuPrincipal(); 
                menucs.Show(this); 
            }
            else 
            {
                MessageBox.Show("Los datos ingresados son incorrectos"); 
            }
            sqlCon.Close(); 
        }

        private void txtUsuario_Leave(object sender, EventArgs e) 
        {
            if (txtUsuario.Text == "") 
            {
               
                txtUsuario.Text = "Usuario"; 
                txtUsuario.ForeColor = Color.Black; 
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e) 
        {
            if (txtUsuario.Text == "Usuario") 
            {
               
                txtUsuario.Text = ""; 
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e) 
        {
            if (txtContraseña.Text == "") 
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Black; 
                txtContraseña.UseSystemPasswordChar = false;             }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña") 
            {
                txtContraseña.Text = ""; 
                txtContraseña.ForeColor = Color.Black; 
                txtContraseña.UseSystemPasswordChar = true; 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) // Muestra un mensaje de confirmación antes de salir
            {
                this.Close(); 
            }
            Application.Exit(); 
        }

        private void pbCerrar_Click_1(object sender, EventArgs e) 
        {
            Application.Exit(); 

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena larga
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena corta
            string accion = "Ha cerrado sesión"; // Define la acción realizada como "Ha cerrado sesión"
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario logueado

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Registra la acción en la base de datos
        }

        private void pbMinimizar_Click_1(object sender, EventArgs e) // Evento que se activa al hacer clic en el botón de minimizar
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza el formulario
        }

        private void pbMaximizar_Click_1(object sender, EventArgs e) // Evento que se activa al hacer clic en el botón de maximizar/restaurar
        {
            this.WindowState = FormWindowState.Maximized; // Maximiza/restaura el formulario
            pbMax.Visible = true; // Muestra el botón de maximizar
            pbMaximizar.Visible = false; // Oculta el botón de maximizar/restaurar
        }

        private void pbMax_Click_1(object sender, EventArgs e) // Evento que se activa al hacer clic en el botón de maximizar/restaurar (pestaña de la barra de título)
        {
            this.WindowState = FormWindowState.Normal; // Restaura el formulario a su tamaño normal
            pbMax.Visible = false; // Oculta el botón de maximizar
            pbMaximizar.Visible = true; // Muestra el botón de maximizar/restaurar
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmInicioSesión_Load(object sender, EventArgs e)
        {

        }
    }
}
