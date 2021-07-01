using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        frmFichas Fichas = new frmFichas();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Fichas.ShowDialog();
        }

        private void fichasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fichas.ShowDialog();
        }

        private void btnSalirInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
