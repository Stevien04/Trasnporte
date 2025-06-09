using clsEntidad;
using clsNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGII_CONTROL_DE_TRANSPORTE.FrmOperativo
{
    public partial class FrmAgregarOperativo : Form
    {
        private string rutaDocumento = "";
        private clsOperativo_CN negocio = new clsOperativo_CN();
        public FrmAgregarOperativo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFecha.Text) ||
                string.IsNullOrWhiteSpace(txtHoraInicio.Text) ||
                string.IsNullOrWhiteSpace(txtHoraFin.Text) ||
                string.IsNullOrWhiteSpace(txtCantidadInspectores.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtMotivo.Text) ||
                string.IsNullOrWhiteSpace(txtResultado.Text))
            {
                MessageBox.Show("Completa todos los campos obligatorios.");
                return;
            }

            try
            {
                var operativo = new clsOperativo_CE
                {
                    FechaOperativo = DateTime.Parse(txtFecha.Text),
                    HoraInicio = TimeSpan.Parse(txtHoraInicio.Text),
                    HoraFin = TimeSpan.Parse(txtHoraFin.Text),
                    CantidadPolicias = 0, // Este campo no está en el form
                    CantidadInspectores = int.Parse(txtCantidadInspectores.Text),
                    Direccion = txtDireccion.Text,
                    MotivoOperativo = txtMotivo.Text,
                    Resultado = txtResultado.Text,
                    UbicacionDocumento = rutaDocumento
                };

                negocio.mtdAgregarOperativo(operativo);
                MessageBox.Show("Operativo registrado correctamente.");

                FrmOperativos frm = new FrmOperativos();
                this.Hide();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnAdjuntarDocumentos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Todos los archivos (*.*)|*.*" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Crear carpeta local del proyecto
                string carpetaDestino = Path.Combine(Application.StartupPath, "Documentos");
                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                string nombreArchivo = Path.GetFileName(ofd.FileName);
                string destinoFinal = Path.Combine(carpetaDestino, nombreArchivo);
                File.Copy(ofd.FileName, destinoFinal, true);
                rutaDocumento = Path.Combine("Documentos", nombreArchivo); // Ruta relativa

                MessageBox.Show("Documento adjuntado correctamente.");
            }
        }

        private void btnVerDocumentos_Click(object sender, EventArgs e)
        {
            string rutaCompleta = Path.Combine(Application.StartupPath, rutaDocumento);
            if (!string.IsNullOrEmpty(rutaDocumento) && File.Exists(rutaCompleta))
                Process.Start(rutaCompleta);
            else
                MessageBox.Show("El documento no existe o no ha sido adjuntado.");
        }

        private void btnDescargarDocumentos_Click(object sender, EventArgs e)
        {
            string rutaCompleta = Path.Combine(Application.StartupPath, rutaDocumento);
            if (string.IsNullOrEmpty(rutaDocumento) || !File.Exists(rutaCompleta))
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
                File.Copy(rutaCompleta, sfd.FileName, true);
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

        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblconductores_Click(object sender, EventArgs e)
        {
            FrmConductores frm = new FrmConductores();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos.FrmVehiculos frm = new Vehiculos.FrmVehiculos();
            this.Hide();
            frm.ShowDialog(); ;
        }

        private void lblmultas_Click(object sender, EventArgs e)
        {
            FrmMultass frm = new FrmMultass();
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
        private void lbloperativos_Click(object sender, EventArgs e)
        {
            FrmOperativos frm = new FrmOperativos();
            this.Hide();
            frm.ShowDialog();

        }


        private void FrmAgregarOperativo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlInterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
            pnlOperativos.BackColor = Color.FromArgb(255, 140, 0);
        }
    }
}