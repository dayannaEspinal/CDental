namespace CioDental1
{
    partial class FrmTratamiento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionTratamiento = new System.Windows.Forms.TextBox();
            this.txtCostoTratamiento = new System.Windows.Forms.TextBox();
            this.btnModificarTratamiento = new System.Windows.Forms.Button();
            this.btnGuardarTratamiento = new System.Windows.Forms.Button();
            this.dgvTratamiento = new System.Windows.Forms.DataGridView();
            this.idTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet12 = new CioDental1.CioDental1DataSet12();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarTratamiento = new System.Windows.Forms.TextBox();
            this.lblCodTra = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet12)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo";
            // 
            // txtDescripcionTratamiento
            // 
            this.txtDescripcionTratamiento.Location = new System.Drawing.Point(120, 209);
            this.txtDescripcionTratamiento.MaxLength = 100;
            this.txtDescripcionTratamiento.Multiline = true;
            this.txtDescripcionTratamiento.Name = "txtDescripcionTratamiento";
            this.txtDescripcionTratamiento.Size = new System.Drawing.Size(158, 27);
            this.txtDescripcionTratamiento.TabIndex = 1;
            // 
            // txtCostoTratamiento
            // 
            this.txtCostoTratamiento.Location = new System.Drawing.Point(120, 242);
            this.txtCostoTratamiento.MaxLength = 10;
            this.txtCostoTratamiento.Multiline = true;
            this.txtCostoTratamiento.Name = "txtCostoTratamiento";
            this.txtCostoTratamiento.Size = new System.Drawing.Size(158, 27);
            this.txtCostoTratamiento.TabIndex = 2;
            this.txtCostoTratamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoTratamiento_KeyPress);
            // 
            // btnModificarTratamiento
            // 
            this.btnModificarTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTratamiento.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarTratamiento.Image = global::CioDental1.Properties.Resources.editar_archivo1;
            this.btnModificarTratamiento.Location = new System.Drawing.Point(149, 285);
            this.btnModificarTratamiento.Name = "btnModificarTratamiento";
            this.btnModificarTratamiento.Size = new System.Drawing.Size(53, 52);
            this.btnModificarTratamiento.TabIndex = 4;
            this.btnModificarTratamiento.UseVisualStyleBackColor = true;
            this.btnModificarTratamiento.Click += new System.EventHandler(this.btnModificarTratamiento_Click);
            // 
            // btnGuardarTratamiento
            // 
            this.btnGuardarTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTratamiento.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarTratamiento.Image = global::CioDental1.Properties.Resources.firmar__2_;
            this.btnGuardarTratamiento.Location = new System.Drawing.Point(79, 285);
            this.btnGuardarTratamiento.Name = "btnGuardarTratamiento";
            this.btnGuardarTratamiento.Size = new System.Drawing.Size(53, 52);
            this.btnGuardarTratamiento.TabIndex = 3;
            this.btnGuardarTratamiento.UseVisualStyleBackColor = true;
            this.btnGuardarTratamiento.Click += new System.EventHandler(this.btnGuardarTratamiento_Click);
            // 
            // dgvTratamiento
            // 
            this.dgvTratamiento.AllowUserToAddRows = false;
            this.dgvTratamiento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvTratamiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTratamiento.AutoGenerateColumns = false;
            this.dgvTratamiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTratamiento.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTratamiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTraDataGridViewTextBoxColumn,
            this.desTraDataGridViewTextBoxColumn,
            this.cosTraDataGridViewTextBoxColumn});
            this.dgvTratamiento.DataSource = this.tratamientosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTratamiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTratamiento.GridColor = System.Drawing.Color.Teal;
            this.dgvTratamiento.Location = new System.Drawing.Point(298, 180);
            this.dgvTratamiento.Name = "dgvTratamiento";
            this.dgvTratamiento.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTratamiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvTratamiento.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTratamiento.Size = new System.Drawing.Size(646, 241);
            this.dgvTratamiento.TabIndex = 12;
            this.dgvTratamiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTratamiento_CellContentClick);
            // 
            // idTraDataGridViewTextBoxColumn
            // 
            this.idTraDataGridViewTextBoxColumn.DataPropertyName = "IdTra";
            this.idTraDataGridViewTextBoxColumn.HeaderText = "Id Tratramiento";
            this.idTraDataGridViewTextBoxColumn.Name = "idTraDataGridViewTextBoxColumn";
            this.idTraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desTraDataGridViewTextBoxColumn
            // 
            this.desTraDataGridViewTextBoxColumn.DataPropertyName = "DesTra";
            this.desTraDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.desTraDataGridViewTextBoxColumn.Name = "desTraDataGridViewTextBoxColumn";
            this.desTraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cosTraDataGridViewTextBoxColumn
            // 
            this.cosTraDataGridViewTextBoxColumn.DataPropertyName = "CosTra";
            this.cosTraDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.cosTraDataGridViewTextBoxColumn.Name = "cosTraDataGridViewTextBoxColumn";
            this.cosTraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tratamientosBindingSource
            // 
            this.tratamientosBindingSource.DataMember = "Tratamientos";
            this.tratamientosBindingSource.DataSource = this.cioDental1DataSet12;
            // 
            // cioDental1DataSet12
            // 
            this.cioDental1DataSet12.DataSetName = "CioDental1DataSet12";
            this.cioDental1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Buscar";
            // 
            // txtBuscarTratamiento
            // 
            this.txtBuscarTratamiento.Location = new System.Drawing.Point(365, 129);
            this.txtBuscarTratamiento.Name = "txtBuscarTratamiento";
            this.txtBuscarTratamiento.Size = new System.Drawing.Size(371, 29);
            this.txtBuscarTratamiento.TabIndex = 5;
            this.txtBuscarTratamiento.TextChanged += new System.EventHandler(this.txtBuscarTratamiento_TextChanged);
            // 
            // lblCodTra
            // 
            this.lblCodTra.AutoSize = true;
            this.lblCodTra.Location = new System.Drawing.Point(116, 180);
            this.lblCodTra.Name = "lblCodTra";
            this.lblCodTra.Size = new System.Drawing.Size(0, 20);
            this.lblCodTra.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 50);
            this.panel1.TabIndex = 53;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkCyan;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Image = global::CioDental1.Properties.Resources.tratamiento;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(255, 3);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(250, 45);
            this.button9.TabIndex = 73;
            this.button9.Text = "Tratamientos";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // FrmTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(978, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodTra);
            this.Controls.Add(this.txtBuscarTratamiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTratamiento);
            this.Controls.Add(this.btnGuardarTratamiento);
            this.Controls.Add(this.btnModificarTratamiento);
            this.Controls.Add(this.txtCostoTratamiento);
            this.Controls.Add(this.txtDescripcionTratamiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTratamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamientos";
            this.Load += new System.EventHandler(this.FrmTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet12)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionTratamiento;
        private System.Windows.Forms.TextBox txtCostoTratamiento;
        private System.Windows.Forms.Button btnModificarTratamiento;
        private System.Windows.Forms.Button btnGuardarTratamiento;
        private System.Windows.Forms.DataGridView dgvTratamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tratamientosBindingSource;
        private CioDental1DataSet12 cioDental1DataSet12;
        private System.Windows.Forms.Label lblCodTra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
    }
}