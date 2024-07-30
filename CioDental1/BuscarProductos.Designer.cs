namespace CioDental1
{
    partial class BuscarProductos
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
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.dgvListaProd = new System.Windows.Forms.DataGridView();
            this.visProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet33 = new CioDental1.CioDental1DataSet33();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet15 = new CioDental1.CioDental1DataSet15();
            this.productosTableAdapter = new CioDental1.CioDental1DataSet15TableAdapters.ProductosTableAdapter();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.visProductoTableAdapter = new CioDental1.CioDental1DataSet33TableAdapters.VisProductoTableAdapter();
            this.cioDental1DataSet67 = new CioDental1.CioDental1DataSet67();
            this.visProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visProductoTableAdapter1 = new CioDental1.CioDental1DataSet67TableAdapters.VisProductoTableAdapter();
            this.idProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecVenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProductoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pbCerrar);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 50);
            this.panel1.TabIndex = 5;
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = global::CioDental1.Properties.Resources.cerrar__6_;
            this.pbCerrar.Location = new System.Drawing.Point(710, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(23, 22);
            this.pbCerrar.TabIndex = 32;
            this.pbCerrar.TabStop = false;
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
            this.button5.Location = new System.Drawing.Point(262, 3);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 45);
            this.button5.TabIndex = 72;
            this.button5.Text = "Productos";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(53, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Buscar";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(128, 88);
            this.txtBuscarProducto.Multiline = true;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(370, 23);
            this.txtBuscarProducto.TabIndex = 29;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // dgvListaProd
            // 
            this.dgvListaProd.AllowUserToAddRows = false;
            this.dgvListaProd.AllowUserToDeleteRows = false;
            this.dgvListaProd.AutoGenerateColumns = false;
            this.dgvListaProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProd.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProDataGridViewTextBoxColumn,
            this.nomProDataGridViewTextBoxColumn,
            this.desProDataGridViewTextBoxColumn,
            this.fecVenDataGridViewTextBoxColumn,
            this.preProDataGridViewTextBoxColumn,
            this.stockProDataGridViewTextBoxColumn,
            this.idMarDataGridViewTextBoxColumn,
            this.nomMarDataGridViewTextBoxColumn});
            this.dgvListaProd.DataSource = this.visProductoBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProd.GridColor = System.Drawing.Color.Teal;
            this.dgvListaProd.Location = new System.Drawing.Point(32, 133);
            this.dgvListaProd.Name = "dgvListaProd";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvListaProd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaProd.Size = new System.Drawing.Size(680, 253);
            this.dgvListaProd.TabIndex = 31;
            this.dgvListaProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProd_CellClick_1);
            // 
            // visProductoBindingSource
            // 
            this.visProductoBindingSource.DataMember = "VisProducto";
            this.visProductoBindingSource.DataSource = this.cioDental1DataSet33;
            // 
            // cioDental1DataSet33
            // 
            this.cioDental1DataSet33.DataSetName = "CioDental1DataSet33";
            this.cioDental1DataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.cioDental1DataSet15;
            // 
            // cioDental1DataSet15
            // 
            this.cioDental1DataSet15.DataSetName = "CioDental1DataSet15";
            this.cioDental1DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // pbRegresar
            // 
            this.pbRegresar.Image = global::CioDental1.Properties.Resources.flecha_hacia_atras;
            this.pbRegresar.Location = new System.Drawing.Point(692, 3);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(50, 36);
            this.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegresar.TabIndex = 32;
            this.pbRegresar.TabStop = false;
            // 
            // visProductoTableAdapter
            // 
            this.visProductoTableAdapter.ClearBeforeFill = true;
            // 
            // cioDental1DataSet67
            // 
            this.cioDental1DataSet67.DataSetName = "CioDental1DataSet67";
            this.cioDental1DataSet67.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visProductoBindingSource1
            // 
            this.visProductoBindingSource1.DataMember = "VisProducto";
            this.visProductoBindingSource1.DataSource = this.cioDental1DataSet67;
            // 
            // visProductoTableAdapter1
            // 
            this.visProductoTableAdapter1.ClearBeforeFill = true;
            // 
            // idProDataGridViewTextBoxColumn
            // 
            this.idProDataGridViewTextBoxColumn.DataPropertyName = "IdPro";
            this.idProDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.idProDataGridViewTextBoxColumn.Name = "idProDataGridViewTextBoxColumn";
            // 
            // nomProDataGridViewTextBoxColumn
            // 
            this.nomProDataGridViewTextBoxColumn.DataPropertyName = "NomPro";
            this.nomProDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomProDataGridViewTextBoxColumn.Name = "nomProDataGridViewTextBoxColumn";
            // 
            // desProDataGridViewTextBoxColumn
            // 
            this.desProDataGridViewTextBoxColumn.DataPropertyName = "DesPro";
            this.desProDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.desProDataGridViewTextBoxColumn.Name = "desProDataGridViewTextBoxColumn";
            // 
            // fecVenDataGridViewTextBoxColumn
            // 
            this.fecVenDataGridViewTextBoxColumn.DataPropertyName = "FecVen";
            this.fecVenDataGridViewTextBoxColumn.HeaderText = "Fecha de vencimiento";
            this.fecVenDataGridViewTextBoxColumn.Name = "fecVenDataGridViewTextBoxColumn";
            // 
            // preProDataGridViewTextBoxColumn
            // 
            this.preProDataGridViewTextBoxColumn.DataPropertyName = "PrePro";
            this.preProDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.preProDataGridViewTextBoxColumn.Name = "preProDataGridViewTextBoxColumn";
            // 
            // stockProDataGridViewTextBoxColumn
            // 
            this.stockProDataGridViewTextBoxColumn.DataPropertyName = "StockPro";
            this.stockProDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockProDataGridViewTextBoxColumn.Name = "stockProDataGridViewTextBoxColumn";
            // 
            // idMarDataGridViewTextBoxColumn
            // 
            this.idMarDataGridViewTextBoxColumn.DataPropertyName = "IdMar";
            this.idMarDataGridViewTextBoxColumn.HeaderText = "ID Marca";
            this.idMarDataGridViewTextBoxColumn.Name = "idMarDataGridViewTextBoxColumn";
            // 
            // nomMarDataGridViewTextBoxColumn
            // 
            this.nomMarDataGridViewTextBoxColumn.DataPropertyName = "NomMar";
            this.nomMarDataGridViewTextBoxColumn.HeaderText = "Nombre Marca";
            this.nomMarDataGridViewTextBoxColumn.Name = "nomMarDataGridViewTextBoxColumn";
            // 
            // BuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(745, 424);
            this.Controls.Add(this.dgvListaProd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarProductos";
            this.Load += new System.EventHandler(this.BuscarProductos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProductoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridView dgvListaProd;
        private CioDental1DataSet15 cioDental1DataSet15;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private CioDental1DataSet15TableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private CioDental1DataSet33 cioDental1DataSet33;
        private System.Windows.Forms.BindingSource visProductoBindingSource;
        private CioDental1DataSet33TableAdapters.VisProductoTableAdapter visProductoTableAdapter;
        private CioDental1DataSet67 cioDental1DataSet67;
        private System.Windows.Forms.BindingSource visProductoBindingSource1;
        private CioDental1DataSet67TableAdapters.VisProductoTableAdapter visProductoTableAdapter1;
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