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
    using clsNegocio;

    namespace PGII_CONTROL_DE_TRANSPORTE.FrmUsuarios
    {

        public partial class FrmEditarUsuario : Form
        {
        private clsUsuario_CN negocio = new clsUsuario_CN();
        private int idInspector;
        public FrmEditarUsuario()
        {
                InitializeComponent();

            idInspector = clsSesion.IdInspector;
            txtID.Text = clsSesion.IdInspector.ToString();
            txtUsuario.Text = clsSesion.Usuario;
            txtpassword.Text = clsSesion.Password;
            txtcorreo.Text = clsSesion.Correo;
            txtcargo.Text = clsSesion.Cargo;
            txtvigencia.Text = clsSesion.VigenciaLicencia;
            txtestado.Text = clsSesion.Estado;
        }

      
        private void FrmEditarUsuario_Load(object sender, EventArgs e)
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
           string.IsNullOrWhiteSpace(txtpassword.Text) ||
           string.IsNullOrWhiteSpace(txtcorreo.Text) ||
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
                    Password = txtpassword.Text,
                    Correo = txtcorreo.Text,
                    Cargo = txtcargo.Text,
                    VigenciaLicencia = txtvigencia.Text,
                    Estado = txtestado.Text
                };

                negocio.mtdModificarUsuario(usuario);

                // ✅ Actualizar clase clsSesion
                
                clsSesion.IdInspector = usuario.id_inspector;
                clsSesion.Usuario = usuario.Usuario;
                clsSesion.Password = usuario.Password;
                clsSesion.Correo = usuario.Correo;
                clsSesion.Cargo = usuario.Cargo;
                clsSesion.VigenciaLicencia = usuario.VigenciaLicencia;
                clsSesion.Estado = usuario.Estado;

                MessageBox.Show("Usuario modificado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

       
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
    }
