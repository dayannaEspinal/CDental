namespace CioDental1
{
    partial class FrmReporteObtenerDetallesCompras
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
            this.cioDental1DataSet96 = new CioDental1.CioDental1DataSet96();
            this.reporteObtenerDetallesCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteObtenerDetallesCompraTableAdapter = new CioDental1.CioDental1DataSet96TableAdapters.ReporteObtenerDetallesCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerDetallesCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ObtenerDetallesCompra";
            reportDataSource1.Value = this.reporteObtenerDetallesCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptObtenerComprasDetalle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet96
            // 
            this.cioDental1DataSet96.DataSetName = "CioDental1DataSet96";
            this.cioDental1DataSet96.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteObtenerDetallesCompraBindingSource
            // 
            this.reporteObtenerDetallesCompraBindingSource.DataMember = "ReporteObtenerDetallesCompra";
            this.reporteObtenerDetallesCompraBindingSource.DataSource = this.cioDental1DataSet96;
            // 
            // reporteObtenerDetallesCompraTableAdapter
            // 
            this.reporteObtenerDetallesCompraTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteObtenerDetallesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteObtenerDetallesCompras";
            this.Text = "FrmReporteObtenerDetallesCompras";
            this.Load += new System.EventHandler(this.FrmReporteObtenerDetallesCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerDetallesCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteObtenerDetallesCompraBindingSource;
        private CioDental1DataSet96 cioDental1DataSet96;
        private CioDental1DataSet96TableAdapters.ReporteObtenerDetallesCompraTableAdapter reporteObtenerDetallesCompraTableAdapter;
    }
}