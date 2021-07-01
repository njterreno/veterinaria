namespace Presentacion
{
    partial class frmCrearReportePersonalizado
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
            this.cmbDueño = new System.Windows.Forms.ComboBox();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.cmbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.cmbMascota = new System.Windows.Forms.ComboBox();
            this.btnMostraReporte = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.lblTipoConsulta = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblDueño = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ckbFechasTodas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbDueño
            // 
            this.cmbDueño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDueño.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDueño.FormattingEnabled = true;
            this.cmbDueño.Location = new System.Drawing.Point(128, 124);
            this.cmbDueño.Name = "cmbDueño";
            this.cmbDueño.Size = new System.Drawing.Size(238, 21);
            this.cmbDueño.TabIndex = 43;
            this.cmbDueño.SelectedIndexChanged += new System.EventHandler(this.cmbDueño_SelectedIndexChanged);
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Items.AddRange(new object[] {
            "",
            "Resumido",
            "Detallado"});
            this.cmbTipoReporte.Location = new System.Drawing.Point(128, 244);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(238, 21);
            this.cmbTipoReporte.TabIndex = 42;
            // 
            // cmbTipoConsulta
            // 
            this.cmbTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoConsulta.FormattingEnabled = true;
            this.cmbTipoConsulta.Location = new System.Drawing.Point(128, 214);
            this.cmbTipoConsulta.Name = "cmbTipoConsulta";
            this.cmbTipoConsulta.Size = new System.Drawing.Size(238, 21);
            this.cmbTipoConsulta.TabIndex = 41;
            // 
            // cmbMascota
            // 
            this.cmbMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMascota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMascota.FormattingEnabled = true;
            this.cmbMascota.Location = new System.Drawing.Point(128, 184);
            this.cmbMascota.Name = "cmbMascota";
            this.cmbMascota.Size = new System.Drawing.Size(238, 21);
            this.cmbMascota.TabIndex = 40;
            // 
            // btnMostraReporte
            // 
            this.btnMostraReporte.FlatAppearance.BorderSize = 3;
            this.btnMostraReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostraReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraReporte.Location = new System.Drawing.Point(166, 277);
            this.btnMostraReporte.Name = "btnMostraReporte";
            this.btnMostraReporte.Size = new System.Drawing.Size(97, 43);
            this.btnMostraReporte.TabIndex = 39;
            this.btnMostraReporte.Text = "MOSTRAR REPORTE";
            this.btnMostraReporte.UseVisualStyleBackColor = true;
            this.btnMostraReporte.Click += new System.EventHandler(this.btnMostraReporte_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(166, 60);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 38;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(166, 33);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 37;
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(21, 246);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(88, 16);
            this.lblTipoReporte.TabIndex = 36;
            this.lblTipoReporte.Text = "Tipo Reporte";
            // 
            // lblTipoConsulta
            // 
            this.lblTipoConsulta.AutoSize = true;
            this.lblTipoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConsulta.Location = new System.Drawing.Point(21, 214);
            this.lblTipoConsulta.Name = "lblTipoConsulta";
            this.lblTipoConsulta.Size = new System.Drawing.Size(91, 16);
            this.lblTipoConsulta.TabIndex = 35;
            this.lblTipoConsulta.Text = "Tipo Consulta";
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascota.Location = new System.Drawing.Point(21, 182);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(60, 16);
            this.lblMascota.TabIndex = 34;
            this.lblMascota.Text = "Mascota";
            // 
            // lblDueño
            // 
            this.lblDueño.AutoSize = true;
            this.lblDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueño.Location = new System.Drawing.Point(21, 124);
            this.lblDueño.Name = "lblDueño";
            this.lblDueño.Size = new System.Drawing.Size(48, 16);
            this.lblDueño.TabIndex = 33;
            this.lblDueño.Text = "Dueño";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(125, 66);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 32;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(125, 39);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 31;
            this.lblFechaDesde.Text = "Desde";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(23, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 16);
            this.lblFecha.TabIndex = 30;
            this.lblFecha.Text = "Fecha";
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(21, 154);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(76, 16);
            this.lblProfesional.TabIndex = 44;
            this.lblProfesional.Text = "Profesional";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesional.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(128, 154);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(238, 21);
            this.cmbProfesional.TabIndex = 45;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(274, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 44);
            this.btnSalir.TabIndex = 66;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ckbFechasTodas
            // 
            this.ckbFechasTodas.AutoSize = true;
            this.ckbFechasTodas.Location = new System.Drawing.Point(128, 86);
            this.ckbFechasTodas.Name = "ckbFechasTodas";
            this.ckbFechasTodas.Size = new System.Drawing.Size(56, 17);
            this.ckbFechasTodas.TabIndex = 67;
            this.ckbFechasTodas.Text = "Todas";
            this.ckbFechasTodas.UseVisualStyleBackColor = true;
            this.ckbFechasTodas.CheckedChanged += new System.EventHandler(this.ckbFechasTodas_CheckedChanged);
            // 
            // frmCrearReportePersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 332);
            this.Controls.Add(this.ckbFechasTodas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.cmbDueño);
            this.Controls.Add(this.cmbTipoReporte);
            this.Controls.Add(this.cmbTipoConsulta);
            this.Controls.Add(this.cmbMascota);
            this.Controls.Add(this.btnMostraReporte);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblTipoReporte);
            this.Controls.Add(this.lblTipoConsulta);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.lblDueño);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmCrearReportePersonalizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Reporte Personalizado";
            this.Load += new System.EventHandler(this.frmCrearReportePersonalizado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDueño;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.ComboBox cmbTipoConsulta;
        private System.Windows.Forms.ComboBox cmbMascota;
        private System.Windows.Forms.Button btnMostraReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Label lblTipoConsulta;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblDueño;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox ckbFechasTodas;
    }
}