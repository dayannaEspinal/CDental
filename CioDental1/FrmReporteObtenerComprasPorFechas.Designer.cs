namespace CioDental1
{
    partial class FrmReporteObtenerComprasPorFechas
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
            this.panelFecCom = new System.Windows.Forms.Panel();
            this.btnRango = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.btnAño = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnAyer = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.cioDental1DataSet93 = new CioDental1.CioDental1DataSet93();
            this.reporteObtenerComprasPorOpcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteObtenerComprasPorOpcionTableAdapter = new CioDental1.CioDental1DataSet93TableAdapters.ReporteObtenerComprasPorOpcionTableAdapter();
            this.panelFecCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerComprasPorOpcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            reportDataSource1.Name = "ObtenerComprasPorFechas";
            reportDataSource1.Value = this.reporteObtenerComprasPorOpcionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CioDental1.RptObtenerComprasPorFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(218, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(907, 523);
            this.reportViewer1.TabIndex = 0;
            // 
            // panelFecCom
            // 
            this.panelFecCom.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelFecCom.Controls.Add(this.btnRango);
            this.panelFecCom.Controls.Add(this.label3);
            this.panelFecCom.Controls.Add(this.label2);
            this.panelFecCom.Controls.Add(this.label1);
            this.panelFecCom.Controls.Add(this.dtpFecFin);
            this.panelFecCom.Controls.Add(this.dtpFecIni);
            this.panelFecCom.Controls.Add(this.btnAño);
            this.panelFecCom.Controls.Add(this.btnMes);
            this.panelFecCom.Controls.Add(this.btnSemana);
            this.panelFecCom.Controls.Add(this.btnAyer);
            this.panelFecCom.Controls.Add(this.btnHoy);
            this.panelFecCom.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFecCom.Location = new System.Drawing.Point(0, 0);
            this.panelFecCom.Name = "panelFecCom";
            this.panelFecCom.Size = new System.Drawing.Size(221, 523);
            this.panelFecCom.TabIndex = 1;
            // 
            // btnRango
            // 
            this.btnRango.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRango.FlatAppearance.BorderSize = 0;
            this.btnRango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRango.ForeColor = System.Drawing.Color.White;
            this.btnRango.Location = new System.Drawing.Point(58, 433);
            this.btnRango.Name = "btnRango";
            this.btnRango.Size = new System.Drawing.Size(93, 52);
            this.btnRango.TabIndex = 19;
            this.btnRango.Text = "Ir";
            this.btnRango.UseVisualStyleBackColor = false;
            this.btnRango.Click += new System.EventHandler(this.btnRango_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha de inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha por rango";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Location = new System.Drawing.Point(41, 401);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(143, 20);
            this.dtpFecFin.TabIndex = 15;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Location = new System.Drawing.Point(41, 338);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(143, 20);
            this.dtpFecIni.TabIndex = 14;
            // 
            // btnAño
            // 
            this.btnAño.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAño.FlatAppearance.BorderSize = 0;
            this.btnAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAño.ForeColor = System.Drawing.Color.White;
            this.btnAño.Location = new System.Drawing.Point(7, 207);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(211, 52);
            this.btnAño.TabIndex = 11;
            this.btnAño.Text = "Hace un año";
            this.btnAño.UseVisualStyleBackColor = false;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // btnMes
            // 
            this.btnMes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMes.FlatAppearance.BorderSize = 0;
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.Location = new System.Drawing.Point(7, 158);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(211, 52);
            this.btnMes.TabIndex = 12;
            this.btnMes.Text = "Hace un mes";
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSemana.FlatAppearance.BorderSize = 0;
            this.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemana.ForeColor = System.Drawing.Color.White;
            this.btnSemana.Location = new System.Drawing.Point(7, 109);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(211, 52);
            this.btnSemana.TabIndex = 13;
            this.btnSemana.Text = "Hace 7 días";
            this.btnSemana.UseVisualStyleBackColor = false;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // btnAyer
            // 
            this.btnAyer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAyer.FlatAppearance.BorderSize = 0;
            this.btnAyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyer.ForeColor = System.Drawing.Color.White;
            this.btnAyer.Location = new System.Drawing.Point(7, 60);
            this.btnAyer.Name = "btnAyer";
            this.btnAyer.Size = new System.Drawing.Size(211, 52);
            this.btnAyer.TabIndex = 10;
            this.btnAyer.Text = "Ayer";
            this.btnAyer.UseVisualStyleBackColor = false;
            this.btnAyer.Click += new System.EventHandler(this.btnAyer_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHoy.FlatAppearance.BorderSize = 0;
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.White;
            this.btnHoy.Location = new System.Drawing.Point(7, 12);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(211, 52);
            this.btnHoy.TabIndex = 9;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = false;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // cioDental1DataSet93
            // 
            this.cioDental1DataSet93.DataSetName = "CioDental1DataSet93";
            this.cioDental1DataSet93.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteObtenerComprasPorOpcionBindingSource
            // 
            this.reporteObtenerComprasPorOpcionBindingSource.DataMember = "ReporteObtenerComprasPorOpcion";
            this.reporteObtenerComprasPorOpcionBindingSource.DataSource = this.cioDental1DataSet93;
            // 
            // reporteObtenerComprasPorOpcionTableAdapter
            // 
            this.reporteObtenerComprasPorOpcionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteObtenerComprasPorFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 523);
            this.Controls.Add(this.panelFecCom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteObtenerComprasPorFechas";
            this.Text = "FrmReporteObtenerComprasPorFechas";
            this.Load += new System.EventHandler(this.FrmReporteObtenerComprasPorFechas_Load);
            this.panelFecCom.ResumeLayout(false);
            this.panelFecCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteObtenerComprasPorOpcionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panelFecCom;
        private System.Windows.Forms.Button btnRango;
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
        private System.Windows.Forms.BindingSource reporteObtenerComprasPorOpcionBindingSource;
        private CioDental1DataSet93 cioDental1DataSet93;
        private CioDental1DataSet93TableAdapters.ReporteObtenerComprasPorOpcionTableAdapter reporteObtenerComprasPorOpcionTableAdapter;
    }
}