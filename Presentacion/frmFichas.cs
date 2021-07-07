using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Datos;

namespace Presentacion
{
    public partial class frmFichas : Form
    {
        clsDueños objDueño = new clsDueños();
        clsMascotas objMascota = new clsMascotas();
        clsConsulta objConsulta = new clsConsulta();
        clsTipoConsulta objTipoConsulta = new clsTipoConsulta();
        clsProfesional objProfesional = new clsProfesional();
        clsDetalleConsulta objDetalleConsulta = new clsDetalleConsulta();

        frmNuevoDueño NuevoDueño = new frmNuevoDueño();

        frmMascota Tab = new frmMascota();

        public frmFichas()
        {
            InitializeComponent();

            //btnNuevoCliente.Enabled = false;
            btnNuevaMascota.Enabled = false;
            Tab.dtpFechaBajaMascota.ShowCheckBox = true;
            Tab.dtpFechaBajaMascota.Checked = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoDueño.btnActualizar.Visible = false;

            NuevoDueño.btnGuardarNuevoDueño.Visible = true;

            NuevoDueño.ShowDialog();
        }

        private void btnSalirBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDatosDueños_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmNuevoDueño NuevoDueño = new frmNuevoDueño();

            NuevoDueño.btnActualizar.Visible = true;

            NuevoDueño.btnGuardarNuevoDueño.Visible = false;

            int i = dgvDatosDueños.CurrentRow.Index;

            NuevoDueño.CargarTxtDueño(Convert.ToInt32(dgvDatosDueños.Rows[i].Cells[0].Value.ToString()));

            dgvDatosDueños.Rows.Clear();

            btnBuscarDueño.PerformClick();
        }

        private void btnBuscarDueño_Click(object sender, EventArgs e)
        {
            dgvDatosDueños.Rows.Clear();

            if (txtDNIBuscar.Text == "" && txtNombreDueñoBuscar.Text == "")
            {
                List<Dueño> lista = objDueño.LeerDueños();

                if (dgvDatosDueños.RowCount == 1)
                {
                    foreach (var item in lista)
                    {
                        dgvDatosDueños.Rows.Add(item.IDDueño, item.DNI, item.Nombre, item.Apellido, item.Domicilio, item.Telefono, item.Correo, item.Observaciones, item.Localidad.Nombre);
                    }
                }
            }
            else if (txtDNIBuscar.Text != "" && txtNombreDueñoBuscar.Text == "")
            {
                List<Dueño> listaDNI = objDueño.LeerPorDNI(Convert.ToInt32(txtDNIBuscar.Text));

                foreach (var item in listaDNI)
                {
                    dgvDatosDueños.Rows.Add(item.IDDueño, item.DNI, item.Nombre, item.Apellido, item.Domicilio, item.Telefono, item.Correo, item.Observaciones, item.Localidad.Nombre);
                }
            }

            if (dgvDatosDueños.RowCount > 1)
            {
                btnNuevaMascota.Enabled = true;
            }
            //btnNuevoCliente.Enabled = true;
            
        }

        private void txtNombreDueñoBuscar_TextChanged(object sender, EventArgs e)
        {
            btnNuevoCliente.Enabled = true;
            btnNuevaMascota.Enabled = true;
            dgvDatosDueños.Rows.Clear();
            dgvDatosMascotas.Rows.Clear();

            List<Dueño> listaDN = objDueño.LeerDueñoXNombre(txtNombreDueñoBuscar.Text);

            foreach (var itemDN in listaDN)
            {
                dgvDatosDueños.Rows.Add(itemDN.IDDueño, itemDN.DNI, itemDN.Nombre, itemDN.Apellido, itemDN.Domicilio, itemDN.Telefono, itemDN.Correo, itemDN.Observaciones, itemDN.Localidad.Nombre);
            }
        }

        private void txtNombreMascotaBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreMascotaBuscar.Text != "")
            {
                dgvDatosMascotas.Rows.Clear();

                List<Mascota> listaM = objMascota.LeerMascotasXNombre(txtNombreMascotaBuscar.Text);
                foreach (Mascota itemM in listaM)
                {
                    List<Tipo> listaT = objMascota.LeerTipoXID(Convert.ToInt32(itemM.IDTipo));
                    foreach (Tipo itemT in listaT)
                    {
                        string Tipo = itemT.Nombre.ToString();

                        List<Raza> listaR = objMascota.LeerRazaXID(Convert.ToInt32(itemM.IDRaza));

                        foreach (Raza itemR in listaR)
                        {
                            string Raza = itemR.Nombre.ToString();

                            dgvDatosMascotas.Rows.Add(itemM.IDMascota, itemM.Nombre, itemT.Nombre, itemR.Nombre, itemM.FechaNacimiento, itemM.FechaBaja, itemM.Motivo);
                        }
                    }
                }

                foreach (DataGridViewRow row in dgvDatosMascotas.Rows)
                {
                    for (int i = 0; i < dgvDatosMascotas.RowCount; i++)
                    {
                        if (dgvDatosMascotas.Rows[i].Cells[6].Value != null)
                        {
                            dgvDatosMascotas.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                dgvDatosMascotas.Rows.Clear();
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Tab.chkDarDeBaja.Visible = false;

            //int i = dgvDatosDueños.CurrentRow.Index;

            if(dgvDatosDueños.RowCount > 1)
            {
                int i = dgvDatosDueños.CurrentRow.Index;

                List<Dueño> listaD = objDueño.LeerDueñoXID(Convert.ToInt32(dgvDatosDueños.Rows[i].Cells[0].Value));
                foreach (Dueño itemD in listaD)
                {
                    Tab.cmbDNIDueñoConsulta.Text = itemD.DNI.ToString();

                    Tab.cmbDNIDueñoNvaMascota.Text = itemD.DNI.ToString();
                }

                Tab.txtNombreMascota.Text = "";
                Tab.cmbTipoMascota.SelectedValue = 1;
                Tab.cmbRazaMascota.SelectedValue = 1;
                Tab.dtpFechaNacMascota.Value = DateTime.Today;
                Tab.dtpFechaBajaMascota.ShowCheckBox = true;
                Tab.dtpFechaBajaMascota.Checked = false;
                Tab.txtMotivoBajaMascota.Text = "";

                Tab.btnActualizarMascota.Visible = false;

                Tab.btnGuardarNuevaMascota.Visible = true;

                Tab.lblFechaBaja.Visible = false;
                Tab.lblMotivo.Visible = false;
                Tab.txtMotivoBajaMascota.Visible = false;
                Tab.dtpFechaBajaMascota.Visible = false;


                Tab.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un dueño", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void dgvDatosDueños_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MascotaXDueño();
            //dgvDatosMascotas.Rows.Clear();

            //int i = dgvDatosDueños.CurrentRow.Index;

            //List<Mascota> listaM = objMascota.LeerMascotasXDNI(Convert.ToInt32(dgvDatosDueños.Rows[i].Cells[0].Value.ToString()));
            //foreach (Mascota itemM in listaM)
            //{
            //    List<Tipo> listaT = objMascota.LeerTipoXID(Convert.ToInt32(itemM.IDTipo));
            //    foreach (Tipo itemT in listaT)
            //    {
            //        string Tipo = itemT.Nombre.ToString();

            //        List<Raza> listaR = objMascota.LeerRazaXID(Convert.ToInt32(itemM.IDRaza));

            //        foreach (Raza itemR in listaR)
            //        {
            //            string Raza = itemR.Nombre.ToString();

            //            dgvDatosMascotas.Rows.Add(itemM.IDMascota, itemM.Nombre, itemT.Nombre, itemR.Nombre, itemM.FechaNacimiento, itemM.FechaBaja, itemM.Motivo);

            //        }
            //    }
            //}

            //foreach (DataGridViewRow row in dgvDatosMascotas.Rows)
            //{
            //    for (int ii = 0; ii < dgvDatosMascotas.RowCount; ii++)
            //    {
            //        if (dgvDatosMascotas.Rows[ii].Cells[6].Value != null)
            //        {
            //            dgvDatosMascotas.Rows[ii].DefaultCellStyle.ForeColor = Color.Red;
            //        }
            //    }
            //}
        }

        private void txtDNIBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvDatosDueños.Rows.Clear();
            dgvDatosMascotas.Rows.Clear();
        }

        private void dgvDatosMascotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tab.lblFechaBaja.Visible = false;
            Tab.lblMotivo.Visible = false;
            Tab.txtMotivoBajaMascota.Visible = false;
            Tab.dtpFechaBajaMascota.Visible = false;
            Tab.chkDarDeBaja.Visible = true;
            Tab.chkDarDeBaja.Checked = false;

            Tab.cmbDNIDueñoNvaMascota.Enabled = false;

            Tab.cmbDNIDueñoConsulta.Enabled = false;

            Tab.btnActualizarMascota.Visible = true;

            Tab.btnGuardarNuevaMascota.Visible = false;

            int i = dgvDatosMascotas.CurrentRow.Index;

            List<Consulta> listaC = objConsulta.LeerConsultaXIDMascota(Convert.ToInt32(dgvDatosMascotas.Rows[i].Cells[0].Value));
            foreach (Consulta itemC in listaC)
            {
                List<Profesional> listaP = objProfesional.LeerProfesXID(Convert.ToInt32(itemC.IDProfesional));
                foreach (Profesional itemP in listaP)
                {
                    List<DetalleConsulta> listaDC = objDetalleConsulta.LeerDetalleConsultaXIDConsulta(Convert.ToInt32(itemC.IDConsulta));
                    foreach (DetalleConsulta itemDC in listaDC)
                    {
                        List<TipoConsulta> listaTC = objTipoConsulta.LeerTipoConsultaXID(Convert.ToInt32(itemDC.IDTipoConsulta));
                        foreach (TipoConsulta itemTC in listaTC)
                        {
                            if (itemTC.Vacuna == "1")
                            {
                                Tab.dgvHistoriaClinica.Rows.Clear();
                                string diagnostico = "Dosis:" + itemDC.Dosis + " - " + "Lote Nro:" + itemDC.NumeroLote + " - " + "Fecha Vto:" + itemDC.FechaVto;
                                Tab.dgvHistoriaClinica.Rows.Add(itemC.IDConsulta, itemC.Fecha, itemP.Apellido, itemTC.Descripcion, diagnostico);
                            }
                            else
                            {
                                Tab.dgvHistoriaClinica.Rows.Clear();
                                Tab.dgvHistoriaClinica.Rows.Add(itemC.IDConsulta, itemC.Fecha, itemP.Apellido, itemDC.Diagnostico, itemDC.Tratamiento);
                            }
                        }
                    }
                }
            }

            Tab.CargarTxtMascota(Convert.ToInt32(dgvDatosMascotas.Rows[i].Cells[0].Value));
            Tab.dgvHistoriaClinica.Rows.Clear();
            Tab.tabMascota.SelectedTab = Tab.tabNuevaMascota;
            Tab.cmbDNIDueñoConsulta.SelectedIndex = -1;
            Tab.dtpFechaConsulta.Value = DateTime.Today;
            Tab.cmbNombreMascotaConsulta.SelectedIndex = -1;
            Tab.txtPesoMascotaConsulta.Text = "";
            Tab.cmbProfesionalConsulta.SelectedIndex = -1;
            Tab.txtObservacionConsulta.Text = "";
            Tab.cmbTipoConsulta.SelectedIndex = -1;
            Tab.pnlTipoConsulta.Visible = false;
        }

        public void MascotaXDueño()
        {
            dgvDatosMascotas.Rows.Clear();

            int i = dgvDatosDueños.CurrentRow.Index;

            List<Mascota> listaM = objMascota.LeerMascotasXIDDueño(Convert.ToInt32(dgvDatosDueños.Rows[i].Cells[0].Value.ToString()));
            foreach (Mascota itemM in listaM)
            {
                List<Tipo> listaT = objMascota.LeerTipoXID(Convert.ToInt32(itemM.IDTipo));
                foreach (Tipo itemT in listaT)
                {
                    string Tipo = itemT.Nombre.ToString();

                    List<Raza> listaR = objMascota.LeerRazaXID(Convert.ToInt32(itemM.IDRaza));

                    foreach (Raza itemR in listaR)
                    {
                        string Raza = itemR.Nombre.ToString();

                        dgvDatosMascotas.Rows.Add(itemM.IDMascota, itemM.Nombre, itemT.Nombre, itemR.Nombre, itemM.FechaNacimiento, itemM.FechaBaja, itemM.Motivo);

                    }
                }
            }

            foreach (DataGridViewRow row in dgvDatosMascotas.Rows)
            {
                for (int ii = 0; ii < dgvDatosMascotas.RowCount; ii++)
                {
                    if (dgvDatosMascotas.Rows[ii].Cells[6].Value != null)
                    {
                        dgvDatosMascotas.Rows[ii].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            dgvDatosMascotas.Rows.Clear();

            List<Mascota> listaM = objMascota.LeerMascotas();
            foreach (Mascota itemM in listaM)
            {
                List<Tipo> listaT = objMascota.LeerTipoXID(Convert.ToInt32(itemM.IDTipo));
                foreach (Tipo itemT in listaT)
                {
                    string Tipo = itemT.Nombre.ToString();

                    List<Raza> listaR = objMascota.LeerRazaXID(Convert.ToInt32(itemM.IDRaza));

                    foreach (Raza itemR in listaR)
                    {
                        string Raza = itemR.Nombre.ToString();

                        if (itemM.Motivo == null & itemM.FechaBaja == null)
                        {
                            dgvDatosMascotas.Rows.Add(itemM.IDMascota, itemM.Nombre, itemT.Nombre, itemR.Nombre, itemM.FechaNacimiento, itemM.FechaBaja, itemM.Motivo);                            
                        }
                    }
                }
            }
        }
    }
}
