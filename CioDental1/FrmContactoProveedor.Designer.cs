namespace CioDental1
{
    partial class FrmContactoProveedor
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
            this.dgvContProveedor = new System.Windows.Forms.DataGridView();
            this.idConProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombConProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numConProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emlConProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estConProvDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visContactoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet31 = new CioDental1.CioDental1DataSet31();
            this.contactoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet7 = new CioDental1.CioDental1DataSet7();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarContProveedor = new System.Windows.Forms.TextBox();
            this.btnModificarContProveedor = new System.Windows.Forms.Button();
            this.btnGuardarContProveedor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccionContProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoContProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreContProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCodProv_ConProv = new System.Windows.Forms.ComboBox();
            this.contactoProveedorTableAdapter = new CioDental1.CioDental1DataSet7TableAdapters.ContactoProveedorTableAdapter();
            this.marcasTableAdapter = new CioDental1.CioDental1DataSet8TableAdapters.MarcasTableAdapter();
            this.pacientesTableAdapter = new CioDental1.CioDental1DataSet9TableAdapters.PacientesTableAdapter();
            this.lblCodContProv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.btnDesactivaContProveedores = new System.Windows.Forms.Button();
            this.visContactoProveedorTableAdapter = new CioDental1.CioDental1DataSet31TableAdapters.VisContactoProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visContactoProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet7)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContProveedor
            // 
            this.dgvContProveedor.AllowUserToAddRows = false;
            this.dgvContProveedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvContProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContProveedor.AutoGenerateColumns = false;
            this.dgvContProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContProveedor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConProvDataGridViewTextBoxColumn,
            this.nombConProvDataGridViewTextBoxColumn,
            this.numConProvDataGridViewTextBoxColumn,
            this.emlConProvDataGridViewTextBoxColumn,
            this.estConProvDataGridViewCheckBoxColumn,
            this.idProvDataGridViewTextBoxColumn,
            this.nomProvDataGridViewTextBoxColumn});
            this.dgvContProveedor.DataSource = this.visContactoProveedorBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContProveedor.GridColor = System.Drawing.Color.Teal;
            this.dgvContProveedor.Location = new System.Drawing.Point(319, 163);
            this.dgvContProveedor.Name = "dgvContProveedor";
            this.dgvContProveedor.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvContProveedor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContProveedor.Size = new System.Drawing.Size(744, 206);
            this.dgvContProveedor.TabIndex = 69;
            this.dgvContProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContProveedor_CellContentClick);
            this.dgvContProveedor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContProveedor_CellFormatting);
            // 
            // idConProvDataGridViewTextBoxColumn
            // 
            this.idConProvDataGridViewTextBoxColumn.DataPropertyName = "IdConProv";
            this.idConProvDataGridViewTextBoxColumn.HeaderText = "ID Contacto Proveedor";
            this.idConProvDataGridViewTextBoxColumn.Name = "idConProvDataGridViewTextBoxColumn";
            this.idConProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombConProvDataGridViewTextBoxColumn
            // 
            this.nombConProvDataGridViewTextBoxColumn.DataPropertyName = "NombConProv";
            this.nombConProvDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombConProvDataGridViewTextBoxColumn.Name = "nombConProvDataGridViewTextBoxColumn";
            this.nombConProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numConProvDataGridViewTextBoxColumn
            // 
            this.numConProvDataGridViewTextBoxColumn.DataPropertyName = "NumConProv";
            this.numConProvDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.numConProvDataGridViewTextBoxColumn.Name = "numConProvDataGridViewTextBoxColumn";
            this.numConProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emlConProvDataGridViewTextBoxColumn
            // 
            this.emlConProvDataGridViewTextBoxColumn.DataPropertyName = "EmlConProv";
            this.emlConProvDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emlConProvDataGridViewTextBoxColumn.Name = "emlConProvDataGridViewTextBoxColumn";
            this.emlConProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estConProvDataGridViewCheckBoxColumn
            // 
            this.estConProvDataGridViewCheckBoxColumn.DataPropertyName = "EstConProv";
            this.estConProvDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estConProvDataGridViewCheckBoxColumn.Name = "estConProvDataGridViewCheckBoxColumn";
            this.estConProvDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estConProvDataGridViewCheckBoxColumn.Visible = false;
            // 
            // idProvDataGridViewTextBoxColumn
            // 
            this.idProvDataGridViewTextBoxColumn.DataPropertyName = "IdProv";
            this.idProvDataGridViewTextBoxColumn.HeaderText = "ID Proveedor";
            this.idProvDataGridViewTextBoxColumn.Name = "idProvDataGridViewTextBoxColumn";
            this.idProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomProvDataGridViewTextBoxColumn
            // 
            this.nomProvDataGridViewTextBoxColumn.DataPropertyName = "NomProv";
            this.nomProvDataGridViewTextBoxColumn.HeaderText = "Nombre Proveedor";
            this.nomProvDataGridViewTextBoxColumn.Name = "nomProvDataGridViewTextBoxColumn";
            this.nomProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visContactoProveedorBindingSource
            // 
            this.visContactoProveedorBindingSource.DataMember = "VisContactoProveedor";
            this.visContactoProveedorBindingSource.DataSource = this.cioDental1DataSet31;
            // 
            // cioDental1DataSet31
            // 
            this.cioDental1DataSet31.DataSetName = "CioDental1DataSet31";
            this.cioDental1DataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactoProveedorBindingSource
            // 
            this.contactoProveedorBindingSource.DataMember = "ContactoProveedor";
            this.contactoProveedorBindingSource.DataSource = this.cioDental1DataSet7;
            // 
            // cioDental1DataSet7
            // 
            this.cioDental1DataSet7.DataSetName = "CioDental1DataSet7";
            this.cioDental1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Buscar";
            // 
            // txtBuscarContProveedor
            // 
            this.txtBuscarContProveedor.Location = new System.Drawing.Point(403, 120);
            this.txtBuscarContProveedor.Name = "txtBuscarContProveedor";
            this.txtBuscarContProveedor.Size = new System.Drawing.Size(543, 29);
            this.txtBuscarContProveedor.TabIndex = 8;
            this.txtBuscarContProveedor.TextChanged += new System.EventHandler(this.txtBuscarContProveedor_TextChanged);
            // 
            // btnModificarContProveedor
            // 
            this.btnModificarContProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarContProveedor.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarContProveedor.Image = global::CioDental1.Properties.Resources.editar_archivo1;
            this.btnModificarContProveedor.Location = new System.Drawing.Point(133, 331);
            this.btnModificarContProveedor.Name = "btnModificarContProveedor";
            this.btnModificarContProveedor.Size = new System.Drawing.Size(53, 52);
            this.btnModificarContProveedor.TabIndex = 6;
            this.btnModificarContProveedor.UseVisualStyleBackColor = true;
            this.btnModificarContProveedor.Click += new System.EventHandler(this.btnModificarContProveedor_Click);
            // 
            // btnGuardarContProveedor
            // 
            this.btnGuardarContProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarContProveedor.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarContProveedor.Image = global::CioDental1.Properties.Resources.firmar__2_;
            this.btnGuardarContProveedor.Location = new System.Drawing.Point(63, 331);
            this.btnGuardarContProveedor.Name = "btnGuardarContProveedor";
            this.btnGuardarContProveedor.Size = new System.Drawing.Size(53, 52);
            this.btnGuardarContProveedor.TabIndex = 5;
            this.btnGuardarContProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarContProveedor.Click += new System.EventHandler(this.btnGuardarContProveedor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Correo";
            // 
            // txtDireccionContProveedor
            // 
            this.txtDireccionContProveedor.Location = new System.Drawing.Point(133, 256);
            this.txtDireccionContProveedor.MaxLength = 80;
            this.txtDireccionContProveedor.Multiline = true;
            this.txtDireccionContProveedor.Name = "txtDireccionContProveedor";
            this.txtDireccionContProveedor.Size = new System.Drawing.Size(158, 27);
            this.txtDireccionContProveedor.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Proveedor";
            // 
            // txtTelefonoContProveedor
            // 
            this.txtTelefonoContProveedor.Location = new System.Drawing.Point(133, 223);
            this.txtTelefonoContProveedor.MaxLength = 10;
            this.txtTelefonoContProveedor.Multiline = true;
            this.txtTelefonoContProveedor.Name = "txtTelefonoContProveedor";
            this.txtTelefonoContProveedor.Size = new System.Drawing.Size(158, 27);
            this.txtTelefonoContProveedor.TabIndex = 2;
            this.txtTelefonoContProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoContProveedor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Teléfono";
            // 
            // txtNombreContProveedor
            // 
            this.txtNombreContProveedor.Location = new System.Drawing.Point(133, 190);
            this.txtNombreContProveedor.MaxLength = 50;
            this.txtNombreContProveedor.Multiline = true;
            this.txtNombreContProveedor.Name = "txtNombreContProveedor";
            this.txtNombreContProveedor.Size = new System.Drawing.Size(158, 27);
            this.txtNombreContProveedor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Código";
            // 
            // cbxCodProv_ConProv
            // 
            this.cbxCodProv_ConProv.FormattingEnabled = true;
            this.cbxCodProv_ConProv.Location = new System.Drawing.Point(133, 289);
            this.cbxCodProv_ConProv.Name = "cbxCodProv_ConProv";
            this.cbxCodProv_ConProv.Size = new System.Drawing.Size(158, 28);
            this.cbxCodProv_ConProv.TabIndex = 4;
            this.cbxCodProv_ConProv.SelectedIndexChanged += new System.EventHandler(this.cbxCodProv_ConProv_SelectedIndexChanged);
            // 
            // contactoProveedorTableAdapter
            // 
            this.contactoProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // lblCodContProv
            // 
            this.lblCodContProv.AutoSize = true;
            this.lblCodContProv.Location = new System.Drawing.Point(133, 161);
            this.lblCodContProv.Name = "lblCodContProv";
            this.lblCodContProv.Size = new System.Drawing.Size(0, 20);
            this.lblCodContProv.TabIndex = 74;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 50);
            this.panel1.TabIndex = 75;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DarkCyan;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.Image = global::CioDental1.Properties.Resources.proveedor;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(203, 3);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(412, 45);
            this.button14.TabIndex = 79;
            this.button14.Text = "Contacto Proveedores";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // btnDesactivaContProveedores
            // 
            this.btnDesactivaContProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivaContProveedores.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDesactivaContProveedores.Image = global::CioDental1.Properties.Resources.ocultar;
            this.btnDesactivaContProveedores.Location = new System.Drawing.Point(197, 331);
            this.btnDesactivaContProveedores.Name = "btnDesactivaContProveedores";
            this.btnDesactivaContProveedores.Size = new System.Drawing.Size(65, 52);
            this.btnDesactivaContProveedores.TabIndex = 7;
            this.btnDesactivaContProveedores.UseVisualStyleBackColor = true;
            this.btnDesactivaContProveedores.Click += new System.EventHandler(this.btnDesactivaContProveedores_Click);
            // 
            // visContactoProveedorTableAdapter
            // 
            this.visContactoProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmContactoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1093, 506);
            this.Controls.Add(this.btnDesactivaContProveedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodContProv);
            this.Controls.Add(this.cbxCodProv_ConProv);
            this.Controls.Add(this.dgvContProveedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarContProveedor);
            this.Controls.Add(this.btnModificarContProveedor);
            this.Controls.Add(this.btnGuardarContProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDireccionContProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefonoContProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreContProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmContactoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmContactoProveedor";
            this.Load += new System.EventHandler(this.FrmContactoProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visContactoProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarContProveedor;
        private System.Windows.Forms.Button btnModificarContProveedor;
        private System.Windows.Forms.Button btnGuardarContProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccionContProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonoContProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreContProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCodProv_ConProv;
        private CioDental1DataSet7 cioDental1DataSet7;
        private System.Windows.Forms.BindingSource contactoProveedorBindingSource;
        private CioDental1DataSet7TableAdapters.ContactoProveedorTableAdapter contactoProveedorTableAdapter;
        private CioDental1DataSet8TableAdapters.MarcasTableAdapter marcasTableAdapter;
        private CioDental1DataSet9TableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.Label lblCodContProv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnDesactivaContProveedores;
        private CioDental1DataSet31 cioDental1DataSet31;
        private System.Windows.Forms.BindingSource visContactoProveedorBindingSource;
        private CioDental1DataSet31TableAdapters.VisContactoProveedorTableAdapter visContactoProveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombConProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numConProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlConProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estConProvDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProvDataGridViewTextBoxColumn;
    }
}