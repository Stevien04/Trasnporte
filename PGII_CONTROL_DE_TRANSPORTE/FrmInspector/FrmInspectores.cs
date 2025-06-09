using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsNegocio;
using PGII_CONTROL_DE_TRANSPORTE.FrmConductor;
using PGII_CONTROL_DE_TRANSPORTE.FrmInspector;

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmInspectores : Form
    {
        private clsInspectores_CN negocio = new clsInspectores_CN();
        public FrmInspectores()
        {
            InitializeComponent();
        }

        private void FrmInspectores_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;

            pnlInspectores.BackColor = Color.FromArgb(255, 140, 0);
        

            dgvInspectores.DataSource = negocio.mtdObtenerInspectores();


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

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarInspectores frm = new FrmAgregarInspectores();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInspectores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un Inspector para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del inspector seleccionado desde el DataGridView
            int id = Convert.ToInt32(dgvInspectores.CurrentRow.Cells["ID"].Value);
            string nombre = dgvInspectores.CurrentRow.Cells["Nombre"].Value.ToString();
            string apellido = dgvInspectores.CurrentRow.Cells["Apellido"].Value.ToString();
            string dni = dgvInspectores.CurrentRow.Cells["DNI"].Value.ToString();
            DateTime finicio = Convert.ToDateTime(dgvInspectores.CurrentRow.Cells["FechaInicio"].Value);
            DateTime ffin = Convert.ToDateTime(dgvInspectores.CurrentRow.Cells["FechaFin"].Value);
            string ruc = dgvInspectores.CurrentRow.Cells["RUC"].Value.ToString();
            string categoria = dgvInspectores.CurrentRow.Cells["Categoria"].Value.ToString();
            string fotografia = dgvInspectores.CurrentRow.Cells["Fotografia"].Value?.ToString();
            string Estado= dgvInspectores.CurrentRow.Cells["Estado"].Value?.ToString();

            // Abrir formulario de edición de inspectores
            FrmEditarInspectores frm = new FrmEditarInspectores(id,nombre, apellido, dni, finicio, ffin, ruc, categoria, fotografia);
            this.Hide();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHistorialInspectores frm = new FrmHistorialInspectores();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
