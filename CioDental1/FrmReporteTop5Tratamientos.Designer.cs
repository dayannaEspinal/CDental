namespace CioDental1
{
    partial class FrmReporteTop5Tratamientos
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
            this.cioDental1DataSet50 = new CioDental1.CioDental1DataSet50();
            this.reporteTop5TratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteTop5TratamientosTableAdapter = new CioDental1.CioDental1DataSet50TableAdapters.ReporteTop5TratamientosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5TratamientosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Top5Tratamientos";
            reportDataSource1.Value = this.reporteTop5TratamientosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptTop5Tratamientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet50
            // 
            this.cioDental1DataSet50.DataSetName = "CioDental1DataSet50";
            this.cioDental1DataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteTop5TratamientosBindingSource
            // 
            this.reporteTop5TratamientosBindingSource.DataMember = "ReporteTop5Tratamientos";
            this.reporteTop5TratamientosBindingSource.DataSource = this.cioDental1DataSet50;
            // 
            // reporteTop5TratamientosTableAdapter
            // 
            this.reporteTop5TratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteTop5Tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteTop5Tratamientos";
            this.Text = "FrmReporteTop5Tratamientos";
            this.Load += new System.EventHandler(this.FrmReporteTop5Tratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5TratamientosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CioDental1DataSet50 cioDental1DataSet50;
        private System.Windows.Forms.BindingSource reporteTop5TratamientosBindingSource;
        private CioDental1DataSet50TableAdapters.ReporteTop5TratamientosTableAdapter reporteTop5TratamientosTableAdapter;
    }
}