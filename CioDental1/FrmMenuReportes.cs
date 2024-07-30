using System; // Importa el espacio de nombres System
using System.Collections.Generic; // Importa el espacio de nombres System.Collections.Generic
using System.ComponentModel; // Importa el espacio de nombres System.ComponentModel
using System.Data; // Importa el espacio de nombres System.Data
using System.Drawing; // Importa el espacio de nombres System.Drawing
using System.Linq; // Importa el espacio de nombres System.Linq
using System.Text; // Importa el espacio de nombres System.Text
using System.Threading.Tasks; // Importa el espacio de nombres System.Threading.Tasks
using System.Windows.Forms; // Importa el espacio de nombres System.Windows.Forms

namespace CioDental1
{
    public partial class FrmMenuReportes : Form
    {
        public FrmMenuReportes() // Constructor de la clase FrmMenuReportes
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        } // Fin del constructor

        // Evento que se activa cuando se carga el formulario de menú de reportes
        private void FrmMenuReportes_Load(object sender, EventArgs e)
        {

        }

        // Abre el formulario de reporte de estado de cuenta
        private void button1_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReporteEstadoCuenta(); // Abre el formulario de reporte de estado de cuenta
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de horas con más pacientes atendidos
        private void btnHorasMasPacientes_Click(object sender, EventArgs e)
        {
            Form HR = new FrmReporteTopHorasConMasPacientesAtendidoscs(); // Abre el formulario de reporte de horas con más pacientes atendidos
            HR.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de compras por fechas
        private void btnComprasPorFechs_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReporteObtenerComprasPorFechas(); // Abre el formulario de reporte de compras por fechas
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de facturas por fechas
        private void btnFacturasPorFechas_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReporteObtenerFacturasPorFecha(); // Abre el formulario de reporte de facturas por fechas
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de productos por vencer
        private void btnProductosVencer_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReporteObtenerFechaVencerProducto(); // Abre el formulario de reporte de productos por vencer
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de pacientes con más citas
        private void btnPacientesMasCitas_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReportePacientesConMasCitas(); // Abre el formulario de reporte de pacientes con más citas
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de productos con menos stock
        private void btnProductosMenosStock_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReporteObtenerProductosMenorStock(); // Abre el formulario de reporte de productos con menos stock
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de los 5 tratamientos más aplicados
        private void btnTratamientosMasAplicados_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReporteTop5Tratamientos(); // Abre el formulario de reporte de los 5 tratamientos más aplicados
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de los días con más citas atendidas
        private void btnDiasMasCitas_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReporteTopDiasCitasAtendidas(); // Abre el formulario de reporte de los días con más citas atendidas
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de productos más vendidos
        private void btnProductosMasVendidos_Click(object sender, EventArgs e)
        {
            Form EC = new FrmProductosMasVendidos(); // Abre el formulario de reporte de productos más vendidos
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de productos menos vendidos
        private void btnProductosMenosVendidos_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReporteProductosMenosVendidos(); // Abre el formulario de reporte de productos menos vendidos
            EC.Show(); // Muestra el formulario
        }

        // Abre el formulario de reporte de los 5 tratamientos menos aplicados
        private void btnTratamientosMenosAplicados_Click(object sender, EventArgs e)
        {
            Form EC = new FrmReporteTop5TratamientosMenosAplicados(); // Abre el formulario de reporte de los 5 tratamientos menos aplicados
            EC.Show(); // Muestra el formulario
        }
    }
}
