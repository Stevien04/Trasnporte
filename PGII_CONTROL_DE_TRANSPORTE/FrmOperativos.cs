using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmOperativos : Form
    {
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
            AjustarPosicionImagen();
        }
        private void AjustarPosicionImagen()
        {
            // Alinea a la derecha con margen y centra verticalmente en el panel superior
            picUsuario.Left = pnltop.Width - picUsuario.Width - 20; // 20 píxeles de margen derecho
            picUsuario.Top = (pnltop.Height - picUsuario.Height) / 2;
        }
        // INTERFAZ

        private void lblmultas_Click(object sender, EventArgs e)
        {
            FrmMultas frm = new FrmMultas();
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


        private void usuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
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
            FrmVehiculos frm = new FrmVehiculos();
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
