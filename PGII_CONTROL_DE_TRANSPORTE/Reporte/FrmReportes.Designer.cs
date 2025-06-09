namespace PGII_CONTROL_DE_TRANSPORTE
{
    partial class FrmReportes
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
            this.picSoporte = new System.Windows.Forms.PictureBox();
            this.pnlInterfaz = new System.Windows.Forms.Panel();
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
            this.pnlVehiculos = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.picvehiculos = new System.Windows.Forms.PictureBox();
            this.pnlConductores = new System.Windows.Forms.Panel();
            this.picconductores = new System.Windows.Forms.PictureBox();
            this.lblconductores = new System.Windows.Forms.Label();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.lblincio = new System.Windows.Forms.Label();
            this.picinicio = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo_Inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa_Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).BeginInit();
            this.pnlInterfaz.SuspendLayout();
            this.pnlInspectores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picinspectores)).BeginInit();
            this.pnlOperativos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picoperatios)).BeginInit();
            this.pnlReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreportes)).BeginInit();
            this.pnlmultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmultas)).BeginInit();
            this.pnlVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picvehiculos)).BeginInit();
            this.pnlConductores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).BeginInit();
            this.pnlInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.OrangeRed;
            this.pnltop.Controls.Add(this.lblsoporte);
            this.pnltop.Controls.Add(this.picSoporte);
            this.pnltop.Location = new System.Drawing.Point(257, 14);
            this.pnltop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(805, 70);
            this.pnltop.TabIndex = 3;
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
            // picSoporte
            // 
            this.picSoporte.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.centro_de_llamadas;
            this.picSoporte.Location = new System.Drawing.Point(7, 12);
            this.picSoporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSoporte.Name = "picSoporte";
            this.picSoporte.Size = new System.Drawing.Size(44, 44);
            this.picSoporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoporte.TabIndex = 13;
            this.picSoporte.TabStop = false;
            this.picSoporte.Click += new System.EventHandler(this.Soporte_Click);
            // 
            // pnlInterfaz
            // 
            this.pnlInterfaz.BackColor = System.Drawing.Color.Firebrick;
            this.pnlInterfaz.Controls.Add(this.pnlInspectores);
            this.pnlInterfaz.Controls.Add(this.pnlOperativos);
            this.pnlInterfaz.Controls.Add(this.pnlReportes);
            this.pnlInterfaz.Controls.Add(this.pnlmultas);
            this.pnlInterfaz.Controls.Add(this.pnlVehiculos);
            this.pnlInterfaz.Controls.Add(this.pnlConductores);
            this.pnlInterfaz.Controls.Add(this.pnlInicio);
            this.pnlInterfaz.Controls.Add(this.piclogo);
            this.pnlInterfaz.Location = new System.Drawing.Point(3, 14);
            this.pnlInterfaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInterfaz.Name = "pnlInterfaz";
            this.pnlInterfaz.Size = new System.Drawing.Size(249, 763);
            this.pnlInterfaz.TabIndex = 4;
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
            this.picinspectores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label8.Click += new System.EventHandler(this.lbloperativos_Click);
            // 
            // picoperatios
            // 
            this.picoperatios.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.operativos;
            this.picoperatios.Location = new System.Drawing.Point(33, 7);
            this.picoperatios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // 
            // picreportes
            // 
            this.picreportes.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.analitica_de_datos;
            this.picreportes.Location = new System.Drawing.Point(41, 9);
            this.picreportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.picmultas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // pnlVehiculos
            // 
            this.pnlVehiculos.Controls.Add(this.label10);
            this.pnlVehiculos.Controls.Add(this.picvehiculos);
            this.pnlVehiculos.Location = new System.Drawing.Point(0, 402);
            this.pnlVehiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlVehiculos.Name = "pnlVehiculos";
            this.pnlVehiculos.Size = new System.Drawing.Size(249, 46);
            this.pnlVehiculos.TabIndex = 22;
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
            // picvehiculos
            // 
            this.picvehiculos.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.coche;
            this.picvehiculos.Location = new System.Drawing.Point(33, 7);
            this.picvehiculos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picvehiculos.Name = "picvehiculos";
            this.picvehiculos.Size = new System.Drawing.Size(40, 33);
            this.picvehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picvehiculos.TabIndex = 16;
            this.picvehiculos.TabStop = false;
            // 
            // pnlConductores
            // 
            this.pnlConductores.Controls.Add(this.picconductores);
            this.pnlConductores.Controls.Add(this.lblconductores);
            this.pnlConductores.Location = new System.Drawing.Point(-8, 350);
            this.pnlConductores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlConductores.Name = "pnlConductores";
            this.pnlConductores.Size = new System.Drawing.Size(257, 46);
            this.pnlConductores.TabIndex = 22;
            // 
            // picconductores
            // 
            this.picconductores.Image = global::PGII_CONTROL_DE_TRANSPORTE.Properties.Resources.conduccion;
            this.picconductores.Location = new System.Drawing.Point(41, 7);
            this.picconductores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // pnlInicio
            // 
            this.pnlInicio.Controls.Add(this.lblincio);
            this.pnlInicio.Controls.Add(this.picinicio);
            this.pnlInicio.Location = new System.Drawing.Point(0, 298);
            this.pnlInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(249, 46);
            this.pnlInicio.TabIndex = 5;
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
            this.picinicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(932, 135);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(159, 55);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(767, 135);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 55);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fecha,
            this.Hora,
            this.Ubicacion,
            this.Descripcion,
            this.estado_revision,
            this.Inspector,
            this.Cargo_Inspector,
            this.Placa_Vehiculo,
            this.Fotografia});
            this.dgvReporte.Location = new System.Drawing.Point(301, 218);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 24;
            this.dgvReporte.Size = new System.Drawing.Size(1909, 450);
            this.dgvReporte.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_Reporte";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 125;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.MinimumWidth = 6;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // estado_revision
            // 
            this.estado_revision.DataPropertyName = "estado_revision";
            this.estado_revision.HeaderText = "Estado revision";
            this.estado_revision.MinimumWidth = 6;
            this.estado_revision.Name = "estado_revision";
            this.estado_revision.ReadOnly = true;
            this.estado_revision.Width = 125;
            // 
            // Inspector
            // 
            this.Inspector.DataPropertyName = "Inspector";
            this.Inspector.HeaderText = "Inspector";
            this.Inspector.MinimumWidth = 6;
            this.Inspector.Name = "Inspector";
            this.Inspector.ReadOnly = true;
            this.Inspector.Width = 125;
            // 
            // Cargo_Inspector
            // 
            this.Cargo_Inspector.DataPropertyName = "Cargo_Inspector";
            this.Cargo_Inspector.HeaderText = "Cargo Inspector";
            this.Cargo_Inspector.MinimumWidth = 6;
            this.Cargo_Inspector.Name = "Cargo_Inspector";
            this.Cargo_Inspector.ReadOnly = true;
            this.Cargo_Inspector.Width = 125;
            // 
            // Placa_Vehiculo
            // 
            this.Placa_Vehiculo.DataPropertyName = "Placa_Vehiculo";
            this.Placa_Vehiculo.HeaderText = "Placa Vehiculo";
            this.Placa_Vehiculo.MinimumWidth = 6;
            this.Placa_Vehiculo.Name = "Placa_Vehiculo";
            this.Placa_Vehiculo.ReadOnly = true;
            this.Placa_Vehiculo.Width = 125;
            // 
            // Fotografia
            // 
            this.Fotografia.DataPropertyName = "foto_video";
            this.Fotografia.HeaderText = "Fotografia";
            this.Fotografia.MinimumWidth = 6;
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.ReadOnly = true;
            this.Fotografia.Width = 125;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(296, 154);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 36);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Información de Reportes";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlInterfaz);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).EndInit();
            this.pnlInterfaz.ResumeLayout(false);
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
            this.pnlVehiculos.ResumeLayout(false);
            this.pnlVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picvehiculos)).EndInit();
            this.pnlConductores.ResumeLayout(false);
            this.pnlConductores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picconductores)).EndInit();
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblsoporte;
        private System.Windows.Forms.PictureBox picSoporte;
        private System.Windows.Forms.Panel pnlInterfaz;
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
        private System.Windows.Forms.Panel pnlVehiculos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picvehiculos;
        private System.Windows.Forms.Panel pnlConductores;
        private System.Windows.Forms.PictureBox picconductores;
        private System.Windows.Forms.Label lblconductores;
        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Label lblincio;
        private System.Windows.Forms.PictureBox picinicio;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_revision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo_Inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa_Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fotografia;
        private System.Windows.Forms.Label lblTitulo;
    }
}