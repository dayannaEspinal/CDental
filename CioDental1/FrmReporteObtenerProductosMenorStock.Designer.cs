﻿namespace CioDental1
{
    partial class FrmReporteObtenerProductosMenorStock
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
            this.cioDental1DataSet87 = new CioDental1.CioDental1DataSet87();
            this.reporteObtenerProductosMenorStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteObtenerProductosMenorStockTableAdapter = new CioDental1.CioDental1DataSet87TableAdapters.ReporteObtenerProductosMenorStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerProductosMenorStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ObtenerProductosMenorStock";
            reportDataSource1.Value = this.reporteObtenerProductosMenorStockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptObtenerProductosMenorStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet87
            // 
            this.cioDental1DataSet87.DataSetName = "CioDental1DataSet87";
            this.cioDental1DataSet87.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteObtenerProductosMenorStockBindingSource
            // 
            this.reporteObtenerProductosMenorStockBindingSource.DataMember = "ReporteObtenerProductosMenorStock";
            this.reporteObtenerProductosMenorStockBindingSource.DataSource = this.cioDental1DataSet87;
            // 
            // reporteObtenerProductosMenorStockTableAdapter
            // 
            this.reporteObtenerProductosMenorStockTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteObtenerProductosMenorStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteObtenerProductosMenorStock";
            this.Text = "FrmReporteObtenerProductosMenorStock";
            this.Load += new System.EventHandler(this.FrmReporteObtenerProductosMenorStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerProductosMenorStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CioDental1DataSet87 cioDental1DataSet87;
        private System.Windows.Forms.BindingSource reporteObtenerProductosMenorStockBindingSource;
        private CioDental1DataSet87TableAdapters.ReporteObtenerProductosMenorStockTableAdapter reporteObtenerProductosMenorStockTableAdapter;
    }
}