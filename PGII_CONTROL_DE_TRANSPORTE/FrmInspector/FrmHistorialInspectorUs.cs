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

    namespace PGII_CONTROL_DE_TRANSPORTE.FrmInspector
    {
        public partial class FrmHistorialInspectorUs : Form
        {
        private int id;
        private string nombre;
        private string apellido;
        private string dni;
        private DateTime finicio;
        private DateTime ffin;
        private string ruc;
        private string categoria;
        private string fotografia;
        private string editado;

        public FrmHistorialInspectorUs(int id, string nombre, string apellido, string dni, DateTime finicio, DateTime ffin, string ruc, string categoria, string fotografia, string editado)
            {
                InitializeComponent();
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.finicio = finicio;
            this.ffin = ffin;
            this.ruc = ruc;
            this.categoria = categoria;
            this.fotografia = fotografia;
            this.editado = editado;
        }

            private void FrmHistorialInspectorUs_Load(object sender, EventArgs e)
            {

            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;

            pnlInspectores.BackColor = Color.FromArgb(255, 140, 0);
            

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("DNI", typeof(string));
            dt.Columns.Add("FechaInicio", typeof(DateTime));
            dt.Columns.Add("FechaFin", typeof(DateTime));
            dt.Columns.Add("RUC", typeof(string));
            dt.Columns.Add("Categoria", typeof(string));
            dt.Columns.Add("Fotografia", typeof(string));
            dt.Columns.Add("Editado", typeof(string));

            dt.Rows.Add(id, nombre, apellido, dni, finicio, ffin, ruc, categoria, fotografia, editado);
            dgvInspectores.DataSource = dt;

            clsAuditoria_CN negocio = new clsAuditoria_CN();
            clsAuditoriaInspector_CE auditoria = negocio.ObtenerUltimaAuditoriaPorInspector(id);

            if (string.IsNullOrEmpty(auditoria.Usuario))
            {
                MessageBox.Show("No se encontró auditoría para este inspector.");
                txtaccion.Text = "";
                txtFecha.Text = "";
                txtUsuario.Text = "";
            }
            else
            {
                txtaccion.Text = auditoria.Accion;
                txtFecha.Text = auditoria.Fecha.ToString("g");
                txtUsuario.Text = auditoria.Usuario;
            }

             }
    

        private void txtRetrocedes_Click(object sender, EventArgs e)
        {
            FrmHistorialInspectores frm = new FrmHistorialInspectores();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblmultas_Click(object sender, EventArgs e)
        {
            FrmMultass frm = new FrmMultass();
            this.Hide();
            frm.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Vehiculos.FrmVehiculos frm = new Vehiculos.FrmVehiculos();
            frm.Show();
            this.Hide();
        }
    }
}
