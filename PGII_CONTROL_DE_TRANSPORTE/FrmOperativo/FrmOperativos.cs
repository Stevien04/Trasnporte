using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsNegocio;
using PGII_CONTROL_DE_TRANSPORTE.FrmOperativo;

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmOperativos : Form
    {
        private clsOperativo_CN negocio = new clsOperativo_CN();
        public FrmOperativos()
        {
            InitializeComponent();
        }

        private void FrmOperativos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;

            pnlOperativos.BackColor = Color.FromArgb(255, 140, 0);
            
            dgvOperativo.DataSource = negocio.mtdObtenerOperativos();
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
            if (dgvOperativo.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un operativo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvOperativo.CurrentRow.Cells["id_Operativo"].Value);
            DateTime fecha = Convert.ToDateTime(dgvOperativo.CurrentRow.Cells["Fecha_operativo"].Value);
            TimeSpan horaIni = TimeSpan.Parse(dgvOperativo.CurrentRow.Cells["hora_inicio"].Value.ToString());
            TimeSpan horaFin = TimeSpan.Parse(dgvOperativo.CurrentRow.Cells["hora_fin"].Value.ToString());
            int cantPolicias = Convert.ToInt32(dgvOperativo.CurrentRow.Cells["cantidad_policias"].Value);
            int cantInspectores = Convert.ToInt32(dgvOperativo.CurrentRow.Cells["cant_inspectores"].Value);
            string direccion = dgvOperativo.CurrentRow.Cells["direccion"].Value.ToString();
            string motivo = dgvOperativo.CurrentRow.Cells["Motivo_Operativo"].Value.ToString();
            string resultado = dgvOperativo.CurrentRow.Cells["Resultado"].Value.ToString();
            string documento = dgvOperativo.CurrentRow.Cells["Ubicacion_Documento"].Value.ToString();

            FrmEditarOperativo frm = new FrmEditarOperativo(id, fecha, horaIni, horaFin, cantPolicias, cantInspectores, direccion, motivo, resultado, documento);
            frm.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarOperativo frm = new FrmAgregarOperativo();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
