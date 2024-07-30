namespace CioDental1
{
    partial class FrmReporteTop5TratamientosMenosAplicados
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
            this.cioDental1DataSet52 = new CioDental1.CioDental1DataSet52();
            this.reporteTop5TratamientosMenosAplicadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteTop5TratamientosMenosAplicadosTableAdapter = new CioDental1.CioDental1DataSet52TableAdapters.ReporteTop5TratamientosMenosAplicadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5TratamientosMenosAplicadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TopTratamientosMenosAplicados";
            reportDataSource1.Value = this.reporteTop5TratamientosMenosAplicadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptTratamientosMenosAplicados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet52
            // 
            this.cioDental1DataSet52.DataSetName = "CioDental1DataSet52";
            this.cioDental1DataSet52.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteTop5TratamientosMenosAplicadosBindingSource
            // 
            this.reporteTop5TratamientosMenosAplicadosBindingSource.DataMember = "ReporteTop5TratamientosMenosAplicados";
            this.reporteTop5TratamientosMenosAplicadosBindingSource.DataSource = this.cioDental1DataSet52;
            // 
            // reporteTop5TratamientosMenosAplicadosTableAdapter
            // 
            this.reporteTop5TratamientosMenosAplicadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteTop5TratamientosMenosAplicados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteTop5TratamientosMenosAplicados";
            this.Text = "FrmReporteTop5TratamientosMenosAplicados";
            this.Load += new System.EventHandler(this.FrmReporteTop5TratamientosMenosAplicados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5TratamientosMenosAplicadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CioDental1DataSet52 cioDental1DataSet52;
        private System.Windows.Forms.BindingSource reporteTop5TratamientosMenosAplicadosBindingSource;
        private CioDental1DataSet52TableAdapters.ReporteTop5TratamientosMenosAplicadosTableAdapter reporteTop5TratamientosMenosAplicadosTableAdapter;
    }
}