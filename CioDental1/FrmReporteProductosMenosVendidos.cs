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
    public partial class FrmReporteProductosMenosVendidos : Form // Declara la clase FrmReporteProductosMenosVendidos que hereda de Form
    {
        public FrmReporteProductosMenosVendidos() // Constructor de la clase FrmReporteProductosMenosVendidos
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void FrmReporteProductosMenosVendidos_Load(object sender, EventArgs e) // Manejador de evento Load del formulario FrmReporteProductosMenosVendidos
        {
            // Carga los datos en la tabla 'cioDental1DataSet61.ReporteTop5ProductosMenosVendidos'
            // Puede mover o quitar la línea según sea necesario.
            this.reporteTop5ProductosMenosVendidosTableAdapter2.Fill(this.cioDental1DataSet61.ReporteTop5ProductosMenosVendidos);
            // Carga los datos en la tabla 'cioDental1DataSet59.ReporteTop5ProductosMenosVendidos'
            // Puede mover o quitarla línea según sea necesario.
            this.reporteTop5ProductosMenosVendidosTableAdapter1.Fill(this.cioDental1DataSet59.ReporteTop5ProductosMenosVendidos);
            // Carga los datos en la tabla 'cioDental1DataSet56.ReporteTop5ProductosMenosVendidos'
            // Puede mover o quitarla línea según sea necesario.
            this.reporteTop5ProductosMenosVendidosTableAdapter.Fill(this.cioDental1DataSet56.ReporteTop5ProductosMenosVendidos);

            this.reportViewer1.RefreshReport(); // Refresca el visor de informes
        }
    }
}
