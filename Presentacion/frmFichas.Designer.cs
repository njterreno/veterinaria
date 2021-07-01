namespace Presentacion
{
    partial class frmFichas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFichas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevaMascota = new System.Windows.Forms.Button();
            this.txtNombreMascotaBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosMascotas = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMnjBuscar = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.txtNombreDueñoBuscar = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDatosDueños = new System.Windows.Forms.DataGridView();
            this.IDDueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarDueño = new System.Windows.Forms.Button();
            this.txtDNIBuscar = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnSalirBuscar = new System.Windows.Forms.Button();
            this.btnBuscarMascota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDueños)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaMascota
            // 
            this.btnNuevaMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevaMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMascota.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaMascota.Image")));
            this.btnNuevaMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaMascota.Location = new System.Drawing.Point(1061, 1);
            this.btnNuevaMascota.Name = "btnNuevaMascota";
            this.btnNuevaMascota.Size = new System.Drawing.Size(165, 67);
            this.btnNuevaMascota.TabIndex = 61;
            this.btnNuevaMascota.Text = "Nueva Mascota";
            this.btnNuevaMascota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaMascota.UseVisualStyleBackColor = true;
            this.btnNuevaMascota.Click += new System.EventHandler(this.btnNuevaMascota_Click);
            // 
            // txtNombreMascotaBuscar
            // 
            this.txtNombreMascotaBuscar.Location = new System.Drawing.Point(719, 21);
            this.txtNombreMascotaBuscar.Name = "txtNombreMascotaBuscar";
            this.txtNombreMascotaBuscar.Size = new System.Drawing.Size(144, 20);
            this.txtNombreMascotaBuscar.TabIndex = 60;
            this.txtNombreMascotaBuscar.TextChanged += new System.EventHandler(this.txtNombreMascotaBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre";
            // 
            // dgvDatosMascotas
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatosMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.dataGridViewTextBoxColumn3,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDatosMascotas.Location = new System.Drawing.Point(664, 74);
            this.dgvDatosMascotas.Name = "dgvDatosMascotas";
            this.dgvDatosMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosMascotas.Size = new System.Drawing.Size(562, 253);
            this.dgvDatosMascotas.TabIndex = 58;
            this.dgvDatosMascotas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosMascotas_CellDoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IDMascota";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Raza";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FechaNacimiento";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "FechaBaja";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Motivo";
            this.Column5.Name = "Column5";
            // 
            // lblMnjBuscar
            // 
            this.lblMnjBuscar.AutoSize = true;
            this.lblMnjBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnjBuscar.ForeColor = System.Drawing.Color.Lime;
            this.lblMnjBuscar.Location = new System.Drawing.Point(67, 330);
            this.lblMnjBuscar.Name = "lblMnjBuscar";
            this.lblMnjBuscar.Size = new System.Drawing.Size(0, 15);
            this.lblMnjBuscar.TabIndex = 57;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.Image")));
            this.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.Location = new System.Drawing.Point(424, 1);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(153, 67);
            this.btnNuevoCliente.TabIndex = 56;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // txtNombreDueñoBuscar
            // 
            this.txtNombreDueñoBuscar.Location = new System.Drawing.Point(70, 34);
            this.txtNombreDueñoBuscar.Name = "txtNombreDueñoBuscar";
            this.txtNombreDueñoBuscar.Size = new System.Drawing.Size(144, 20);
            this.txtNombreDueñoBuscar.TabIndex = 55;
            this.txtNombreDueñoBuscar.TextChanged += new System.EventHandler(this.txtNombreDueñoBuscar_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 54;
            this.lblNombre.Text = "Nombre";
            // 
            // dgvDatosDueños
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosDueños.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatosDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosDueños.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDueño,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Domicilio,
            this.Telefono,
            this.Correo,
            this.Observaciones,
            this.Localidad});
            this.dgvDatosDueños.Location = new System.Drawing.Point(15, 74);
            this.dgvDatosDueños.Name = "dgvDatosDueños";
            this.dgvDatosDueños.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosDueños.Size = new System.Drawing.Size(562, 253);
            this.dgvDatosDueños.TabIndex = 53;
            this.dgvDatosDueños.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosDueños_CellClick);
            this.dgvDatosDueños.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosDueños_CellDoubleClick);
            // 
            // IDDueño
            // 
            this.IDDueño.HeaderText = "IDDueño";
            this.IDDueño.Name = "IDDueño";
            this.IDDueño.Visible = false;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            // 
            // btnBuscarDueño
            // 
            this.btnBuscarDueño.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBuscarDueño.FlatAppearance.BorderSize = 4;
            this.btnBuscarDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDueño.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarDueño.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDueño.Image")));
            this.btnBuscarDueño.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarDueño.Location = new System.Drawing.Point(234, 2);
            this.btnBuscarDueño.Name = "btnBuscarDueño";
            this.btnBuscarDueño.Size = new System.Drawing.Size(109, 55);
            this.btnBuscarDueño.TabIndex = 52;
            this.btnBuscarDueño.Text = "Buscar";
            this.btnBuscarDueño.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarDueño.UseVisualStyleBackColor = true;
            this.btnBuscarDueño.Click += new System.EventHandler(this.btnBuscarDueño_Click);
            // 
            // txtDNIBuscar
            // 
            this.txtDNIBuscar.Location = new System.Drawing.Point(70, 6);
            this.txtDNIBuscar.Name = "txtDNIBuscar";
            this.txtDNIBuscar.Size = new System.Drawing.Size(144, 20);
            this.txtDNIBuscar.TabIndex = 51;
            this.txtDNIBuscar.TextChanged += new System.EventHandler(this.txtDNIBuscar_TextChanged);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(12, 9);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 50;
            this.lblDNI.Text = "DNI";
            // 
            // btnSalirBuscar
            // 
            this.btnSalirBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirBuscar.Image")));
            this.btnSalirBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirBuscar.Location = new System.Drawing.Point(1142, 340);
            this.btnSalirBuscar.Name = "btnSalirBuscar";
            this.btnSalirBuscar.Size = new System.Drawing.Size(99, 53);
            this.btnSalirBuscar.TabIndex = 62;
            this.btnSalirBuscar.Text = "Salir";
            this.btnSalirBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirBuscar.UseVisualStyleBackColor = true;
            this.btnSalirBuscar.Click += new System.EventHandler(this.btnSalirBuscar_Click);
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBuscarMascota.FlatAppearance.BorderSize = 4;
            this.btnBuscarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMascota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarMascota.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMascota.Image")));
            this.btnBuscarMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarMascota.Location = new System.Drawing.Point(884, 2);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(109, 55);
            this.btnBuscarMascota.TabIndex = 63;
            this.btnBuscarMascota.Text = "Buscar";
            this.btnBuscarMascota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarMascota.UseVisualStyleBackColor = true;
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // frmFichas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 405);
            this.Controls.Add(this.btnBuscarMascota);
            this.Controls.Add(this.btnSalirBuscar);
            this.Controls.Add(this.btnNuevaMascota);
            this.Controls.Add(this.txtNombreMascotaBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatosMascotas);
            this.Controls.Add(this.lblMnjBuscar);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.txtNombreDueñoBuscar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDatosDueños);
            this.Controls.Add(this.btnBuscarDueño);
            this.Controls.Add(this.txtDNIBuscar);
            this.Controls.Add(this.lblDNI);
            this.Name = "frmFichas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fichas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDueños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaMascota;
        private System.Windows.Forms.TextBox txtNombreMascotaBuscar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvDatosMascotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblMnjBuscar;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.TextBox txtNombreDueñoBuscar;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.DataGridView dgvDatosDueños;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.Button btnBuscarDueño;
        private System.Windows.Forms.TextBox txtDNIBuscar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnSalirBuscar;
        public System.Windows.Forms.Button btnBuscarMascota;
    }
}