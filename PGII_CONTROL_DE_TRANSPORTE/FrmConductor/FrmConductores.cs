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
using PGII_CONTROL_DE_TRANSPORTE.FrmConductor;

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmConductores : Form
    {
        private clsConductor_CN negocio = new clsConductor_CN();
        public FrmConductores()
        {
            InitializeComponent();
        }

        private void FrmConductores_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlInterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
            pnlConductores.BackColor = Color.FromArgb(255, 140, 0);
            
            dgvConductores.DataSource = negocio.mtdObtenerConductores();
        }

        
        
        
        
        // BOTONES Y CONFIGURACIONES DE PANTALLA
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmConductor.FrmAgregarConductor frm = new FrmConductor.FrmAgregarConductor();
            this.Hide();
            frm.ShowDialog();
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
        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblsoporte_Click(object sender, EventArgs e)
        {

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvConductores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un conductor para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del registro seleccionado
            int id = Convert.ToInt32(dgvConductores.CurrentRow.Cells["Id"].Value);
            string dni = dgvConductores.CurrentRow.Cells["DNI"].Value.ToString();
            string codigo = dgvConductores.CurrentRow.Cells["Codigo"].Value.ToString();
            string nombre = dgvConductores.CurrentRow.Cells["nombre"].Value.ToString();
            string apellidos = dgvConductores.CurrentRow.Cells["Apellido"].Value.ToString();
            string vigencia = dgvConductores.CurrentRow.Cells["VigenciaLicencia"].Value.ToString();
            string tipoLicencia = dgvConductores.CurrentRow.Cells["TipoLicencia"].Value.ToString();
            string fotografia = dgvConductores.CurrentRow.Cells["Fotografia"].Value?.ToString();

            // Abrir formulario de edición
            FrmEditarConductor frm = new FrmEditarConductor(id, dni, codigo, nombre, apellidos, vigencia, tipoLicencia, fotografia);
            this.Hide();
            frm.ShowDialog();
        }
    }
}
