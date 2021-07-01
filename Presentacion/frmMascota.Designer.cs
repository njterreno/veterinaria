namespace Presentacion
{
    partial class frmMascota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMascota = new System.Windows.Forms.TabControl();
            this.tabNuevaMascota = new System.Windows.Forms.TabPage();
            this.dtpFechaBajaMascota = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNacMascota = new System.Windows.Forms.DateTimePicker();
            this.cmbDNIDueñoNvaMascota = new System.Windows.Forms.ComboBox();
            this.btnActualizarMascota = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarNuevaMascota = new System.Windows.Forms.Button();
            this.lblDNIDueño = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pbxFotoMascota = new System.Windows.Forms.PictureBox();
            this.cmbRazaMascota = new System.Windows.Forms.ComboBox();
            this.cmbTipoMascota = new System.Windows.Forms.ComboBox();
            this.txtMotivoBajaMascota = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblFechaBaja = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.lblRazaMascota = new System.Windows.Forms.Label();
            this.lblTipoMascota = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.tabHistoriaClinica = new System.Windows.Forms.TabPage();
            this.btnCrearReportePersonalizado = new System.Windows.Forms.Button();
            this.btnCrearReporte = new System.Windows.Forms.Button();
            this.btnSalirHistoriaClinica = new System.Windows.Forms.Button();
            this.dgvHistoriaClinica = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.cmbNombreMascotaConsulta = new System.Windows.Forms.ComboBox();
            this.cmbDNIDueñoConsulta = new System.Windows.Forms.ComboBox();
            this.btnActualizarConsulta = new System.Windows.Forms.Button();
            this.btnSalirConsulta = new System.Windows.Forms.Button();
            this.btnGuardarConsulta = new System.Windows.Forms.Button();
            this.pnlTipoConsulta = new System.Windows.Forms.Panel();
            this.dtpFechaVto = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVto = new System.Windows.Forms.Label();
            this.txtNroLoteOTratamiento = new System.Windows.Forms.TextBox();
            this.txtDosisODiagnostico = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblDosis = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.cmbProfesionalConsulta = new System.Windows.Forms.ComboBox();
            this.cmbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtObservacionConsulta = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtPesoMascotaConsulta = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkDarDeBaja = new System.Windows.Forms.CheckBox();
            this.tabMascota.SuspendLayout();
            this.tabNuevaMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoMascota)).BeginInit();
            this.tabHistoriaClinica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaClinica)).BeginInit();
            this.tabConsulta.SuspendLayout();
            this.pnlTipoConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMascota
            // 
            this.tabMascota.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMascota.Controls.Add(this.tabNuevaMascota);
            this.tabMascota.Controls.Add(this.tabHistoriaClinica);
            this.tabMascota.Controls.Add(this.tabConsulta);
            this.tabMascota.Location = new System.Drawing.Point(2, 12);
            this.tabMascota.Name = "tabMascota";
            this.tabMascota.SelectedIndex = 0;
            this.tabMascota.Size = new System.Drawing.Size(483, 533);
            this.tabMascota.TabIndex = 0;
            this.tabMascota.Click += new System.EventHandler(this.tabMascota_Click);
            // 
            // tabNuevaMascota
            // 
            this.tabNuevaMascota.Controls.Add(this.chkDarDeBaja);
            this.tabNuevaMascota.Controls.Add(this.dtpFechaBajaMascota);
            this.tabNuevaMascota.Controls.Add(this.dtpFechaNacMascota);
            this.tabNuevaMascota.Controls.Add(this.cmbDNIDueñoNvaMascota);
            this.tabNuevaMascota.Controls.Add(this.btnActualizarMascota);
            this.tabNuevaMascota.Controls.Add(this.btnSalir);
            this.tabNuevaMascota.Controls.Add(this.btnGuardarNuevaMascota);
            this.tabNuevaMascota.Controls.Add(this.lblDNIDueño);
            this.tabNuevaMascota.Controls.Add(this.btnBuscar);
            this.tabNuevaMascota.Controls.Add(this.pbxFotoMascota);
            this.tabNuevaMascota.Controls.Add(this.cmbRazaMascota);
            this.tabNuevaMascota.Controls.Add(this.cmbTipoMascota);
            this.tabNuevaMascota.Controls.Add(this.txtMotivoBajaMascota);
            this.tabNuevaMascota.Controls.Add(this.lblMotivo);
            this.tabNuevaMascota.Controls.Add(this.lblFechaBaja);
            this.tabNuevaMascota.Controls.Add(this.lblFechaNac);
            this.tabNuevaMascota.Controls.Add(this.txtNombreMascota);
            this.tabNuevaMascota.Controls.Add(this.lblRazaMascota);
            this.tabNuevaMascota.Controls.Add(this.lblTipoMascota);
            this.tabNuevaMascota.Controls.Add(this.lblNombreMascota);
            this.tabNuevaMascota.Location = new System.Drawing.Point(4, 25);
            this.tabNuevaMascota.Name = "tabNuevaMascota";
            this.tabNuevaMascota.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevaMascota.Size = new System.Drawing.Size(475, 504);
            this.tabNuevaMascota.TabIndex = 0;
            this.tabNuevaMascota.Text = "Nueva Mascota";
            this.tabNuevaMascota.UseVisualStyleBackColor = true;
            this.tabNuevaMascota.Click += new System.EventHandler(this.tabNuevaMascota_Click);
            // 
            // dtpFechaBajaMascota
            // 
            this.dtpFechaBajaMascota.Location = new System.Drawing.Point(234, 225);
            this.dtpFechaBajaMascota.Name = "dtpFechaBajaMascota";
            this.dtpFechaBajaMascota.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaBajaMascota.TabIndex = 69;
            // 
            // dtpFechaNacMascota
            // 
            this.dtpFechaNacMascota.Location = new System.Drawing.Point(234, 170);
            this.dtpFechaNacMascota.Name = "dtpFechaNacMascota";
            this.dtpFechaNacMascota.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacMascota.TabIndex = 68;
            // 
            // cmbDNIDueñoNvaMascota
            // 
            this.cmbDNIDueñoNvaMascota.FormattingEnabled = true;
            this.cmbDNIDueñoNvaMascota.Location = new System.Drawing.Point(234, 14);
            this.cmbDNIDueñoNvaMascota.Name = "cmbDNIDueñoNvaMascota";
            this.cmbDNIDueñoNvaMascota.Size = new System.Drawing.Size(200, 21);
            this.cmbDNIDueñoNvaMascota.TabIndex = 67;
            // 
            // btnActualizarMascota
            // 
            this.btnActualizarMascota.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnActualizarMascota.FlatAppearance.BorderSize = 3;
            this.btnActualizarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMascota.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnActualizarMascota.Location = new System.Drawing.Point(274, 454);
            this.btnActualizarMascota.Name = "btnActualizarMascota";
            this.btnActualizarMascota.Size = new System.Drawing.Size(92, 44);
            this.btnActualizarMascota.TabIndex = 66;
            this.btnActualizarMascota.Text = "Actualizar";
            this.btnActualizarMascota.UseVisualStyleBackColor = true;
            this.btnActualizarMascota.Click += new System.EventHandler(this.btnActualizarMascota_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(378, 454);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 44);
            this.btnSalir.TabIndex = 65;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardarNuevaMascota
            // 
            this.btnGuardarNuevaMascota.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGuardarNuevaMascota.FlatAppearance.BorderSize = 3;
            this.btnGuardarNuevaMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevaMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevaMascota.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardarNuevaMascota.Location = new System.Drawing.Point(256, 454);
            this.btnGuardarNuevaMascota.Name = "btnGuardarNuevaMascota";
            this.btnGuardarNuevaMascota.Size = new System.Drawing.Size(92, 44);
            this.btnGuardarNuevaMascota.TabIndex = 64;
            this.btnGuardarNuevaMascota.Text = "Guardar";
            this.btnGuardarNuevaMascota.UseVisualStyleBackColor = true;
            this.btnGuardarNuevaMascota.Click += new System.EventHandler(this.btnGuardarNuevaMascota_Click);
            // 
            // lblDNIDueño
            // 
            this.lblDNIDueño.AutoSize = true;
            this.lblDNIDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIDueño.Location = new System.Drawing.Point(83, 14);
            this.lblDNIDueño.Name = "lblDNIDueño";
            this.lblDNIDueño.Size = new System.Drawing.Size(77, 17);
            this.lblDNIDueño.TabIndex = 62;
            this.lblDNIDueño.Text = "DNI Dueño";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(83, 411);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 61;
            this.btnBuscar.Text = "Buscar...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pbxFotoMascota
            // 
            this.pbxFotoMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFotoMascota.Location = new System.Drawing.Point(83, 303);
            this.pbxFotoMascota.Name = "pbxFotoMascota";
            this.pbxFotoMascota.Size = new System.Drawing.Size(157, 102);
            this.pbxFotoMascota.TabIndex = 60;
            this.pbxFotoMascota.TabStop = false;
            // 
            // cmbRazaMascota
            // 
            this.cmbRazaMascota.FormattingEnabled = true;
            this.cmbRazaMascota.Location = new System.Drawing.Point(234, 130);
            this.cmbRazaMascota.Name = "cmbRazaMascota";
            this.cmbRazaMascota.Size = new System.Drawing.Size(200, 21);
            this.cmbRazaMascota.TabIndex = 59;
            this.cmbRazaMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRazaMascota_KeyPress);
            // 
            // cmbTipoMascota
            // 
            this.cmbTipoMascota.FormattingEnabled = true;
            this.cmbTipoMascota.Location = new System.Drawing.Point(234, 91);
            this.cmbTipoMascota.Name = "cmbTipoMascota";
            this.cmbTipoMascota.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoMascota.TabIndex = 58;
            this.cmbTipoMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoMascota_KeyPress);
            // 
            // txtMotivoBajaMascota
            // 
            this.txtMotivoBajaMascota.Location = new System.Drawing.Point(234, 267);
            this.txtMotivoBajaMascota.Name = "txtMotivoBajaMascota";
            this.txtMotivoBajaMascota.Size = new System.Drawing.Size(200, 20);
            this.txtMotivoBajaMascota.TabIndex = 57;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(80, 268);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(103, 17);
            this.lblMotivo.TabIndex = 55;
            this.lblMotivo.Text = "Motivo De Baja";
            // 
            // lblFechaBaja
            // 
            this.lblFechaBaja.AutoSize = true;
            this.lblFechaBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaBaja.Location = new System.Drawing.Point(83, 229);
            this.lblFechaBaja.Name = "lblFechaBaja";
            this.lblFechaBaja.Size = new System.Drawing.Size(101, 17);
            this.lblFechaBaja.TabIndex = 54;
            this.lblFechaBaja.Text = "Fecha De Baja";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(83, 170);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(143, 17);
            this.lblFechaNac.TabIndex = 52;
            this.lblFechaNac.Text = "Fecha De Nacimiento";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(234, 52);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(200, 20);
            this.txtNombreMascota.TabIndex = 49;
            // 
            // lblRazaMascota
            // 
            this.lblRazaMascota.AutoSize = true;
            this.lblRazaMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaMascota.Location = new System.Drawing.Point(83, 131);
            this.lblRazaMascota.Name = "lblRazaMascota";
            this.lblRazaMascota.Size = new System.Drawing.Size(41, 17);
            this.lblRazaMascota.TabIndex = 48;
            this.lblRazaMascota.Text = "Raza";
            // 
            // lblTipoMascota
            // 
            this.lblTipoMascota.AutoSize = true;
            this.lblTipoMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMascota.Location = new System.Drawing.Point(83, 92);
            this.lblTipoMascota.Name = "lblTipoMascota";
            this.lblTipoMascota.Size = new System.Drawing.Size(36, 17);
            this.lblTipoMascota.TabIndex = 47;
            this.lblTipoMascota.Text = "Tipo";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.Location = new System.Drawing.Point(83, 53);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(58, 17);
            this.lblNombreMascota.TabIndex = 46;
            this.lblNombreMascota.Text = "Nombre";
            // 
            // tabHistoriaClinica
            // 
            this.tabHistoriaClinica.Controls.Add(this.btnCrearReportePersonalizado);
            this.tabHistoriaClinica.Controls.Add(this.btnCrearReporte);
            this.tabHistoriaClinica.Controls.Add(this.btnSalirHistoriaClinica);
            this.tabHistoriaClinica.Controls.Add(this.dgvHistoriaClinica);
            this.tabHistoriaClinica.Location = new System.Drawing.Point(4, 25);
            this.tabHistoriaClinica.Name = "tabHistoriaClinica";
            this.tabHistoriaClinica.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistoriaClinica.Size = new System.Drawing.Size(475, 504);
            this.tabHistoriaClinica.TabIndex = 1;
            this.tabHistoriaClinica.Text = "Historia Clinica";
            this.tabHistoriaClinica.UseVisualStyleBackColor = true;
            // 
            // btnCrearReportePersonalizado
            // 
            this.btnCrearReportePersonalizado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCrearReportePersonalizado.FlatAppearance.BorderSize = 3;
            this.btnCrearReportePersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReportePersonalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReportePersonalizado.ForeColor = System.Drawing.Color.Black;
            this.btnCrearReportePersonalizado.Location = new System.Drawing.Point(120, 454);
            this.btnCrearReportePersonalizado.Name = "btnCrearReportePersonalizado";
            this.btnCrearReportePersonalizado.Size = new System.Drawing.Size(106, 44);
            this.btnCrearReportePersonalizado.TabIndex = 63;
            this.btnCrearReportePersonalizado.Text = "Crear Reporte Personalizado";
            this.btnCrearReportePersonalizado.UseVisualStyleBackColor = true;
            this.btnCrearReportePersonalizado.Click += new System.EventHandler(this.btnCrearReportePersonalizado_Click);
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCrearReporte.FlatAppearance.BorderSize = 3;
            this.btnCrearReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReporte.ForeColor = System.Drawing.Color.Black;
            this.btnCrearReporte.Location = new System.Drawing.Point(249, 454);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Size = new System.Drawing.Size(106, 44);
            this.btnCrearReporte.TabIndex = 62;
            this.btnCrearReporte.Text = "Crear Reporte Historia Clinica";
            this.btnCrearReporte.UseVisualStyleBackColor = true;
            this.btnCrearReporte.Click += new System.EventHandler(this.btnCrearReporte_Click);
            // 
            // btnSalirHistoriaClinica
            // 
            this.btnSalirHistoriaClinica.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalirHistoriaClinica.FlatAppearance.BorderSize = 3;
            this.btnSalirHistoriaClinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirHistoriaClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirHistoriaClinica.ForeColor = System.Drawing.Color.Red;
            this.btnSalirHistoriaClinica.Location = new System.Drawing.Point(377, 454);
            this.btnSalirHistoriaClinica.Name = "btnSalirHistoriaClinica";
            this.btnSalirHistoriaClinica.Size = new System.Drawing.Size(92, 44);
            this.btnSalirHistoriaClinica.TabIndex = 61;
            this.btnSalirHistoriaClinica.Text = "Salir";
            this.btnSalirHistoriaClinica.UseVisualStyleBackColor = true;
            this.btnSalirHistoriaClinica.Click += new System.EventHandler(this.btnSalirHistoriaClinica_Click);
            // 
            // dgvHistoriaClinica
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoriaClinica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistoriaClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriaClinica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Fecha,
            this.Profesional,
            this.Diagnostico,
            this.Tratamiento});
            this.dgvHistoriaClinica.Location = new System.Drawing.Point(6, 6);
            this.dgvHistoriaClinica.Name = "dgvHistoriaClinica";
            this.dgvHistoriaClinica.Size = new System.Drawing.Size(464, 421);
            this.dgvHistoriaClinica.TabIndex = 0;
            this.dgvHistoriaClinica.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistoriaClinica_CellDoubleClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "IDConsulta";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Profesional
            // 
            this.Profesional.HeaderText = "Profesional";
            this.Profesional.Name = "Profesional";
            // 
            // Diagnostico
            // 
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.btnCancelar);
            this.tabConsulta.Controls.Add(this.dtpFechaConsulta);
            this.tabConsulta.Controls.Add(this.cmbNombreMascotaConsulta);
            this.tabConsulta.Controls.Add(this.cmbDNIDueñoConsulta);
            this.tabConsulta.Controls.Add(this.btnActualizarConsulta);
            this.tabConsulta.Controls.Add(this.btnSalirConsulta);
            this.tabConsulta.Controls.Add(this.btnGuardarConsulta);
            this.tabConsulta.Controls.Add(this.pnlTipoConsulta);
            this.tabConsulta.Controls.Add(this.cmbProfesionalConsulta);
            this.tabConsulta.Controls.Add(this.cmbTipoConsulta);
            this.tabConsulta.Controls.Add(this.lblTipo);
            this.tabConsulta.Controls.Add(this.txtObservacionConsulta);
            this.tabConsulta.Controls.Add(this.lblObservacion);
            this.tabConsulta.Controls.Add(this.lblDNI);
            this.tabConsulta.Controls.Add(this.txtPesoMascotaConsulta);
            this.tabConsulta.Controls.Add(this.lblPeso);
            this.tabConsulta.Controls.Add(this.lblMascota);
            this.tabConsulta.Controls.Add(this.lblProfesional);
            this.tabConsulta.Controls.Add(this.lblFecha);
            this.tabConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(475, 504);
            this.tabConsulta.TabIndex = 2;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.Location = new System.Drawing.Point(237, 49);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaConsulta.TabIndex = 64;
            // 
            // cmbNombreMascotaConsulta
            // 
            this.cmbNombreMascotaConsulta.FormattingEnabled = true;
            this.cmbNombreMascotaConsulta.Location = new System.Drawing.Point(236, 88);
            this.cmbNombreMascotaConsulta.Name = "cmbNombreMascotaConsulta";
            this.cmbNombreMascotaConsulta.Size = new System.Drawing.Size(201, 21);
            this.cmbNombreMascotaConsulta.TabIndex = 63;
            this.cmbNombreMascotaConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNombreMascotaConsulta_KeyPress);
            // 
            // cmbDNIDueñoConsulta
            // 
            this.cmbDNIDueñoConsulta.FormattingEnabled = true;
            this.cmbDNIDueñoConsulta.Location = new System.Drawing.Point(236, 11);
            this.cmbDNIDueñoConsulta.Name = "cmbDNIDueñoConsulta";
            this.cmbDNIDueñoConsulta.Size = new System.Drawing.Size(201, 21);
            this.cmbDNIDueñoConsulta.TabIndex = 62;
            // 
            // btnActualizarConsulta
            // 
            this.btnActualizarConsulta.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnActualizarConsulta.FlatAppearance.BorderSize = 3;
            this.btnActualizarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarConsulta.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnActualizarConsulta.Location = new System.Drawing.Point(281, 457);
            this.btnActualizarConsulta.Name = "btnActualizarConsulta";
            this.btnActualizarConsulta.Size = new System.Drawing.Size(92, 44);
            this.btnActualizarConsulta.TabIndex = 61;
            this.btnActualizarConsulta.Text = "Actualizar";
            this.btnActualizarConsulta.UseVisualStyleBackColor = true;
            this.btnActualizarConsulta.Click += new System.EventHandler(this.btnActualizarConsulta_Click);
            // 
            // btnSalirConsulta
            // 
            this.btnSalirConsulta.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalirConsulta.FlatAppearance.BorderSize = 3;
            this.btnSalirConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsulta.ForeColor = System.Drawing.Color.Red;
            this.btnSalirConsulta.Location = new System.Drawing.Point(379, 457);
            this.btnSalirConsulta.Name = "btnSalirConsulta";
            this.btnSalirConsulta.Size = new System.Drawing.Size(92, 44);
            this.btnSalirConsulta.TabIndex = 60;
            this.btnSalirConsulta.Text = "Salir";
            this.btnSalirConsulta.UseVisualStyleBackColor = true;
            this.btnSalirConsulta.Click += new System.EventHandler(this.btnSalirConsulta_Click);
            // 
            // btnGuardarConsulta
            // 
            this.btnGuardarConsulta.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGuardarConsulta.FlatAppearance.BorderSize = 3;
            this.btnGuardarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConsulta.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardarConsulta.Location = new System.Drawing.Point(257, 457);
            this.btnGuardarConsulta.Name = "btnGuardarConsulta";
            this.btnGuardarConsulta.Size = new System.Drawing.Size(92, 44);
            this.btnGuardarConsulta.TabIndex = 59;
            this.btnGuardarConsulta.Text = "Guardar";
            this.btnGuardarConsulta.UseVisualStyleBackColor = true;
            this.btnGuardarConsulta.Click += new System.EventHandler(this.btnGuardarConsulta_Click);
            // 
            // pnlTipoConsulta
            // 
            this.pnlTipoConsulta.Controls.Add(this.dtpFechaVto);
            this.pnlTipoConsulta.Controls.Add(this.lblFechaVto);
            this.pnlTipoConsulta.Controls.Add(this.txtNroLoteOTratamiento);
            this.pnlTipoConsulta.Controls.Add(this.txtDosisODiagnostico);
            this.pnlTipoConsulta.Controls.Add(this.lblLote);
            this.pnlTipoConsulta.Controls.Add(this.lblDosis);
            this.pnlTipoConsulta.Controls.Add(this.lblDiagnostico);
            this.pnlTipoConsulta.Controls.Add(this.lblTratamiento);
            this.pnlTipoConsulta.Location = new System.Drawing.Point(87, 283);
            this.pnlTipoConsulta.Name = "pnlTipoConsulta";
            this.pnlTipoConsulta.Size = new System.Drawing.Size(357, 117);
            this.pnlTipoConsulta.TabIndex = 57;
            // 
            // dtpFechaVto
            // 
            this.dtpFechaVto.Location = new System.Drawing.Point(149, 90);
            this.dtpFechaVto.Name = "dtpFechaVto";
            this.dtpFechaVto.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVto.TabIndex = 22;
            // 
            // lblFechaVto
            // 
            this.lblFechaVto.AutoSize = true;
            this.lblFechaVto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVto.Location = new System.Drawing.Point(-3, 90);
            this.lblFechaVto.Name = "lblFechaVto";
            this.lblFechaVto.Size = new System.Drawing.Size(94, 17);
            this.lblFechaVto.TabIndex = 21;
            this.lblFechaVto.Text = "Fecha De Vto";
            // 
            // txtNroLoteOTratamiento
            // 
            this.txtNroLoteOTratamiento.Location = new System.Drawing.Point(149, 50);
            this.txtNroLoteOTratamiento.Name = "txtNroLoteOTratamiento";
            this.txtNroLoteOTratamiento.Size = new System.Drawing.Size(201, 20);
            this.txtNroLoteOTratamiento.TabIndex = 19;
            // 
            // txtDosisODiagnostico
            // 
            this.txtDosisODiagnostico.Location = new System.Drawing.Point(149, 10);
            this.txtDosisODiagnostico.Name = "txtDosisODiagnostico";
            this.txtDosisODiagnostico.Size = new System.Drawing.Size(201, 20);
            this.txtDosisODiagnostico.TabIndex = 18;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(-3, 53);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(89, 17);
            this.lblLote.TabIndex = 16;
            this.lblLote.Text = "Nro. De Lote";
            // 
            // lblDosis
            // 
            this.lblDosis.AutoSize = true;
            this.lblDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDosis.Location = new System.Drawing.Point(-3, 10);
            this.lblDosis.Name = "lblDosis";
            this.lblDosis.Size = new System.Drawing.Size(43, 17);
            this.lblDosis.TabIndex = 17;
            this.lblDosis.Text = "Dosis";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(-3, 10);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(82, 17);
            this.lblDiagnostico.TabIndex = 15;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.Location = new System.Drawing.Point(-3, 50);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(84, 17);
            this.lblTratamiento.TabIndex = 16;
            this.lblTratamiento.Text = "Tratamiento";
            // 
            // cmbProfesionalConsulta
            // 
            this.cmbProfesionalConsulta.FormattingEnabled = true;
            this.cmbProfesionalConsulta.Location = new System.Drawing.Point(236, 168);
            this.cmbProfesionalConsulta.Name = "cmbProfesionalConsulta";
            this.cmbProfesionalConsulta.Size = new System.Drawing.Size(201, 21);
            this.cmbProfesionalConsulta.TabIndex = 56;
            this.cmbProfesionalConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProfesionalConsulta_KeyPress);
            // 
            // cmbTipoConsulta
            // 
            this.cmbTipoConsulta.FormattingEnabled = true;
            this.cmbTipoConsulta.Location = new System.Drawing.Point(236, 249);
            this.cmbTipoConsulta.Name = "cmbTipoConsulta";
            this.cmbTipoConsulta.Size = new System.Drawing.Size(201, 21);
            this.cmbTipoConsulta.TabIndex = 54;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(84, 250);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(117, 17);
            this.lblTipo.TabIndex = 53;
            this.lblTipo.Text = "Tipo De Consulta";
            // 
            // txtObservacionConsulta
            // 
            this.txtObservacionConsulta.Location = new System.Drawing.Point(236, 209);
            this.txtObservacionConsulta.Name = "txtObservacionConsulta";
            this.txtObservacionConsulta.Size = new System.Drawing.Size(201, 20);
            this.txtObservacionConsulta.TabIndex = 52;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(84, 210);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(88, 17);
            this.lblObservacion.TabIndex = 51;
            this.lblObservacion.Text = "Observacion";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(84, 12);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(77, 17);
            this.lblDNI.TabIndex = 50;
            this.lblDNI.Text = "DNI Dueño";
            // 
            // txtPesoMascotaConsulta
            // 
            this.txtPesoMascotaConsulta.Location = new System.Drawing.Point(236, 128);
            this.txtPesoMascotaConsulta.Name = "txtPesoMascotaConsulta";
            this.txtPesoMascotaConsulta.Size = new System.Drawing.Size(201, 20);
            this.txtPesoMascotaConsulta.TabIndex = 48;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(84, 129);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 17);
            this.lblPeso.TabIndex = 46;
            this.lblPeso.Text = "Peso";
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascota.Location = new System.Drawing.Point(84, 89);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(61, 17);
            this.lblMascota.TabIndex = 45;
            this.lblMascota.Text = "Mascota";
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(84, 169);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(79, 17);
            this.lblProfesional.TabIndex = 44;
            this.lblProfesional.Text = "Profesional";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(84, 50);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 43;
            this.lblFecha.Text = "Fecha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(134, 457);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 44);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkDarDeBaja
            // 
            this.chkDarDeBaja.AutoSize = true;
            this.chkDarDeBaja.Location = new System.Drawing.Point(86, 200);
            this.chkDarDeBaja.Name = "chkDarDeBaja";
            this.chkDarDeBaja.Size = new System.Drawing.Size(82, 17);
            this.chkDarDeBaja.TabIndex = 70;
            this.chkDarDeBaja.Text = "Dar de Baja";
            this.chkDarDeBaja.UseVisualStyleBackColor = true;
            this.chkDarDeBaja.CheckedChanged += new System.EventHandler(this.chkDarDeBaja_CheckedChanged);
            // 
            // frmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 545);
            this.Controls.Add(this.tabMascota);
            this.Name = "frmMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascotas";
            this.tabMascota.ResumeLayout(false);
            this.tabNuevaMascota.ResumeLayout(false);
            this.tabNuevaMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoMascota)).EndInit();
            this.tabHistoriaClinica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaClinica)).EndInit();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            this.pnlTipoConsulta.ResumeLayout(false);
            this.pnlTipoConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbxFotoMascota;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblRazaMascota;
        private System.Windows.Forms.Label lblTipoMascota;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Label lblDNIDueño;
        public System.Windows.Forms.Button btnActualizarMascota;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnGuardarNuevaMascota;
        public System.Windows.Forms.TabControl tabMascota;
        public System.Windows.Forms.TabPage tabNuevaMascota;
        public System.Windows.Forms.TabPage tabHistoriaClinica;
        public System.Windows.Forms.ComboBox cmbRazaMascota;
        public System.Windows.Forms.ComboBox cmbTipoMascota;
        public System.Windows.Forms.TextBox txtMotivoBajaMascota;
        public System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Button btnActualizarConsulta;
        private System.Windows.Forms.Button btnSalirConsulta;
        public System.Windows.Forms.Button btnGuardarConsulta;
        public System.Windows.Forms.DataGridView dgvHistoriaClinica;
        private System.Windows.Forms.Button btnSalirHistoriaClinica;
        public System.Windows.Forms.Panel pnlTipoConsulta;
        public System.Windows.Forms.TextBox txtNroLoteOTratamiento;
        public System.Windows.Forms.TextBox txtDosisODiagnostico;
        public System.Windows.Forms.Label lblLote;
        public System.Windows.Forms.Label lblDosis;
        public System.Windows.Forms.Label lblDiagnostico;
        public System.Windows.Forms.Label lblTratamiento;
        public System.Windows.Forms.ComboBox cmbProfesionalConsulta;
        public System.Windows.Forms.ComboBox cmbTipoConsulta;
        public System.Windows.Forms.TextBox txtObservacionConsulta;
        public System.Windows.Forms.TextBox txtPesoMascotaConsulta;
        public System.Windows.Forms.ComboBox cmbNombreMascotaConsulta;
        public System.Windows.Forms.ComboBox cmbDNIDueñoConsulta;
        public System.Windows.Forms.Label lblFechaVto;
        private System.Windows.Forms.Button btnCrearReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.Button btnCrearReportePersonalizado;
        private System.Windows.Forms.DateTimePicker dtpFechaVto;
        public System.Windows.Forms.DateTimePicker dtpFechaBajaMascota;
        public System.Windows.Forms.DateTimePicker dtpFechaNacMascota;
        public System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        public System.Windows.Forms.ComboBox cmbDNIDueñoNvaMascota;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lblMotivo;
        public System.Windows.Forms.Label lblFechaBaja;
        public System.Windows.Forms.CheckBox chkDarDeBaja;
    }
}