using System; // Importa el espacio de nombres System, que contiene clases fundamentales y servicios del tiempo de ejecución.
using System.Collections.Generic; // Importa el espacio de nombres System.Collections.Generic, que proporciona interfaces y clases que definen colecciones genéricas.
using System.ComponentModel; // Importa el espacio de nombres System.ComponentModel, que contiene interfaces que se utilizan para implementar el comportamiento de componentes y controles.
using System.Data; // Importa el espacio de nombres System.Data, que proporciona acceso a clases que representan la arquitectura de datos ADO.NET.
using System.Drawing; // Importa el espacio de nombres System.Drawing, que proporciona acceso a GDI+ básico.
using System.Linq; // Importa el espacio de nombres System.Linq, que proporciona clases y interfaces que admiten consultas que utilizan LINQ.
using System.Text; // Importa el espacio de nombres System.Text, que contiene clases que representan codificaciones de caracteres Unicode y ANSI, así como clases para manipular cadenas de texto y bytes.
using System.Threading.Tasks; // Importa el espacio de nombres System.Threading.Tasks, que proporciona clases e interfaces que permiten la implementación de programación asincrónica y paralela.
using System.Windows.Forms; // Importa el espacio de nombres System.Windows.Forms, que contiene clases para crear aplicaciones de Windows que aprovechan las características y capacidades de la plataforma Windows.

namespace CioDental1 // Declara un espacio de nombres llamado CioDental1.
{
    public partial class FrmProductosMasVendidos : Form // Declara una clase parcial llamada FrmProductosMasVendidos que hereda de Form.
    {
        public FrmProductosMasVendidos() // Define un constructor para la clase FrmProductosMasVendidos.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        private void FrmProductosMasVendidos_Load(object sender, EventArgs e) // Define un método para manejar el evento Load del formulario FrmProductosMasVendidos.
        {
            // TODO: esta línea de código carga datos en la tabla 'cioDental1DataSet48.ObtenerTop5ProductosMasVendidos' Puede moverla o quitarla según sea necesario.
            this.obtenerTop5ProductosMasVendidosTableAdapter.Fill(this.cioDental1DataSet48.ObtenerTop5ProductosMasVendidos); // Carga datos en la tabla desde el conjunto de datos enlazado al control.

            this.reportViewer1.RefreshReport(); // Actualiza el informe mostrado en el control ReportViewer.
            this.reportViewer1.RefreshReport(); // Actualiza el informe mostrado en el control ReportViewer (repetición innecesaria).
        }
    }
}
