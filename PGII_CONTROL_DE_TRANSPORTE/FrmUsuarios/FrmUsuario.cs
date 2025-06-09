using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsEntidad;
using clsNegocio;
using PGII_CONTROL_DE_TRANSPORTE.FrmUsuarios;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmUsuario : Form
    {

        clsUsuario_CN usuarioCN = new clsUsuario_CN();
        public FrmUsuario()
        {
            InitializeComponent();
            this.Load += FrmUsuario_Load;


        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
            AjustarPosicionImagen();

            txtcorreo.Text = clsSesion.Correo;
            txtcargo.Text = clsSesion.Cargo;
            txtPassword.Text = clsSesion.Password;
            txtUsuario.Text = clsSesion.Usuario;
            txtID.Text = clsSesion.IdInspector.ToString();
        }
        private void AjustarPosicionImagen()
        {
            // Alinea a la derecha con margen y centra verticalmente en el panel superior
            picSoporte.Left = pnltop.Width - picSoporte.Width - 20; // 20 píxeles de margen derecho
            picSoporte.Top = (pnltop.Height - picSoporte.Height) / 2;
        }

        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            this.Hide();
            frm.ShowDialog();
        }
        private void lblcerrar_Click(object sender, EventArgs e)
        {
            FrmAcceso frm = new FrmAcceso();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            FrmEditarUsuario frm = new FrmEditarUsuario();
            this.Hide();
            frm.ShowDialog();


        }
    }
}
