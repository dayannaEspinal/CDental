namespace CioDental1
{
    partial class FrmReportePacientesConMasCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cioDental1DataSet89 = new CioDental1.CioDental1DataSet89();
            this.reporteObtenerTop7PacientesConMasCitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteObtenerTop7PacientesConMasCitasTableAdapter = new CioDental1.CioDental1DataSet89TableAdapters.ReporteObtenerTop7PacientesConMasCitasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerTop7PacientesConMasCitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PacientesConMasCitas";
            reportDataSource1.Value = this.reporteObtenerTop7PacientesConMasCitasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptObtenerPacientesConMasCitas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet89
            // 
            this.cioDental1DataSet89.DataSetName = "CioDental1DataSet89";
            this.cioDental1DataSet89.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteObtenerTop7PacientesConMasCitasBindingSource
            // 
            this.reporteObtenerTop7PacientesConMasCitasBindingSource.DataMember = "ReporteObtenerTop7PacientesConMasCitas";
            this.reporteObtenerTop7PacientesConMasCitasBindingSource.DataSource = this.cioDental1DataSet89;
            // 
            // reporteObtenerTop7PacientesConMasCitasTableAdapter
            // 
            this.reporteObtenerTop7PacientesConMasCitasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePacientesConMasCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportePacientesConMasCitas";
            this.Text = "FrmReportePacientesConMasCitas";
            this.Load += new System.EventHandler(this.FrmReportePacientesConMasCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerTop7PacientesConMasCitasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CioDental1DataSet89 cioDental1DataSet89;
        private System.Windows.Forms.BindingSource reporteObtenerTop7PacientesConMasCitasBindingSource;
        private CioDental1DataSet89TableAdapters.ReporteObtenerTop7PacientesConMasCitasTableAdapter reporteObtenerTop7PacientesConMasCitasTableAdapter;
    }
}