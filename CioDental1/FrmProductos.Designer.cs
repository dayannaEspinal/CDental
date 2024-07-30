namespace CioDental1
{
    partial class FrmProductos
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
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecVenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet66 = new CioDental1.CioDental1DataSet66();
            this.visProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet30 = new CioDental1.CioDental1DataSet30();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet10 = new CioDental1.CioDental1DataSet10();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.proveedoresTableAdapter = new CioDental1.CioDental1DataSet11TableAdapters.ProveedoresTableAdapter();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visProductoTableAdapter = new CioDental1.CioDental1DataSet30TableAdapters.VisProductoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecVen = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nUdStockPro = new System.Windows.Forms.NumericUpDown();
            this.visProductoTableAdapter1 = new CioDental1.CioDental1DataSet66TableAdapters.VisProductoTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet10)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdStockPro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(117, 204);
            this.txtDescripcionProducto.MaxLength = 100;
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(158, 27);
            this.txtDescripcionProducto.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripción";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(117, 171);
            this.txtNombreProducto.MaxLength = 50;
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(158, 27);
            this.txtNombreProducto.TabIndex = 1;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Marca";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(117, 272);
            this.txtPrecioProducto.MaxLength = 10;
            this.txtPrecioProducto.Multiline = true;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(158, 27);
            this.txtPrecioProducto.TabIndex = 3;
            this.txtPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProducto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProDataGridViewTextBoxColumn,
            this.nomProDataGridViewTextBoxColumn,
            this.desProDataGridViewTextBoxColumn,
            this.fecVenDataGridViewTextBoxColumn,
            this.preProDataGridViewTextBoxColumn,
            this.stockProDataGridViewTextBoxColumn,
            this.idMarDataGridViewTextBoxColumn,
            this.nomMarDataGridViewTextBoxColumn});
            this.dgvProductos.DataSource = this.visProductoBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.GridColor = System.Drawing.Color.Teal;
            this.dgvProductos.Location = new System.Drawing.Point(291, 171);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.Size = new System.Drawing.Size(817, 240);
            this.dgvProductos.TabIndex = 29;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // idProDataGridViewTextBoxColumn
            // 
            this.idProDataGridViewTextBoxColumn.DataPropertyName = "IdPro";
            this.idProDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.idProDataGridViewTextBoxColumn.Name = "idProDataGridViewTextBoxColumn";
            this.idProDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomProDataGridViewTextBoxColumn
            // 
            this.nomProDataGridViewTextBoxColumn.DataPropertyName = "NomPro";
            this.nomProDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomProDataGridViewTextBoxColumn.Name = "nomProDataGridViewTextBoxColumn";
            this.nomProDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desProDataGridViewTextBoxColumn
            // 
            this.desProDataGridViewTextBoxColumn.DataPropertyName = "DesPro";
            this.desProDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.desProDataGridViewTextBoxColumn.Name = "desProDataGridViewTextBoxColumn";
            this.desProDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fecVenDataGridViewTextBoxColumn
            // 
            this.fecVenDataGridViewTextBoxColumn.DataPropertyName = "FecVen";
            this.fecVenDataGridViewTextBoxColumn.HeaderText = "Fecha de vencimiento";
            this.fecVenDataGridViewTextBoxColumn.Name = "fecVenDataGridViewTextBoxColumn";
            this.fecVenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preProDataGridViewTextBoxColumn
            // 
            this.preProDataGridViewTextBoxColumn.DataPropertyName = "PrePro";
            this.preProDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.preProDataGridViewTextBoxColumn.Name = "preProDataGridViewTextBoxColumn";
            this.preProDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockProDataGridViewTextBoxColumn
            // 
            this.stockProDataGridViewTextBoxColumn.DataPropertyName = "StockPro";
            this.stockProDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockProDataGridViewTextBoxColumn.Name = "stockProDataGridViewTextBoxColumn";
            this.stockProDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMarDataGridViewTextBoxColumn
            // 
            this.idMarDataGridViewTextBoxColumn.DataPropertyName = "IdMar";
            this.idMarDataGridViewTextBoxColumn.HeaderText = "ID Marca";
            this.idMarDataGridViewTextBoxColumn.Name = "idMarDataGridViewTextBoxColumn";
            this.idMarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomMarDataGridViewTextBoxColumn
            // 
            this.nomMarDataGridViewTextBoxColumn.DataPropertyName = "NomMar";
            this.nomMarDataGridViewTextBoxColumn.HeaderText = "Nombre Marca";
            this.nomMarDataGridViewTextBoxColumn.Name = "nomMarDataGridViewTextBoxColumn";
            this.nomMarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visProductoBindingSource1
            // 
            this.visProductoBindingSource1.DataMember = "VisProducto";
            this.visProductoBindingSource1.DataSource = this.cioDental1DataSet66;
            // 
            // cioDental1DataSet66
            // 
            this.cioDental1DataSet66.DataSetName = "CioDental1DataSet66";
            this.cioDental1DataSet66.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visProductoBindingSource
            // 
            this.visProductoBindingSource.DataMember = "VisProducto";
            this.visProductoBindingSource.DataSource = this.cioDental1DataSet30;
            // 
            // cioDental1DataSet30
            // 
            this.cioDental1DataSet30.DataSetName = "CioDental1DataSet30";
            this.cioDental1DataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.cioDental1DataSet10;
            // 
            // cioDental1DataSet10
            // 
            this.cioDental1DataSet10.DataSetName = "CioDental1DataSet10";
            this.cioDental1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Buscar";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(412, 112);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(511, 29);
            this.txtBuscarProducto.TabIndex = 7;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.FormattingEnabled = true;
            this.cbxMarcas.Location = new System.Drawing.Point(117, 340);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(158, 28);
            this.cbxMarcas.TabIndex = 4;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(117, 139);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(0, 20);
            this.lblCodProd.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 50);
            this.panel1.TabIndex = 33;
            // 
            // visProductoTableAdapter
            // 
            this.visProductoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fecha de v.";
            // 
            // dtpFecVen
            // 
            this.dtpFecVen.Location = new System.Drawing.Point(117, 237);
            this.dtpFecVen.Name = "dtpFecVen";
            this.dtpFecVen.Size = new System.Drawing.Size(158, 29);
            this.dtpFecVen.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Stock";
            // 
            // nUdStockPro
            // 
            this.nUdStockPro.Location = new System.Drawing.Point(117, 305);
            this.nUdStockPro.Name = "nUdStockPro";
            this.nUdStockPro.Size = new System.Drawing.Size(53, 29);
            this.nUdStockPro.TabIndex = 39;
            // 
            // visProductoTableAdapter1
            // 
            this.visProductoTableAdapter1.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = global::CioDental1.Properties.Resources.pasta_dental;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(255, 3);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 45);
            this.button5.TabIndex = 71;
            this.button5.Text = "Productos";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarProducto.Image = global::CioDental1.Properties.Resources.editar_archivo1;
            this.btnModificarProducto.Location = new System.Drawing.Point(161, 383);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(53, 52);
            this.btnModificarProducto.TabIndex = 6;
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarProducto.Image = global::CioDental1.Properties.Resources.firmar__2_;
            this.btnGuardarProducto.Location = new System.Drawing.Point(87, 383);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(53, 52);
            this.btnGuardarProducto.TabIndex = 5;
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1120, 545);
            this.Controls.Add(this.nUdStockPro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecVen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.cbxMarcas);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet10)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUdStockPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.ComboBox cbxMarcas;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private CioDental1DataSet10 cioDental1DataSet10;
        private CioDental1DataSet11TableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private CioDental1DataSet30 cioDental1DataSet30;
        private System.Windows.Forms.BindingSource visProductoBindingSource;
        private CioDental1DataSet30TableAdapters.VisProductoTableAdapter visProductoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecVen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUdStockPro;
        private CioDental1DataSet66 cioDental1DataSet66;
        private System.Windows.Forms.BindingSource visProductoBindingSource1;
        private CioDental1DataSet66TableAdapters.VisProductoTableAdapter visProductoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desProDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecVenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preProDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMarDataGridViewTextBoxColumn;
    }
}