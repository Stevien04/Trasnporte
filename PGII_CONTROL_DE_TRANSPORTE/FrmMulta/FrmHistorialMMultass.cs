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
    public partial class FrmHistorialMMultass : Form
    {
        public FrmHistorialMMultass()
        {
            InitializeComponent();
        }

        //SqlConnection conexion = new SqlConnection("server:HIDDEN; database:upt_TrabajoInspectores; integrated segurity=true");

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;

            pnlmultas.BackColor = Color.FromArgb(255, 140, 0);
            AjustarPosicionImagen();

            


        }
        private void AjustarPosicionImagen()
        {
            // Alinea a la derecha con margen y centra verticalmente en el panel superior
         

            lblsoporte.Left = pnltop.Width - lblsoporte.Width - 70;
            lblsoporte.Top = (pnltop.Height - lblsoporte.Height) / 2;

            picSoporte.Left = pnltop.Width - picSoporte.Width - 130;
            picSoporte.Top = (pnltop.Height - picSoporte.Height) / 2;

            AjustarPosicionBotonEditar();
            this.Resize += FrmVehiculos_Load;


        }

        private void AjustarPosicionBotonEditar()
        {
            // Colocar el botón en la esquina inferior derecha del formulario
            btnMenú.Left = this.ClientSize.Width - btnMenú.Width - 20; // 20 px del borde derecho
            btnMenú.Top = this.ClientSize.Height - btnMenú.Height - 20; // 20 px del borde inferior
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
            FrmHistorialMMultass frm = new FrmHistorialMMultass();
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

        private void label10_Click(object sender, EventArgs e)
        {
            Vehiculos.FrmVehiculos frm = new Vehiculos.FrmVehiculos();
            frm.Show();
            this.Hide();
        }
    }
}
