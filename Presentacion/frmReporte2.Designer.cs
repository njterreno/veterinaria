namespace Presentacion
{
    partial class frmReporte2
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
            this.crvReporte2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporte2
            // 
            this.crvReporte2.ActiveViewIndex = -1;
            this.crvReporte2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporte2.Location = new System.Drawing.Point(0, 0);
            this.crvReporte2.Name = "crvReporte2";
            this.crvReporte2.Size = new System.Drawing.Size(683, 656);
            this.crvReporte2.TabIndex = 0;
            this.crvReporte2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 656);
            this.Controls.Add(this.crvReporte2);
            this.Name = "frmReporte2";
            this.Text = "Reporte 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte2;

    }
}