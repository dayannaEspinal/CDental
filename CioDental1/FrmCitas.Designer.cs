namespace CioDental1
{
    partial class FrmCitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaCitas = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarCitas = new System.Windows.Forms.TextBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.idCitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apePacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecCitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horCitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estCitDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visCitaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet34 = new CioDental1.CioDental1DataSet34();
            this.visCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet28 = new CioDental1.CioDental1DataSet28();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet6 = new CioDental1.CioDental1DataSet6();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHoraCita = new System.Windows.Forms.DateTimePicker();
            this.cbxCodPac = new System.Windows.Forms.ComboBox();
            this.facturaDetalleTableAdapter = new CioDental1.CioDental1DataSet2TableAdapters.FacturaDetalleTableAdapter();
            this.citasTableAdapter = new CioDental1.CioDental1DataSet6TableAdapters.CitasTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodCit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visCitaTableAdapter = new CioDental1.CioDental1DataSet28TableAdapters.VisCitaTableAdapter();
            this.cioDental1DataSet29 = new CioDental1.CioDental1DataSet29();
            this.visCitaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visCitaTableAdapter1 = new CioDental1.CioDental1DataSet29TableAdapters.VisCitaTableAdapter();
            this.visCitaTableAdapter2 = new CioDental1.CioDental1DataSet35TableAdapters.VisCitaTableAdapter();
            this.btnDesactivarProveedores = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificarCitas = new System.Windows.Forms.Button();
            this.btnGuardarCitas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // dtpFechaCitas
            // 
            this.dtpFechaCitas.Location = new System.Drawing.Point(112, 199);
            this.dtpFechaCitas.Name = "dtpFechaCitas";
            this.dtpFechaCitas.Size = new System.Drawing.Size(186, 29);
            this.dtpFechaCitas.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Buscar";
            // 
            // txtBuscarCitas
            // 
            this.txtBuscarCitas.Location = new System.Drawing.Point(423, 91);
            this.txtBuscarCitas.Name = "txtBuscarCitas";
            this.txtBuscarCitas.Size = new System.Drawing.Size(315, 29);
            this.txtBuscarCitas.TabIndex = 7;
            this.txtBuscarCitas.TextChanged += new System.EventHandler(this.txtBuscarCitas_TextChanged);
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitas.AutoGenerateColumns = false;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCitDataGridViewTextBoxColumn,
            this.idPacDataGridViewTextBoxColumn,
            this.nomPacDataGridViewTextBoxColumn,
            this.apePacDataGridViewTextBoxColumn,
            this.fecCitDataGridViewTextBoxColumn,
            this.horCitDataGridViewTextBoxColumn,
            this.estCitDataGridViewCheckBoxColumn});
            this.dgvCitas.DataSource = this.visCitaBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCitas.GridColor = System.Drawing.Color.Teal;
            this.dgvCitas.Location = new System.Drawing.Point(316, 137);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCitas.Size = new System.Drawing.Size(713, 213);
            this.dgvCitas.TabIndex = 17;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            this.dgvCitas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCitas_CellFormatting);
            // 
            // idCitDataGridViewTextBoxColumn
            // 
            this.idCitDataGridViewTextBoxColumn.DataPropertyName = "IdCit";
            this.idCitDataGridViewTextBoxColumn.HeaderText = "ID Cita";
            this.idCitDataGridViewTextBoxColumn.Name = "idCitDataGridViewTextBoxColumn";
            this.idCitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPacDataGridViewTextBoxColumn
            // 
            this.idPacDataGridViewTextBoxColumn.DataPropertyName = "IdPac";
            this.idPacDataGridViewTextBoxColumn.HeaderText = "ID Paciente";
            this.idPacDataGridViewTextBoxColumn.Name = "idPacDataGridViewTextBoxColumn";
            this.idPacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomPacDataGridViewTextBoxColumn
            // 
            this.nomPacDataGridViewTextBoxColumn.DataPropertyName = "NomPac";
            this.nomPacDataGridViewTextBoxColumn.HeaderText = "Nombre Paciente";
            this.nomPacDataGridViewTextBoxColumn.Name = "nomPacDataGridViewTextBoxColumn";
            this.nomPacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apePacDataGridViewTextBoxColumn
            // 
            this.apePacDataGridViewTextBoxColumn.DataPropertyName = "ApePac";
            this.apePacDataGridViewTextBoxColumn.HeaderText = "Apellido Paciente";
            this.apePacDataGridViewTextBoxColumn.Name = "apePacDataGridViewTextBoxColumn";
            this.apePacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fecCitDataGridViewTextBoxColumn
            // 
            this.fecCitDataGridViewTextBoxColumn.DataPropertyName = "FecCit";
            this.fecCitDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fecCitDataGridViewTextBoxColumn.Name = "fecCitDataGridViewTextBoxColumn";
            this.fecCitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horCitDataGridViewTextBoxColumn
            // 
            this.horCitDataGridViewTextBoxColumn.DataPropertyName = "HorCit";
            this.horCitDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horCitDataGridViewTextBoxColumn.Name = "horCitDataGridViewTextBoxColumn";
            this.horCitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estCitDataGridViewCheckBoxColumn
            // 
            this.estCitDataGridViewCheckBoxColumn.DataPropertyName = "EstCit";
            this.estCitDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estCitDataGridViewCheckBoxColumn.Name = "estCitDataGridViewCheckBoxColumn";
            this.estCitDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estCitDataGridViewCheckBoxColumn.Visible = false;
            // 
            // visCitaBindingSource2
            // 
            this.visCitaBindingSource2.DataMember = "VisCita";
            this.visCitaBindingSource2.DataSource = this.cioDental1DataSet34;
            // 
            // cioDental1DataSet34
            // 
            this.cioDental1DataSet34.DataSetName = "CioDental1DataSet34";
            this.cioDental1DataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visCitaBindingSource
            // 
            this.visCitaBindingSource.DataMember = "VisCita";
            this.visCitaBindingSource.DataSource = this.cioDental1DataSet28;
            // 
            // cioDental1DataSet28
            // 
            this.cioDental1DataSet28.DataSetName = "CioDental1DataSet28";
            this.cioDental1DataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.cioDental1DataSet6;
            // 
            // cioDental1DataSet6
            // 
            this.cioDental1DataSet6.DataSetName = "CioDental1DataSet6";
            this.cioDental1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hora";
            // 
            // dtpHoraCita
            // 
            this.dtpHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraCita.Location = new System.Drawing.Point(112, 234);
            this.dtpHoraCita.Name = "dtpHoraCita";
            this.dtpHoraCita.Size = new System.Drawing.Size(186, 29);
            this.dtpHoraCita.TabIndex = 3;
            // 
            // cbxCodPac
            // 
            this.cbxCodPac.FormattingEnabled = true;
            this.cbxCodPac.Location = new System.Drawing.Point(112, 165);
            this.cbxCodPac.Name = "cbxCodPac";
            this.cbxCodPac.Size = new System.Drawing.Size(186, 28);
            this.cbxCodPac.TabIndex = 1;
            // 
            // facturaDetalleTableAdapter
            // 
            this.facturaDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Código ";
            // 
            // lblCodCit
            // 
            this.lblCodCit.AutoSize = true;
            this.lblCodCit.Location = new System.Drawing.Point(108, 137);
            this.lblCodCit.Name = "lblCodCit";
            this.lblCodCit.Size = new System.Drawing.Size(0, 20);
            this.lblCodCit.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 50);
            this.panel1.TabIndex = 21;
            // 
            // visCitaTableAdapter
            // 
            this.visCitaTableAdapter.ClearBeforeFill = true;
            // 
            // cioDental1DataSet29
            // 
            this.cioDental1DataSet29.DataSetName = "CioDental1DataSet29";
            this.cioDental1DataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visCitaBindingSource1
            // 
            this.visCitaBindingSource1.DataMember = "VisCita";
            this.visCitaBindingSource1.DataSource = this.cioDental1DataSet29;
            // 
            // visCitaTableAdapter1
            // 
            this.visCitaTableAdapter1.ClearBeforeFill = true;
            // 
            // visCitaTableAdapter2
            // 
            this.visCitaTableAdapter2.ClearBeforeFill = true;
            // 
            // btnDesactivarProveedores
            // 
            this.btnDesactivarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarProveedores.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDesactivarProveedores.Image = global::CioDental1.Properties.Resources.ocultar;
            this.btnDesactivarProveedores.Location = new System.Drawing.Point(184, 283);
            this.btnDesactivarProveedores.Name = "btnDesactivarProveedores";
            this.btnDesactivarProveedores.Size = new System.Drawing.Size(65, 52);
            this.btnDesactivarProveedores.TabIndex = 6;
            this.btnDesactivarProveedores.UseVisualStyleBackColor = true;
            this.btnDesactivarProveedores.Click += new System.EventHandler(this.btnDesactivarProveedores_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::CioDental1.Properties.Resources.cita;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(255, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 45);
            this.button2.TabIndex = 68;
            this.button2.Text = "Citas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnModificarCitas
            // 
            this.btnModificarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCitas.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarCitas.Image = global::CioDental1.Properties.Resources.editar_archivo;
            this.btnModificarCitas.Location = new System.Drawing.Point(112, 283);
            this.btnModificarCitas.Name = "btnModificarCitas";
            this.btnModificarCitas.Size = new System.Drawing.Size(53, 52);
            this.btnModificarCitas.TabIndex = 5;
            this.btnModificarCitas.UseVisualStyleBackColor = true;
            this.btnModificarCitas.Click += new System.EventHandler(this.btnModificarCitas_Click);
            // 
            // btnGuardarCitas
            // 
            this.btnGuardarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCitas.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarCitas.Image = global::CioDental1.Properties.Resources.firmar__2_;
            this.btnGuardarCitas.Location = new System.Drawing.Point(49, 283);
            this.btnGuardarCitas.Name = "btnGuardarCitas";
            this.btnGuardarCitas.Size = new System.Drawing.Size(53, 52);
            this.btnGuardarCitas.TabIndex = 4;
            this.btnGuardarCitas.UseVisualStyleBackColor = true;
            this.btnGuardarCitas.Click += new System.EventHandler(this.btnGuardarCitas_Click);
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1058, 464);
            this.Controls.Add(this.btnDesactivarProveedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodCit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCodPac);
            this.Controls.Add(this.dtpHoraCita);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.txtBuscarCitas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaCitas);
            this.Controls.Add(this.btnModificarCitas);
            this.Controls.Add(this.btnGuardarCitas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarCitas;
        private System.Windows.Forms.Button btnModificarCitas;
        private System.Windows.Forms.DateTimePicker dtpFechaCitas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarCitas;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHoraCita;
        private System.Windows.Forms.ComboBox cbxCodPac;
        private CioDental1DataSet2TableAdapters.FacturaDetalleTableAdapter facturaDetalleTableAdapter;
        private CioDental1DataSet6 cioDental1DataSet6;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private CioDental1DataSet6TableAdapters.CitasTableAdapter citasTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodCit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDesactivarProveedores;
        private CioDental1DataSet28 cioDental1DataSet28;
        private System.Windows.Forms.BindingSource visCitaBindingSource;
        private CioDental1DataSet28TableAdapters.VisCitaTableAdapter visCitaTableAdapter;
        private CioDental1DataSet29 cioDental1DataSet29;
        private System.Windows.Forms.BindingSource visCitaBindingSource1;
        private CioDental1DataSet29TableAdapters.VisCitaTableAdapter visCitaTableAdapter1;
        private System.Windows.Forms.BindingSource visCitaBindingSource2;
        private CioDental1DataSet34 cioDental1DataSet34;
        private CioDental1DataSet35TableAdapters.VisCitaTableAdapter visCitaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apePacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecCitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horCitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estCitDataGridViewCheckBoxColumn;
    }
}