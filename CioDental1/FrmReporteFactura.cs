using Microsoft.Reporting.WinForms; // Importa el espacio de nombres Microsoft.Reporting.WinForms
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
    public partial class FrmReporteFactura : Form // Declara la clase FrmReporteFactura que hereda de Form
    {
        private int IdFac; // Declara una variable privada IdFac de tipo entero
        public FrmReporteFactura(int idFac) // Constructor de la clase FrmReporteFactura que recibe un parámetro idFac de tipo entero
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.IdFac=idFac; // Asigna el valor del parámetro idFac a la variable IdFac de la clase
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e) // Manejador de evento Load del formulario FrmReporteFactura
        {
            this.cioDental1DataSet83.EnforceConstraints = false; // Deshabilita la aplicación de restricciones de integridad referencial en el conjunto de datos cioDental1DataSet83
            this.reporteObtenerDetallesFacturaTableAdapter1.Fill(this.cioDental1DataSet83.ReporteObtenerDetallesFactura, IdFac); // Llena el conjunto de datos 'cioDental1DataSet83' con los detalles de la factura utilizando el adaptador de tabla 'reporteObtenerDetallesFacturaTableAdapter1' y pasando el IdFac como parámetro

            this.reportViewer1.RefreshReport(); // Refresca el visor de informes
        }
    }
}
