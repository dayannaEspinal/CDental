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
    public partial class FrmBitacora : Form // Define la clase parcial FrmBitacora que hereda de Form
    {
        public FrmBitacora() // Constructor del formulario FrmBitacora
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        Conexión conexion = new Conexión(); // Instancia de la clase Conexión

        private void FrmBitacora_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
        {
            conexion.mostrasbitacoras(dgvBitacoras); // Llama al método mostrasbitacoras de la conexión y muestra los datos en dgvBitacoras
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Evento que se ejecuta cuando se cambia el texto en el cuadro de búsqueda
        {
            conexion.Busquedas("exec VistaBitacoras", dgvBitacoras, "IdUsr LIKE '%" + txtBuscarBitacoras.Text + "%*' "); // Llama al método Busquedas para filtrar bitácoras por IdUsr y actualiza el DataGridView
        }

        private void button1_Click(object sender, EventArgs e) // Evento que se ejecuta cuando se hace clic en el botón1
        {
            Form KK = new FrmMenuPrincipal(); // Crea una nueva instancia del formulario FrmMenuPrincipal
            KK.Show(); // Muestra el formulario FrmMenuPrincipal
        }
    }
}
