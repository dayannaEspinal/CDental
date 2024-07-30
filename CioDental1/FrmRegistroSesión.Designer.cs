namespace CioDental1
{
    partial class FrmRegistroSesión
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
            this.txtNombreRegistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseñaRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarseRegistros = new System.Windows.Forms.Button();
            this.btnModificarRegistros = new System.Windows.Forms.Button();
            this.cbxRolUsuario = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.nomUsrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conUsrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estUsrDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rolUsrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cioDental1DataSet14 = new CioDental1.CioDental1DataSet14();
            this.usuariosTableAdapter = new CioDental1.CioDental1DataSet14TableAdapters.UsuariosTableAdapter();
            this.btnDesactivarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // txtNombreRegistro
            // 
            this.txtNombreRegistro.Location = new System.Drawing.Point(128, 166);
            this.txtNombreRegistro.MaxLength = 30;
            this.txtNombreRegistro.Multiline = true;
            this.txtNombreRegistro.Name = "txtNombreRegistro";
            this.txtNombreRegistro.Size = new System.Drawing.Size(158, 27);
            this.txtNombreRegistro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // txtContraseñaRegistro
            // 
            this.txtContraseñaRegistro.Location = new System.Drawing.Point(128, 199);
            this.txtContraseñaRegistro.MaxLength = 70;
            this.txtContraseñaRegistro.Multiline = true;
            this.txtContraseñaRegistro.Name = "txtContraseñaRegistro";
            this.txtContraseñaRegistro.Size = new System.Drawing.Size(158, 27);
            this.txtContraseñaRegistro.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rol";
            // 
            // btnRegistrarseRegistros
            // 
            this.btnRegistrarseRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarseRegistros.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrarseRegistros.Image = global::CioDental1.Properties.Resources.firmar__2_;
            this.btnRegistrarseRegistros.Location = new System.Drawing.Point(69, 278);
            this.btnRegistrarseRegistros.Name = "btnRegistrarseRegistros";
            this.btnRegistrarseRegistros.Size = new System.Drawing.Size(53, 52);
            this.btnRegistrarseRegistros.TabIndex = 4;
            this.btnRegistrarseRegistros.UseVisualStyleBackColor = true;
            this.btnRegistrarseRegistros.Click += new System.EventHandler(this.btnRegistrarseRegistros_Click);
            // 
            // btnModificarRegistros
            // 
            this.btnModificarRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRegistros.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarRegistros.Image = global::CioDental1.Properties.Resources.editar_archivo1;
            this.btnModificarRegistros.Location = new System.Drawing.Point(128, 278);
            this.btnModificarRegistros.Name = "btnModificarRegistros";
            this.btnModificarRegistros.Size = new System.Drawing.Size(53, 52);
            this.btnModificarRegistros.TabIndex = 5;
            this.btnModificarRegistros.UseVisualStyleBackColor = true;
            this.btnModificarRegistros.Click += new System.EventHandler(this.btnModificarRegistros_Click);
            // 
            // cbxRolUsuario
            // 
            this.cbxRolUsuario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxRolUsuario.FormattingEnabled = true;
            this.cbxRolUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Colaborador"});
            this.cbxRolUsuario.Location = new System.Drawing.Point(128, 232);
            this.cbxRolUsuario.Name = "cbxRolUsuario";
            this.cbxRolUsuario.Size = new System.Drawing.Size(158, 28);
            this.cbxRolUsuario.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 50);
            this.panel1.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::CioDental1.Properties.Resources.agregar_usuario;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(295, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 67;
            this.button1.Text = "Usuario";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.AutoGenerateColumns = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomUsrDataGridViewTextBoxColumn,
            this.conUsrDataGridViewTextBoxColumn,
            this.estUsrDataGridViewCheckBoxColumn,
            this.rolUsrDataGridViewTextBoxColumn});
            this.dgvUsuario.DataSource = this.usuariosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuario.GridColor = System.Drawing.Color.Teal;
            this.dgvUsuario.Location = new System.Drawing.Point(314, 166);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            this.dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuario.Size = new System.Drawing.Size(532, 213);
            this.dgvUsuario.TabIndex = 53;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            this.dgvUsuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsuario_CellFormatting);
            // 
            // nomUsrDataGridViewTextBoxColumn
            // 
            this.nomUsrDataGridViewTextBoxColumn.DataPropertyName = "NomUsr";
            this.nomUsrDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.nomUsrDataGridViewTextBoxColumn.Name = "nomUsrDataGridViewTextBoxColumn";
            this.nomUsrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conUsrDataGridViewTextBoxColumn
            // 
            this.conUsrDataGridViewTextBoxColumn.DataPropertyName = "ConUsr";
            this.conUsrDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.conUsrDataGridViewTextBoxColumn.Name = "conUsrDataGridViewTextBoxColumn";
            this.conUsrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estUsrDataGridViewCheckBoxColumn
            // 
            this.estUsrDataGridViewCheckBoxColumn.DataPropertyName = "EstUsr";
            this.estUsrDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estUsrDataGridViewCheckBoxColumn.Name = "estUsrDataGridViewCheckBoxColumn";
            this.estUsrDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estUsrDataGridViewCheckBoxColumn.Visible = false;
            // 
            // rolUsrDataGridViewTextBoxColumn
            // 
            this.rolUsrDataGridViewTextBoxColumn.DataPropertyName = "RolUsr";
            this.rolUsrDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolUsrDataGridViewTextBoxColumn.Name = "rolUsrDataGridViewTextBoxColumn";
            this.rolUsrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.cioDental1DataSet14;
            // 
            // cioDental1DataSet14
            // 
            this.cioDental1DataSet14.DataSetName = "CioDental1DataSet14";
            this.cioDental1DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // btnDesactivarUsuario
            // 
            this.btnDesactivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarUsuario.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDesactivarUsuario.Image = global::CioDental1.Properties.Resources.ocultar;
            this.btnDesactivarUsuario.Location = new System.Drawing.Point(187, 278);
            this.btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            this.btnDesactivarUsuario.Size = new System.Drawing.Size(65, 52);
            this.btnDesactivarUsuario.TabIndex = 6;
            this.btnDesactivarUsuario.UseVisualStyleBackColor = true;
            this.btnDesactivarUsuario.Click += new System.EventHandler(this.btnDesactivarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Buscar";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(391, 124);
            this.txtBuscarUsuario.MaxLength = 30;
            this.txtBuscarUsuario.Multiline = true;
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(362, 27);
            this.txtBuscarUsuario.TabIndex = 7;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmRegistroSesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(878, 492);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesactivarUsuario);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxRolUsuario);
            this.Controls.Add(this.btnModificarRegistros);
            this.Controls.Add(this.btnRegistrarseRegistros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraseñaRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreRegistro);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmRegistroSesión";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Sesión";
            this.Load += new System.EventHandler(this.FrmRegistroSesión_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cioDental1DataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseñaRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarseRegistros;
        private System.Windows.Forms.Button btnModificarRegistros;
        private System.Windows.Forms.ComboBox cbxRolUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private CioDental1DataSet14 cioDental1DataSet14;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private CioDental1DataSet14TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button btnDesactivarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUsrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conUsrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estUsrDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolUsrDataGridViewTextBoxColumn;
    }
}