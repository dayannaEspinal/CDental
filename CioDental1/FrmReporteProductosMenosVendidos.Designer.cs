namespace CioDental1
{
    partial class FrmReporteProductosMenosVendidos
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
            this.cioDental1DataSet56 = new CioDental1.CioDental1DataSet56();
            this.reporteTop5ProductosMenosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteTop5ProductosMenosVendidosTableAdapter = new CioDental1.CioDental1DataSet56TableAdapters.ReporteTop5ProductosMenosVendidosTableAdapter();
            this.cioDental1DataSet59 = new CioDental1.CioDental1DataSet59();
            this.reporteTop5ProductosMenosVendidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reporteTop5ProductosMenosVendidosTableAdapter1 = new CioDental1.CioDental1DataSet59TableAdapters.ReporteTop5ProductosMenosVendidosTableAdapter();
            this.cioDental1DataSet61 = new CioDental1.CioDental1DataSet61();
            this.reporteTop5ProductosMenosVendidosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reporteTop5ProductosMenosVendidosTableAdapter2 = new CioDental1.CioDental1DataSet61TableAdapters.ReporteTop5ProductosMenosVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5ProductosMenosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5ProductosMenosVendidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5ProductosMenosVendidosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TopProductosMenosVendidos";
            reportDataSource1.Value = this.reporteTop5ProductosMenosVendidosBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptTopProductoSMenosVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet56
            // 
            this.cioDental1DataSet56.DataSetName = "CioDental1DataSet56";
            this.cioDental1DataSet56.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteTop5ProductosMenosVendidosBindingSource
            // 
            this.reporteTop5ProductosMenosVendidosBindingSource.DataMember = "ReporteTop5ProductosMenosVendidos";
            this.reporteTop5ProductosMenosVendidosBindingSource.DataSource = this.cioDental1DataSet56;
            // 
            // reporteTop5ProductosMenosVendidosTableAdapter
            // 
            this.reporteTop5ProductosMenosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // cioDental1DataSet59
            // 
            this.cioDental1DataSet59.DataSetName = "CioDental1DataSet59";
            this.cioDental1DataSet59.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteTop5ProductosMenosVendidosBindingSource1
            // 
            this.reporteTop5ProductosMenosVendidosBindingSource1.DataMember = "ReporteTop5ProductosMenosVendidos";
            this.reporteTop5ProductosMenosVendidosBindingSource1.DataSource = this.cioDental1DataSet59;
            // 
            // reporteTop5ProductosMenosVendidosTableAdapter1
            // 
            this.reporteTop5ProductosMenosVendidosTableAdapter1.ClearBeforeFill = true;
            // 
            // cioDental1DataSet61
            // 
            this.cioDental1DataSet61.DataSetName = "CioDental1DataSet61";
            this.cioDental1DataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteTop5ProductosMenosVendidosBindingSource2
            // 
            this.reporteTop5ProductosMenosVendidosBindingSource2.DataMember = "ReporteTop5ProductosMenosVendidos";
            this.reporteTop5ProductosMenosVendidosBindingSource2.DataSource = this.cioDental1DataSet61;
            // 
            // reporteTop5ProductosMenosVendidosTableAdapter2
            // 
            this.reporteTop5ProductosMenosVendidosTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmReporteProductosMenosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteProductosMenosVendidos";
            this.Text = "FrmReporteProductosMenosVendidos";
            this.Load += new System.EventHandler(this.FrmReporteProductosMenosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5ProductosMenosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5ProductosMenosVendidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTop5ProductosMenosVendidosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CioDental1DataSet56 cioDental1DataSet56;
        private System.Windows.Forms.BindingSource reporteTop5ProductosMenosVendidosBindingSource;
        private CioDental1DataSet56TableAdapters.ReporteTop5ProductosMenosVendidosTableAdapter reporteTop5ProductosMenosVendidosTableAdapter;
        private CioDental1DataSet59 cioDental1DataSet59;
        private System.Windows.Forms.BindingSource reporteTop5ProductosMenosVendidosBindingSource1;
        private CioDental1DataSet59TableAdapters.ReporteTop5ProductosMenosVendidosTableAdapter reporteTop5ProductosMenosVendidosTableAdapter1;
        private CioDental1DataSet61 cioDental1DataSet61;
        private System.Windows.Forms.BindingSource reporteTop5ProductosMenosVendidosBindingSource2;
        private CioDental1DataSet61TableAdapters.ReporteTop5ProductosMenosVendidosTableAdapter reporteTop5ProductosMenosVendidosTableAdapter2;
    }
}