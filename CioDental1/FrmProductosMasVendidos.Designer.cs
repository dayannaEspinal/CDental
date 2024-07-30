namespace CioDental1
{
    partial class FrmProductosMasVendidos
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
            this.cioDental1DataSet48 = new CioDental1.CioDental1DataSet48();
            this.obtenerTop5ProductosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerTop5ProductosMasVendidosTableAdapter = new CioDental1.CioDental1DataSet48TableAdapters.ObtenerTop5ProductosMasVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerTop5ProductosMasVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TopProductos";
            reportDataSource1.Value = this.obtenerTop5ProductosMasVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptTopProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cioDental1DataSet48
            // 
            this.cioDental1DataSet48.DataSetName = "CioDental1DataSet48";
            this.cioDental1DataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obtenerTop5ProductosMasVendidosBindingSource
            // 
            this.obtenerTop5ProductosMasVendidosBindingSource.DataMember = "ObtenerTop5ProductosMasVendidos";
            this.obtenerTop5ProductosMasVendidosBindingSource.DataSource = this.cioDental1DataSet48;
            // 
            // obtenerTop5ProductosMasVendidosTableAdapter
            // 
            this.obtenerTop5ProductosMasVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProductosMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmProductosMasVendidos";
            this.Text = "FrmProductosMasVendidos";
            this.Load += new System.EventHandler(this.FrmProductosMasVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerTop5ProductosMasVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CioDental1DataSet48 cioDental1DataSet48;
        private System.Windows.Forms.BindingSource obtenerTop5ProductosMasVendidosBindingSource;
        private CioDental1DataSet48TableAdapters.ObtenerTop5ProductosMasVendidosTableAdapter obtenerTop5ProductosMasVendidosTableAdapter;
    }
}