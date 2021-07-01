using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;


namespace Presentacion
{
    public partial class frmCrearReportePersonalizado : Form
    {
        public frmCrearReportePersonalizado()
        {
            InitializeComponent();
        }

        private void frmCrearReportePersonalizado_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.MaxDate = DateTime.Today;
            dtpFechaHasta.MaxDate = DateTime.Today;

            try
            {
                cargarComboTipoConsulta();
                cargarComboCliente();
                cargarComboProfesional();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
            }
        }

        private void cargarComboTipoConsulta()
        {
            clsTipoConsulta objClsTipoConsulta = new clsTipoConsulta();
            objClsTipoConsulta.cargarComboTipoConsulta(cmbTipoConsulta);
        }

        private void cargarComboCliente()
        {
            clsDueños objDueño = new clsDueños();
            objDueño.cargarComboCliente(cmbDueño);
        }

        private void cargarComboProfesional()
        {
            clsProfesional objClsProfesional = new clsProfesional();
            objClsProfesional.cargarComboProfesional(cmbProfesional);
        }

        private void cmbDueño_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsDueños.DueñoV objDueñoV = (clsDueños.DueñoV)((ComboBox)sender).SelectedItem;

            clsMascotas objClsMascotas = new clsMascotas();
            objClsMascotas.cargacombomascota(cmbMascota, objDueñoV.IDDueño);
        }        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbFechasTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFechasTodas.Checked)
            {
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
            else
            {
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
            }
        }

        private void btnMostraReporte_Click(object sender, EventArgs e)
        {
            string stFormula = "";
            int inValor = 0;

            string FechaDesde = Convert.ToDateTime(dtpFechaDesde.Value).ToString("yyyy/MM/dd 00:00");
            string FechaHasta = Convert.ToDateTime(dtpFechaHasta.Value).ToString("yyyy/MM/dd 23:59");

            if (!ckbFechasTodas.Checked)
            {
                stFormula = "({Consulta.Fecha} >= #" + FechaDesde + "#)" + " and " + "({Consulta.fecha} <= #" + FechaHasta + "#)"; 
            }

            if (cmbDueño.Text != " ")
            {
                if (stFormula.Length != 0) stFormula += " and ";
                stFormula = stFormula + "{Mascota.IDDueño} = " + Convert.ToInt32(cmbDueño.SelectedValue);
            }

            if (cmbProfesional.Text != " ")
            {
                if (stFormula.Length != 0) stFormula += " and ";
                    stFormula = stFormula + "{Consulta.IDProfesional} = " + Convert.ToInt32(cmbProfesional.SelectedValue);
            }

            if (cmbMascota.Text != "")
            {
                if (stFormula.Length != 0) stFormula += " and ";
                    stFormula = stFormula + "{Consulta.IDMascota} = " + Convert.ToInt32(cmbMascota.SelectedValue);
            }

            if (cmbTipoConsulta.Text != " ")
            {
                if (stFormula.Length != 0) stFormula += " and ";
                    stFormula = stFormula + "{TipoConsulta.IDTipoConsulta} = " + Convert.ToInt32(cmbTipoConsulta.SelectedValue);
            }

            if (cmbTipoReporte.Text == "Resumido")
            {
                inValor = 0;                
            }
            else
            {
                inValor = 1;
            }

            frmReporte2 frmReporte2 = new frmReporte2();

            rptReporte Reporte = new rptReporte();

            Reporte.DataDefinition.FormulaFields["Formato"].Text = inValor.ToString();

            Reporte.RecordSelectionFormula = stFormula;

            frmReporte2.crvReporte2.ReportSource = Reporte;

            frmReporte2.crvReporte2.Refresh();

            frmReporte2.ShowDialog();
        }        
    }
}
