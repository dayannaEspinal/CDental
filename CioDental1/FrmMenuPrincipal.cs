using System; // Importa el espacio de nombres System
using System.Collections.Generic; // Importa el espacio de nombres System.Collections.Generic
using System.ComponentModel; // Importa el espacio de nombres System.ComponentModel
using System.Data; // Importa el espacio de nombres System.Data
using System.Drawing; // Importa el espacio de nombres System.Drawing
using System.Linq; // Importa el espacio de nombres System.Linq
using System.Text; // Importa el espacio de nombres System.Text
using System.Threading.Tasks; // Importa el espacio de nombres System.Threading.Tasks
using System.Windows.Forms; // Importa el espacio de nombres System.Windows.Forms
using FontAwesome; // Importa el espacio de nombres FontAwesome
using static CioDental1.Conexión; // Importa la clase Conexión del espacio de nombres CioDental1

namespace CioDental1 // Define un espacio de nombres llamado CioDental1
{
    public partial class FrmMenuPrincipal : Form // Define la clase FrmMenuPrincipal que hereda de Form
    {
        public FrmMenuPrincipal() // Constructor de la clase FrmMenuPrincipal
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        // Instancia de la clase Conexión
        Conexión conexion = new Conexión();

        // Evento click del botón para abrir el formulario de pacientes
        private void button6_Click(object sender, EventArgs e) // Define el evento click del botón button6
        {
            openpanelFormulario(new FrmPacientes()); // Abre el formulario de pacientes en el panel
        }

        // Evento click del botón para abrir el formulario de tratamiento
        private void button9_Click(object sender, EventArgs e) // Define el evento click del botón button9
        {
            openpanelFormulario(new FrmTratamiento()); // Abre el formulario de tratamiento en el panel
        }

        // Evento click del botón para abrir el formulario de inicio de sesión
        private void button13_Click(object sender, EventArgs e) // Define el evento click del botón button13
        {
            Form L = new FrmInicioSesión(); // Crea una instancia del formulario de inicio de sesión
            L.Show(); // Muestra el formulario de inicio de sesión
        }

        // Evento click del botón para abrir el formulario de citas
        private void button2_Click(object sender, EventArgs e) // Define el evento click del botón button2
        {
            openpanelFormulario(new FrmCitas()); // Abre el formulario de citas en el panel
        }

        // Evento click del botón para abrir el formulario de registro de sesión
        private void button1_Click(object sender, EventArgs e) // Define el evento click del botón button1
        {
            // Verifica si el usuario tiene permiso de administrador
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Si el usuario no es administrador
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje de que no tiene permiso
                return; // Retorna
            }
            openpanelFormulario(new FrmRegistroSesión()); // Abre el formulario de registro de sesión en el panel
        }

        // Evento click del botón para abrir el formulario de marcas
        private void button12_Click(object sender, EventArgs e) // Define el evento click del botón button12
        {
            openpanelFormulario(new FrmMarcas()); // Abre el formulario de marcas en el panel
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Abre un formulario de productos cuando se hace clic en el botón
            openpanelFormulario(new FrmProductos());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Abre un formulario de proveedores cuando se hace clic en el botón
            openpanelFormulario(new FrmProveedores());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Abre un formulario de compras cuando se hace clic en el botón
            openpanelFormulario(new FrmCompras());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Abre un formulario de factura cuando se hace clic en el botón
            openpanelFormulario(new FrmFactura());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Verifica si el usuario tiene permisos de administrador y luego abre un formulario de bitácora
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado))
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje de advertencia si el usuario no es administrador
                return; // Sale del método
            }
            openpanelFormulario(new FrmBitacora()); // Abre el formulario de Bitacora
        }

        private Form activoForm = null; // Declara una variable para almacenar el formulario activo

        private void openpanelFormulario(Form panelForm)
        {
            // Cierra el formulario activo si hay alguno
            if (activoForm != null)
                activoForm.Close();

            activoForm = panelForm; // Asigna el formulario pasado como parámetro al formulario activo
            panelForm.TopLevel = false; // Establece el formulario como secundario
            panelForm.FormBorderStyle = FormBorderStyle.None; // Establece el borde del formulario como ninguno
            panelForm.Dock = DockStyle.Fill; // Dock el formulario al tamaño del panel contenedor
            panelFormulario.Controls.Add(panelForm); // Agrega el formulario al panel contenedor
            panelFormulario.Tag = panelForm; // Asigna el formulario al tag del panel
            panelForm.BringToFront(); // Trae el formulario al frente
            panelForm.Show(); // Muestra el formulario
        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {
            // No hay acciones al pintar el panel
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Verifica si el usuario tiene permisos de administrador y luego abre un formulario de menu de reportes
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado))
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje de advertencia si el usuario no es administrador
                return; // Sale del método
            }

            openpanelFormulario(new FrmMenuReportes()); // Abre el formulario de menú de reportes
        }


        private void button14_Click(object sender, EventArgs e)
        {
            openpanelFormulario(new FrmContactoProveedor()); // Abre un formulario de contacto de proveedor cuando se hace clic en el botón
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual

            string accion = "Ha cerrado sesión"; // Define la acción como "Ha cerrado sesión"
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario logueado

            // Inserta un registro en la bitácora con la acción de cierre de sesión
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");
        }


        private void pbMaximizar_Click(object sender, EventArgs e) // Maximiza la ventana y muestra el botón de restaurar
        {
            this.WindowState = FormWindowState.Maximized; // Maximiza la ventana
            pbMax.Visible = true; // Muestra el botón de restaurar
            pbMaximizar.Visible = false; // Oculta el botón de maximizar
        }


        private void pbMax_Click(object sender, EventArgs e) // Restaura la ventana a su tamaño normal
        {
            this.WindowState = FormWindowState.Normal; // Restaura el estado de la ventana a normal
            pbMax.Visible = false; // Oculta el botón de maximizar
            pbMaximizar.Visible = true; // Muestra el botón de maximizar
        }

        private void pbMinimizar_Click(object sender, EventArgs e) // Minimiza la ventana
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza la ventana
        }

    }
}
