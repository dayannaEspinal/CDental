namespace CioDental1
{
    partial class FrmPacientes
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
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionPaciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreoPaciente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxGeneroPaciente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaNacPaciente = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarPaciente = new System.Windows.Forms.Button();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.txtBuscarPacientes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.idPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apePacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emlPacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet9 = new CioDental1.CioDental1DataSet9();
            this.lblCodPac = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet9)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(122, 178);
            this.txtNombrePaciente.MaxLength = 40;
            this.txtNombrePaciente.Multiline = true;
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(158, 27);
            this.txtNombrePaciente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido";
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Location = new System.Drawing.Point(122, 211);
            this.txtApellidoPaciente.MaxLength = 40;
            this.txtApellidoPaciente.Multiline = true;
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(158, 27);
            this.txtApellidoPaciente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dirección";
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.Location = new System.Drawing.Point(122, 313);
            this.txtDireccionPaciente.MaxLength = 100;
            this.txtDireccionPaciente.Multiline = true;
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(158, 27);
            this.txtDireccionPaciente.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Teléfono";
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(122, 346);
            this.txtTelefonoPaciente.MaxLength = 10;
            this.txtTelefonoPaciente.Multiline = true;
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(158, 27);
            this.txtTelefonoPaciente.TabIndex = 6;
            this.txtTelefonoPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoPaciente_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // txtCorreoPaciente
            // 
            this.txtCorreoPaciente.Location = new System.Drawing.Point(122, 379);
            this.txtCorreoPaciente.MaxLength = 80;
            this.txtCorreoPaciente.Multiline = true;
            this.txtCorreoPaciente.Name = "txtCorreoPaciente";
            this.txtCorreoPaciente.Size = new System.Drawing.Size(158, 27);
            this.txtCorreoPaciente.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Género";
            // 
            // cbxGeneroPaciente
            // 
            this.cbxGeneroPaciente.FormattingEnabled = true;
            this.cbxGeneroPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxGeneroPaciente.Location = new System.Drawing.Point(122, 244);
            this.cbxGeneroPaciente.Name = "cbxGeneroPaciente";
            this.cbxGeneroPaciente.Size = new System.Drawing.Size(158, 28);
            this.cbxGeneroPaciente.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "F. de nac.";
            // 
            // dtpFechaNacPaciente
            // 
            this.dtpFechaNacPaciente.Location = new System.Drawing.Point(121, 278);
            this.dtpFechaNacPaciente.Name = "dtpFechaNacPaciente";
            this.dtpFechaNacPaciente.Size = new System.Drawing.Size(159, 29);
            this.dtpFechaNacPaciente.TabIndex = 4;
            // 
            // btnGuardarPaciente
            // 
            this.btnGuardarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPaciente.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarPaciente.Image = global::CioDental1.Properties.Resources.firmar__2_;
            this.btnGuardarPaciente.Location = new System.Drawing.Point(97, 424);
            this.btnGuardarPaciente.Name = "btnGuardarPaciente";
            this.btnGuardarPaciente.Size = new System.Drawing.Size(53, 52);
            this.btnGuardarPaciente.TabIndex = 8;
            this.btnGuardarPaciente.UseVisualStyleBackColor = true;
            this.btnGuardarPaciente.Click += new System.EventHandler(this.btnGuardarPaciente_Click);
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPaciente.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarPaciente.Image = global::CioDental1.Properties.Resources.editar_archivo1;
            this.btnModificarPaciente.Location = new System.Drawing.Point(165, 424);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(53, 52);
            this.btnModificarPaciente.TabIndex = 9;
            this.btnModificarPaciente.UseVisualStyleBackColor = true;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // txtBuscarPacientes
            // 
            this.txtBuscarPacientes.Location = new System.Drawing.Point(368, 135);
            this.txtBuscarPacientes.Name = "txtBuscarPacientes";
            this.txtBuscarPacientes.Size = new System.Drawing.Size(509, 29);
            this.txtBuscarPacientes.TabIndex = 10;
            this.txtBuscarPacientes.TextChanged += new System.EventHandler(this.txtBuscarPacientes_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Buscar";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.AutoGenerateColumns = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacDataGridViewTextBoxColumn,
            this.nomPacDataGridViewTextBoxColumn,
            this.apePacDataGridViewTextBoxColumn,
            this.genPacDataGridViewTextBoxColumn,
            this.fecNacDataGridViewTextBoxColumn,
            this.dirPacDataGridViewTextBoxColumn,
            this.telPacDataGridViewTextBoxColumn,
            this.emlPacDataGridViewTextBoxColumn});
            this.dgvPacientes.DataSource = this.pacientesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientes.GridColor = System.Drawing.Color.Teal;
            this.dgvPacientes.Location = new System.Drawing.Point(307, 178);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPacientes.Size = new System.Drawing.Size(788, 275);
            this.dgvPacientes.TabIndex = 23;
            this.dgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentClick);
            // 
            // idPacDataGridViewTextBoxColumn
            // 
            this.idPacDataGridViewTextBoxColumn.DataPropertyName = "IdPac";
            this.idPacDataGridViewTextBoxColumn.HeaderText = "Id Paciente";
            this.idPacDataGridViewTextBoxColumn.Name = "idPacDataGridViewTextBoxColumn";
            this.idPacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomPacDataGridViewTextBoxColumn
            // 
            this.nomPacDataGridViewTextBoxColumn.DataPropertyName = "NomPac";
            this.nomPacDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomPacDataGridViewTextBoxColumn.Name = "nomPacDataGridViewTextBoxColumn";
            this.nomPacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apePacDataGridViewTextBoxColumn
            // 
            this.apePacDataGridViewTextBoxColumn.DataPropertyName = "ApePac";
            this.apePacDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apePacDataGridViewTextBoxColumn.Name = "apePacDataGridViewTextBoxColumn";
            this.apePacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genPacDataGridViewTextBoxColumn
            // 
            this.genPacDataGridViewTextBoxColumn.DataPropertyName = "GenPac";
            this.genPacDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.genPacDataGridViewTextBoxColumn.Name = "genPacDataGridViewTextBoxColumn";
            this.genPacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fecNacDataGridViewTextBoxColumn
            // 
            this.fecNacDataGridViewTextBoxColumn.DataPropertyName = "FecNac";
            this.fecNacDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento";
            this.fecNacDataGridViewTextBoxColumn.Name = "fecNacDataGridViewTextBoxColumn";
            this.fecNacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirPacDataGridViewTextBoxColumn
            // 
            this.dirPacDataGridViewTextBoxColumn.DataPropertyName = "DirPac";
            this.dirPacDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.dirPacDataGridViewTextBoxColumn.Name = "dirPacDataGridViewTextBoxColumn";
            this.dirPacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telPacDataGridViewTextBoxColumn
            // 
            this.telPacDataGridViewTextBoxColumn.DataPropertyName = "TelPac";
            this.telPacDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telPacDataGridViewTextBoxColumn.Name = "telPacDataGridViewTextBoxColumn";
            this.telPacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emlPacDataGridViewTextBoxColumn
            // 
            this.emlPacDataGridViewTextBoxColumn.DataPropertyName = "EmlPac";
            this.emlPacDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emlPacDataGridViewTextBoxColumn.Name = "emlPacDataGridViewTextBoxColumn";
            this.emlPacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.cioDental1DataSet9;
            // 
            // cioDental1DataSet9
            // 
            this.cioDental1DataSet9.DataSetName = "CioDental1DataSet9";
            this.cioDental1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCodPac
            // 
            this.lblCodPac.AutoSize = true;
            this.lblCodPac.Location = new System.Drawing.Point(118, 144);
            this.lblCodPac.Name = "lblCodPac";
            this.lblCodPac.Size = new System.Drawing.Size(0, 20);
            this.lblCodPac.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 50);
            this.panel1.TabIndex = 25;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkCyan;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = global::CioDental1.Properties.Resources.medico__1_1;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(276, 3);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(250, 45);
            this.button6.TabIndex = 70;
            this.button6.Text = "Pacientes";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1120, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodPac);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarPacientes);
            this.Controls.Add(this.btnModificarPaciente);
            this.Controls.Add(this.btnGuardarPaciente);
            this.Controls.Add(this.dtpFechaNacPaciente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxGeneroPaciente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorreoPaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefonoPaciente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccionPaciente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidoPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet9)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreoPaciente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxGeneroPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaNacPaciente;
        private System.Windows.Forms.Button btnGuardarPaciente;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.TextBox txtBuscarPacientes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apePacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlPacDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private CioDental1DataSet9 cioDental1DataSet9;
        private System.Windows.Forms.Label lblCodPac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
    }
}