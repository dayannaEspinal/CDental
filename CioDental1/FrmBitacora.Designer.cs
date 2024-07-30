namespace CioDental1
{
    partial class FrmBitacora
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
            this.dgvBitacoras = new System.Windows.Forms.DataGridView();
            this.idBitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecBitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrBitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decBitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet13 = new CioDental1.CioDental1DataSet13();
            this.bitacoraTableAdapter = new CioDental1.CioDental1DataSet13TableAdapters.BitacoraTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarBitacoras = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet13)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBitacoras
            // 
            this.dgvBitacoras.AllowUserToAddRows = false;
            this.dgvBitacoras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvBitacoras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBitacoras.AutoGenerateColumns = false;
            this.dgvBitacoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacoras.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBitacoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBitDataGridViewTextBoxColumn,
            this.fecBitDataGridViewTextBoxColumn,
            this.hrBitDataGridViewTextBoxColumn,
            this.decBitDataGridViewTextBoxColumn,
            this.idUsrDataGridViewTextBoxColumn});
            this.dgvBitacoras.DataSource = this.bitacoraBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBitacoras.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBitacoras.GridColor = System.Drawing.Color.Teal;
            this.dgvBitacoras.Location = new System.Drawing.Point(29, 159);
            this.dgvBitacoras.Name = "dgvBitacoras";
            this.dgvBitacoras.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacoras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvBitacoras.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBitacoras.Size = new System.Drawing.Size(1053, 346);
            this.dgvBitacoras.TabIndex = 0;
            // 
            // idBitDataGridViewTextBoxColumn
            // 
            this.idBitDataGridViewTextBoxColumn.DataPropertyName = "IdBit";
            this.idBitDataGridViewTextBoxColumn.HeaderText = "Id Bitacora";
            this.idBitDataGridViewTextBoxColumn.Name = "idBitDataGridViewTextBoxColumn";
            this.idBitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fecBitDataGridViewTextBoxColumn
            // 
            this.fecBitDataGridViewTextBoxColumn.DataPropertyName = "FecBit";
            this.fecBitDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fecBitDataGridViewTextBoxColumn.Name = "fecBitDataGridViewTextBoxColumn";
            this.fecBitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hrBitDataGridViewTextBoxColumn
            // 
            this.hrBitDataGridViewTextBoxColumn.DataPropertyName = "HrBit";
            this.hrBitDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.hrBitDataGridViewTextBoxColumn.Name = "hrBitDataGridViewTextBoxColumn";
            this.hrBitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // decBitDataGridViewTextBoxColumn
            // 
            this.decBitDataGridViewTextBoxColumn.DataPropertyName = "DecBit";
            this.decBitDataGridViewTextBoxColumn.HeaderText = "Acción";
            this.decBitDataGridViewTextBoxColumn.Name = "decBitDataGridViewTextBoxColumn";
            this.decBitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUsrDataGridViewTextBoxColumn
            // 
            this.idUsrDataGridViewTextBoxColumn.DataPropertyName = "IdUsr";
            this.idUsrDataGridViewTextBoxColumn.HeaderText = "Id Usuario";
            this.idUsrDataGridViewTextBoxColumn.Name = "idUsrDataGridViewTextBoxColumn";
            this.idUsrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bitacoraBindingSource
            // 
            this.bitacoraBindingSource.DataMember = "Bitacora";
            this.bitacoraBindingSource.DataSource = this.cioDental1DataSet13;
            // 
            // cioDental1DataSet13
            // 
            this.cioDental1DataSet13.DataSetName = "CioDental1DataSet13";
            this.cioDental1DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitacoraTableAdapter
            // 
            this.bitacoraTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar";
            // 
            // txtBuscarBitacoras
            // 
            this.txtBuscarBitacoras.Location = new System.Drawing.Point(112, 112);
            this.txtBuscarBitacoras.Name = "txtBuscarBitacoras";
            this.txtBuscarBitacoras.Size = new System.Drawing.Size(493, 29);
            this.txtBuscarBitacoras.TabIndex = 3;
            this.txtBuscarBitacoras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 50);
            this.panel1.TabIndex = 4;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DarkCyan;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Image = global::CioDental1.Properties.Resources.web;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(271, 3);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(250, 45);
            this.button11.TabIndex = 77;
            this.button11.Text = "Bitacora";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1118, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscarBitacoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBitacoras);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBitacora";
            this.Load += new System.EventHandler(this.FrmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet13)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacoras;
        private CioDental1DataSet13 cioDental1DataSet13;
        private System.Windows.Forms.BindingSource bitacoraBindingSource;
        private CioDental1DataSet13TableAdapters.BitacoraTableAdapter bitacoraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecBitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrBitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decBitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsrDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarBitacoras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button11;
    }
}