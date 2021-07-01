namespace Presentacion
{
    partial class frmReporte1
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
            this.crvReporte1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporte1
            // 
            this.crvReporte1.ActiveViewIndex = -1;
            this.crvReporte1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporte1.Location = new System.Drawing.Point(0, 0);
            this.crvReporte1.Name = "crvReporte1";
            this.crvReporte1.ShowGroupTreeButton = false;
            this.crvReporte1.Size = new System.Drawing.Size(683, 656);
            this.crvReporte1.TabIndex = 0;
            this.crvReporte1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 656);
            this.Controls.Add(this.crvReporte1);
            this.Name = "frmReporte1";
            this.Text = "Reporte 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte1;


    }
}