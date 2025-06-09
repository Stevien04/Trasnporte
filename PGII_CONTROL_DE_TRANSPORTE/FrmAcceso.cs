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
using static System.Collections.Specialized.BitVector32;

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmAcceso : Form
    {
        public FrmAcceso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string password = txtpassword.Text.Trim();
            string captchaIngresado = txtcaptcha.Text.Trim();
            string captchaGenerado = txtcaptchaValor.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (captchaIngresado != captchaGenerado)
            {
                MessageBox.Show("Captcha incorrecto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcaptchaValor.Clear();
                txtcaptchaValor.Text = GenerarCaptcha();
               
                return;
            }

            clsUsuario_CN negocio = new clsUsuario_CN();
            DataTable resultado = negocio.mtdAutenticarUsuario(usuario, password);

            if (resultado.Rows.Count > 0)
            {
               DataTable datosCompletos = negocio.mtdObtenerUsuarioPorNombre(usuario);

                if (datosCompletos.Rows.Count > 0)
                {
                    DataRow fila = datosCompletos.Rows[0];

                    clsUsuario_CE usuarioObj = new clsUsuario_CE()
                    {
                        id_inspector = Convert.ToInt32(fila["id_inspector"]),
                        Usuario = fila["Usuario"].ToString(),
                        Password = fila["Password"].ToString(),
                        Correo = fila["Correo"].ToString(),
                        Cargo = fila["Cargo"].ToString(),
                        Estado = fila["Estado"].ToString(),
                        VigenciaLicencia = fila["VigenciaLicencia"].ToString()
                    };

                    // Guardar en sesión
                    clsSesion.IdInspector = usuarioObj.id_inspector;
                    clsSesion.Usuario = usuarioObj.Usuario;
                    clsSesion.Password = usuarioObj.Password;
                    clsSesion.Correo = usuarioObj.Correo;
                    clsSesion.Cargo = usuarioObj.Cargo;
                    clsSesion.Estado = usuarioObj.Estado;
                    clsSesion.VigenciaLicencia = usuarioObj.VigenciaLicencia;

                    FrmMenusPrincipal frm = new FrmMenusPrincipal(usuarioObj);
                    this.Hide();
                    frm.ShowDialog();
                    
                }
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcaptchaValor.Clear();
                txtcaptchaValor.Text = GenerarCaptcha(); // Regenera el captcha
                
            }
        }
        

        private string GenerarCaptcha()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString(); // Número aleatorio de 6 dígitos
        }


        private void lblcrearcuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta frm = new FrmCrearCuenta();
            this.Hide();
            frm.ShowDialog();

            txtcaptchaValor.Text = GenerarCaptcha();

        }

        private void FrmAcceso_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            txtcaptchaValor.Text = GenerarCaptcha();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
