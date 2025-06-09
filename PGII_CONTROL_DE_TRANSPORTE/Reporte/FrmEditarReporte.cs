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
using clsEntidad;
using clsNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PGII_CONTROL_DE_TRANSPORTE.Reporte
{
    public partial class FrmEditarReporte : Form
    {
        private int id_Reporte;
        private string rutaFotoReporte = "";
        private string rutaDocumento = "";
        private clsReporte_CN negocio = new clsReporte_CN();
        public FrmEditarReporte(int idReporte, DateTime fecha, string hora, string ubicacion, string descripcion, string idInspector, string idVehiculo, string fotoVideo, string estadoRevision,string cargo)
        {
            InitializeComponent();

            id_Reporte = idReporte;
            txtID.Text = id_Reporte.ToString();
            txtFecha.Text = fecha.ToString();
            txthora.Text = hora.ToString();
            txtUbicacion.Text = ubicacion;
            txtDescripcion.Text = descripcion;
            txtInspector.Text = idInspector;
            txtPlacaV.Text = idVehiculo;
            txtEstadoR.Text = estadoRevision;
            

          
            rutaFotoReporte = fotoVideo;

            if (!string.IsNullOrEmpty(rutaFotoReporte) && File.Exists(rutaFotoReporte))
                pictureBox1.ImageLocation = rutaFotoReporte;

        }

        private void FrmEditarReporte_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
            pnlReportes.BackColor = Color.FromArgb(255, 140, 0);
            


        }
      
        private void btnAdjuntarDocumentos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Todos los archivos (*.*)|*.*" };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(rutaDocumento))
                {
                    var confirm = MessageBox.Show("Ya hay un documento adjunto. ¿Deseas sobrescribirlo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm != DialogResult.Yes) return;
                }

                string carpetaDestino = Path.Combine(Application.StartupPath, "DocumentosReportes");
                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                string nombreArchivo = $"Documento_{DateTime.Now.Ticks}{Path.GetExtension(ofd.FileName)}";
                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);
                File.Copy(ofd.FileName, rutaDestino, true);

                rutaDocumento = rutaDestino;
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

            SaveFileDialog sfd = new SaveFileDialog { FileName = Path.GetFileName(rutaDocumento) };
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
                try
                {
                    if (File.Exists(rutaDocumento))
                        File.Delete(rutaDocumento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar el archivo: " + ex.Message);
                    return;
                }

                rutaDocumento = "";
                MessageBox.Show("Documento eliminado y desvinculado.");
            }

        }

        private void btnImportarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string carpetaDestino = Path.Combine(Application.StartupPath, "FotosReportes");
                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                string nombreArchivo = $"Reporte_{DateTime.Now.Ticks}{Path.GetExtension(ofd.FileName)}";
                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                File.Copy(ofd.FileName, rutaDestino, true);
                pictureBox1.ImageLocation = rutaDestino;
                rutaFotoReporte = rutaDestino;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFecha.Text) ||
                    string.IsNullOrWhiteSpace(txthora.Text) ||
                    string.IsNullOrWhiteSpace(txtPlacaV.Text) ||
                    string.IsNullOrWhiteSpace(txtUbicacion.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                    string.IsNullOrWhiteSpace(txtInspector.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            if (!DateTime.TryParse(txtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("Fecha no válida.");
                return;
            }

            if (!TimeSpan.TryParse(txthora.Text, out TimeSpan hora))
            {
                MessageBox.Show("Hora no válida.");
                return;
            }

            var reporte = new clsReporte_CE
            {
                Id_Reporte = int.Parse(txtID.Text),
                Descripcion = txtDescripcion.Text,
                Ubicacion = txtUbicacion.Text,
                Id_Inspector = int.Parse(txtInspector.Text),
                Id_Vehiculo = int.Parse(txtPlacaV.Text),
                Estado_Revision = txtEstadoR.Text,
                Fecha = fecha.Date,
                Hora = hora,
                Foto_Video = rutaFotoReporte
            };

            negocio.mtdModificarReporte(reporte);

            MessageBox.Show("Reporte actualizado con éxito.");
            FrmReportes frm = new FrmReportes();
            this.Hide();
            frm.ShowDialog();

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


        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
