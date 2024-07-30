namespace CioDental1
{
    partial class BuscarCitas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvListaCitas = new System.Windows.Forms.DataGridView();
            this.visCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet32 = new CioDental1.CioDental1DataSet32();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet17 = new CioDental1.CioDental1DataSet17();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarCitas = new System.Windows.Forms.TextBox();
            this.citasTableAdapter = new CioDental1.CioDental1DataSet17TableAdapters.CitasTableAdapter();
            this.cioDental1DataSet35 = new CioDental1.CioDental1DataSet35();
            this.visCitaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idCitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apePacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecCitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horCitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estCitDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 50);
            this.panel1.TabIndex = 22;
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
            // dgvListaCitas
            // 
            this.dgvListaCitas.AllowUserToAddRows = false;
            this.dgvListaCitas.AllowUserToDeleteRows = false;
            this.dgvListaCitas.AutoGenerateColumns = false;
            this.dgvListaCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCitas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCitDataGridViewTextBoxColumn,
            this.idPacDataGridViewTextBoxColumn,
            this.nomPacDataGridViewTextBoxColumn,
            this.apePacDataGridViewTextBoxColumn,
            this.fecCitDataGridViewTextBoxColumn,
            this.horCitDataGridViewTextBoxColumn,
            this.estCitDataGridViewCheckBoxColumn});
            this.dgvListaCitas.DataSource = this.visCitaBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCitas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaCitas.GridColor = System.Drawing.Color.Teal;
            this.dgvListaCitas.Location = new System.Drawing.Point(26, 110);
            this.dgvListaCitas.Name = "dgvListaCitas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvListaCitas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaCitas.Size = new System.Drawing.Size(680, 253);
            this.dgvListaCitas.TabIndex = 34;
            this.dgvListaCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCitas_CellClick);
            this.dgvListaCitas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaCitas_CellFormatting);
            // 
            // visCitaBindingSource
            // 
            this.visCitaBindingSource.DataMember = "VisCita";
            this.visCitaBindingSource.DataSource = this.cioDental1DataSet32;
            // 
            // cioDental1DataSet32
            // 
            this.cioDental1DataSet32.DataSetName = "CioDental1DataSet32";
            this.cioDental1DataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.cioDental1DataSet17;
            this.citasBindingSource.CurrentChanged += new System.EventHandler(this.citasBindingSource_CurrentChanged);
            // 
            // cioDental1DataSet17
            // 
            this.cioDental1DataSet17.DataSetName = "CioDental1DataSet17";
            this.cioDental1DataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(47, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Buscar";
            // 
            // txtBuscarCitas
            // 
            this.txtBuscarCitas.Location = new System.Drawing.Point(122, 65);
            this.txtBuscarCitas.Multiline = true;
            this.txtBuscarCitas.Name = "txtBuscarCitas";
            this.txtBuscarCitas.Size = new System.Drawing.Size(370, 23);
            this.txtBuscarCitas.TabIndex = 32;
            this.txtBuscarCitas.TextChanged += new System.EventHandler(this.txtBuscarCitas_TextChanged);
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // cioDental1DataSet35
            // 
            this.cioDental1DataSet35.DataSetName = "CioDental1DataSet35";
            this.cioDental1DataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visCitaBindingSource1
            // 
            this.visCitaBindingSource1.DataMember = "VisCita";
            this.visCitaBindingSource1.DataSource = this.cioDental1DataSet35;
            // 
            // idCitDataGridViewTextBoxColumn
            // 
            this.idCitDataGridViewTextBoxColumn.DataPropertyName = "IdCit";
            this.idCitDataGridViewTextBoxColumn.HeaderText = "ID Cita";
            this.idCitDataGridViewTextBoxColumn.Name = "idCitDataGridViewTextBoxColumn";
            // 
            // idPacDataGridViewTextBoxColumn
            // 
            this.idPacDataGridViewTextBoxColumn.DataPropertyName = "IdPac";
            this.idPacDataGridViewTextBoxColumn.HeaderText = "ID Paciente";
            this.idPacDataGridViewTextBoxColumn.Name = "idPacDataGridViewTextBoxColumn";
            // 
            // nomPacDataGridViewTextBoxColumn
            // 
            this.nomPacDataGridViewTextBoxColumn.DataPropertyName = "NomPac";
            this.nomPacDataGridViewTextBoxColumn.HeaderText = "Nombre Paciente";
            this.nomPacDataGridViewTextBoxColumn.Name = "nomPacDataGridViewTextBoxColumn";
            // 
            // apePacDataGridViewTextBoxColumn
            // 
            this.apePacDataGridViewTextBoxColumn.DataPropertyName = "ApePac";
            this.apePacDataGridViewTextBoxColumn.HeaderText = "Apellido Paciente";
            this.apePacDataGridViewTextBoxColumn.Name = "apePacDataGridViewTextBoxColumn";
            // 
            // fecCitDataGridViewTextBoxColumn
            // 
            this.fecCitDataGridViewTextBoxColumn.DataPropertyName = "FecCit";
            this.fecCitDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fecCitDataGridViewTextBoxColumn.Name = "fecCitDataGridViewTextBoxColumn";
            // 
            // horCitDataGridViewTextBoxColumn
            // 
            this.horCitDataGridViewTextBoxColumn.DataPropertyName = "HorCit";
            this.horCitDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horCitDataGridViewTextBoxColumn.Name = "horCitDataGridViewTextBoxColumn";
            // 
            // estCitDataGridViewCheckBoxColumn
            // 
            this.estCitDataGridViewCheckBoxColumn.DataPropertyName = "EstCit";
            this.estCitDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estCitDataGridViewCheckBoxColumn.Name = "estCitDataGridViewCheckBoxColumn";
            this.estCitDataGridViewCheckBoxColumn.Visible = false;
            // 
            // BuscarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(729, 385);
            this.Controls.Add(this.dgvListaCitas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarCitas);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarCitas";
            this.Load += new System.EventHandler(this.BuscarCitas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visCitaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvListaCitas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarCitas;
        private CioDental1DataSet17 cioDental1DataSet17;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private CioDental1DataSet17TableAdapters.CitasTableAdapter citasTableAdapter;
        private System.Windows.Forms.BindingSource visCitaBindingSource;
        private CioDental1DataSet32 cioDental1DataSet32;
        private System.Windows.Forms.BindingSource visCitaBindingSource1;
        private CioDental1DataSet35 cioDental1DataSet35;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apePacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecCitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horCitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estCitDataGridViewCheckBoxColumn;
    }
}