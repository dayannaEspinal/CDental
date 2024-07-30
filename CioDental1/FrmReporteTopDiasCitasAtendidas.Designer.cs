namespace CioDental1
{
    partial class FrmReporteTopDiasCitasAtendidas
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
            this.cioDental1DataSet65 = new CioDental1.CioDental1DataSet65();
            this.reporteTopDiasCitasAtendidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteTopDiasCitasAtendidasTableAdapter = new CioDental1.CioDental1DataSet65TableAdapters.ReporteTopDiasCitasAtendidasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTopDiasCitasAtendidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TopDiasCitasAtendidas";
            reportDataSource1.Value = this.reporteTopDiasCitasAtendidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptTopDiasCitasAtendidas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet65
            // 
            this.cioDental1DataSet65.DataSetName = "CioDental1DataSet65";
            this.cioDental1DataSet65.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteTopDiasCitasAtendidasBindingSource
            // 
            this.reporteTopDiasCitasAtendidasBindingSource.DataMember = "ReporteTopDiasCitasAtendidas";
            this.reporteTopDiasCitasAtendidasBindingSource.DataSource = this.cioDental1DataSet65;
            // 
            // reporteTopDiasCitasAtendidasTableAdapter
            // 
            this.reporteTopDiasCitasAtendidasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteTopDiasCitasAtendidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteTopDiasCitasAtendidas";
            this.Text = "FrmReporteTopDiasCitasAtendidas";
            this.Load += new System.EventHandler(this.FrmReporteTopDiasCitasAtendidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTopDiasCitasAtendidasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CioDental1DataSet65 cioDental1DataSet65;
        private System.Windows.Forms.BindingSource reporteTopDiasCitasAtendidasBindingSource;
        private CioDental1DataSet65TableAdapters.ReporteTopDiasCitasAtendidasTableAdapter reporteTopDiasCitasAtendidasTableAdapter;
    }
}