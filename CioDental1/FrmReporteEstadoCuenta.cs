using System; // Importa el espacio de nombres System
using System.Collections.Generic; // Importa el espacio de nombres System.Collections.Generic
using System.ComponentModel; // Importa el espacio de nombres System.ComponentModel
using System.Data; // Importa el espacio de nombres System.Data
using System.Drawing; // Importa el espacio de nombres System.Drawing
using System.Linq; // Importa el espacio de nombres System.Linq
using System.Text; // Importa el espacio de nombres System.Text
using System.Threading.Tasks; // Importa el espacio de nombres System.Threading.Tasks
using System.Windows.Forms; // Importa el espacio de nombres System.Windows.Forms

namespace CioDental1 // Inicia el espacio de nombres CioDental1
{
    public partial class FrmReporteEstadoCuenta : Form // Declara la clase FrmReporteEstadoCuenta que hereda de Form
    {
        public FrmReporteEstadoCuenta() // Constructor de la clase FrmReporteEstadoCuenta
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void FrmReporteEstadoCuenta_Load(object sender, EventArgs e) // Manejador de evento Load del formulario FrmReporteEstadoCuenta
        {
            // TODO: esta línea de código carga datos en la tabla 'cioDental1DataSet77.ObtenerEstadoCuenta' Puede moverla o quitarla según sea necesario.
            this.obtenerEstadoCuentaTableAdapter1.Fill(this.cioDental1DataSet77.ObtenerEstadoCuenta); // Llena el conjunto de datos 'cioDental1DataSet77' con los datos de la tabla 'ObtenerEstadoCuenta' utilizando el adaptador de tabla 'obtenerEstadoCuentaTableAdapter1'

            // TODO: esta línea de código carga datos en la tabla 'cioDental1DataSet75.ObtenerEstadoCuenta' Puede moverla o quitarla según sea necesario.
            this.obtenerEstadoCuentaTableAdapter.Fill(this.cioDental1DataSet75.ObtenerEstadoCuenta); // Llena el conjunto de datos 'cioDental1DataSet75' con los datos de la tabla 'ObtenerEstadoCuenta' utilizando el adaptador de tabla 'obtenerEstadoCuentaTableAdapter'

            this.reportViewer1.RefreshReport(); // Refresca el visor de informes
        }
    }
}
