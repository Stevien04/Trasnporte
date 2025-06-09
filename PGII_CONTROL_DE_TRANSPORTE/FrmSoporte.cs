using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGII_CONTROL_DE_TRANSPORTE
{
    public partial class FrmSoporte : Form
    {
        public FrmSoporte()
        {
            InitializeComponent();
        }

        private void FrmSoporte_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnlinterfaz.Dock = DockStyle.Left;
            pnltop.Dock = DockStyle.Top;
        }

        private void lblincio_Click(object sender, EventArgs e)
        {
            FrmMenusPrincipal frm = new FrmMenusPrincipal();
            this.Hide();
            frm.ShowDialog();
        }

    }
}
