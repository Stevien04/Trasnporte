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

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmEditarMultass : Form
    {
        private int idMulta;
        public FrmEditarMultass(int idMulta, string codigo, DateTime fecha, string monto, string uit, string deposito, string estado, int idInspector, int idConductor)
        {
            InitializeComponent();
            this.idMulta = idMulta;

            // Asigna los valores a los controles del formulario
            this.idMulta = idMulta;

            // Asignar valores a los controles visuales
            txtId.Text = idMulta.ToString();
            txtCodigo.Text = codigo;
            txtfecha.Text = fecha.ToString(); // formato legible
            txtMonto.Text = monto.ToString();
            txtUIT.Text = uit.ToString();
            txtDeposito.Text = deposito;
            txtcategoria.Text = estado;
            txtInspector.Text = idInspector.ToString();
            txtConductor.Text = idConductor.ToString();
            
        }

        private void LoadEditarMultass(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;

            pnlmultas.BackColor = Color.FromArgb(255, 140, 0);
            AjustarPosicionImagen();
        }
        //SqlConnection conexion = new SqlConnection("server:HIDDEN; database:upt_TrabajoInspectores; integrated segurity=true");

   
        private void AjustarPosicionImagen()
        {
            // Alinea a la derecha con margen y centra verticalmente en el panel superior
         

            lblsoporte.Left = pnltop.Width - lblsoporte.Width - 70;
            lblsoporte.Top = (pnltop.Height - lblsoporte.Height) / 2;

            picSoporte.Left = pnltop.Width - picSoporte.Width - 130;
            picSoporte.Top = (pnltop.Height - picSoporte.Height) / 2;

            AjustarPosicionBotonEditar();
            

        }

        private void AjustarPosicionBotonEditar()
        {
            // Colocar el botón en la esquina inferior derecha del formulario
            btnGuardar.Left = this.ClientSize.Width - btnGuardar.Width - 20; // 20 px del borde derecho
            btnGuardar.Top = this.ClientSize.Height - btnGuardar.Height - 20; // 20 px del borde inferior
        }

        //interfaz
        private void lblmultas_Click(object sender, EventArgs e)
        {
            FrmMultass frm = new FrmMultass();
            frm.ShowDialog();
            this.Hide();
        }

        private void lbloperativos_Click(object sender, EventArgs e)
        {
            FrmOperativos frm = new FrmOperativos();
            frm.ShowDialog();
            this.Hide();
        }

        private void lblreportes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            frm.ShowDialog();
            this.Hide();
        }

        private void lblinspectores_Click(object sender, EventArgs e)
        {
            FrmInspectores frm = new FrmInspectores();
            frm.ShowDialog();
            this.Hide();
        }


   

        private void lblconductores_Click(object sender, EventArgs e)
        {
            FrmConductores frm = new FrmConductores();
            frm.ShowDialog();
            this.Hide();
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
            frm.ShowDialog();
            this.Hide();
        }
        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            frm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnadjuntar_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Vehiculos.FrmVehiculos frm = new Vehiculos.FrmVehiculos();
            frm.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblObservacion_Click(object sender, EventArgs e)
        {

        }
    }
}
