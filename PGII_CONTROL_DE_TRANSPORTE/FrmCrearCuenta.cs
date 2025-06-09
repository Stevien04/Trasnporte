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

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmCrearCuenta : Form
    {
        clsUsuario_CN logica = new clsUsuario_CN();

        public FrmCrearCuenta()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAcceso frm = new FrmAcceso();
            this.Hide();
            frm.ShowDialog();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
        if (
        string.IsNullOrWhiteSpace(txtID.Text) ||
        string.IsNullOrWhiteSpace(txtusuario.Text) ||
        string.IsNullOrWhiteSpace(txtpassword.Text) ||
        string.IsNullOrWhiteSpace(txtcorreo.Text) ||
        string.IsNullOrWhiteSpace(txtcargo.Text) ||
        string.IsNullOrWhiteSpace(txtclave.Text)) 
        // Asegurar que se ingresó la clave
        {
        MessageBox.Show("Por favor complete todos los campos obligatorios, incluida la clave.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        }
            string[] dominiosValidos = { "@gmail.com", "@upt.pe", "@hotmail.com", "@outlook.com" };
            string correoIngresado = txtcorreo.Text.Trim();

            if (!dominiosValidos.Any(d => correoIngresado.EndsWith(d, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El correo debe terminar en @gmail.com, @upt.pe, @hotmail.com o @outlook.com", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rutaClave = "clave.txt";

            // Verificar que el archivo con la clave exista
            if (!System.IO.File.Exists(rutaClave))
            {
                MessageBox.Show("No se encontró ninguna clave generada. Solicite una clave antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtcargo.Text))
            {
                string texto = txtcargo.Text.Trim().ToLower();
                txtcargo.Text = char.ToUpper(texto[0]) + texto.Substring(1);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el cargo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que sea Supervisor o Administrador
            if (txtcargo.Text != "Supervisor" && txtcargo.Text != "Administrador")
            {
                MessageBox.Show("El cargo debe ser 'Supervisor' o 'Administrador'.", "Cargo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Leer todas las claves del archivo
            string[] clavesGuardadas = System.IO.File.ReadAllLines(rutaClave);

            // Verificar la clave ingresada (txtclave.Text) que exista en el archivo
            if (!clavesGuardadas.Contains(txtclave.Text.Trim()))
            {
                MessageBox.Show("La clave ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (logica.ExisteUsuarioPorInspectorID(int.Parse(txtID.Text.Trim())))
            {
                MessageBox.Show("Ya existe un usuario con ese ID de inspector. Usa otro ID.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                clsUsuario_CE nuevoUsuario = new clsUsuario_CE()
                {
                    id_inspector = int.Parse(txtID.Text.Trim()),
                    VigenciaLicencia = txtvigencia.Text.Trim(),
                    Usuario = txtusuario.Text.Trim(),
                    Password = txtpassword.Text.Trim(),
                    Cargo = txtcargo.Text.Trim(),
                    Correo = txtcorreo.Text.Trim(),
                    Estado = "Activo"
                };

                clsUsuario_CN logica = new clsUsuario_CN();
                logica.mtdAgregarUsuario(nuevoUsuario);

                // Borrar la clave después de usarla
                System.IO.File.Delete(rutaClave);

                MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                FrmAcceso frm = new FrmAcceso();
                this.Hide();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


        }

        private void comboxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcargo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtcargo.Text))
            {
                string texto = txtcargo.Text.Trim().ToLower();
                txtcargo.Text = char.ToUpper(texto[0]) + texto.Substring(1);
            }
        }
    }
}
