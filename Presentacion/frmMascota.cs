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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using Datos;


namespace Presentacion
{
    public partial class frmMascota : Form
    {
        clsMascotas objMascota = new clsMascotas();

        clsDueños objDueño = new clsDueños();

        clsProfesional objProfes = new clsProfesional();

        clsTipoConsulta objTipoConsulta = new clsTipoConsulta();

        clsConsulta objConsulta = new clsConsulta();

        clsDetalleConsulta objDetalleConsulta = new clsDetalleConsulta();

        Mascota InfoMascota = new Mascota();

        Dueño InfoDueño = new Dueño();

        Consulta InfoConsulta = new Consulta();

        DetalleConsulta InfoDetalleConsulta = new DetalleConsulta();


        public frmMascota()
        {
            InitializeComponent();

            dtpFechaConsulta.Enabled = false;
            dtpFechaConsulta.Value = DateTime.Today;
            dtpFechaNacMascota.MaxDate = DateTime.Today;
            dtpFechaBajaMascota.MaxDate = DateTime.Today;
            dtpFechaVto.MinDate = DateTime.Today;

            pnlTipoConsulta.Hide();

            cmbTipoMascota.DataSource = objMascota.LeerTipos();
            cmbTipoMascota.ValueMember = "IDTipo";
            cmbTipoMascota.DisplayMember = "Nombre";

            cmbRazaMascota.DataSource = objMascota.LeerRazas(Convert.ToInt32(cmbTipoMascota.SelectedValue));
            cmbRazaMascota.ValueMember = "IDRaza";
            cmbRazaMascota.DisplayMember = "Nombre";

            cmbTipoMascota.SelectedValueChanged += cmbTipoMascota_SelectedValueChanged;

            cmbProfesionalConsulta.DataSource = objProfes.LeerProfesionales();
            cmbProfesionalConsulta.ValueMember = "IDProfesional";
            cmbProfesionalConsulta.DisplayMember = "Apellido";

            cmbTipoConsulta.DataSource = objTipoConsulta.LeerTiposConsulta();
            cmbTipoConsulta.ValueMember = "IDTipoConsulta";
            cmbTipoConsulta.DisplayMember = "Descripcion";

            cmbTipoConsulta.SelectedValueChanged += cmbTipoConsulta_SelectedValueChanged;

            LlenarComboDueños(cmbDNIDueñoConsulta);
            LlenarComboDueños(cmbDNIDueñoNvaMascota);

            cmbDNIDueñoConsulta.SelectedValueChanged += cmbDNIDueñoConsulta_SelectedValueChanged;
        }

        void cmbTipoConsulta_SelectedValueChanged(object sender, EventArgs e)
        {
            List<TipoConsulta> listaTC = objTipoConsulta.LeerTipoConsultaXNombre(cmbTipoConsulta.Text);
            foreach (var i in listaTC)
            {
                if (i.Vacuna == "1")
                {
                    pnlTipoConsulta.Show();
                    lblDiagnostico.Hide();
                    lblTratamiento.Hide();
                    lblDosis.Show();
                    lblLote.Show();
                    lblFechaVto.Show();
                    dtpFechaVto.Show();
                }
                else
                {
                    pnlTipoConsulta.Show();
                    lblDiagnostico.Show();
                    lblTratamiento.Show();
                    lblDosis.Hide();
                    lblLote.Hide();
                    lblFechaVto.Hide();
                    dtpFechaVto.Hide();
                }
            }
        }

        void cmbDNIDueñoConsulta_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbNombreMascotaConsulta.DataSource = objMascota.LeerMascotasXIDDueño(Convert.ToInt32(cmbDNIDueñoConsulta.SelectedValue));
            cmbNombreMascotaConsulta.ValueMember = "IDMascota";
            cmbNombreMascotaConsulta.DisplayMember = "Nombre";
        }

        void cmbTipoMascota_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbRazaMascota.DataSource = objMascota.LeerRazas(Convert.ToInt32(cmbTipoMascota.SelectedValue));
            cmbRazaMascota.ValueMember = "IDRaza";
            cmbRazaMascota.DisplayMember = "Nombre";
        }

        public void LlenarComboDueños(ComboBox cmb)
        {
            cmb.DataSource = objDueño.LeerDueños();
            cmb.ValueMember = "IDDueño";
            cmb.DisplayMember = "DNI";
            cmb.SelectedIndex = -1;

            cmb.AutoCompleteCustomSource = CargarDueños();
            cmb.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public AutoCompleteStringCollection CargarDueños()
        {
            List<Dueño> dueños = objDueño.LeerDueños();
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            foreach (Dueño itemD in dueños)
            {
                datos.Add(itemD.DNI.ToString());
            }

            return datos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de imagen (*.png)|*.jpg|All files (*.*)|*.*";

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                String Dir = BuscarImagen.FileName;
                Bitmap Picture = new Bitmap(Dir);
                pbxFotoMascota.Image = (Image)Picture;
                pbxFotoMascota.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void tabNuevaMascota_Click(object sender, EventArgs e)
        {
            btnActualizarMascota.Visible = false;

            btnGuardarNuevaMascota.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarNuevaMascota_Click(object sender, EventArgs e)
        {
            bool band = false;
            try
            {
                InfoMascota.IDDueño = Convert.ToInt32(cmbDNIDueñoNvaMascota.SelectedValue);

                InfoMascota.Nombre = txtNombreMascota.Text;

                InfoMascota.IDTipo = Convert.ToInt32(cmbTipoMascota.SelectedValue);

                InfoMascota.IDRaza = Convert.ToInt32(cmbRazaMascota.SelectedValue);

                InfoMascota.FechaNacimiento = dtpFechaNacMascota.Value;

                InfoMascota.FechaBaja = null;                

                if (txtMotivoBajaMascota.Text == "")
                {
                    InfoMascota.Motivo = null;
                }
                else
                {
                    InfoMascota.Motivo = txtMotivoBajaMascota.Text;
                }
                

                if (pbxFotoMascota.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pbxFotoMascota.Image.Save(ms, ImageFormat.Png);
                    InfoMascota.Foto = ms.ToArray();
                }

                objMascota.CrearMascota(InfoMascota);                
            }
            catch (Exception ex2)
            {
                MessageBox.Show("PROBLEMA AL GUARDAR LA MASCOTA" + ex2.ToString());
                band = true;
            }
            finally
            {
                if (band == false)
                {
                    MessageBox.Show("Los datos se han guardado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            Program.ActualizarDgvMascotas();
          
            this.Close();
        }

        private void btnActualizarMascota_Click(object sender, EventArgs e)
        {
            bool band = false;
            try
            {
                InfoMascota.IDDueño = Convert.ToInt32(cmbDNIDueñoNvaMascota.SelectedValue);

                InfoMascota.Nombre = txtNombreMascota.Text;

                InfoMascota.IDTipo = Convert.ToInt32(cmbTipoMascota.SelectedValue);

                InfoMascota.IDRaza = Convert.ToInt32(cmbRazaMascota.SelectedValue);

                InfoMascota.FechaNacimiento = dtpFechaNacMascota.Value;


                if (dtpFechaBajaMascota.Checked == false)
                    InfoMascota.FechaBaja = null;
                else
                    InfoMascota.FechaBaja = dtpFechaBajaMascota.Value;


                if (txtMotivoBajaMascota.Text == "")
                    InfoMascota.Motivo = null;
                else
                    InfoMascota.Motivo = txtMotivoBajaMascota.Text;


                if (pbxFotoMascota.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pbxFotoMascota.Image.Save(ms, ImageFormat.Png);
                    InfoMascota.Foto = ms.ToArray();
                }

                objMascota.ActualizarDatosMascota(InfoMascota);

                Metodo Metodo = new Metodo();

                Metodo.MascotaXDueño2();

            }
            catch (Exception ex2)
            {
                MessageBox.Show("PROBLEMA AL ACTUALIZAR LOS DATOS DE LA MASCOTA" + ex2.ToString());
                band = true;
            }
            finally
            {
                if (band == false)
                    MessageBox.Show("Los datos se han actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        public void CargarTxtMascota(int IDM)
        {
            try
            {
                InfoMascota = objMascota.LeerMascotasXID(IDM);

                List<Dueño> listaD = objDueño.LeerDueñoXID(Convert.ToInt32(InfoMascota.IDDueño));
                foreach (Dueño itemD in listaD)
                {
                    cmbDNIDueñoConsulta.Text = itemD.DNI.ToString();

                    cmbDNIDueñoNvaMascota.Text = itemD.DNI.ToString();                  
                }
                
                txtNombreMascota.Text = InfoMascota.Nombre;
                cmbTipoMascota.SelectedValue = InfoMascota.IDTipo;
                cmbRazaMascota.SelectedValue = InfoMascota.IDRaza;
                dtpFechaNacMascota.Value = Convert.ToDateTime(InfoMascota.FechaNacimiento);

                if (InfoMascota.FechaBaja == null & InfoMascota.Motivo == null)
                {
                    dtpFechaBajaMascota.ShowCheckBox = true;
                    dtpFechaBajaMascota.Checked = false;
                    txtMotivoBajaMascota.Text = "";
                }
                else
                {
                    dtpFechaBajaMascota.Value = Convert.ToDateTime(InfoMascota.FechaBaja);
                    txtMotivoBajaMascota.Text = InfoMascota.Motivo;
                }

                if (InfoMascota.Foto != null)
                {
                    MemoryStream ms = new MemoryStream(InfoMascota.Foto);
                    pbxFotoMascota.Image = Image.FromStream(ms);
                    pbxFotoMascota.SizeMode = PictureBoxSizeMode.Zoom;
                }

                this.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL CARGAR LOS DATOS DE LA MASCOTA" + ex.ToString());
            }
        }

        public class Metodo : frmFichas
        {
            clsMascotas objMascota = new clsMascotas();

            public void MascotaXDueño2()
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
        }

        private void btnSalirConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dgvHistoriaClinica_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarConsulta.Visible = true;

            btnGuardarConsulta.Visible = false;

            int i = dgvHistoriaClinica.CurrentRow.Index;

            CargarTxtConsulta(Convert.ToInt32(dgvHistoriaClinica.Rows[i].Cells[0].Value));
        }

        private void CargarTxtConsulta(int IDC)
        {
            try
            {
                InfoConsulta = objConsulta.LeerConsultaXID(IDC);

                dtpFechaConsulta.Value = Convert.ToDateTime(InfoConsulta.Fecha);
                txtPesoMascotaConsulta.Text = InfoConsulta.Peso.ToString();
                txtObservacionConsulta.Text = InfoConsulta.Observación;

                List<Mascota> listaM = objMascota.LeerMascotaXID(Convert.ToInt32(InfoConsulta.IDMascota));
                foreach (Mascota itemM in listaM)
                {
                    cmbNombreMascotaConsulta.Text = itemM.Nombre.ToString();                    

                    List<Profesional> listaP = objProfes.LeerProfesXID(Convert.ToInt32(InfoConsulta.IDProfesional));
                    foreach (Profesional itemP in listaP)
                    {
                        cmbProfesionalConsulta.Text = itemP.Apellido;
                    }

                    List<Dueño> listaD = objDueño.LeerDueñoXID(Convert.ToInt32(itemM.IDDueño));
                    foreach (Dueño itemD in listaD)
                    {
                        cmbDNIDueñoConsulta.Text = itemD.DNI.ToString();
                    }
                }

                List<DetalleConsulta> listaDC = objDetalleConsulta.LeerDetalleConsultaXIDConsulta(Convert.ToInt32(InfoConsulta.IDConsulta));
                foreach (DetalleConsulta itemDC in listaDC)
                {
                    List<TipoConsulta> listaTC = objTipoConsulta.LeerTipoConsultaXID(Convert.ToInt32(itemDC.IDTipoConsulta));
                    foreach (TipoConsulta itemTC in listaTC)
                    {
                        cmbTipoConsulta.Text = itemTC.Descripcion;

                        if (itemTC.Vacuna == "1")
                        {
                            txtDosisODiagnostico.Text = itemDC.Dosis;
                            txtNroLoteOTratamiento.Text = itemDC.NumeroLote.ToString();
                            dtpFechaVto.Value = Convert.ToDateTime(itemDC.FechaVto);
                            pnlTipoConsulta.Show();
                            lblDiagnostico.Hide();
                            lblTratamiento.Hide();
                            lblDosis.Show();
                            lblLote.Show();
                            lblFechaVto.Show();
                            dtpFechaVto.Show();
                        }
                        else
                        {
                            txtDosisODiagnostico.Text = itemDC.Diagnostico;
                            txtNroLoteOTratamiento.Text = itemDC.Tratamiento;
                            pnlTipoConsulta.Show();
                            lblDiagnostico.Show();
                            lblTratamiento.Show();
                            lblDosis.Hide();
                            lblLote.Hide();
                            lblFechaVto.Hide();
                            dtpFechaVto.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL CARGAR LOS DATOS DE LA CONSULTA" + ex.ToString());
            }

            tabMascota.SelectedTab = tabConsulta;
        }

        private void tabMascota_Click(object sender, EventArgs e)
        {
            btnActualizarConsulta.Visible = false;

            btnGuardarConsulta.Visible = true;
        }

        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {
            bool band = false;
            try
            {
                InfoConsulta.Fecha = dtpFechaConsulta.Value;
                InfoConsulta.Observación = txtObservacionConsulta.Text;

                List<Profesional> listaP = objProfes.LeerProfesXApellido(cmbProfesionalConsulta.Text);
                foreach (Profesional itemP in listaP)
                {
                    InfoConsulta.IDProfesional = itemP.IDProfesional;
                }

                List<Mascota> listaM = objMascota.LeerMascotaXNombre(cmbNombreMascotaConsulta.Text);
                foreach (Mascota itemM in listaM)
                {
                    InfoConsulta.IDMascota = itemM.IDMascota;
                }
                
                InfoConsulta.Peso = txtPesoMascotaConsulta.Text;

                List<TipoConsulta> listaTC = objTipoConsulta.LeerTipoConsultaXNombre(cmbTipoConsulta.Text);
                foreach (TipoConsulta itemTC in listaTC)
                {
                    if (itemTC.Vacuna == "1")
                    {
                        InfoDetalleConsulta.Dosis = txtDosisODiagnostico.Text;
                        InfoDetalleConsulta.NumeroLote = Convert.ToInt32(txtNroLoteOTratamiento.Text);
                        InfoDetalleConsulta.FechaVto = dtpFechaVto.Value;
                    }
                    else
                    {
                        InfoDetalleConsulta.Diagnostico = txtDosisODiagnostico.Text;
                        InfoDetalleConsulta.Tratamiento = txtNroLoteOTratamiento.Text;
                    }
                }

                InfoDetalleConsulta.IDTipoConsulta = Convert.ToInt32(cmbTipoConsulta.SelectedValue);

                objConsulta.CrearConsulta(InfoConsulta);
                List<Consulta> listaC = objConsulta.LeerConsultas();
                foreach (Consulta itemC in listaC)
                {
                    List<Consulta> listaUC = objConsulta.LeerUltimaConsulta(listaC.Count());

                    foreach (Consulta itemUC in listaUC)
                    {
                        InfoDetalleConsulta.IDConsulta = itemUC.IDConsulta;
                    }
                }
                
               
                objDetalleConsulta.CrearDetalleConsulta(InfoDetalleConsulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL GUARDAR LA CONSULTA" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                band = true;
            }
            finally
            {
                if (band == false)
                {
                    MessageBox.Show("Los datos se han guardado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDNIDueñoConsulta.Text = "";
                    cmbNombreMascotaConsulta.Text = "";
                    cmbProfesionalConsulta.Text = "";
                    cmbTipoConsulta.Text = "";
                    dtpFechaConsulta.Value = DateTime.Today;
                    txtPesoMascotaConsulta.Text = "";
                    txtObservacionConsulta.Text = "";
                    txtDosisODiagnostico.Text = "";
                    txtNroLoteOTratamiento.Text = "";
                    dtpFechaVto.MaxDate = DateTime.Today;
                }
            }

            tabHistoriaClinica.Show();
        }

        private void cmbTipoMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbRazaMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbNombreMascotaConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbProfesionalConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSalirHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarConsulta_Click(object sender, EventArgs e)
        {
            bool band = false;
            try
            {
                InfoConsulta.Fecha = dtpFechaConsulta.Value;
                InfoConsulta.Observación = txtObservacionConsulta.Text;

                List<Profesional> listaP = objProfes.LeerProfesXApellido(cmbProfesionalConsulta.Text);
                foreach (Profesional itemP in listaP)
                {
                    InfoConsulta.IDProfesional = itemP.IDProfesional;
                }

                List<Mascota> listaM = objMascota.LeerMascotaXNombre(cmbNombreMascotaConsulta.Text);
                foreach (Mascota itemM in listaM)
                {
                    InfoConsulta.IDMascota = itemM.IDMascota;
                }

                InfoConsulta.Peso = txtPesoMascotaConsulta.Text;

                List<TipoConsulta> listaTC = objTipoConsulta.LeerTipoConsultaXNombre(cmbTipoConsulta.Text);
                foreach (TipoConsulta itemTC in listaTC)
                {
                    if (itemTC.Vacuna == "1")
                    {
                        InfoDetalleConsulta.Dosis = txtDosisODiagnostico.Text;
                        InfoDetalleConsulta.NumeroLote = Convert.ToInt32(txtNroLoteOTratamiento.Text);
                        InfoDetalleConsulta.FechaVto = dtpFechaVto.Value;
                    }
                    else
                    {
                        InfoDetalleConsulta.Diagnostico = txtDosisODiagnostico.Text;
                        InfoDetalleConsulta.Tratamiento = txtNroLoteOTratamiento.Text;
                    }
                }

                InfoDetalleConsulta.IDTipoConsulta = Convert.ToInt32(cmbTipoConsulta.SelectedValue);

                objConsulta.ActualizarConsulta(InfoConsulta);

                List<Consulta> listaC = objConsulta.LeerConsultas();
                foreach (Consulta itemC in listaC)
                {
                    List<Consulta> listaUC = objConsulta.LeerUltimaConsulta(listaC.Count());

                    foreach (Consulta itemUC in listaUC)
                    {
                        InfoDetalleConsulta.IDConsulta = itemUC.IDConsulta;
                    }
                }


                objDetalleConsulta.ActualizarDetalleConsulta(InfoDetalleConsulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL ACTUALIZAR LA CONSULTA" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                band = true;
            }
            finally
            {
                if (band == false)
                {
                    MessageBox.Show("Los datos se han actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDNIDueñoConsulta.Text = "";
                    cmbNombreMascotaConsulta.Text = "";
                    cmbProfesionalConsulta.Text = "";
                    cmbTipoConsulta.Text = "";
                    dtpFechaConsulta.Text = "";
                    txtPesoMascotaConsulta.Text = "";
                    txtObservacionConsulta.Text = "";
                    txtDosisODiagnostico.Text = "";
                    txtNroLoteOTratamiento.Text = "";
                    dtpFechaVto.Text = "";
                    
                }
            }

            tabHistoriaClinica.Show();
        }

        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
            DSHistoriaClinica DS = new DSHistoriaClinica();

            try
            {
                foreach (DataGridViewRow g in this.dgvHistoriaClinica.Rows)
                {
                    DSHistoriaClinica.HistoriaClinicaRow r = DS.HistoriaClinica.NewHistoriaClinicaRow();
                    r.Fecha = Convert.ToString(g.Cells["Fecha"].Value);
                    r.Profesional = Convert.ToString(g.Cells["Profesional"].Value);
                    r.Diagnostico = Convert.ToString(g.Cells["Diagnostico"].Value);
                    r.Tratamiento = Convert.ToString(g.Cells["Tratamiento"].Value);
                    
                    DS.HistoriaClinica.AddHistoriaClinicaRow(r);
                }
                
                frmReporte1 Reporte = new frmReporte1(DS);
                DSHistoriaClinica datos = DS;
                Reporte.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL REALIZAR EL REPORTE" + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void txtFechaConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCrearReportePersonalizado_Click(object sender, EventArgs e)
        {
            frmCrearReportePersonalizado ReportePersonalizado = new frmCrearReportePersonalizado();
            ReportePersonalizado.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtpFechaConsulta.Value = DateTime.Today;
            cmbNombreMascotaConsulta.Text = "";
            txtPesoMascotaConsulta.Text = "";
            cmbProfesionalConsulta.Text = "";
            txtObservacionConsulta.Text = "";
            cmbTipoConsulta.Text = "";
            txtDosisODiagnostico.Text = "";
            txtNroLoteOTratamiento.Text = "";
            dtpFechaVto.Value = DateTime.Today;
        }

        private void chkDarDeBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarDeBaja.Checked)
            {
                lblFechaBaja.Visible = true;
                lblMotivo.Visible = true;
                txtMotivoBajaMascota.Visible = true;
                dtpFechaBajaMascota.Visible = true;
            }
            else
            {
                lblFechaBaja.Visible = false;
                lblMotivo.Visible = false;
                txtMotivoBajaMascota.Visible = false;
                dtpFechaBajaMascota.Visible = false;

            }
        }      
    }
}
