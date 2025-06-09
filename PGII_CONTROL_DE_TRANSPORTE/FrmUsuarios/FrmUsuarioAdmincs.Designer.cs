namespace PGII_CONTROL_DE_TRANSPORTE.FrmUsuarios
{
    partial class FrmUsuarioAdmincs
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
            this.textID = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.lblclave = new System.Windows.Forms.Label();
            this.dgvcodigo = new System.Windows.Forms.DataGridView();
            this.pnltop = new System.Windows.Forms.Panel();
            this.pnlinterfaz = new System.Windows.Forms.Panel();
            this.pnlconductor = new System.Windows.Forms.Panel();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.pnlinicio = new System.Windows.Forms.Panel();
            this.lblincio = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.picSoporte = new System.Windows.Forms.PictureBox();
            this.picconductores = new System.Windows.Forms.PictureBox();
            this.picinicio = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VigenciaLicencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcodigo)).BeginInit();
            this.pnltop.SuspendLayout();
            this.pnlinterfaz.SuspendLayout();
            this.pnlconductor.SuspendLayout();
            this.pnlinicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.Color.Black;
            this.textID.Location = new System.Drawing.Point(339, 366);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(40, 25);
            this.textID.TabIndex = 133;
            this.textID.Text = "ID:";
            this.textID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGenerar.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(1268, 190);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(176, 52);
            this.btnGenerar.TabIndex = 132;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(397, 366);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(43, 21);
            this.txtID.TabIndex = 131;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.Black;
            this.lblCargo.Location = new System.Drawing.Point(509, 311);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(71, 25);
            this.lblCargo.TabIndex = 130;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcargo
            // 
            this.txtcargo.BackColor = System.Drawing.Color.LightGray;
            this.txtcargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcargo.Enabled = false;
            this.txtcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcargo.Location = new System.Drawing.Point(725, 311);
            this.txtcargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(235, 28);
            this.txtcargo.TabIndex = 129;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.ForeColor = System.Drawing.Color.Black;
            this.lblcorreo.Location = new System.Drawing.Point(509, 270);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(85, 25);
            this.lblcorreo.TabIndex = 128;
            this.lblcorreo.Text = "Correo:";
            this.lblcorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.LightGray;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcorreo.Enabled = false;
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(725, 270);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(235, 28);
            this.txtcorreo.TabIndex = 127;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(725, 229);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 28);
            this.txtPassword.TabIndex = 126;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(725, 191);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(235, 28);
            this.txtUsuario.TabIndex = 125;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Black;
            this.lblpassword.Location = new System.Drawing.Point(509, 229);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(113, 25);
            this.lblpassword.TabIndex = 124;
            this.lblpassword.Text = "Password:";
            this.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(509, 191);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(93, 25);
            this.lblUsuario.TabIndex = 123;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(291, 121);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(418, 36);
            this.lblTitulo.TabIndex = 122;
            this.lblTitulo.Text = "INFORMACION PERSONAL";
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.LightGray;
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclave.Enabled = false;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(1242, 147);
            this.txtclave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(235, 28);
            this.txtclave.TabIndex = 134;
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclave.ForeColor = System.Drawing.Color.Black;
            this.lblclave.Location = new System.Drawing.Point(1314, 105);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(86, 29);
            this.lblclave.TabIndex = 135;
            this.lblclave.Text = "Clave:";
            this.lblclave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvcodigo
            // 
            this.dgvcodigo.AllowUserToAddRows = false;
            this.dgvcodigo.AllowUserToDeleteRows = false;
            this.dgvcodigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcodigo.Location = new System.Drawing.Point(1268, 259);
            this.dgvcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvcodigo.Name = "dgvcodigo";
            this.dgvcodigo.ReadOnly = true;
            this.dgvcodigo.RowHeadersWidth = 51;
            this.dgvcodigo.RowTemplate.Height = 24;
            this.dgvcodigo.Size = new System.Drawing.Size(181, 311);
            this.dgvcodigo.TabIndex = 136;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.OrangeRed;
            this.pnltop.Controls.Add(this.picSoporte);
            this.pnltop.Location = new System.Drawing.Point(244, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(971, 70);
            this.pnltop.TabIndex = 146;
            // 
            // pnlinterfaz
            // 
            this.pnlinterfaz.BackColor = System.Drawing.Color.Firebrick;
            this.pnlinterfaz.Controls.Add(this.pnlconductor);
            this.pnlinterfaz.Controls.Add(this.pnlinicio);
            this.pnlinterfaz.Controls.Add(this.piclogo);
            this.pnlinterfaz.Location = new System.Drawing.Point(1, 0);
            this.pnlinterfaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlinterfaz.Name = "pnlinterfaz";
            this.pnlinterfaz.Size = new System.Drawing.Size(249, 743);
            this.pnlinterfaz.TabIndex = 145;
            // 
            // pnlconductor
            // 
            this.pnlconductor.Controls.Add(this.picconductores);
            this.pnlconductor.Controls.Add(this.lblcerrar);
            this.pnlconductor.Location = new System.Drawing.Point(-8, 350);
            this.pnlconductor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlconductor.Name = "pnlconductor";
            this.pnlconductor.Size = new System.Drawing.Size(257, 46);
            this.pnlconductor.TabIndex = 22;
            // 
            // lblcerrar
            // 
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.Color.White;
            this.lblcerrar.Location = new System.Drawing.Point(88, 7);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(73, 25);
            this.lblcerrar.TabIndex = 22;
            this.lblcerrar.Text = "Cerrar";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // pnlinicio
            // 
            this.pnlinicio.Controls.Add(this.lblincio);
            this.pnlinicio.Controls.Add(this.picinicio);
            this.pnlinicio.Location = new System.Drawing.Point(0, 298);
            this.pnlinicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlinicio.Name = "pnlinicio";
            this.pnlinicio.Size = new System.Drawing.Size(249, 46);
            this.pnlinicio.TabIndex = 5;
            // 
            // lblincio
            // 
            this.lblincio.AutoSize = true;
            this.lblincio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblincio.ForeColor = System.Drawing.Color.White;
            this.lblincio.Location = new System.Drawing.Point(80, 11);
            this.lblincio.Name = "lblincio";
            this.lblincio.Size = new System.Drawing.Size(63, 25);
            this.lblincio.TabIndex = 21;
            this.lblincio.Text = "Inicio";
            this.lblincio.Click += new System.EventHandler(this.lblincio_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(297, 474);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(176, 52);
            this.btnEditar.TabIndex = 147;
            this.btnEditar.Text = "Editar Perfil";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_User,
            this.id_inspector,
            this.nombre,
            this.VigenciaLicencia,
            this.Usuario,
            this.Cargo,
            this.Correo,
            this.Estado});
            this.dgvUsuarios.Location = new System.Drawing.Point(296, 593);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(1497, 150);
            this.dgvUsuarios.TabIndex = 148;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnmodificar.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(533, 474);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(231, 52);
            this.btnmodificar.TabIndex = 149;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // picSoporte
            // 
            this.picSoporte.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.centro_de_llamadas;
            this.picSoporte.Location = new System.Drawing.Point(911, 4);
            this.picSoporte.Margin = new System.Windows.Forms.Padding(4);
            this.picSoporte.Name = "picSoporte";
            this.picSoporte.Size = new System.Drawing.Size(44, 44);
            this.picSoporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoporte.TabIndex = 13;
            this.picSoporte.TabStop = false;
            // 
            // picconductores
            // 
            this.picconductores.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.cerrar_sesion;
            this.picconductores.Location = new System.Drawing.Point(41, 7);
            this.picconductores.Margin = new System.Windows.Forms.Padding(4);
            this.picconductores.Name = "picconductores";
            this.picconductores.Size = new System.Drawing.Size(40, 33);
            this.picconductores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picconductores.TabIndex = 15;
            this.picconductores.TabStop = false;
            // 
            // picinicio
            // 
            this.picinicio.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.casa_silueta_negra_sin_puerta;
            this.picinicio.Location = new System.Drawing.Point(33, 7);
            this.picinicio.Margin = new System.Windows.Forms.Padding(4);
            this.picinicio.Name = "picinicio";
            this.picinicio.Size = new System.Drawing.Size(40, 33);
            this.picinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picinicio.TabIndex = 14;
            this.picinicio.TabStop = false;
            // 
            // piclogo
            // 
            this.piclogo.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.LogoTrasporte_removebg_preview;
            this.piclogo.Location = new System.Drawing.Point(12, 59);
            this.piclogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(225, 176);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 16;
            this.piclogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.nueva_cuenta;
            this.pictureBox1.Location = new System.Drawing.Point(296, 193);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // id_User
            // 
            this.id_User.DataPropertyName = "id_User";
            this.id_User.HeaderText = "ID";
            this.id_User.MinimumWidth = 6;
            this.id_User.Name = "id_User";
            this.id_User.ReadOnly = true;
            this.id_User.Width = 125;
            // 
            // id_inspector
            // 
            this.id_inspector.DataPropertyName = "id_inspector";
            this.id_inspector.HeaderText = "Inspector";
            this.id_inspector.MinimumWidth = 6;
            this.id_inspector.Name = "id_inspector";
            this.id_inspector.ReadOnly = true;
            this.id_inspector.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Inspector";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // VigenciaLicencia
            // 
            this.VigenciaLicencia.DataPropertyName = "VigenciaLicencia";
            this.VigenciaLicencia.HeaderText = "Vigencia";
            this.VigenciaLicencia.MinimumWidth = 6;
            this.VigenciaLicencia.Name = "VigenciaLicencia";
            this.VigenciaLicencia.ReadOnly = true;
            this.VigenciaLicencia.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 125;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 125;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // FrmUsuarioAdmincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1038);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlinterfaz);
            this.Controls.Add(this.dgvcodigo);
            this.Controls.Add(this.lblclave);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUsuarioAdmincs";
            this.Text = "FrmUsuarioAdmincs";
            this.Load += new System.EventHandler(this.FrmUsuarioAdmincs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcodigo)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnlinterfaz.ResumeLayout(false);
            this.pnlconductor.ResumeLayout(false);
            this.pnlconductor.PerformLayout();
            this.pnlinicio.ResumeLayout(false);
            this.pnlinicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textID;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.DataGridView dgvcodigo;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.PictureBox picSoporte;
        private System.Windows.Forms.Panel pnlinterfaz;
        private System.Windows.Forms.Panel pnlconductor;
        private System.Windows.Forms.PictureBox picconductores;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Panel pnlinicio;
        private System.Windows.Forms.Label lblincio;
        private System.Windows.Forms.PictureBox picinicio;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn VigenciaLicencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}