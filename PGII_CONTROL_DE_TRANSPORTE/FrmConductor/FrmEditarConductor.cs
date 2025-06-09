using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using clsNegocio;
using clsEntidad;
using System.Diagnostics;

namespace PGII_CONTROL_DE_TRANSPORTE.FrmConductor
{
    public partial class FrmEditarConductor : Form
    {
        private int idConductor;
        private string rutaFoto = "";
        private string rutaDocumento = "";
        private clsConductor_CN negocio = new clsConductor_CN();

        public FrmEditarConductor(int id, string dni, string codigo, string nombre, string apellidos, string vigencia, string tipoLicencia, string fotografia)
        {
            InitializeComponent();
            idConductor = id;
            txtDni.Text = dni;
            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
            txtApellidos.Text = apellidos;
            txtVigenciaLicencia.Text = vigencia;
            txtTipoLicencia.Text = tipoLicencia;
            rutaFoto = fotografia;

            if (!string.IsNullOrEmpty(rutaFoto) && File.Exists(rutaFoto))
                pictureBox1.ImageLocation = rutaFoto;
        }

        private void FrmEditarConductor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlInterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
            pnlConductores.BackColor = Color.FromArgb(255, 140, 0);
           
        }
       
        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            this.Hide();
            frm.ShowDialog();
        }
        private void lblconductores_Click(object sender, EventArgs e)
        {

        }
        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos.FrmVehiculos frm = new Vehiculos.FrmVehiculos();
            this.Hide();
            frm.ShowDialog();
        }
        private void lblmultas_Click(object sender, EventArgs e)
        {
            FrmMultass frm = new FrmMultass();
            this.Hide();
            frm.ShowDialog();
        }
        private void lblOperativos_Click(object sender, EventArgs e)
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
       
        private void picSoporte_Click(object sender, EventArgs e)
        {
            FrmSoporte frm = new FrmSoporte();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtVigenciaLicencia.Text) ||
                string.IsNullOrWhiteSpace(txtTipoLicencia.Text))
            {
                MessageBox.Show("Completa todos los campos obligatorios.");
                return;
            }

            var conductor = new clsConductor_CE
            {
                IdConductor = idConductor,
                Dni = txtDni.Text,
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellidos.Text,
                VigenciaLicencia = txtVigenciaLicencia.Text,
                TipoLicencia = txtTipoLicencia.Text,
                Fotografia = rutaFoto
            };

            try
            {
                negocio.mtdActualizarConductor(conductor);
                MessageBox.Show("Conductor actualizado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }

            FrmConductores frm = new FrmConductores();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnImportarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = ofd.FileName;
                pictureBox1.ImageLocation = rutaFoto;
            }
        }

        private void btnAdjuntarDocumentos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Todos los archivos (*.*)|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(rutaDocumento))
                {
                    var confirm = MessageBox.Show("Ya hay un documento adjunto. ¿Deseas sobrescribirlo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm != DialogResult.Yes) return;
                }

                rutaDocumento = ofd.FileName;
                MessageBox.Show("Documento adjuntado correctamente.");
            }
        }

        private void btnVerDocumentos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rutaDocumento) && File.Exists(rutaDocumento))
                Process.Start(rutaDocumento);
            else
                MessageBox.Show("El documento no existe o no ha sido adjuntado.");
        }

        private void btnDescargarDocumentos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaDocumento) || !File.Exists(rutaDocumento))
            {
                MessageBox.Show("No hay documento para descargar.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = Path.GetFileName(rutaDocumento)
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(rutaDocumento, sfd.FileName, true);
                MessageBox.Show("Documento descargado con éxito.");
            }
        }

        private void btnBorrarDocumentos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaDocumento))
            {
                MessageBox.Show("No hay documento adjunto.");
                return;
            }

            var confirm = MessageBox.Show("¿Seguro que deseas borrar el documento vinculado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                rutaDocumento = "";
                MessageBox.Show("Documento desvinculado.");
            }
        }
    }
}
