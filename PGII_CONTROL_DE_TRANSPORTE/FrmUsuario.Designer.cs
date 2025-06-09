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
            this.lblcerrar = new System.Windows.Forms.Label();
            this.pnlinicio = new System.Windows.Forms.Panel();
            this.lblincio = new System.Windows.Forms.Label();
            this.picconductores = new System.Windows.Forms.PictureBox();
            this.picinicio = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pnltop = new System.Windows.Forms.Panel();
            this.picSoporte = new System.Windows.Forms.PictureBox();
            this.pnlinterfaz.SuspendLayout();
            this.pnlconductor.SuspendLayout();
            this.pnlinicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlinterfaz
            // 
            this.pnlinterfaz.BackColor = System.Drawing.Color.Firebrick;
            this.pnlinterfaz.Controls.Add(this.pnlconductor);
            this.pnlinterfaz.Controls.Add(this.pnlinicio);
            this.pnlinterfaz.Controls.Add(this.piclogo);
            this.pnlinterfaz.Location = new System.Drawing.Point(1, 11);
            this.pnlinterfaz.Margin = new System.Windows.Forms.Padding(2);
            this.pnlinterfaz.Name = "pnlinterfaz";
            this.pnlinterfaz.Size = new System.Drawing.Size(187, 604);
            this.pnlinterfaz.TabIndex = 1;
            // 
            // pnlconductor
            // 
            this.pnlconductor.Controls.Add(this.picconductores);
            this.pnlconductor.Controls.Add(this.lblcerrar);
            this.pnlconductor.Location = new System.Drawing.Point(-6, 284);
            this.pnlconductor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlconductor.Name = "pnlconductor";
            this.pnlconductor.Size = new System.Drawing.Size(193, 37);
            this.pnlconductor.TabIndex = 22;
            // 
            // lblcerrar
            // 
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.Color.White;
            this.lblcerrar.Location = new System.Drawing.Point(66, 6);
            this.lblcerrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(59, 20);
            this.lblcerrar.TabIndex = 22;
            this.lblcerrar.Text = "Cerrar";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // pnlinicio
            // 
            this.pnlinicio.Controls.Add(this.lblincio);
            this.pnlinicio.Controls.Add(this.picinicio);
            this.pnlinicio.Location = new System.Drawing.Point(0, 242);
            this.pnlinicio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlinicio.Name = "pnlinicio";
            this.pnlinicio.Size = new System.Drawing.Size(187, 37);
            this.pnlinicio.TabIndex = 5;
            // 
            // lblincio
            // 
            this.lblincio.AutoSize = true;
            this.lblincio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblincio.ForeColor = System.Drawing.Color.White;
            this.lblincio.Location = new System.Drawing.Point(60, 9);
            this.lblincio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblincio.Name = "lblincio";
            this.lblincio.Size = new System.Drawing.Size(52, 20);
            this.lblincio.TabIndex = 21;
            this.lblincio.Text = "Inicio";
            this.lblincio.Click += new System.EventHandler(this.lblincio_Click);
            // 
            // picconductores
            // 
            this.picconductores.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.cerrar_sesion;
            this.picconductores.Location = new System.Drawing.Point(31, 6);
            this.picconductores.Name = "picconductores";
            this.picconductores.Size = new System.Drawing.Size(30, 27);
            this.picconductores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picconductores.TabIndex = 15;
            this.picconductores.TabStop = false;
            // 
            // picinicio
            // 
            this.picinicio.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.casa_silueta_negra_sin_puerta;
            this.picinicio.Location = new System.Drawing.Point(25, 6);
            this.picinicio.Name = "picinicio";
            this.picinicio.Size = new System.Drawing.Size(30, 27);
            this.picinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picinicio.TabIndex = 14;
            this.picinicio.TabStop = false;
            // 
            // piclogo
            // 
            this.piclogo.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.LogoTrasporte_removebg_preview;
            this.piclogo.Location = new System.Drawing.Point(9, 48);
            this.piclogo.Margin = new System.Windows.Forms.Padding(2);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(169, 143);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 16;
            this.piclogo.TabStop = false;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.OrangeRed;
            this.pnltop.Controls.Add(this.picSoporte);
            this.pnltop.Location = new System.Drawing.Point(192, 11);
            this.pnltop.Margin = new System.Windows.Forms.Padding(2);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(719, 57);
            this.pnltop.TabIndex = 2;
            // 
            // picSoporte
            // 
            this.picSoporte.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.centro_de_llamadas;
            this.picSoporte.Location = new System.Drawing.Point(683, 3);
            this.picSoporte.Name = "picSoporte";
            this.picSoporte.Size = new System.Drawing.Size(33, 36);
            this.picSoporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoporte.TabIndex = 13;
            this.picSoporte.TabStop = false;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 599);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlinterfaz);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.pnlinterfaz.ResumeLayout(false);
            this.pnlconductor.ResumeLayout(false);
            this.pnlconductor.PerformLayout();
            this.pnlinicio.ResumeLayout(false);
            this.pnlinicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.pnltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).EndInit();
            this.ResumeLayout(false);

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
    }
}