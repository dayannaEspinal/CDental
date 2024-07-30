namespace CioDental1
{
    partial class FrmReporteEstadoCuenta
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
            this.cioDental1DataSet75 = new CioDental1.CioDental1DataSet75();
            this.obtenerEstadoCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerEstadoCuentaTableAdapter = new CioDental1.CioDental1DataSet75TableAdapters.ObtenerEstadoCuentaTableAdapter();
            this.cioDental1DataSet77 = new CioDental1.CioDental1DataSet77();
            this.obtenerEstadoCuentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerEstadoCuentaTableAdapter1 = new CioDental1.CioDental1DataSet77TableAdapters.ObtenerEstadoCuentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerEstadoCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerEstadoCuentaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "EstadoCuenta";
            reportDataSource1.Value = this.obtenerEstadoCuentaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptEstadoCuenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet75
            // 
            this.cioDental1DataSet75.DataSetName = "CioDental1DataSet75";
            this.cioDental1DataSet75.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obtenerEstadoCuentaBindingSource
            // 
            this.obtenerEstadoCuentaBindingSource.DataMember = "ObtenerEstadoCuenta";
            this.obtenerEstadoCuentaBindingSource.DataSource = this.cioDental1DataSet75;
            // 
            // obtenerEstadoCuentaTableAdapter
            // 
            this.obtenerEstadoCuentaTableAdapter.ClearBeforeFill = true;
            // 
            // cioDental1DataSet77
            // 
            this.cioDental1DataSet77.DataSetName = "CioDental1DataSet77";
            this.cioDental1DataSet77.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obtenerEstadoCuentaBindingSource1
            // 
            this.obtenerEstadoCuentaBindingSource1.DataMember = "ObtenerEstadoCuenta";
            this.obtenerEstadoCuentaBindingSource1.DataSource = this.cioDental1DataSet77;
            // 
            // obtenerEstadoCuentaTableAdapter1
            // 
            this.obtenerEstadoCuentaTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmReporteEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteEstadoCuenta";
            this.Text = "FrmReporteEstadoCuenta";
            this.Load += new System.EventHandler(this.FrmReporteEstadoCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerEstadoCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerEstadoCuentaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CioDental1DataSet75 cioDental1DataSet75;
        private System.Windows.Forms.BindingSource obtenerEstadoCuentaBindingSource;
        private CioDental1DataSet75TableAdapters.ObtenerEstadoCuentaTableAdapter obtenerEstadoCuentaTableAdapter;
        private CioDental1DataSet77 cioDental1DataSet77;
        private System.Windows.Forms.BindingSource obtenerEstadoCuentaBindingSource1;
        private CioDental1DataSet77TableAdapters.ObtenerEstadoCuentaTableAdapter obtenerEstadoCuentaTableAdapter1;
    }
}