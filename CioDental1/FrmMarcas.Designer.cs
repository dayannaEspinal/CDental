namespace CioDental1
{
    partial class FrmMarcas
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
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.idMarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet8 = new CioDental1.CioDental1DataSet8();
            this.lblCodMarca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Location = new System.Drawing.Point(108, 218);
            this.txtNombreMarca.MaxLength = 30;
            this.txtNombreMarca.Multiline = true;
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(181, 27);
            this.txtNombreMarca.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código ";
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMarca.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarMarca.Image = global::CioDental1.Properties.Resources.editar_archivo1;
            this.btnModificarMarca.Location = new System.Drawing.Point(176, 265);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(53, 52);
            this.btnModificarMarca.TabIndex = 3;
            this.btnModificarMarca.Text = "\r\n";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMarca.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarMarca.Image = global::CioDental1.Properties.Resources.firmar__2_;
            this.btnGuardarMarca.Location = new System.Drawing.Point(102, 265);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(53, 52);
            this.btnGuardarMarca.TabIndex = 2;
            this.btnGuardarMarca.Text = "\r\n";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Buscar";
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Location = new System.Drawing.Point(396, 131);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(318, 29);
            this.txtBuscarMarca.TabIndex = 4;
            this.txtBuscarMarca.TextChanged += new System.EventHandler(this.txtBuscarMarca_TextChanged);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarca.AutoGenerateColumns = false;
            this.dgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarca.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarDataGridViewTextBoxColumn,
            this.nomMarDataGridViewTextBoxColumn});
            this.dgvMarca.DataSource = this.marcasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarca.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarca.GridColor = System.Drawing.Color.Teal;
            this.dgvMarca.Location = new System.Drawing.Point(317, 179);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvMarca.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMarca.Size = new System.Drawing.Size(432, 175);
            this.dgvMarca.TabIndex = 26;
            this.dgvMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarca_CellContentClick);
            // 
            // idMarDataGridViewTextBoxColumn
            // 
            this.idMarDataGridViewTextBoxColumn.DataPropertyName = "IdMar";
            this.idMarDataGridViewTextBoxColumn.HeaderText = "Id Marca";
            this.idMarDataGridViewTextBoxColumn.Name = "idMarDataGridViewTextBoxColumn";
            this.idMarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomMarDataGridViewTextBoxColumn
            // 
            this.nomMarDataGridViewTextBoxColumn.DataPropertyName = "NomMar";
            this.nomMarDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomMarDataGridViewTextBoxColumn.Name = "nomMarDataGridViewTextBoxColumn";
            this.nomMarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.cioDental1DataSet8;
            // 
            // cioDental1DataSet8
            // 
            this.cioDental1DataSet8.DataSetName = "CioDental1DataSet8";
            this.cioDental1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCodMarca
            // 
            this.lblCodMarca.AutoSize = true;
            this.lblCodMarca.Location = new System.Drawing.Point(104, 185);
            this.lblCodMarca.Name = "lblCodMarca";
            this.lblCodMarca.Size = new System.Drawing.Size(0, 20);
            this.lblCodMarca.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 50);
            this.panel1.TabIndex = 28;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkCyan;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Image = global::CioDental1.Properties.Resources.ubicacion;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(298, 3);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(250, 45);
            this.button12.TabIndex = 76;
            this.button12.Text = "Marcas";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(792, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodMarca);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.FrmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private CioDental1DataSet8 cioDental1DataSet8;
        private System.Windows.Forms.Label lblCodMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button12;
    }
}