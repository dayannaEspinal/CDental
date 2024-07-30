﻿using System; // Importa el espacio de nombres System
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
    public partial class FrmReporteTopDiasCitasAtendidas : Form // Declara la clase FrmReporteTopDiasCitasAtendidas que hereda de Form
    {
        public FrmReporteTopDiasCitasAtendidas() // Constructor de la clase FrmReporteTopDiasCitasAtendidas
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void FrmReporteTopDiasCitasAtendidas_Load(object sender, EventArgs e) // Manejador de evento Load del formulario FrmReporteTopDiasCitasAtendidas
        {
            // Carga los datos en la tabla 'cioDental1DataSet65.ReporteTopDiasCitasAtendidas'
            // Puede mover o quitarla línea según sea necesario.
            this.reporteTopDiasCitasAtendidasTableAdapter.Fill(this.cioDental1DataSet65.ReporteTopDiasCitasAtendidas);

            this.reportViewer1.RefreshReport(); // Refresca el visor de informes
        }
    }
}
