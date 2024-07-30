using Microsoft.Reporting.WinForms; // Importa el espacio de nombres Microsoft.Reporting.WinForms
using System; // Importa el espacio de nombres System
using System.Collections.Generic; // Importa el espacio de nombres System.Collections.Generic
using System.ComponentModel; // Importa el espacio de nombres System.ComponentModel
using System.Data; // Importa el espacio de nombres System.Data
using System.Data.SqlClient; // Importa el espacio de nombres System.Data.SqlClient
using System.Drawing; // Importa el espacio de nombres System.Drawing
using System.Linq; // Importa el espacio de nombres System.Linq
using System.Text; // Importa el espacio de nombres System.Text
using System.Threading.Tasks; // Importa el espacio de nombres System.Threading.Tasks
using System.Windows.Forms; // Importa el espacio de nombres System.Windows.Forms

namespace CioDental1 // Inicia el espacio de nombres CioDental1
{
    public partial class FrmReporteObtenerDetallesCompras : Form // Declara la clase FrmReporteObtenerDetallesCompras que hereda de Form
    {
        private int IdCom; // Declara una variable privada IdCom de tipo entero
        public FrmReporteObtenerDetallesCompras(int idCom) // Constructor de la clase FrmReporteObtenerDetallesCompras que recibe un parámetro idCom de tipo entero
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.IdCom=idCom; // Asigna el valor del parámetro idCom a la variable IdCom de la clase
        }

        private void FrmReporteObtenerDetallesCompras_Load(object sender, EventArgs e) // Manejador de evento Load del formulario FrmReporteObtenerDetallesCompras
        {
            this.cioDental1DataSet96.EnforceConstraints = false; // Deshabilita la aplicación de restricciones de integridad referencial en el conjunto de datos cioDental1DataSet96
            this.reporteObtenerDetallesCompraTableAdapter.Fill(this.cioDental1DataSet96.ReporteObtenerDetallesCompra, IdCom); // Llena el conjunto de datos 'cioDental1DataSet96' con los detalles de la compra utilizando el adaptador de tabla 'reporteObtenerDetallesCompraTableAdapter' y pasando el IdCom como parámetro

            this.reportViewer1.RefreshReport(); // Refresca el visor de informes
        }
    }
}
