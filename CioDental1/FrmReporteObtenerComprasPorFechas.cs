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
    public partial class FrmReporteObtenerComprasPorFechas : Form // Declara la clase FrmReporteObtenerComprasPorFechas que hereda de Form
    {
        public FrmReporteObtenerComprasPorFechas() // Constructor de la clase FrmReporteObtenerComprasPorFechas
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void MostrarReporteCompras(int opcion, DateTime? fechaInicio = null, DateTime? fechaFin = null) // Método para mostrar el reporte de compras por fechas
        {
            DataTable dt = new DataTable(); // Crea un nuevo objeto DataTable

            // Crea una nueva conexión a la base de datos utilizando la cadena de conexión especificada
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"))
            {
                // Crea un nuevo comando para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("ReporteObtenerComprasPorOpcion", conn))
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
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ObtenerComprasPorFechas", dt)); // Agrega un nuevo origen de datos al visor de informes

            this.reportViewer1.RefreshReport(); // Refresca el visor de informes
        }

        private void FrmReporteObtenerComprasPorFechas_Load(object sender, EventArgs e) // Manejador de evento Load del formulario FrmReporteObtenerComprasPorFechas
        {
            this.reportViewer1.RefreshReport(); // Refresca el visor de informes al cargar el formulario
        }

        // Los siguientes métodos son manejadores de eventos para los botones de selección de fechas, cada uno llama al método MostrarReporteCompras con un parámetro de opción correspondiente

        private void btnHoy_Click(object sender, EventArgs e)
        {
            MostrarReporteCompras(1); // Muestra el reporte de compras de hoy
        }

        private void btnAyer_Click(object sender, EventArgs e)
        {
            MostrarReporteCompras(2); // Muestra el reporte de compras de ayer
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            MostrarReporteCompras(3); // Muestra el reporte de compras de la semana
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            MostrarReporteCompras(4); // Muestra el reporte de compras del mes
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            MostrarReporteCompras(5); // Muestra el reporte de compras del año
        }

        private void btnRango_Click(object sender, EventArgs e)
        {
            // Obtiene las fechas seleccionadas por el usuario y muestra el reporte de compras para ese rango de fechas
            DateTime fechaInicio = dtpFecIni.Value; // Obtiene la fecha de inicio seleccionada por el usuario
            DateTime fechaFin = dtpFecFin.Value; // Obtiene la fecha de fin seleccionada por el usuario

            MostrarReporteCompras(6, fechaInicio, fechaFin); // Muestra el reporte de compras para el rango de fechas seleccionado
        }
    }
}
