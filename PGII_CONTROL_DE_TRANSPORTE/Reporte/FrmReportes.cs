using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsEntidad;
using clsNegocio;
using PGII_CONTROL_DE_TRANSPORTE.Reporte;

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmReportes : Form
    {
        private clsReporte_CN negocio = new clsReporte_CN();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            pnlInterfaz.Dock = DockStyle.Left;

            pnltop.Dock = DockStyle.Top;

            pnlReportes.BackColor = Color.FromArgb(255, 140, 0);
            
            dgvReporte.DataSource = negocio.mtdListarReportes();

        }


        // INTERFAZ

        private void lblmultas_Click(object sender, EventArgs e)
        {
            FrmMultass frm = new FrmMultass();
            this.Hide();
            frm.ShowDialog();

        }

        private void lbloperativos_Click(object sender, EventArgs e)
        {
            FrmOperativos frm = new FrmOperativos();
            this.Hide();
            frm.ShowDialog();

        }

        private void lblreportes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            this.Hide();
            frm.ShowDialog();

        }

        private void lblinspectores_Click(object sender, EventArgs e)
        {
            FrmInspectores frm = new FrmInspectores();
            this.Hide();
            frm.ShowDialog();

        }


    

        private void lblconductores_Click(object sender, EventArgs e)
        {
            FrmConductores frm = new FrmConductores();
            this.Hide();
            frm.ShowDialog();

        }

        private void lblvehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos.FrmVehiculos frm = new Vehiculos.FrmVehiculos();
            this.Hide();
            frm.ShowDialog();
        }

        private void Soporte_Click(object sender, EventArgs e)
        {
            FrmSoporte frm = new FrmSoporte();
            this.Hide();
            frm.ShowDialog();

        }


        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvReporte.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un reporte para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del reporte seleccionado desde el DataGridView
            int idReporte = Convert.ToInt32(dgvReporte.CurrentRow.Cells["ID"].Value);
            DateTime fecha = Convert.ToDateTime(dgvReporte.CurrentRow.Cells["Fecha"].Value);
            string hora = dgvReporte.CurrentRow.Cells["Hora"].Value.ToString();
            string ubicacion = dgvReporte.CurrentRow.Cells["Ubicacion"].Value.ToString();
            string descripcion = dgvReporte.CurrentRow.Cells["Descripcion"].Value.ToString();
            string cargo = dgvReporte.CurrentRow.Cells["Cargo_Inspector"].Value.ToString();
            string idInspector = dgvReporte.CurrentRow.Cells["Inspector"].Value.ToString();
            string idVehiculo = dgvReporte.CurrentRow.Cells["Placa_Vehiculo"].Value.ToString();
            string fotoVideo = dgvReporte.CurrentRow.Cells["Fotografia"].Value?.ToString();
            string estadoRevision = dgvReporte.CurrentRow.Cells["estado_revision"].Value?.ToString();

            // Abrir formulario de edición de reportes (este formulario debes haberlo creado)
            FrmEditarReporte frm = new FrmEditarReporte(idReporte, fecha, hora, ubicacion, descripcion, idInspector,idVehiculo,fotoVideo, estadoRevision,cargo
            );
            this.Hide();
            frm.ShowDialog();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarReporte frm = new FrmAgregarReporte();
            this.Hide();
            frm.ShowDialog();
        }

       
    }
}
