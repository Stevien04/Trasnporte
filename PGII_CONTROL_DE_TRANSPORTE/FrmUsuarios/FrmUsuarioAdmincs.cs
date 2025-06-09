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
using PGII_CONTROL_DE_TRANSPORTE.FrmInspector;

    namespace PGII_CONTROL_DE_TRANSPORTE.FrmUsuarios
    {
        public partial class FrmUsuarioAdmincs : Form
        {
            clsUsuario_CN negocio = new clsUsuario_CN();
            public FrmUsuarioAdmincs()
            {
                InitializeComponent();
            }
      

   
            private void FrmUsuarioAdmincs_Load(object sender, EventArgs e)
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

                dgvUsuarios.DataSource = negocio.mtdListaUsuario();
                CargarClavesEnDataGrid();
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


            private void btnGenerar_Click(object sender, EventArgs e)
            {
                // Generar clave aleatoria de 6 dígitos
                Random rnd = new Random();
                int clave = rnd.Next(100000, 1000000); // 6 dígitos

                // Mostrar la clave en un TextBox llamado txtclave
                txtclave.Text = clave.ToString();

                // Ruta del archivo (puedes cambiarla si lo deseas)
                string rutaArchivo = "clave.txt";

                try
                {
                    // Guardar la clave en el archivo
                    System.IO.File.AppendAllText(rutaArchivo, clave.ToString() + Environment.NewLine);
                    MessageBox.Show("Clave generada y guardada en el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarClavesEnDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la clave: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        private void CargarClavesEnDataGrid()
        {
            string rutaArchivo = "clave.txt";

            if (!System.IO.File.Exists(rutaArchivo))
            {
                return;
            }

            string[] claves = System.IO.File.ReadAllLines(rutaArchivo);

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Clave Generada");

            foreach (string clave in claves)
            {
                if (!string.IsNullOrWhiteSpace(clave))
                {
                    tabla.Rows.Add(clave.Trim());
                }
            }

            dgvcodigo.DataSource = tabla;

            // Configuración visual
            dgvcodigo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcodigo.ReadOnly = true;
            dgvcodigo.AllowUserToAddRows = false;
            dgvcodigo.AllowUserToDeleteRows = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario frm = new FrmEditarUsuario();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un Inspector para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del inspector seleccionado desde el DataGridView
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id_User"].Value);
            int idIns = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id_inspector"].Value);
            string nombre = dgvUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
            string Usuario = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
            string Cargo = dgvUsuarios.CurrentRow.Cells["Cargo"].Value.ToString();
            DateTime Vigencia = Convert.ToDateTime(dgvUsuarios.CurrentRow.Cells["VigenciaLicencia"].Value);
            string Correo = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
            string Estado = dgvUsuarios.CurrentRow.Cells["Estado"].Value.ToString();
           

            
            FrmUsuarioModificar frm = new FrmUsuarioModificar(id, nombre, idIns, Usuario, Cargo, Vigencia, Correo, Estado);
            this.Hide();
            frm.ShowDialog();
        }
    }
    }
