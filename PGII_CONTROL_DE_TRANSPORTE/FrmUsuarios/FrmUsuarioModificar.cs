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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PGII_CONTROL_DE_TRANSPORTE.FrmUsuarios
{
    public partial class FrmUsuarioModificar : Form
    {
        clsUsuario_CE usuario = new clsUsuario_CE();
        clsUsuario_CN negocio = new clsUsuario_CN();
        private int idInspector;
        public FrmUsuarioModificar(int id,string nombre,int idIns,string Usuario, string Cargo,DateTime Vigencia, string Correo, string Estado)
        {
            InitializeComponent();


            this.idInspector = idIns;
            txtID.Text = idIns.ToString();
            txtUsuario.Text = Usuario;
            txtcorreo.Text = Correo;
            txtcargo.Text = Cargo;
            txtvigencia.Text = Vigencia.ToString();
            txtestado.Text = Estado;
        }

        private void FrmUsuarioModificar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
            AjustarPosicionImagen();
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
            if (
          string.IsNullOrWhiteSpace(txtUsuario.Text) ||
          string.IsNullOrWhiteSpace(txtestado.Text) ||
          string.IsNullOrWhiteSpace(txtcorreo.Text) ||
          string.IsNullOrWhiteSpace(txtcargo.Text) ||
          string.IsNullOrWhiteSpace(txtcargo.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                clsUsuario_CE usuario = new clsUsuario_CE
                {
                    id_User = Convert.ToInt32(txtID.Text),
                    id_inspector = idInspector,
                    Usuario = txtUsuario.Text,
                    
                    Correo = txtcorreo.Text,
                    Cargo = txtcargo.Text,
                    VigenciaLicencia = txtvigencia.Text,
                    Estado = txtestado.Text
                };

                negocio.mtdModificarUsuario(usuario);

         
               
                MessageBox.Show("Usuario modificado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
            }
        }
        

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
