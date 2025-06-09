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
using System.Data.SqlClient;

namespace PGII_CONTROL_DE_TRANSPORTE.FrmInspector
{
    public partial class FrmHistorialInspectores : Form
    {
        private clsInspectores_CN inspectoresCN = new clsInspectores_CN();
        private DataTable dtInspectores;
        public FrmHistorialInspectores()
        {
            InitializeComponent();
        }

        private void HistorialInspectores_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;

            pnlInspectores.BackColor = Color.FromArgb(255, 140, 0);
           

            CargarInspectores();

        }
  
        private void CargarInspectores()
        {
            dtInspectores = inspectoresCN.mtdObtenerInspectores();
            dgvInspectores.DataSource = dtInspectores; ;
        }
        private void txtHistorial_Click(object sender, EventArgs e)
        {
            if (dgvInspectores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un Inspector.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string Estado = dgvInspectores.CurrentRow.Cells["Estado"].Value?.ToString();
            string Editado = dgvInspectores.CurrentRow.Cells["Editado"].Value?.ToString();

            // Abrir formulario de edición de inspectores
            FrmHistorialInspectorUs frm = new FrmHistorialInspectorUs(id, nombre, apellido, dni, finicio, ffin, ruc, categoria, fotografia, Editado);
            this.Hide();
            frm.ShowDialog();
        }


        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            string filtro = txtbusqueda.Text.Trim();
            DataTable dt;

            if (string.IsNullOrEmpty(filtro))
                dt = inspectoresCN.mtdObtenerInspectores();
            else
                dt = inspectoresCN.mtdBuscarInspectoresPorIdONombre(filtro);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvInspectores.DataSource = dt;
            }
            else
            {
                dgvInspectores.DataSource = null; // O puedes asignar un DataTable vacío
            }
        }

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

    }
}
