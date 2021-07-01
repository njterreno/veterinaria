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
    public partial class frmNuevoDueño : Form
    {
        public frmNuevoDueño()
        {
            InitializeComponent();

            cmbLocalidades.DataSource = objDueño.LeerLocalidades();
            cmbLocalidades.ValueMember = "IDLocalidad";
            cmbLocalidades.DisplayMember = "Nombre";
        }

        clsDueños objDueño = new clsDueños();

        Dueño InfoDueño = new Dueño();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarNuevoDueño_Click(object sender, EventArgs e)
        {
            bool band = false;

            try
            {
                InfoDueño.Nombre = txtNombre.Text;
                InfoDueño.Apellido = txtApellido.Text;
                InfoDueño.DNI = Convert.ToInt32(txtDNI.Text);
                InfoDueño.Domicilio = txtDomicilio.Text;
                InfoDueño.Telefono = Convert.ToInt32(txtTelefono.Text);
                InfoDueño.Correo = txtCorreo.Text;
                InfoDueño.Observaciones = txtObservaciones.Text;
                InfoDueño.IDLocalidad = Convert.ToInt32(cmbLocalidades.SelectedValue);

                objDueño.Crear(InfoDueño);

                btnGuardarNuevoDueño.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL GUARDAR EL DUEÑO" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                band = true;
            }
            finally
            {
                if (band == false)
                {
                    MessageBox.Show("Los datos se han actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }

            this.Close();
        }

        public void CargarTxtDueño(int IDD)
        {
            try
            {
                InfoDueño = objDueño.LeerPorID(IDD);

                txtNombre.Text = InfoDueño.Nombre;
                txtApellido.Text = InfoDueño.Apellido;
                txtDNI.Text = InfoDueño.DNI.ToString();
                txtDomicilio.Text = InfoDueño.Domicilio;
                txtTelefono.Text = InfoDueño.Telefono.ToString();
                txtCorreo.Text = InfoDueño.Correo;
                txtObservaciones.Text = InfoDueño.Observaciones;
                cmbLocalidades.SelectedValue = Convert.ToInt32(InfoDueño.IDLocalidad);

                this.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL CARGAR LOS DATOS DEL DUEÑO" + ex.ToString());
            }

            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bool band = false;

            try
            {
                InfoDueño.Nombre = txtNombre.Text;
                InfoDueño.Apellido = txtApellido.Text;
                InfoDueño.DNI = Convert.ToInt32(txtDNI.Text);
                InfoDueño.Domicilio = txtDomicilio.Text;
                InfoDueño.Telefono = Convert.ToInt32(txtTelefono.Text);
                InfoDueño.Correo = txtCorreo.Text;
                InfoDueño.Observaciones = txtObservaciones.Text;
                InfoDueño.IDLocalidad = Convert.ToInt32(cmbLocalidades.SelectedValue);

                objDueño.Actualizar(InfoDueño);

            }
            catch (Exception ex1)
            {
                MessageBox.Show("PROBLEMA AL ACTUALIZAR EL DUEÑO" + ex1.ToString());
                band = true;
            }
            finally
            {
                if (band == false)
                {
                    MessageBox.Show("Los datos se han actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Close();
        }

        private void cmbLocalidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
