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

namespace PGII_CONTROL_DE_TRANSPORTE.Vehiculos
{
    public partial class FrmVehiculos : Form
    {
        private clsVehiculo_CN vehiculoCN = new clsVehiculo_CN();
        public FrmVehiculos()
        {
            InitializeComponent();
         
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
       

            AjustarPosicionImagen();
            CargarVehiculos();
        }

        private void AjustarPosicionImagen()
        {
           

            lblsoporte.Left = pnltop.Width - lblsoporte.Width - 70;
            lblsoporte.Top = (pnltop.Height - lblsoporte.Height) / 2;

            picSoporte.Left = pnltop.Width - picSoporte.Width - 130;
            picSoporte.Top = (pnltop.Height - picSoporte.Height) / 2;

            AjustarPosicionBotonEditar();
            this.Resize += FrmVehiculos_Load;

         

            AjustarPosicionBtnAgregar();
            this.Resize += FrmVehiculos_Load;
        }

        private void CargarVehiculos()
        {
            try
            {
                DataTable dt = vehiculoCN.mtdObtenerVehiculos();
                dgvVehiculos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vehículos: " + ex.Message);
            }
        }

      

        private void AjustarPosicionBotonEditar()
        {
            btneditar.Left = this.ClientSize.Width - btneditar.Width - 20;
            btneditar.Top = this.ClientSize.Height - btneditar.Height - 20;
        }

     
        private void AjustarPosicionBtnAgregar()
        {
            btnagregar.Left = this.ClientSize.Width - btnagregar.Width - 20;
            btnagregar.Top = pnltop.Height + 20;
        }

        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblconductores_Click(object sender, EventArgs e)
        {
            FrmConductores frm = new FrmConductores();
            this.Hide();
            frm.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblmultas_Click(object sender, EventArgs e)
        {
            FrmMultass frm = new FrmMultass();
            this.Hide();
            frm.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
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

       

        private void picSoporte_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmAgregarVehiculos frm = new FrmAgregarVehiculos();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un Vehículo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los datos seleccionados desde el DataGridView
            // Obtener los datos desde el DataGridView
            int idVehiculo = Convert.ToInt32(dgvVehiculos.CurrentRow.Cells["IdVehiculo"].Value);
            string codigo = dgvVehiculos.CurrentRow.Cells["CodigoVehiculo"].Value?.ToString();
            int idConductor = Convert.ToInt32(dgvVehiculos.CurrentRow.Cells["IdConductor"].Value);
            string placa = dgvVehiculos.CurrentRow.Cells["NPlaca"].Value?.ToString();
            string tipo = dgvVehiculos.CurrentRow.Cells["Tipo"].Value?.ToString();
            string marca = dgvVehiculos.CurrentRow.Cells["Marca"].Value?.ToString();
            string modelo = dgvVehiculos.CurrentRow.Cells["Modelo"].Value?.ToString();
            string color = dgvVehiculos.CurrentRow.Cells["Color"].Value?.ToString();
            DateTime fechaRegistro = Convert.ToDateTime(dgvVehiculos.CurrentRow.Cells["FechaRegistro"].Value);
            string nAsientos = dgvVehiculos.CurrentRow.Cells["NAsientos"].Value?.ToString();
            string estado = dgvVehiculos.CurrentRow.Cells["Estado"].Value?.ToString();


            // Abrir el formulario de edición de vehículos, pasando los valores
            FrmEditarVehiculos frm = new FrmEditarVehiculos(idVehiculo, codigo, idConductor, placa, tipo, marca, modelo, color, fechaRegistro, nAsientos, estado);
 
            this.Hide();
            frm.ShowDialog();

        }

      
    }
}
