namespace CioDental1
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFechaCompras = new System.Windows.Forms.DateTimePicker();
            this.txtCodFacCompras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxConProv_Com = new System.Windows.Forms.ComboBox();
            this.comprasDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet1 = new CioDental1.CioDental1DataSet1();
            this.comprasDetallesTableAdapter = new CioDental1.CioDental1DataSet1TableAdapters.ComprasDetallesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdCom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarComEnc = new System.Windows.Forms.Button();
            this.btnGuardarCompras = new System.Windows.Forms.Button();
            this.btnModificarCompras = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nUdCanPro = new System.Windows.Forms.NumericUpDown();
            this.txtTotalPro = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnTotPro = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrePro = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtNomPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.vistaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet25 = new CioDental1.CioDental1DataSet25();
            this.vistaCompraTableAdapter = new CioDental1.CioDental1DataSet25TableAdapters.VistaCompraTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAñadirCompra = new System.Windows.Forms.Button();
            this.dgvCompraGeneral = new System.Windows.Forms.DataGridView();
            this.idcomdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.btnCalcularCambio = new System.Windows.Forms.Button();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdCanPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet25)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraGeneral)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaCompras
            // 
            this.dtpFechaCompras.Location = new System.Drawing.Point(178, 83);
            this.dtpFechaCompras.Name = "dtpFechaCompras";
            this.dtpFechaCompras.Size = new System.Drawing.Size(175, 33);
            this.dtpFechaCompras.TabIndex = 2;
            // 
            // txtCodFacCompras
            // 
            this.txtCodFacCompras.Location = new System.Drawing.Point(178, 49);
            this.txtCodFacCompras.MaxLength = 15;
            this.txtCodFacCompras.Name = "txtCodFacCompras";
            this.txtCodFacCompras.Size = new System.Drawing.Size(175, 33);
            this.txtCodFacCompras.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Contacto Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nro de factura";
            // 
            // cbxConProv_Com
            // 
            this.cbxConProv_Com.FormattingEnabled = true;
            this.cbxConProv_Com.Location = new System.Drawing.Point(178, 117);
            this.cbxConProv_Com.Name = "cbxConProv_Com";
            this.cbxConProv_Com.Size = new System.Drawing.Size(175, 29);
            this.cbxConProv_Com.TabIndex = 3;
            // 
            // comprasDetallesBindingSource
            // 
            this.comprasDetallesBindingSource.DataMember = "ComprasDetalles";
            this.comprasDetallesBindingSource.DataSource = this.cioDental1DataSet1;
            // 
            // cioDental1DataSet1
            // 
            this.cioDental1DataSet1.DataSetName = "CioDental1DataSet1";
            this.cioDental1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprasDetallesTableAdapter
            // 
            this.comprasDetallesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "Código";
            // 
            // lblIdCom
            // 
            this.lblIdCom.AutoSize = true;
            this.lblIdCom.Location = new System.Drawing.Point(174, 18);
            this.lblIdCom.Name = "lblIdCom";
            this.lblIdCom.Size = new System.Drawing.Size(0, 21);
            this.lblIdCom.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 50);
            this.panel1.TabIndex = 99;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = global::CioDental1.Properties.Resources.anadir_al_carrito;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(277, 2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(250, 45);
            this.button4.TabIndex = 72;
            this.button4.Text = "Compras";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarComEnc);
            this.groupBox1.Controls.Add(this.dtpFechaCompras);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblIdCom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodFacCompras);
            this.groupBox1.Controls.Add(this.cbxConProv_Com);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(49, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 177);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra Encabezado";
            // 
            // btnLimpiarComEnc
            // 
            this.btnLimpiarComEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarComEnc.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnLimpiarComEnc.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarComEnc.Image")));
            this.btnLimpiarComEnc.Location = new System.Drawing.Point(357, 67);
            this.btnLimpiarComEnc.Name = "btnLimpiarComEnc";
            this.btnLimpiarComEnc.Size = new System.Drawing.Size(42, 36);
            this.btnLimpiarComEnc.TabIndex = 113;
            this.btnLimpiarComEnc.UseVisualStyleBackColor = true;
            this.btnLimpiarComEnc.Click += new System.EventHandler(this.btnLimpiarComEnc_Click);
            // 
            // btnGuardarCompras
            // 
            this.btnGuardarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCompras.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarCompras.Image = global::CioDental1.Properties.Resources.firmar__2_;
            this.btnGuardarCompras.Location = new System.Drawing.Point(886, 132);
            this.btnGuardarCompras.Name = "btnGuardarCompras";
            this.btnGuardarCompras.Size = new System.Drawing.Size(53, 52);
            this.btnGuardarCompras.TabIndex = 9;
            this.btnGuardarCompras.UseVisualStyleBackColor = true;
            this.btnGuardarCompras.Click += new System.EventHandler(this.btnGuardarCompras_Click);
            // 
            // btnModificarCompras
            // 
            this.btnModificarCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCompras.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarCompras.Image = global::CioDental1.Properties.Resources.editar_archivo1;
            this.btnModificarCompras.Location = new System.Drawing.Point(886, 194);
            this.btnModificarCompras.Name = "btnModificarCompras";
            this.btnModificarCompras.Size = new System.Drawing.Size(53, 52);
            this.btnModificarCompras.TabIndex = 10;
            this.btnModificarCompras.UseVisualStyleBackColor = true;
            this.btnModificarCompras.Click += new System.EventHandler(this.btnModificarCompras_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.nUdCanPro);
            this.groupBox2.Controls.Add(this.txtTotalPro);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnTotPro);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtPrePro);
            this.groupBox2.Controls.Add(this.btnBuscarProducto);
            this.groupBox2.Controls.Add(this.txtNomPro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCodPro);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(498, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 177);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de productos";
            // 
            // nUdCanPro
            // 
            this.nUdCanPro.Location = new System.Drawing.Point(97, 105);
            this.nUdCanPro.Name = "nUdCanPro";
            this.nUdCanPro.Size = new System.Drawing.Size(53, 33);
            this.nUdCanPro.TabIndex = 5;
            // 
            // txtTotalPro
            // 
            this.txtTotalPro.Location = new System.Drawing.Point(97, 139);
            this.txtTotalPro.Multiline = true;
            this.txtTotalPro.Name = "txtTotalPro";
            this.txtTotalPro.Size = new System.Drawing.Size(90, 27);
            this.txtTotalPro.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 21);
            this.label17.TabIndex = 110;
            this.label17.Text = "Total";
            // 
            // btnTotPro
            // 
            this.btnTotPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotPro.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnTotPro.Image = ((System.Drawing.Image)(resources.GetObject("btnTotPro.Image")));
            this.btnTotPro.Location = new System.Drawing.Point(213, 130);
            this.btnTotPro.Name = "btnTotPro";
            this.btnTotPro.Size = new System.Drawing.Size(42, 36);
            this.btnTotPro.TabIndex = 7;
            this.btnTotPro.UseVisualStyleBackColor = true;
            this.btnTotPro.Click += new System.EventHandler(this.btnTotPro_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 21);
            this.label16.TabIndex = 108;
            this.label16.Text = "Cantidad";
            // 
            // txtPrePro
            // 
            this.txtPrePro.Location = new System.Drawing.Point(97, 76);
            this.txtPrePro.Multiline = true;
            this.txtPrePro.Name = "txtPrePro";
            this.txtPrePro.Size = new System.Drawing.Size(158, 27);
            this.txtPrePro.TabIndex = 106;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(270, 45);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(53, 52);
            this.btnBuscarProducto.TabIndex = 4;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtNomPro
            // 
            this.txtNomPro.Location = new System.Drawing.Point(97, 49);
            this.txtNomPro.Multiline = true;
            this.txtNomPro.Name = "txtNomPro";
            this.txtNomPro.Size = new System.Drawing.Size(158, 27);
            this.txtNomPro.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 100;
            this.label1.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Código";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 21);
            this.label12.TabIndex = 67;
            this.label12.Text = "Producto";
            // 
            // txtCodPro
            // 
            this.txtCodPro.Location = new System.Drawing.Point(97, 22);
            this.txtCodPro.Multiline = true;
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(158, 27);
            this.txtCodPro.TabIndex = 104;
            // 
            // vistaCompraBindingSource
            // 
            this.vistaCompraBindingSource.DataMember = "VistaCompra";
            this.vistaCompraBindingSource.DataSource = this.cioDental1DataSet25;
            // 
            // cioDental1DataSet25
            // 
            this.cioDental1DataSet25.DataSetName = "CioDental1DataSet25";
            this.cioDental1DataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaCompraTableAdapter
            // 
            this.vistaCompraTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDetalle);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(49, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 50);
            this.groupBox3.TabIndex = 118;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compra Detalle";
            this.groupBox3.Visible = false;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(174, 18);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(0, 21);
            this.lblDetalle.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 97;
            this.label11.Text = "Código";
            // 
            // btnAñadirCompra
            // 
            this.btnAñadirCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirCompra.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAñadirCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirCompra.Image")));
            this.btnAñadirCompra.Location = new System.Drawing.Point(881, 67);
            this.btnAñadirCompra.Name = "btnAñadirCompra";
            this.btnAñadirCompra.Size = new System.Drawing.Size(63, 59);
            this.btnAñadirCompra.TabIndex = 8;
            this.btnAñadirCompra.UseVisualStyleBackColor = true;
            this.btnAñadirCompra.Click += new System.EventHandler(this.btnAñadirCompra_Click);
            // 
            // dgvCompraGeneral
            // 
            this.dgvCompraGeneral.AllowUserToAddRows = false;
            this.dgvCompraGeneral.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            this.dgvCompraGeneral.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompraGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompraGeneral.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompraGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompraGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomdet,
            this.idpro,
            this.nompro,
            this.cantpro,
            this.precpro,
            this.totalParcial});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompraGeneral.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompraGeneral.GridColor = System.Drawing.Color.Teal;
            this.dgvCompraGeneral.Location = new System.Drawing.Point(49, 277);
            this.dgvCompraGeneral.Name = "dgvCompraGeneral";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompraGeneral.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvCompraGeneral.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCompraGeneral.Size = new System.Drawing.Size(915, 191);
            this.dgvCompraGeneral.TabIndex = 124;
            this.dgvCompraGeneral.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompraGeneral_CellClick);
            this.dgvCompraGeneral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompraGeneral_CellContentClick);
            // 
            // idcomdet
            // 
            this.idcomdet.HeaderText = "ID Detalle";
            this.idcomdet.Name = "idcomdet";
            this.idcomdet.Visible = false;
            // 
            // idpro
            // 
            this.idpro.HeaderText = "ID Producto";
            this.idpro.Name = "idpro";
            // 
            // nompro
            // 
            this.nompro.HeaderText = "Nombre Producto";
            this.nompro.Name = "nompro";
            // 
            // cantpro
            // 
            this.cantpro.HeaderText = "Cantidad";
            this.cantpro.Name = "cantpro";
            // 
            // precpro
            // 
            this.precpro.HeaderText = "Precio";
            this.precpro.Name = "precpro";
            // 
            // totalParcial
            // 
            this.totalParcial.HeaderText = "Total Parcial";
            this.totalParcial.Name = "totalParcial";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lblCambio);
            this.groupBox4.Controls.Add(this.btnCalcularCambio);
            this.groupBox4.Controls.Add(this.lblTotalFinal);
            this.groupBox4.Controls.Add(this.txtEfectivo);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(642, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 119);
            this.groupBox4.TabIndex = 125;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resumen de Pago";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.Color.Black;
            this.lblCambio.Location = new System.Drawing.Point(120, 82);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 21);
            this.lblCambio.TabIndex = 128;
            // 
            // btnCalcularCambio
            // 
            this.btnCalcularCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularCambio.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCalcularCambio.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularCambio.Image")));
            this.btnCalcularCambio.Location = new System.Drawing.Point(234, 43);
            this.btnCalcularCambio.Name = "btnCalcularCambio";
            this.btnCalcularCambio.Size = new System.Drawing.Size(42, 36);
            this.btnCalcularCambio.TabIndex = 12;
            this.btnCalcularCambio.UseVisualStyleBackColor = true;
            this.btnCalcularCambio.Click += new System.EventHandler(this.btnCalcularCambio_Click);
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinal.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFinal.Location = new System.Drawing.Point(120, 28);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(0, 21);
            this.lblTotalFinal.TabIndex = 126;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(124, 52);
            this.txtEfectivo.Multiline = true;
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(101, 27);
            this.txtEfectivo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 100;
            this.label9.Text = "Cambio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 21);
            this.label10.TabIndex = 65;
            this.label10.Text = "Total Final";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 21);
            this.label13.TabIndex = 67;
            this.label13.Text = "Efectivo";
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1002, 633);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvCompraGeneral);
            this.Controls.Add(this.btnAñadirCompra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGuardarCompras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificarCompras);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdCanPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet25)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraGeneral)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaCompras;
        private System.Windows.Forms.TextBox txtCodFacCompras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxConProv_Com;
        private System.Windows.Forms.Button btnModificarCompras;
        private System.Windows.Forms.Button btnGuardarCompras;
        private CioDental1DataSet1 cioDental1DataSet1;
        private System.Windows.Forms.BindingSource comprasDetallesBindingSource;
        private CioDental1DataSet1TableAdapters.ComprasDetallesTableAdapter comprasDetallesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdCom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nUdCanPro;
        private System.Windows.Forms.TextBox txtTotalPro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnTotPro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrePro;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtNomPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodPro;
        private CioDental1DataSet25 cioDental1DataSet25;
        private System.Windows.Forms.BindingSource vistaCompraBindingSource;
        private CioDental1DataSet25TableAdapters.VistaCompraTableAdapter vistaCompraTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLimpiarComEnc;
        private System.Windows.Forms.Button btnAñadirCompra;
        private System.Windows.Forms.DataGridView dgvCompraGeneral;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Button btnCalcularCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn precpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalParcial;
    }
}