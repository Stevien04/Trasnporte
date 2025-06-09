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

namespace PGII_CONTROL_DE_TRANSPORTE.FrmInspector
{
    public partial class FrmAgregarInspectores : Form
    {
        private string rutaFotoInspectores = "";
        private string rutaDocumento = "";
        private clsInspectores_CN negocio = new clsInspectores_CN();
        public FrmAgregarInspectores()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtFinicio.Text) ||
                string.IsNullOrWhiteSpace(txtFfin.Text) ||
                string.IsNullOrWhiteSpace(txtRuc.Text) ||
                string.IsNullOrWhiteSpace(txtcategoria.Text)
                )

            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }
            if (!DateTime.TryParse(txtFinicio.Text, out DateTime fechaInicio))
            {
                MessageBox.Show("Fecha de inicio no es válida.");
                return;
            }

            if (!DateTime.TryParse(txtFfin.Text, out DateTime fechaFin))
            {
                MessageBox.Show("Fecha de fin no es válida.");
                return;
            }

            var inspector = new clsInspectores_CE
            {
                
                nombre = txtNombre.Text,
                Apellido = txtApellidos.Text,
                dni = txtDni.Text,
                fecha_in = DateTime.Parse(txtFinicio.Text),
                fecha_fin = DateTime.Parse(txtFfin.Text),
                ruc = txtRuc.Text,
                categoria = txtcategoria.Text,
                Fotografia = rutaFotoInspectores,
                Estado = "ACTIVO"
            };
            negocio.mtdAgregarInspector(inspector);


            clsAuditoriaInspector_CE auditoria = new clsAuditoriaInspector_CE
            {
                IdInspectorUsuario = clsSesion.IdInspector,         // quien hace la acción
                IdInspectorModificado = clsSesion.IdInspector,                // quien fue modificado
                Accion = "Modificó al inspector: " + txtNombre.Text + " " + txtApellidos.Text,
                Usuario = clsSesion.Usuario,
                Fecha = DateTime.Now
            };

            clsAuditoria_CN negocioAuditoria = new clsAuditoria_CN();
            negocioAuditoria.mtdRegistrarAuditoria(auditoria);



            MessageBox.Show("Inspector  registrado con éxito.");
            FrmInspectores frm = new FrmInspectores();
            this.Hide();
            frm.ShowDialog();

        }
        private void btnImportarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string carpetaDestino = Path.Combine(Application.StartupPath, "FotosInspectores");

                // Crear la carpeta si no existe
                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                // Crear un nombre único para la imagen (usando timestamp o GUID)
                string nombreArchivo = $"Inspector_{DateTime.Now.Ticks}{Path.GetExtension(ofd.FileName)}";
                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                // Copiar la imagen al directorio del programa
                File.Copy(ofd.FileName, rutaDestino, true);

                // Mostrar la imagen en el PictureBox
                pictureBox1.ImageLocation = rutaDestino;

                // Guardar la ruta relativa o absoluta para usarla después
                rutaFotoInspectores = rutaDestino;
            }
        }

        private void FrmAgregarInspectores_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;

            pnlInspectores.BackColor = Color.FromArgb(255, 140, 0);
            

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

                // Crear carpeta destino si no existe
                string carpetaDestino = Path.Combine(Application.StartupPath, "DocumentosInspectores");
                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                // Crear nombre único para el documento
                string nombreArchivo = $"Documento_{DateTime.Now.Ticks}{Path.GetExtension(ofd.FileName)}";
                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                // Copiar el documento
                File.Copy(ofd.FileName, rutaDestino, true);

                // Guardar la ruta del nuevo documento
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
                try
                {
                    if (File.Exists(rutaDocumento))
                    {
                        File.Delete(rutaDocumento);
                    }
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
            frm.Show();
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

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlinterfaz_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
