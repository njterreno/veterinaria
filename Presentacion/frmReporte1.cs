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
    public partial class frmReporte1 : Form
    {
        DSHistoriaClinica DSHistoriaClinica;

        public frmReporte1()
        {
            InitializeComponent();
        }

        public frmReporte1(DSHistoriaClinica datos): this()
        {
            DSHistoriaClinica = datos;
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            rptHistoriaClinica rptHistoriaClinica = new rptHistoriaClinica();
            rptHistoriaClinica.SetDataSource(DSHistoriaClinica);
            crvReporte1.ReportSource = rptHistoriaClinica;
            crvReporte1.Refresh();
        }
    }
}
