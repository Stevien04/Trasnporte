using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using clsEntidad;
using clsNegocio;

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmAgregarVehiculos : Form
    {
        private clsVehiculo_CN vehiculoCN = new clsVehiculo_CN();
        public FrmAgregarVehiculos()
        {
            InitializeComponent();
        }

        //SqlConnection conexion = new SqlConnection("server:HIDDEN; database:upt_TrabajoInspectores; integrated segurity=true");

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;

            pnlvehiculo.BackColor = Color.FromArgb(255, 140, 0);
            AjustarPosicionImagen();

            


        }
        private void AjustarPosicionImagen()
        {
            // Alinea a la derecha con margen y centra verticalmente en el panel superior
           

            lblsoporte.Left = pnltop.Width - lblsoporte.Width - 70;
            lblsoporte.Top = (pnltop.Height - lblsoporte.Height) / 2;

            picSoporte.Left = pnltop.Width - picSoporte.Width - 130;
            picSoporte.Top = (pnltop.Height - picSoporte.Height) / 2;

            AjustarPosicionBotonEditar();
            this.Resize += FrmVehiculos_Load;


        }

        private void AjustarPosicionBotonEditar()
        {
            // Colocar el botón en la esquina inferior derecha del formulario
            btnguardar.Left = this.ClientSize.Width - btnguardar.Width - 20; // 20 px del borde derecho
            btnguardar.Top = this.ClientSize.Height - btnguardar.Height - 20; // 20 px del borde inferior
        }

        //interfaz
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
            FrmAgregarVehiculos frm = new FrmAgregarVehiculos();
            this.Hide();
            frm.ShowDialog();

        }

        private void Soporte_Click(object sender, EventArgs e)
        {
            FrmSoporte frm = new FrmSoporte();
            frm.ShowDialog();
            this.Hide();
        }
        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtconductor.Text, out int idConductor))
                {
                    MessageBox.Show("Por favor ingrese un ID de conductor válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtconductor.Focus();
                    return;
                }
                if (!int.TryParse(txtasientos.Text, out int numeroAsientos))
                {
                    MessageBox.Show("Por favor ingrese un número válido en N° Asientos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtasientos.Focus();
                    return;
                }

                clsVehiculo_CE nuevoVehiculo = new clsVehiculo_CE
                {
                    CodigoVehiculo = txtCodigo.Text,
                    IdConductor = idConductor,
                    NumeroPlaca = txtplaca.Text,
                    Tipo = txttipo.Text,
                    Marca = txtmarca.Text,
                    Modelo = txtmodelo.Text,
                    Color = txtcolor.Text,
                    FechaRegistro = txtFecha.Text,
                    NumeroAsientos = numeroAsientos,
                    Estado = txtestado.Text
                };

                vehiculoCN.mtdAgregarVehiculo(nuevoVehiculo);
                MessageBox.Show("Vehículo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtasientos.Text = "";
            txtplaca.Text = "";
            txtcolor.Text = "";
            txtestado.Text = "";
            txtFecha.Text = "";
            txtmarca.Text = "";
            txttipo.Text = "";
            txtconductor.Text = "";
            txtmodelo.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
