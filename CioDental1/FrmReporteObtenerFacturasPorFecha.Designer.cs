namespace CioDental1
{
    partial class FrmReporteObtenerFacturasPorFecha
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
            this.panelFechaFactura = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnAyer = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnAño = new System.Windows.Forms.Button();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRango = new System.Windows.Forms.Button();
            this.cioDental1DataSet91 = new CioDental1.CioDental1DataSet91();
            this.reporteObtenerFacturasPorOpcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteObtenerFacturasPorOpcionTableAdapter = new CioDental1.CioDental1DataSet91TableAdapters.ReporteObtenerFacturasPorOpcionTableAdapter();
            this.panelFechaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerFacturasPorOpcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFechaFactura
            // 
            this.panelFechaFactura.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelFechaFactura.Controls.Add(this.btnRango);
            this.panelFechaFactura.Controls.Add(this.label3);
            this.panelFechaFactura.Controls.Add(this.label2);
            this.panelFechaFactura.Controls.Add(this.label1);
            this.panelFechaFactura.Controls.Add(this.dtpFecFin);
            this.panelFechaFactura.Controls.Add(this.dtpFecIni);
            this.panelFechaFactura.Controls.Add(this.btnAño);
            this.panelFechaFactura.Controls.Add(this.btnMes);
            this.panelFechaFactura.Controls.Add(this.btnSemana);
            this.panelFechaFactura.Controls.Add(this.btnAyer);
            this.panelFechaFactura.Controls.Add(this.btnHoy);
            this.panelFechaFactura.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFechaFactura.ForeColor = System.Drawing.Color.White;
            this.panelFechaFactura.Location = new System.Drawing.Point(0, 0);
            this.panelFechaFactura.Name = "panelFechaFactura";
            this.panelFechaFactura.Size = new System.Drawing.Size(211, 575);
            this.panelFechaFactura.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ObtenerFacturasPorFechas";
            reportDataSource1.Value = this.reporteObtenerFacturasPorOpcionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptObtenerFacturasPorFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(211, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(840, 575);
            this.reportViewer1.TabIndex = 1;
            // 
            // btnHoy
            // 
            this.btnHoy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHoy.FlatAppearance.BorderSize = 0;
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.White;
            this.btnHoy.Location = new System.Drawing.Point(0, 19);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(211, 52);
            this.btnHoy.TabIndex = 0;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = false;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btnAyer
            // 
            this.btnAyer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAyer.FlatAppearance.BorderSize = 0;
            this.btnAyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyer.ForeColor = System.Drawing.Color.White;
            this.btnAyer.Location = new System.Drawing.Point(0, 67);
            this.btnAyer.Name = "btnAyer";
            this.btnAyer.Size = new System.Drawing.Size(211, 52);
            this.btnAyer.TabIndex = 1;
            this.btnAyer.Text = "Ayer";
            this.btnAyer.UseVisualStyleBackColor = false;
            this.btnAyer.Click += new System.EventHandler(this.btnAyer_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSemana.FlatAppearance.BorderSize = 0;
            this.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemana.ForeColor = System.Drawing.Color.White;
            this.btnSemana.Location = new System.Drawing.Point(0, 116);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(211, 52);
            this.btnSemana.TabIndex = 2;
            this.btnSemana.Text = "Hace 7 días";
            this.btnSemana.UseVisualStyleBackColor = false;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // btnMes
            // 
            this.btnMes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMes.FlatAppearance.BorderSize = 0;
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.Location = new System.Drawing.Point(0, 165);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(211, 52);
            this.btnMes.TabIndex = 2;
            this.btnMes.Text = "Hace un mes";
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnAño
            // 
            this.btnAño.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAño.FlatAppearance.BorderSize = 0;
            this.btnAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAño.ForeColor = System.Drawing.Color.White;
            this.btnAño.Location = new System.Drawing.Point(0, 214);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(211, 52);
            this.btnAño.TabIndex = 2;
            this.btnAño.Text = "Hace un año";
            this.btnAño.UseVisualStyleBackColor = false;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Location = new System.Drawing.Point(34, 345);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(143, 26);
            this.dtpFecIni.TabIndex = 3;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Location = new System.Drawing.Point(34, 408);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(143, 26);
            this.dtpFecFin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha por rango";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha final";
            // 
            // btnRango
            // 
            this.btnRango.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRango.FlatAppearance.BorderSize = 0;
            this.btnRango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRango.ForeColor = System.Drawing.Color.White;
            this.btnRango.Location = new System.Drawing.Point(51, 440);
            this.btnRango.Name = "btnRango";
            this.btnRango.Size = new System.Drawing.Size(93, 52);
            this.btnRango.TabIndex = 8;
            this.btnRango.Text = "Ir";
            this.btnRango.UseVisualStyleBackColor = false;
            this.btnRango.Click += new System.EventHandler(this.btnRango_Click);
            // 
            // cioDental1DataSet91
            // 
            this.cioDental1DataSet91.DataSetName = "CioDental1DataSet91";
            this.cioDental1DataSet91.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteObtenerFacturasPorOpcionBindingSource
            // 
            this.reporteObtenerFacturasPorOpcionBindingSource.DataMember = "ReporteObtenerFacturasPorOpcion";
            this.reporteObtenerFacturasPorOpcionBindingSource.DataSource = this.cioDental1DataSet91;
            // 
            // reporteObtenerFacturasPorOpcionTableAdapter
            // 
            this.reporteObtenerFacturasPorOpcionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteObtenerFacturasPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 575);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelFechaFactura);
            this.Name = "FrmReporteObtenerFacturasPorFecha";
            this.Text = "FrmReporteObtenerFacturasPorFecha";
            this.Load += new System.EventHandler(this.FrmReporteObtenerFacturasPorFecha_Load);
            this.panelFechaFactura.ResumeLayout(false);
            this.panelFechaFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerFacturasPorOpcionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFechaFactura;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Button btnAño;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.Button btnAyer;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnRango;
        private System.Windows.Forms.BindingSource reporteObtenerFacturasPorOpcionBindingSource;
        private CioDental1DataSet91 cioDental1DataSet91;
        private CioDental1DataSet91TableAdapters.ReporteObtenerFacturasPorOpcionTableAdapter reporteObtenerFacturasPorOpcionTableAdapter;
    }
}