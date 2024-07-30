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
    public partial class FrmReporteObtenerFacturasPorFecha : Form // Declara la clase FrmReporteObtenerFacturasPorFecha que hereda de Form
    {
        public FrmReporteObtenerFacturasPorFecha() // Constructor de la clase FrmReporteObtenerFacturasPorFecha
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        // Método para mostrar el reporte de facturas por fecha
        private void MostrarReporte(int opcion, DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            DataTable dt = new DataTable(); // Crea un nuevo objeto DataTable

            // Crea una nueva conexión a la base de datos utilizando la cadena de conexión especificada
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"))
            {
                // Crea un nuevo comando para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("ReporteObtenerFacturasPorOpcion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure; // Especifica que el comando es un procedimiento almacenado

                    // Agrega los parámetros al comando
                    cmd.Parameters.AddWithValue("@Opcion", opcion); // Agrega el parámetro @Opcion con el valor de la variable opcion
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio ?? (object)DBNull.Value); // Agrega el parámetro @FechaInicio con el valor de la variable fechaInicio o DBNull.Value si fechaInicio es nulo
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin ?? (object)DBNull.Value); // Agrega el parámetro @FechaFin con el valor de la variable fechaFin o DBNull.Value si fechaFin es nulo

                    SqlDataAdapter da = new SqlDataAdapter(cmd); // Crea un nuevo adaptador de datos utilizando el comando
                    da.Fill(dt); // Llena el DataTable con los resultados obtenidos del adaptador de datos
                }
            }

            this.reportViewer1.LocalReport.DataSources.Clear(); // Limpia los orígenes de datos del visor de informes
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ObtenerFacturasPorFechas", dt)); // Agrega un nuevo origen de datos al visor de informes

            this.reportViewer1.RefreshReport(); // Refresca el visor de informes
        }

        private void FrmReporteObtenerFacturasPorFecha_Load(object sender, EventArgs e) // Manejador de evento Load del formulario FrmReporteObtenerFacturasPorFecha
        {
            this.reportViewer1.RefreshReport(); // Refresca el visor de informes al cargar el formulario
        }

        // Los siguientes métodos son manejadores de eventos para los botones de selección de fechas, cada uno llama al método MostrarReporte con un parámetro de opción correspondiente

        private void btnHoy_Click(object sender, EventArgs e)
        {
            MostrarReporte(1); // Muestra el reporte de facturas de hoy
        }

        private void btnAyer_Click(object sender, EventArgs e)
        {
            MostrarReporte(2); // Muestra el reporte de facturas de ayer
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            MostrarReporte(3); // Muestra el reporte de facturas de la semana
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            MostrarReporte(4); // Muestra el reporte de facturas del mes
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            MostrarReporte(5); // Muestra el reporte de facturas del año
        }

        private void btnRango_Click(object sender, EventArgs e)
        {
            // Obtiene las fechas seleccionadas por el usuario y muestra el reporte de facturas para ese rango de fechas
            DateTime fechaInicio = dtpFecIni.Value; // Obtiene la fecha de inicio seleccionada por el usuario
            DateTime fechaFin = dtpFecFin.Value; // Obtiene la fecha de fin seleccionada por


            MostrarReporte(6, fechaInicio, fechaFin); // Muestra el reporte de facturas para el rango de fechas seleccionado
        }
    }
}
