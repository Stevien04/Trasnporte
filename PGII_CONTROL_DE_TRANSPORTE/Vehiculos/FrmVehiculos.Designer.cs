namespace PGII_CONTROL_DE_TRANSPORTE.Vehiculos
{
    partial class FrmVehiculos
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
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.IdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAsientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.pnlinterfaz = new System.Windows.Forms.Panel();
            this.pnlInspectores = new System.Windows.Forms.Panel();
            this.lblinspectores = new System.Windows.Forms.Label();
            this.picinspectores = new System.Windows.Forms.PictureBox();
            this.pnlOperativos = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.picoperatios = new System.Windows.Forms.PictureBox();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.lblreportes = new System.Windows.Forms.Label();
            this.picreportes = new System.Windows.Forms.PictureBox();
            this.pnlmultas = new System.Windows.Forms.Panel();
            this.picmultas = new System.Windows.Forms.PictureBox();
            this.lblmultas = new System.Windows.Forms.Label();
            this.pnlvehiculo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.picvehiculos = new System.Windows.Forms.PictureBox();
            this.pnlconductor = new System.Windows.Forms.Panel();
            this.picconductores = new System.Windows.Forms.PictureBox();
            this.lblconductores = new System.Windows.Forms.Label();
            this.pnlinicio = new System.Windows.Forms.Panel();
            this.lblincio = new System.Windows.Forms.Label();
            this.picinicio = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.picSoporte = new System.Windows.Forms.PictureBox();
            this.lblsoporte = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnltop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.pnlinterfaz.SuspendLayout();
            this.pnlInspectores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picinspectores)).BeginInit();
            this.pnlOperativos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picoperatios)).BeginInit();
            this.pnlReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreportes)).BeginInit();
            this.pnlmultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmultas)).BeginInit();
            this.pnlvehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picvehiculos)).BeginInit();
            this.pnlconductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).BeginInit();
            this.pnlinicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVehiculo,
            this.CodigoVehiculo,
            this.IdConductor,
            this.NPlaca,
            this.Tipo,
            this.Marca,
            this.Modelo,
            this.Color,
            this.FechaRegistro,
            this.NAsientos,
            this.Estado});
            this.dgvVehiculos.Location = new System.Drawing.Point(254, 153);
            this.dgvVehiculos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.Size = new System.Drawing.Size(1185, 637);
            this.dgvVehiculos.TabIndex = 12;
            // 
            // IdVehiculo
            // 
            this.IdVehiculo.DataPropertyName = "id_Vehiculo";
            this.IdVehiculo.HeaderText = "IdVehiculo";
            this.IdVehiculo.MinimumWidth = 6;
            this.IdVehiculo.Name = "IdVehiculo";
            this.IdVehiculo.ReadOnly = true;
            this.IdVehiculo.Width = 125;
            // 
            // CodigoVehiculo
            // 
            this.CodigoVehiculo.DataPropertyName = "Codigo_Vehiculo";
            this.CodigoVehiculo.HeaderText = "CodigoVehiculo";
            this.CodigoVehiculo.MinimumWidth = 6;
            this.CodigoVehiculo.Name = "CodigoVehiculo";
            this.CodigoVehiculo.ReadOnly = true;
            this.CodigoVehiculo.Width = 125;
            // 
            // IdConductor
            // 
            this.IdConductor.DataPropertyName = "id_Conductor";
            this.IdConductor.HeaderText = "IdConductor";
            this.IdConductor.MinimumWidth = 6;
            this.IdConductor.Name = "IdConductor";
            this.IdConductor.ReadOnly = true;
            this.IdConductor.Width = 125;
            // 
            // NPlaca
            // 
            this.NPlaca.DataPropertyName = "N_Placa";
            this.NPlaca.HeaderText = "NPlaca";
            this.NPlaca.MinimumWidth = 6;
            this.NPlaca.Name = "NPlaca";
            this.NPlaca.ReadOnly = true;
            this.NPlaca.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 125;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 125;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.HeaderText = "FechaRegistro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 125;
            // 
            // NAsientos
            // 
            this.NAsientos.DataPropertyName = "N_asientos";
            this.NAsientos.HeaderText = "NAsientos";
            this.NAsientos.MinimumWidth = 6;
            this.NAsientos.Name = "NAsientos";
            this.NAsientos.ReadOnly = true;
            this.NAsientos.Width = 125;
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
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.OrangeRed;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(1282, 810);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(160, 49);
            this.btneditar.TabIndex = 11;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(1278, 76);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(161, 49);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
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
            this.pnlinterfaz.Location = new System.Drawing.Point(-2, 0);
            this.pnlinterfaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlinterfaz.Name = "pnlinterfaz";
            this.pnlinterfaz.Size = new System.Drawing.Size(249, 859);
            this.pnlinterfaz.TabIndex = 7;
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
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            // pnlmultas
            // 
            this.pnlmultas.Controls.Add(this.picmultas);
            this.pnlmultas.Controls.Add(this.lblmultas);
            this.pnlmultas.Location = new System.Drawing.Point(0, 454);
            this.pnlmultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlmultas.Name = "pnlmultas";
            this.pnlmultas.Size = new System.Drawing.Size(245, 46);
            this.pnlmultas.TabIndex = 24;
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
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            // picSoporte
            // 
            this.picSoporte.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.centro_de_llamadas;
            this.picSoporte.Location = new System.Drawing.Point(1000, 10);
            this.picSoporte.Margin = new System.Windows.Forms.Padding(4);
            this.picSoporte.Name = "picSoporte";
            this.picSoporte.Size = new System.Drawing.Size(44, 44);
            this.picSoporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoporte.TabIndex = 13;
            this.picSoporte.TabStop = false;
            this.picSoporte.Click += new System.EventHandler(this.picSoporte_Click);
            // 
            // lblsoporte
            // 
            this.lblsoporte.AutoSize = true;
            this.lblsoporte.Location = new System.Drawing.Point(1052, 23);
            this.lblsoporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsoporte.Name = "lblsoporte";
            this.lblsoporte.Size = new System.Drawing.Size(73, 16);
            this.lblsoporte.TabIndex = 12;
            this.lblsoporte.Text = "SOPORTE";
            // 
            // txtbuscar
            // 
            this.txtbuscar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbuscar.Location = new System.Drawing.Point(64, 20);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(469, 22);
            this.txtbuscar.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(29, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.OrangeRed;
            this.pnltop.Controls.Add(this.pictureBox1);
            this.pnltop.Controls.Add(this.txtbuscar);
            this.pnltop.Controls.Add(this.lblsoporte);
            this.pnltop.Controls.Add(this.picSoporte);
            this.pnltop.Location = new System.Drawing.Point(241, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1201, 70);
            this.pnltop.TabIndex = 8;
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 880);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlinterfaz);
            this.Name = "FrmVehiculos";
            this.Text = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.pnlinterfaz.ResumeLayout(false);
            this.pnlInspectores.ResumeLayout(false);
            this.pnlInspectores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picinspectores)).EndInit();
            this.pnlOperativos.ResumeLayout(false);
            this.pnlOperativos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picoperatios)).EndInit();
            this.pnlReportes.ResumeLayout(false);
            this.pnlReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreportes)).EndInit();
            this.pnlmultas.ResumeLayout(false);
            this.pnlmultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmultas)).EndInit();
            this.pnlvehiculo.ResumeLayout(false);
            this.pnlvehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picvehiculos)).EndInit();
            this.pnlconductor.ResumeLayout(false);
            this.pnlconductor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).EndInit();
            this.pnlinicio.ResumeLayout(false);
            this.pnlinicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnagregar;
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
        private System.Windows.Forms.PictureBox picSoporte;
        private System.Windows.Forms.Label lblsoporte;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAsientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}