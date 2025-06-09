namespace PGII_CONTROL_DE_TRANSPORTE
{
    partial class FrmUsuario
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
            this.pnlinterfaz = new System.Windows.Forms.Panel();
            this.pnlconductor = new System.Windows.Forms.Panel();
            this.picconductores = new System.Windows.Forms.PictureBox();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.pnlinicio = new System.Windows.Forms.Panel();
            this.lblincio = new System.Windows.Forms.Label();
            this.picinicio = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pnltop = new System.Windows.Forms.Panel();
            this.picSoporte = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.Label();
            this.pnlinterfaz.SuspendLayout();
            this.pnlconductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).BeginInit();
            this.pnlinicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlinterfaz
            // 
            this.pnlinterfaz.BackColor = System.Drawing.Color.Firebrick;
            this.pnlinterfaz.Controls.Add(this.pnlconductor);
            this.pnlinterfaz.Controls.Add(this.pnlinicio);
            this.pnlinterfaz.Controls.Add(this.piclogo);
            this.pnlinterfaz.Location = new System.Drawing.Point(1, 14);
            this.pnlinterfaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlinterfaz.Name = "pnlinterfaz";
            this.pnlinterfaz.Size = new System.Drawing.Size(249, 743);
            this.pnlinterfaz.TabIndex = 1;
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
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.OrangeRed;
            this.pnltop.Controls.Add(this.picSoporte);
            this.pnltop.Location = new System.Drawing.Point(244, 14);
            this.pnltop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(971, 70);
            this.pnltop.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.nueva_cuenta;
            this.pictureBox1.Location = new System.Drawing.Point(308, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(302, 121);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(418, 36);
            this.lblTitulo.TabIndex = 104;
            this.lblTitulo.Text = "INFORMACION PERSONAL";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(737, 191);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(235, 28);
            this.txtUsuario.TabIndex = 109;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(521, 191);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(93, 25);
            this.lblUsuario.TabIndex = 107;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcargo
            // 
            this.txtcargo.BackColor = System.Drawing.Color.LightGray;
            this.txtcargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcargo.Enabled = false;
            this.txtcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcargo.Location = new System.Drawing.Point(737, 312);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(235, 28);
            this.txtcargo.TabIndex = 116;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.ForeColor = System.Drawing.Color.Black;
            this.lblcorreo.Location = new System.Drawing.Point(521, 270);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(85, 25);
            this.lblcorreo.TabIndex = 115;
            this.lblcorreo.Text = "Correo:";
            this.lblcorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LightGray;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(371, 371);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(96, 28);
            this.txtID.TabIndex = 118;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.Black;
            this.lblCargo.Location = new System.Drawing.Point(521, 312);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(71, 25);
            this.lblCargo.TabIndex = 117;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(308, 422);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(176, 52);
            this.btnEditar.TabIndex = 119;
            this.btnEditar.Text = "Editar Perfil";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Black;
            this.lblpassword.Location = new System.Drawing.Point(521, 230);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(113, 25);
            this.lblpassword.TabIndex = 108;
            this.lblpassword.Text = "Password:";
            this.lblpassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.LightGray;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcorreo.Enabled = false;
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(737, 270);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(235, 28);
            this.txtcorreo.TabIndex = 112;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(737, 230);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 28);
            this.txtPassword.TabIndex = 110;
            // 
            // textID
            // 
            this.textID.AutoSize = true;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.Color.Black;
            this.textID.Location = new System.Drawing.Point(311, 371);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(40, 25);
            this.textID.TabIndex = 120;
            this.textID.Text = "ID:";
            this.textID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 737);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.btnEditar);
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
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlinterfaz);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.pnlinterfaz.ResumeLayout(false);
            this.pnlconductor.ResumeLayout(false);
            this.pnlconductor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).EndInit();
            this.pnlinicio.ResumeLayout(false);
            this.pnlinicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.pnltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlinterfaz;
        private System.Windows.Forms.Panel pnlconductor;
        private System.Windows.Forms.PictureBox picconductores;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Panel pnlinicio;
        private System.Windows.Forms.Label lblincio;
        private System.Windows.Forms.PictureBox picinicio;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.PictureBox picSoporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label textID;
    }
}