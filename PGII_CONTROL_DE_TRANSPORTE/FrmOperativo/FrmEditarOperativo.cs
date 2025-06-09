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

namespace PGII_CONTROL_DE_TRANSPORTE.FrmOperativo
{
    public partial class FrmEditarOperativo : Form
    {

        private int idOperativo;
        private string rutaDocumento = "";
        private string documentoPath;
        private clsOperativo_CN negocio = new clsOperativo_CN();
        public FrmEditarOperativo(int id, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, int cantidadPolicias, int cantidadInspectores, string direccion, string motivo, string resultado, string ubicacionDoc)
        {
            InitializeComponent();
            idOperativo = id;
            txtId.Text = id.ToString();
            txtFecha.Text = fecha.ToString("yyyy-MM-dd");
            txtHoraInicio.Text = horaInicio.ToString(@"hh\:mm");
            txtHoraFin.Text = horaFin.ToString(@"hh\:mm");
            txtCantidadInspectores.Text = cantidadInspectores.ToString();
            txtDireccion.Text = direccion;
            txtMotivo.Text = motivo;
            txtResultado.Text = resultado;
            rutaDocumento = ubicacionDoc;
        }

        private void FrmEditarOperativo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlInterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
            pnlOperativos.BackColor = Color.FromArgb(255, 140, 0);
        
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
                MessageBox.Show("Por favor completa todos los campos obligatorios.");
                return;
            }

            try
            {
                var operativo = new clsOperativo_CE
                {
                    IdOperativo = idOperativo,
                    FechaOperativo = DateTime.Parse(txtFecha.Text),
                    HoraInicio = TimeSpan.Parse(txtHoraInicio.Text),
                    HoraFin = TimeSpan.Parse(txtHoraFin.Text),
                    CantidadPolicias = 0,
                    CantidadInspectores = int.Parse(txtCantidadInspectores.Text),
                    Direccion = txtDireccion.Text,
                    MotivoOperativo = txtMotivo.Text,
                    Resultado = txtResultado.Text,
                    UbicacionDocumento = rutaDocumento
                };

                negocio.mtdActualizarOperativo(operativo);
                MessageBox.Show("Operativo actualizado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
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
                rutaDocumento = "";
                MessageBox.Show("Documento desvinculado.");
            }
        }

        private void lblmultas_Click(object sender, EventArgs e)
        {
            FrmMultass frm = new FrmMultass();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos.FrmVehiculos frm = new Vehiculos.FrmVehiculos();
            this.Hide();
            frm.ShowDialog();
        }

        // INTERFAZ

     
        

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


        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
