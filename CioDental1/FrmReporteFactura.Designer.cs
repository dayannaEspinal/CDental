namespace CioDental1
{
    partial class FrmReporteFactura
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
            this.reporteObtenerDetallesFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet79 = new CioDental1.CioDental1DataSet79();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteObtenerDetallesFacturaTableAdapter = new CioDental1.CioDental1DataSet79TableAdapters.ReporteObtenerDetallesFacturaTableAdapter();
            this.cioDental1DataSet83 = new CioDental1.CioDental1DataSet83();
            this.reporteObtenerDetallesFacturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reporteObtenerDetallesFacturaTableAdapter1 = new CioDental1.CioDental1DataSet83TableAdapters.ReporteObtenerDetallesFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerDetallesFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerDetallesFacturaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteObtenerDetallesFacturaBindingSource
            // 
            this.reporteObtenerDetallesFacturaBindingSource.DataMember = "ReporteObtenerDetallesFactura";
            this.reporteObtenerDetallesFacturaBindingSource.DataSource = this.cioDental1DataSet79;
            // 
            // cioDental1DataSet79
            // 
            this.cioDental1DataSet79.DataSetName = "CioDental1DataSet79";
            this.cioDental1DataSet79.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DetallesFactura";
            reportDataSource1.Value = this.reporteObtenerDetallesFacturaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteObtenerDetallesFacturaTableAdapter
            // 
            this.reporteObtenerDetallesFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // cioDental1DataSet83
            // 
            this.cioDental1DataSet83.DataSetName = "CioDental1DataSet83";
            this.cioDental1DataSet83.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteObtenerDetallesFacturaBindingSource1
            // 
            this.reporteObtenerDetallesFacturaBindingSource1.DataMember = "ReporteObtenerDetallesFactura";
            this.reporteObtenerDetallesFacturaBindingSource1.DataSource = this.cioDental1DataSet83;
            // 
            // reporteObtenerDetallesFacturaTableAdapter1
            // 
            this.reporteObtenerDetallesFacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteFactura";
            this.Text = "FrmReporteFactura";
            this.Load += new System.EventHandler(this.FrmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerDetallesFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerDetallesFacturaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteObtenerDetallesFacturaBindingSource;
        private CioDental1DataSet79 cioDental1DataSet79;
        private CioDental1DataSet79TableAdapters.ReporteObtenerDetallesFacturaTableAdapter reporteObtenerDetallesFacturaTableAdapter;
        private System.Windows.Forms.BindingSource reporteObtenerDetallesFacturaBindingSource1;
        private CioDental1DataSet83 cioDental1DataSet83;
        private CioDental1DataSet83TableAdapters.ReporteObtenerDetallesFacturaTableAdapter reporteObtenerDetallesFacturaTableAdapter1;
    }
}