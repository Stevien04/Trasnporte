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
using PGII_CONTROL_DE_TRANSPORTE.FrmUsuarios;
using PGII_CONTROL_DE_TRANSPORTE.Vehiculos;


namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmMenusPrincipal : Form
    {
        private clsUsuario_CE usuarioActual;

        public FrmMenusPrincipal()
        {
            InitializeComponent();
           
        }

        public FrmMenusPrincipal(clsUsuario_CE usuario) : this() // Llama al constructor por defecto
        {
            usuarioActual = usuario;
        }
        private void FrmMenusPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;

            pnlinicio.BackColor = Color.FromArgb(255, 140, 0);

            AjustarPosicionImagen();



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

  
        private void usuario_Click(object sender, EventArgs e)
        {
            if ( clsSesion.Cargo == "Administrador")
            {
                FrmUsuarioAdmincs frm = new FrmUsuarioAdmincs();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                FrmUsuario frm = new FrmUsuario();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
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

        private void AjustarPosicionImagen()
        {
            // Alinea a la derecha con margen y centra verticalmente en el panel superior
            picUsuario.Left = pnltop.Width - picUsuario.Width - 20; // 20 píxeles de margen derecho
            picUsuario.Top = (pnltop.Height - picUsuario.Height) / 2;
        }

        private void lblincio_Click(object sender, EventArgs e)
        {

        }

        private void pnlinicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
