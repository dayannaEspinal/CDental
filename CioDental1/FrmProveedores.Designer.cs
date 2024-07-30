namespace CioDental1
{
    partial class FrmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.idProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emlProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTNProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estProvDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet11 = new CioDental1.CioDental1DataSet11();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtRTNProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tratamientosTableAdapter = new CioDental1.CioDental1DataSet12TableAdapters.TratamientosTableAdapter();
            this.lblCodProv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.btnDesactivarProveedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedor.AutoGenerateColumns = false;
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProvDataGridViewTextBoxColumn,
            this.nomProvDataGridViewTextBoxColumn,
            this.numProvDataGridViewTextBoxColumn,
            this.dirProvDataGridViewTextBoxColumn,
            this.emlProvDataGridViewTextBoxColumn,
            this.rTNProvDataGridViewTextBoxColumn,
            this.estProvDataGridViewCheckBoxColumn});
            this.dgvProveedor.DataSource = this.proveedoresBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedor.GridColor = System.Drawing.Color.Teal;
            this.dgvProveedor.Location = new System.Drawing.Point(291, 192);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProveedor.Size = new System.Drawing.Size(763, 240);
            this.dgvProveedor.TabIndex = 47;
            this.dgvProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellContentClick);
            this.dgvProveedor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProveedor_CellFormatting);
            // 
            // idProvDataGridViewTextBoxColumn
            // 
            this.idProvDataGridViewTextBoxColumn.DataPropertyName = "IdProv";
            this.idProvDataGridViewTextBoxColumn.HeaderText = "Id Proveedor";
            this.idProvDataGridViewTextBoxColumn.Name = "idProvDataGridViewTextBoxColumn";
            this.idProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomProvDataGridViewTextBoxColumn
            // 
            this.nomProvDataGridViewTextBoxColumn.DataPropertyName = "NomProv";
            this.nomProvDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomProvDataGridViewTextBoxColumn.Name = "nomProvDataGridViewTextBoxColumn";
            this.nomProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numProvDataGridViewTextBoxColumn
            // 
            this.numProvDataGridViewTextBoxColumn.DataPropertyName = "NumProv";
            this.numProvDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numProvDataGridViewTextBoxColumn.Name = "numProvDataGridViewTextBoxColumn";
            this.numProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirProvDataGridViewTextBoxColumn
            // 
            this.dirProvDataGridViewTextBoxColumn.DataPropertyName = "DirProv";
            this.dirProvDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.dirProvDataGridViewTextBoxColumn.Name = "dirProvDataGridViewTextBoxColumn";
            this.dirProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emlProvDataGridViewTextBoxColumn
            // 
            this.emlProvDataGridViewTextBoxColumn.DataPropertyName = "EmlProv";
            this.emlProvDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emlProvDataGridViewTextBoxColumn.Name = "emlProvDataGridViewTextBoxColumn";
            this.emlProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rTNProvDataGridViewTextBoxColumn
            // 
            this.rTNProvDataGridViewTextBoxColumn.DataPropertyName = "RTNProv";
            this.rTNProvDataGridViewTextBoxColumn.HeaderText = "RTN";
            this.rTNProvDataGridViewTextBoxColumn.Name = "rTNProvDataGridViewTextBoxColumn";
            this.rTNProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estProvDataGridViewCheckBoxColumn
            // 
            this.estProvDataGridViewCheckBoxColumn.DataPropertyName = "EstProv";
            this.estProvDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estProvDataGridViewCheckBoxColumn.Name = "estProvDataGridViewCheckBoxColumn";
            this.estProvDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estProvDataGridViewCheckBoxColumn.Visible = false;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.cioDental1DataSet11;
            // 
            // cioDental1DataSet11
            // 
            this.cioDental1DataSet11.DataSetName = "CioDental1DataSet11";
            this.cioDental1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Buscar";
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(365, 153);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(561, 29);
            this.txtBuscarProveedor.TabIndex = 9;
            this.txtBuscarProveedor.TextChanged += new System.EventHandler(this.txtBuscarProveedor_TextChanged);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarProveedor.Image")));
            this.btnModificarProveedor.Location = new System.Drawing.Point(118, 367);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(53, 52);
            this.btnModificarProveedor.TabIndex = 7;
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProveedor.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProveedor.Image")));
            this.btnGuardarProveedor.Location = new System.Drawing.Point(47, 367);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(53, 52);
            this.btnGuardarProveedor.TabIndex = 6;
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Dirección";
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Location = new System.Drawing.Point(109, 291);
            this.txtCorreoProveedor.MaxLength = 80;
            this.txtCorreoProveedor.Multiline = true;
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(158, 27);
            this.txtCorreoProveedor.TabIndex = 4;
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(109, 258);
            this.txtDireccionProveedor.MaxLength = 100;
            this.txtDireccionProveedor.Multiline = true;
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(158, 27);
            this.txtDireccionProveedor.TabIndex = 3;
            // 
            // txtRTNProveedor
            // 
            this.txtRTNProveedor.Location = new System.Drawing.Point(109, 324);
            this.txtRTNProveedor.MaxLength = 15;
            this.txtRTNProveedor.Multiline = true;
            this.txtRTNProveedor.Name = "txtRTNProveedor";
            this.txtRTNProveedor.Size = new System.Drawing.Size(158, 27);
            this.txtRTNProveedor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "RTN";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(109, 225);
            this.txtTelefonoProveedor.MaxLength = 10;
            this.txtTelefonoProveedor.Multiline = true;
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(158, 27);
            this.txtTelefonoProveedor.TabIndex = 2;
            this.txtTelefonoProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoProveedor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Teléfono";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(109, 192);
            this.txtNombreProveedor.MaxLength = 30;
            this.txtNombreProveedor.Multiline = true;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(158, 27);
            this.txtNombreProveedor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Código";
            // 
            // tratamientosTableAdapter
            // 
            this.tratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // lblCodProv
            // 
            this.lblCodProv.AutoSize = true;
            this.lblCodProv.Location = new System.Drawing.Point(108, 162);
            this.lblCodProv.Name = "lblCodProv";
            this.lblCodProv.Size = new System.Drawing.Size(0, 20);
            this.lblCodProv.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 50);
            this.panel1.TabIndex = 51;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkCyan;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Image = global::CioDental1.Properties.Resources.proveedor_hotelero;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(255, 3);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(250, 45);
            this.button8.TabIndex = 74;
            this.button8.Text = "Proveedores";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnDesactivarProveedores
            // 
            this.btnDesactivarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarProveedores.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDesactivarProveedores.Image = global::CioDental1.Properties.Resources.ocultar;
            this.btnDesactivarProveedores.Location = new System.Drawing.Point(187, 367);
            this.btnDesactivarProveedores.Name = "btnDesactivarProveedores";
            this.btnDesactivarProveedores.Size = new System.Drawing.Size(65, 52);
            this.btnDesactivarProveedores.TabIndex = 8;
            this.btnDesactivarProveedores.UseVisualStyleBackColor = true;
            this.btnDesactivarProveedores.Click += new System.EventHandler(this.btnDesactivarProveedores_Click);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1083, 565);
            this.Controls.Add(this.btnDesactivarProveedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodProv);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorreoProveedor);
            this.Controls.Add(this.txtDireccionProveedor);
            this.Controls.Add(this.txtRTNProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefonoProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtRTNProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private CioDental1DataSet11 cioDental1DataSet11;
        private CioDental1DataSet12TableAdapters.TratamientosTableAdapter tratamientosTableAdapter;
        private System.Windows.Forms.Label lblCodProv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnDesactivarProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTNProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estProvDataGridViewCheckBoxColumn;
    }
}