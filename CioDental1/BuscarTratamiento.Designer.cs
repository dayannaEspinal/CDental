namespace CioDental1
{
    partial class BuscarTratamiento
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
            this.button9 = new System.Windows.Forms.Button();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarTratamiento = new System.Windows.Forms.TextBox();
            this.dgvListaTra = new System.Windows.Forms.DataGridView();
            this.idTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet16 = new CioDental1.CioDental1DataSet16();
            this.tratamientosTableAdapter = new CioDental1.CioDental1DataSet16TableAdapters.TratamientosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.pbCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 50);
            this.panel1.TabIndex = 6;
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
            this.button9.Location = new System.Drawing.Point(250, 2);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(250, 45);
            this.button9.TabIndex = 74;
            this.button9.Text = "Tratamientos";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = global::CioDental1.Properties.Resources.cerrar__6_;
            this.pbCerrar.Location = new System.Drawing.Point(694, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(23, 22);
            this.pbCerrar.TabIndex = 32;
            this.pbCerrar.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(55, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Buscar";
            // 
            // txtBuscarTratamiento
            // 
            this.txtBuscarTratamiento.Location = new System.Drawing.Point(130, 70);
            this.txtBuscarTratamiento.Multiline = true;
            this.txtBuscarTratamiento.Name = "txtBuscarTratamiento";
            this.txtBuscarTratamiento.Size = new System.Drawing.Size(370, 23);
            this.txtBuscarTratamiento.TabIndex = 31;
            this.txtBuscarTratamiento.TextChanged += new System.EventHandler(this.txtBuscarTratamiento_TextChanged);
            // 
            // dgvListaTra
            // 
            this.dgvListaTra.AllowUserToAddRows = false;
            this.dgvListaTra.AllowUserToDeleteRows = false;
            this.dgvListaTra.AutoGenerateColumns = false;
            this.dgvListaTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaTra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTraDataGridViewTextBoxColumn,
            this.desTraDataGridViewTextBoxColumn,
            this.cosTraDataGridViewTextBoxColumn});
            this.dgvListaTra.DataSource = this.tratamientosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaTra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaTra.GridColor = System.Drawing.Color.Teal;
            this.dgvListaTra.Location = new System.Drawing.Point(26, 109);
            this.dgvListaTra.Name = "dgvListaTra";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaTra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvListaTra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaTra.Size = new System.Drawing.Size(680, 253);
            this.dgvListaTra.TabIndex = 33;
            this.dgvListaTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaTra_CellClick);
            // 
            // idTraDataGridViewTextBoxColumn
            // 
            this.idTraDataGridViewTextBoxColumn.DataPropertyName = "IdTra";
            this.idTraDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idTraDataGridViewTextBoxColumn.Name = "idTraDataGridViewTextBoxColumn";
            // 
            // desTraDataGridViewTextBoxColumn
            // 
            this.desTraDataGridViewTextBoxColumn.DataPropertyName = "DesTra";
            this.desTraDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.desTraDataGridViewTextBoxColumn.Name = "desTraDataGridViewTextBoxColumn";
            // 
            // cosTraDataGridViewTextBoxColumn
            // 
            this.cosTraDataGridViewTextBoxColumn.DataPropertyName = "CosTra";
            this.cosTraDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.cosTraDataGridViewTextBoxColumn.Name = "cosTraDataGridViewTextBoxColumn";
            // 
            // tratamientosBindingSource
            // 
            this.tratamientosBindingSource.DataMember = "Tratamientos";
            this.tratamientosBindingSource.DataSource = this.cioDental1DataSet16;
            // 
            // cioDental1DataSet16
            // 
            this.cioDental1DataSet16.DataSetName = "CioDental1DataSet16";
            this.cioDental1DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tratamientosTableAdapter
            // 
            this.tratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // BuscarTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 385);
            this.Controls.Add(this.dgvListaTra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarTratamiento);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarTratamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarTratamiento";
            this.Load += new System.EventHandler(this.BuscarTratamiento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarTratamiento;
        private System.Windows.Forms.DataGridView dgvListaTra;
        private CioDental1DataSet16 cioDental1DataSet16;
        private System.Windows.Forms.BindingSource tratamientosBindingSource;
        private CioDental1DataSet16TableAdapters.TratamientosTableAdapter tratamientosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosTraDataGridViewTextBoxColumn;
    }
}