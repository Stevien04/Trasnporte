using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using clsNegocio;
using clsEntidad;


namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmMultass : Form
    {
        private clsMulta_CN negocioMulta = new clsMulta_CN();

        public FrmMultass()
        {
            InitializeComponent();
            negocioMulta = new clsMulta_CN();
        }
            
      
        private void AjustarPosicionImagen()
        {
            // Alinea a la derecha con margen y centra verticalmente en el panel superior
          

            lblsoporte.Left = pnltop.Width - lblsoporte.Width - 70;
            lblsoporte.Top = (pnltop.Height - lblsoporte.Height) / 2;

            picSoporte.Left = pnltop.Width - picSoporte.Width - 130;
            picSoporte.Top = (pnltop.Height - picSoporte.Height) / 2;

            AjustarPosicionBotonEditar();
           

            AjustarPosicionBtnHistorial();
           

            AjustarPosicionBtnAgregar();
            

        }

        private void AjustarPosicionBotonEditar()
        {
            // Colocar el botón en la esquina inferior derecha del formulario
            btneditar.Left = this.ClientSize.Width - btneditar.Width - 20; // 20 px del borde derecho
            btneditar.Top = this.ClientSize.Height - btneditar.Height - 20; // 20 px del borde inferior
        }

        private void AjustarPosicionBtnHistorial()
        {
            // Ubicar btnhistorial justo a la derecha de pnlinterfaz, abajo
            btnhistorial.Left = pnlinterfaz.Width + 20; // margen de 20px a la derecha del panel
            btnhistorial.Top = this.ClientSize.Height - btnhistorial.Height - 20; // margen inferior
        }

        private void AjustarPosicionBtnAgregar()
        {
            btnagregar.Left = this.ClientSize.Width - btnagregar.Width - 20;
            btnagregar.Top = pnltop.Height + 20;
        }

 
        //interfaz
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
            frm.ShowDialog(); ;
        }



        private void lblconductores_Click(object sender, EventArgs e)
        {
            FrmConductores frm = new FrmConductores();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblvehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos.FrmVehiculos  frm = new Vehiculos.FrmVehiculos();
            this.Hide();
            frm.ShowDialog();

        }

        private void Soporte_Click(object sender, EventArgs e)
        {
            FrmSoporte frm = new FrmSoporte();
            frm.ShowDialog();
            this.Hide();
        }
        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            this.Hide();
            frm.ShowDialog();
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmAgregarMultass frm = new FrmAgregarMultass();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvMultas.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un Multa para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idMulta = Convert.ToInt32(dgvMultas.CurrentRow.Cells["id_Multas"].Value);
            int idConductor = Convert.ToInt32(dgvMultas.CurrentRow.Cells["id_Conductor"].Value);
            string codigo = dgvMultas.CurrentRow.Cells["codigo_Multa"].Value.ToString();
            DateTime fecha = Convert.ToDateTime(dgvMultas.CurrentRow.Cells["fecha_multa"].Value);
            string monto = dgvMultas.CurrentRow.Cells["monto"].Value.ToString();
            string uit = dgvMultas.CurrentRow.Cells["valor_uit"].Value.ToString();
            string deposito = dgvMultas.CurrentRow.Cells["Vehi_Deposito"].Value.ToString();
            string estado = dgvMultas.CurrentRow.Cells["Estado_Multa"].Value.ToString();
            int idInspector = Convert.ToInt32(dgvMultas.CurrentRow.Cells["id_inspector_responsable"].Value);
            

            FrmEditarMultass frm = new FrmEditarMultass(idMulta, codigo, fecha, monto, uit, deposito, estado, idInspector, idConductor);
            this.Hide();
            frm.ShowDialog();
                
               
           
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Vehiculos.FrmVehiculos frm = new Vehiculos.FrmVehiculos();
            frm.Show();
            this.Hide();
        }

        private void dgvMultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMultass_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
            pnlmultas.BackColor = Color.FromArgb(255, 140, 0);
            AjustarPosicionImagen();

            dgvMultas.DataSource = negocioMulta.mtdObtenerMultas();
        }
    }
}
