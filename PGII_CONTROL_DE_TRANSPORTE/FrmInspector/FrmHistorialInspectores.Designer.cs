namespace PGII_CONTROL_DE_TRANSPORTE.FrmInspector
{
    partial class FrmHistorialInspectores
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
            this.dgvInspectores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtHistorial = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.pnltop = new System.Windows.Forms.Panel();
            this.lblsoporte = new System.Windows.Forms.Label();
            this.picSoporte = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectores)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).BeginInit();
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
            this.SuspendLayout();
            // 
            // dgvInspectores
            // 
            this.dgvInspectores.AllowUserToAddRows = false;
            this.dgvInspectores.AllowUserToDeleteRows = false;
            this.dgvInspectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspectores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.FechaInicio,
            this.FechaFin,
            this.Categoria,
            this.RUC,
            this.Fotografia,
            this.Estado,
            this.Editado});
            this.dgvInspectores.Location = new System.Drawing.Point(319, 261);
            this.dgvInspectores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInspectores.Name = "dgvInspectores";
            this.dgvInspectores.ReadOnly = true;
            this.dgvInspectores.RowHeadersWidth = 51;
            this.dgvInspectores.RowTemplate.Height = 24;
            this.dgvInspectores.Size = new System.Drawing.Size(1907, 334);
            this.dgvInspectores.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_inspector";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 125;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "dni";
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 125;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "fecha_in";
            this.FechaInicio.HeaderText = "FechaInicio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 125;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "Fecha_fin";
            this.FechaFin.HeaderText = "FechaFin";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // RUC
            // 
            this.RUC.DataPropertyName = "ruc";
            this.RUC.HeaderText = "RUC";
            this.RUC.MinimumWidth = 6;
            this.RUC.Name = "RUC";
            this.RUC.ReadOnly = true;
            this.RUC.Width = 125;
            // 
            // Fotografia
            // 
            this.Fotografia.DataPropertyName = "Fotografia";
            this.Fotografia.HeaderText = "Fotografia";
            this.Fotografia.MinimumWidth = 6;
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.ReadOnly = true;
            this.Fotografia.Width = 125;
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
            // Editado
            // 
            this.Editado.HeaderText = "Editado";
            this.Editado.MinimumWidth = 6;
            this.Editado.Name = "Editado";
            this.Editado.ReadOnly = true;
            this.Editado.Width = 125;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(309, 116);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(502, 52);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Historial de Inspectores";
            // 
            // txtHistorial
            // 
            this.txtHistorial.BackColor = System.Drawing.Color.OrangeRed;
            this.txtHistorial.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorial.Location = new System.Drawing.Point(948, 188);
            this.txtHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.Size = new System.Drawing.Size(159, 55);
            this.txtHistorial.TabIndex = 17;
            this.txtHistorial.Text = "Historial";
            this.txtHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtHistorial.UseVisualStyleBackColor = false;
            this.txtHistorial.Click += new System.EventHandler(this.txtHistorial_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Location = new System.Drawing.Point(319, 208);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(443, 22);
            this.txtbusqueda.TabIndex = 18;
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnBusqueda.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBusqueda.Location = new System.Drawing.Point(769, 188);
            this.BtnBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(159, 55);
            this.BtnBusqueda.TabIndex = 19;
            this.BtnBusqueda.Text = "Busqueda";
            this.BtnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusqueda.UseVisualStyleBackColor = false;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.OrangeRed;
            this.pnltop.Controls.Add(this.lblsoporte);
            this.pnltop.Controls.Add(this.picSoporte);
            this.pnltop.Location = new System.Drawing.Point(256, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(805, 70);
            this.pnltop.TabIndex = 115;
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
            this.picSoporte.Location = new System.Drawing.Point(5, 10);
            this.picSoporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSoporte.Name = "picSoporte";
            this.picSoporte.Size = new System.Drawing.Size(44, 44);
            this.picSoporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoporte.TabIndex = 13;
            this.picSoporte.TabStop = false;
            this.picSoporte.Click += new System.EventHandler(this.Soporte_Click);
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
            this.pnlinterfaz.Location = new System.Drawing.Point(1, 0);
            this.pnlinterfaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlinterfaz.Name = "pnlinterfaz";
            this.pnlinterfaz.Size = new System.Drawing.Size(249, 743);
            this.pnlinterfaz.TabIndex = 114;
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
            this.lblreportes.Click += new System.EventHandler(this.lblreportes_Click);
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
            this.pnlmultas.Size = new System.Drawing.Size(249, 46);
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
            // FrmHistorialInspectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1051);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlinterfaz);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.txtHistorial);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvInspectores);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHistorialInspectores";
            this.Text = "HistorialInspectores";
            this.Load += new System.EventHandler(this.HistorialInspectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectores)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoporte)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInspectores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button txtHistorial;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button BtnBusqueda;
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
    }
}