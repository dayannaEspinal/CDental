namespace CioDental1
{
    partial class FrmReporteTopHorasConMasPacientesAtendidoscs
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
            this.cioDental1DataSet63 = new CioDental1.CioDental1DataSet63();
            this.topHorasConMasPacientesAtendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topHorasConMasPacientesAtendidosTableAdapter = new CioDental1.CioDental1DataSet63TableAdapters.TopHorasConMasPacientesAtendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topHorasConMasPacientesAtendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TopHorasConMasPacientesAtendidos";
            reportDataSource1.Value = this.topHorasConMasPacientesAtendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptHorasConMasPacientesAtendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet63
            // 
            this.cioDental1DataSet63.DataSetName = "CioDental1DataSet63";
            this.cioDental1DataSet63.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topHorasConMasPacientesAtendidosBindingSource
            // 
            this.topHorasConMasPacientesAtendidosBindingSource.DataMember = "TopHorasConMasPacientesAtendidos";
            this.topHorasConMasPacientesAtendidosBindingSource.DataSource = this.cioDental1DataSet63;
            // 
            // topHorasConMasPacientesAtendidosTableAdapter
            // 
            this.topHorasConMasPacientesAtendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteTopHorasConMasPacientesAtendidoscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteTopHorasConMasPacientesAtendidoscs";
            this.Text = "FrmReporteTopHorasConMasPacientesAtendidoscs";
            this.Load += new System.EventHandler(this.FrmReporteTopHorasConMasPacientesAtendidoscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topHorasConMasPacientesAtendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CioDental1DataSet63 cioDental1DataSet63;
        private System.Windows.Forms.BindingSource topHorasConMasPacientesAtendidosBindingSource;
        private CioDental1DataSet63TableAdapters.TopHorasConMasPacientesAtendidosTableAdapter topHorasConMasPacientesAtendidosTableAdapter;
    }
}