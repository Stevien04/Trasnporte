namespace PGII_CONTROL_DE_TRANSPORTE.Reporte
{
    partial class FrmEditarReporte
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
            this.pnltop = new System.Windows.Forms.Panel();
            this.lblsoporte = new System.Windows.Forms.Label();
            this.pnlinterfaz = new System.Windows.Forms.Panel();
            this.pnlInspectores = new System.Windows.Forms.Panel();
            this.lblinspectores = new System.Windows.Forms.Label();
            this.pnlOperativos = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.lblreportes = new System.Windows.Forms.Label();
            this.pnlmultas = new System.Windows.Forms.Panel();
            this.lblmultas = new System.Windows.Forms.Label();
            this.pnlvehiculo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlconductor = new System.Windows.Forms.Panel();
            this.lblconductores = new System.Windows.Forms.Label();
            this.pnlinicio = new System.Windows.Forms.Panel();
            this.lblincio = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlacaV = new System.Windows.Forms.TextBox();
            this.lblinspector = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.MaskedTextBox();
            this.txtEstadoR = new System.Windows.Forms.TextBox();
            this.lblEstadoR = new System.Windows.Forms.Label();
            this.btnImportarFoto = new System.Windows.Forms.Button();
            this.btnBorrarDocumentos = new System.Windows.Forms.Button();
            this.btnDescargarDocumentos = new System.Windows.Forms.Button();
            this.btnVerDocumentos = new System.Windows.Forms.Button();
            this.btnAdjuntarDocumentos = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtInspector = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSoporte = new System.Windows.Forms.PictureBox();
            this.picinspectores = new System.Windows.Forms.PictureBox();
            this.picoperatios = new System.Windows.Forms.PictureBox();
            this.picreportes = new System.Windows.Forms.PictureBox();
            this.picmultas = new System.Windows.Forms.PictureBox();
            this.picvehiculos = new System.Windows.Forms.PictureBox();
            this.picconductores = new System.Windows.Forms.PictureBox();
            this.picinicio = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pnltop.SuspendLayout();
            this.pnlinterfaz.SuspendLayout();
            this.pnlInspectores.SuspendLayout();
            this.pnlOperativos.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.pnlmultas.SuspendLayout();
            this.pnlvehiculo.SuspendLayout();
            this.pnlconductor.SuspendLayout();
            this.pnlinicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picinspectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picoperatios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.OrangeRed;
            this.pnltop.Controls.Add(this.lblsoporte);
            this.pnltop.Controls.Add(this.picSoporte);
            this.pnltop.Location = new System.Drawing.Point(256, 1);
            this.pnltop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(805, 70);
            this.pnltop.TabIndex = 117;
            // 
            // lblsoporte
            // 
            this.lblsoporte.AutoSize = true;
            this.lblsoporte.Location = new System.Drawing.Point(59, 23);
            this.lblsoporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsoporte.Name = "lblsoporte";
            this.lblsoporte.Size = new System.Drawing.Size(73, 16);
            this.lblsoporte.TabIndex = 12;
            this.lblsoporte.Text = "SOPORTE";
            this.lblsoporte.Click += new System.EventHandler(this.Soporte_Click);
            // 
            // pnlinterfaz
            // 
            this.pnlinterfaz.BackColor = System.Drawing.Color.Firebrick;
            this.pnlinterfaz.Controls.Add(this.pnlInspectores);
            this.pnlinterfaz.Controls.Add(this.pnlOperativos);
            this.pnlinterfaz.Controls.Add(this.pnlReportes);
            this.pnlinterfaz.Controls.Add(this.pnlmultas);
            this.pnlinterfaz.Controls.Add(this.pnlvehiculo);
            this.pnlinterfaz.Controls.Add(this.pnlconductor);
            this.pnlinterfaz.Controls.Add(this.pnlinicio);
            this.pnlinterfaz.Controls.Add(this.piclogo);
            this.pnlinterfaz.Location = new System.Drawing.Point(1, 1);
            this.pnlinterfaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlinterfaz.Name = "pnlinterfaz";
            this.pnlinterfaz.Size = new System.Drawing.Size(249, 743);
            this.pnlinterfaz.TabIndex = 116;
            // 
            // pnlInspectores
            // 
            this.pnlInspectores.Controls.Add(this.lblinspectores);
            this.pnlInspectores.Controls.Add(this.picinspectores);
            this.pnlInspectores.Location = new System.Drawing.Point(0, 609);
            this.pnlInspectores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInspectores.Name = "pnlInspectores";
            this.pnlInspectores.Size = new System.Drawing.Size(245, 46);
            this.pnlInspectores.TabIndex = 31;
            // 
            // lblinspectores
            // 
            this.lblinspectores.AutoSize = true;
            this.lblinspectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinspectores.ForeColor = System.Drawing.Color.White;
            this.lblinspectores.Location = new System.Drawing.Point(77, 12);
            this.lblinspectores.Name = "lblinspectores";
            this.lblinspectores.Size = new System.Drawing.Size(124, 25);
            this.lblinspectores.TabIndex = 27;
            this.lblinspectores.Text = "Inspectores";
            this.lblinspectores.Click += new System.EventHandler(this.lblinspectores_Click);
            // 
            // pnlOperativos
            // 
            this.pnlOperativos.Controls.Add(this.label8);
            this.pnlOperativos.Controls.Add(this.picoperatios);
            this.pnlOperativos.Location = new System.Drawing.Point(0, 507);
            this.pnlOperativos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOperativos.Name = "pnlOperativos";
            this.pnlOperativos.Size = new System.Drawing.Size(249, 46);
            this.pnlOperativos.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(77, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Operativos";
            this.label8.Click += new System.EventHandler(this.lbloperativos_Click);
            // 
            // pnlReportes
            // 
            this.pnlReportes.Controls.Add(this.lblreportes);
            this.pnlReportes.Controls.Add(this.picreportes);
            this.pnlReportes.Location = new System.Drawing.Point(-8, 558);
            this.pnlReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(257, 46);
            this.pnlReportes.TabIndex = 30;
            // 
            // lblreportes
            // 
            this.lblreportes.AutoSize = true;
            this.lblreportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreportes.ForeColor = System.Drawing.Color.White;
            this.lblreportes.Location = new System.Drawing.Point(85, 12);
            this.lblreportes.Name = "lblreportes";
            this.lblreportes.Size = new System.Drawing.Size(98, 25);
            this.lblreportes.TabIndex = 26;
            this.lblreportes.Text = "Reportes";
            this.lblreportes.Click += new System.EventHandler(this.lblreportes_Click);
            // 
            // pnlmultas
            // 
            this.pnlmultas.Controls.Add(this.picmultas);
            this.pnlmultas.Controls.Add(this.lblmultas);
            this.pnlmultas.Location = new System.Drawing.Point(0, 454);
            this.pnlmultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlmultas.Name = "pnlmultas";
            this.pnlmultas.Size = new System.Drawing.Size(249, 46);
            this.pnlmultas.TabIndex = 24;
            // 
            // lblmultas
            // 
            this.lblmultas.AutoSize = true;
            this.lblmultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmultas.ForeColor = System.Drawing.Color.White;
            this.lblmultas.Location = new System.Drawing.Point(80, 16);
            this.lblmultas.Name = "lblmultas";
            this.lblmultas.Size = new System.Drawing.Size(76, 25);
            this.lblmultas.TabIndex = 24;
            this.lblmultas.Text = "Multas";
            this.lblmultas.Click += new System.EventHandler(this.lblmultas_Click);
            // 
            // pnlvehiculo
            // 
            this.pnlvehiculo.Controls.Add(this.label10);
            this.pnlvehiculo.Controls.Add(this.picvehiculos);
            this.pnlvehiculo.Location = new System.Drawing.Point(0, 402);
            this.pnlvehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlvehiculo.Name = "pnlvehiculo";
            this.pnlvehiculo.Size = new System.Drawing.Size(249, 46);
            this.pnlvehiculo.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(77, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Vehiculos";
            this.label10.Click += new System.EventHandler(this.lblvehiculos_Click);
            // 
            // pnlconductor
            // 
            this.pnlconductor.Controls.Add(this.picconductores);
            this.pnlconductor.Controls.Add(this.lblconductores);
            this.pnlconductor.Location = new System.Drawing.Point(-8, 350);
            this.pnlconductor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlconductor.Name = "pnlconductor";
            this.pnlconductor.Size = new System.Drawing.Size(257, 46);
            this.pnlconductor.TabIndex = 22;
            // 
            // lblconductores
            // 
            this.lblconductores.AutoSize = true;
            this.lblconductores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconductores.ForeColor = System.Drawing.Color.White;
            this.lblconductores.Location = new System.Drawing.Point(88, 7);
            this.lblconductores.Name = "lblconductores";
            this.lblconductores.Size = new System.Drawing.Size(135, 25);
            this.lblconductores.TabIndex = 22;
            this.lblconductores.Text = "Conductores";
            this.lblconductores.Click += new System.EventHandler(this.lblconductores_Click);
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
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.Black;
            this.lblPlaca.Location = new System.Drawing.Point(381, 469);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(130, 25);
            this.lblPlaca.TabIndex = 172;
            this.lblPlaca.Text = "ID Vehiculo:";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlacaV
            // 
            this.txtPlacaV.BackColor = System.Drawing.Color.LightGray;
            this.txtPlacaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlacaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaV.Location = new System.Drawing.Point(647, 464);
            this.txtPlacaV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlacaV.MaxLength = 10;
            this.txtPlacaV.Name = "txtPlacaV";
            this.txtPlacaV.Size = new System.Drawing.Size(235, 28);
            this.txtPlacaV.TabIndex = 171;
            // 
            // lblinspector
            // 
            this.lblinspector.AutoSize = true;
            this.lblinspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinspector.ForeColor = System.Drawing.Color.Black;
            this.lblinspector.Location = new System.Drawing.Point(381, 426);
            this.lblinspector.Name = "lblinspector";
            this.lblinspector.Size = new System.Drawing.Size(135, 25);
            this.lblinspector.TabIndex = 169;
            this.lblinspector.Text = "ID Inspector:";
            this.lblinspector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.LightGray;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(593, 585);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(410, 142);
            this.txtDescripcion.TabIndex = 168;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LightGray;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(647, 230);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(235, 28);
            this.txtID.TabIndex = 167;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(381, 230);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 25);
            this.lblID.TabIndex = 166;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txthora
            // 
            this.txthora.BackColor = System.Drawing.Color.LightGray;
            this.txthora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthora.Location = new System.Drawing.Point(647, 321);
            this.txthora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthora.Mask = "00:00:00";
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(235, 22);
            this.txthora.TabIndex = 164;
            this.txthora.ValidatingType = typeof(System.DateTime);
            // 
            // txtEstadoR
            // 
            this.txtEstadoR.BackColor = System.Drawing.Color.LightGray;
            this.txtEstadoR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoR.Location = new System.Drawing.Point(647, 519);
            this.txtEstadoR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstadoR.MaxLength = 10;
            this.txtEstadoR.Name = "txtEstadoR";
            this.txtEstadoR.Size = new System.Drawing.Size(235, 28);
            this.txtEstadoR.TabIndex = 163;
            // 
            // lblEstadoR
            // 
            this.lblEstadoR.AutoSize = true;
            this.lblEstadoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoR.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoR.Location = new System.Drawing.Point(381, 523);
            this.lblEstadoR.Name = "lblEstadoR";
            this.lblEstadoR.Size = new System.Drawing.Size(204, 25);
            this.lblEstadoR.TabIndex = 161;
            this.lblEstadoR.Text = "Estado de Revision:";
            this.lblEstadoR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImportarFoto
            // 
            this.btnImportarFoto.FlatAppearance.BorderSize = 0;
            this.btnImportarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarFoto.Location = new System.Drawing.Point(1172, 374);
            this.btnImportarFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportarFoto.Name = "btnImportarFoto";
            this.btnImportarFoto.Size = new System.Drawing.Size(149, 23);
            this.btnImportarFoto.TabIndex = 160;
            this.btnImportarFoto.Text = "Importar foto (.png)";
            this.btnImportarFoto.UseVisualStyleBackColor = true;
            this.btnImportarFoto.Click += new System.EventHandler(this.btnImportarFoto_Click);
            // 
            // btnBorrarDocumentos
            // 
            this.btnBorrarDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBorrarDocumentos.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarDocumentos.Location = new System.Drawing.Point(1088, 585);
            this.btnBorrarDocumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarDocumentos.Name = "btnBorrarDocumentos";
            this.btnBorrarDocumentos.Size = new System.Drawing.Size(371, 46);
            this.btnBorrarDocumentos.TabIndex = 158;
            this.btnBorrarDocumentos.Text = "BORRAR DOCUMENTOS";
            this.btnBorrarDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarDocumentos.UseVisualStyleBackColor = false;
            this.btnBorrarDocumentos.Click += new System.EventHandler(this.btnBorrarDocumentos_Click);
            // 
            // btnDescargarDocumentos
            // 
            this.btnDescargarDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDescargarDocumentos.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarDocumentos.Location = new System.Drawing.Point(1088, 533);
            this.btnDescargarDocumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDescargarDocumentos.Name = "btnDescargarDocumentos";
            this.btnDescargarDocumentos.Size = new System.Drawing.Size(371, 46);
            this.btnDescargarDocumentos.TabIndex = 157;
            this.btnDescargarDocumentos.Text = "DESCARGAR DOCUMENTOS";
            this.btnDescargarDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargarDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarDocumentos.UseVisualStyleBackColor = false;
            this.btnDescargarDocumentos.Click += new System.EventHandler(this.btnDescargarDocumentos_Click);
            // 
            // btnVerDocumentos
            // 
            this.btnVerDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerDocumentos.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDocumentos.Location = new System.Drawing.Point(1088, 481);
            this.btnVerDocumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerDocumentos.Name = "btnVerDocumentos";
            this.btnVerDocumentos.Size = new System.Drawing.Size(371, 46);
            this.btnVerDocumentos.TabIndex = 156;
            this.btnVerDocumentos.Text = "VER DOCUMENTOS";
            this.btnVerDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerDocumentos.UseVisualStyleBackColor = false;
            this.btnVerDocumentos.Click += new System.EventHandler(this.btnVerDocumentos_Click);
            // 
            // btnAdjuntarDocumentos
            // 
            this.btnAdjuntarDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdjuntarDocumentos.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarDocumentos.Location = new System.Drawing.Point(1088, 428);
            this.btnAdjuntarDocumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdjuntarDocumentos.Name = "btnAdjuntarDocumentos";
            this.btnAdjuntarDocumentos.Size = new System.Drawing.Size(371, 46);
            this.btnAdjuntarDocumentos.TabIndex = 155;
            this.btnAdjuntarDocumentos.Text = "ADJUNTAR DOCUMENTOS";
            this.btnAdjuntarDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdjuntarDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdjuntarDocumentos.UseVisualStyleBackColor = false;
            this.btnAdjuntarDocumentos.Click += new System.EventHandler(this.btnAdjuntarDocumentos_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardar.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(1171, 665);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 59);
            this.btnGuardar.TabIndex = 154;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BackColor = System.Drawing.Color.LightGray;
            this.txtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(647, 369);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUbicacion.MaxLength = 40;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(235, 28);
            this.txtUbicacion.TabIndex = 153;
            // 
            // txtInspector
            // 
            this.txtInspector.BackColor = System.Drawing.Color.LightGray;
            this.txtInspector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInspector.Location = new System.Drawing.Point(647, 417);
            this.txtInspector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInspector.MaxLength = 10;
            this.txtInspector.Name = "txtInspector";
            this.txtInspector.Size = new System.Drawing.Size(235, 28);
            this.txtInspector.TabIndex = 152;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(377, 585);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(132, 25);
            this.lblDescripcion.TabIndex = 151;
            this.lblDescripcion.Text = "Descripcion:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(381, 267);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 25);
            this.lblFecha.TabIndex = 150;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.ForeColor = System.Drawing.Color.Black;
            this.lblUbicacion.Location = new System.Drawing.Point(381, 374);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(114, 25);
            this.lblUbicacion.TabIndex = 149;
            this.lblUbicacion.Text = "Ubicacion:";
            this.lblUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.Black;
            this.lblhora.Location = new System.Drawing.Point(381, 321);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(65, 25);
            this.lblhora.TabIndex = 148;
            this.lblhora.Text = "Hora:";
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(380, 145);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(291, 36);
            this.lblTitulo.TabIndex = 147;
            this.lblTitulo.Text = "EDITAR REPORTE";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.LightGray;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Location = new System.Drawing.Point(647, 272);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Mask = "00-00-0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(235, 22);
            this.txtFecha.TabIndex = 173;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1163, 214);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // picSoporte
            // 
            this.picSoporte.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.centro_de_llamadas;
            this.picSoporte.Location = new System.Drawing.Point(5, 10);
            this.picSoporte.Margin = new System.Windows.Forms.Padding(4);
            this.picSoporte.Name = "picSoporte";
            this.picSoporte.Size = new System.Drawing.Size(44, 44);
            this.picSoporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoporte.TabIndex = 13;
            this.picSoporte.TabStop = false;
            this.picSoporte.Click += new System.EventHandler(this.Soporte_Click);
            // 
            // picinspectores
            // 
            this.picinspectores.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.inspector;
            this.picinspectores.Location = new System.Drawing.Point(33, 4);
            this.picinspectores.Margin = new System.Windows.Forms.Padding(4);
            this.picinspectores.Name = "picinspectores";
            this.picinspectores.Size = new System.Drawing.Size(40, 33);
            this.picinspectores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picinspectores.TabIndex = 20;
            this.picinspectores.TabStop = false;
            // 
            // picoperatios
            // 
            this.picoperatios.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.operativos;
            this.picoperatios.Location = new System.Drawing.Point(33, 7);
            this.picoperatios.Margin = new System.Windows.Forms.Padding(4);
            this.picoperatios.Name = "picoperatios";
            this.picoperatios.Size = new System.Drawing.Size(40, 33);
            this.picoperatios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picoperatios.TabIndex = 28;
            this.picoperatios.TabStop = false;
            // 
            // picreportes
            // 
            this.picreportes.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.analitica_de_datos;
            this.picreportes.Location = new System.Drawing.Point(41, 9);
            this.picreportes.Margin = new System.Windows.Forms.Padding(4);
            this.picreportes.Name = "picreportes";
            this.picreportes.Size = new System.Drawing.Size(40, 33);
            this.picreportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picreportes.TabIndex = 19;
            this.picreportes.TabStop = false;
            // 
            // picmultas
            // 
            this.picmultas.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.multa;
            this.picmultas.Location = new System.Drawing.Point(33, 7);
            this.picmultas.Margin = new System.Windows.Forms.Padding(4);
            this.picmultas.Name = "picmultas";
            this.picmultas.Size = new System.Drawing.Size(40, 33);
            this.picmultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmultas.TabIndex = 17;
            this.picmultas.TabStop = false;
            // 
            // picvehiculos
            // 
            this.picvehiculos.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.coche;
            this.picvehiculos.Location = new System.Drawing.Point(33, 7);
            this.picvehiculos.Margin = new System.Windows.Forms.Padding(4);
            this.picvehiculos.Name = "picvehiculos";
            this.picvehiculos.Size = new System.Drawing.Size(40, 33);
            this.picvehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picvehiculos.TabIndex = 16;
            this.picvehiculos.TabStop = false;
            // 
            // picconductores
            // 
            this.picconductores.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.conduccion;
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
            // FrmEditarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1042);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlacaV);
            this.Controls.Add(this.lblinspector);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.txtEstadoR);
            this.Controls.Add(this.lblEstadoR);
            this.Controls.Add(this.btnImportarFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBorrarDocumentos);
            this.Controls.Add(this.btnDescargarDocumentos);
            this.Controls.Add(this.btnVerDocumentos);
            this.Controls.Add(this.btnAdjuntarDocumentos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtInspector);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlinterfaz);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditarReporte";
            this.Text = "FrmEditarReporte";
            this.Load += new System.EventHandler(this.FrmEditarReporte_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlinterfaz.ResumeLayout(false);
            this.pnlInspectores.ResumeLayout(false);
            this.pnlInspectores.PerformLayout();
            this.pnlOperativos.ResumeLayout(false);
            this.pnlOperativos.PerformLayout();
            this.pnlReportes.ResumeLayout(false);
            this.pnlReportes.PerformLayout();
            this.pnlmultas.ResumeLayout(false);
            this.pnlmultas.PerformLayout();
            this.pnlvehiculo.ResumeLayout(false);
            this.pnlvehiculo.PerformLayout();
            this.pnlconductor.ResumeLayout(false);
            this.pnlconductor.PerformLayout();
            this.pnlinicio.ResumeLayout(false);
            this.pnlinicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picinspectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picoperatios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblsoporte;
        private System.Windows.Forms.PictureBox picSoporte;
        private System.Windows.Forms.Panel pnlinterfaz;
        private System.Windows.Forms.Panel pnlInspectores;
        private System.Windows.Forms.Label lblinspectores;
        private System.Windows.Forms.PictureBox picinspectores;
        private System.Windows.Forms.Panel pnlOperativos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picoperatios;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Label lblreportes;
        private System.Windows.Forms.PictureBox picreportes;
        private System.Windows.Forms.Panel pnlmultas;
        private System.Windows.Forms.PictureBox picmultas;
        private System.Windows.Forms.Label lblmultas;
        private System.Windows.Forms.Panel pnlvehiculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picvehiculos;
        private System.Windows.Forms.Panel pnlconductor;
        private System.Windows.Forms.PictureBox picconductores;
        private System.Windows.Forms.Label lblconductores;
        private System.Windows.Forms.Panel pnlinicio;
        private System.Windows.Forms.Label lblincio;
        private System.Windows.Forms.PictureBox picinicio;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlacaV;
        private System.Windows.Forms.Label lblinspector;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.MaskedTextBox txthora;
        private System.Windows.Forms.TextBox txtEstadoR;
        private System.Windows.Forms.Label lblEstadoR;
        private System.Windows.Forms.Button btnImportarFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBorrarDocumentos;
        private System.Windows.Forms.Button btnDescargarDocumentos;
        private System.Windows.Forms.Button btnVerDocumentos;
        private System.Windows.Forms.Button btnAdjuntarDocumentos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtInspector;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox txtFecha;
    }
}