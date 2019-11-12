namespace TP_PAV_3K02.REPORTES.rep_distri
{
    partial class INFOdistribucion
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
            this.RV_distribuciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_distribuciones
            // 
            this.RV_distribuciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_distribuciones.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_distri.Reportdistribucion.rdlc";
            this.RV_distribuciones.Location = new System.Drawing.Point(0, 0);
            this.RV_distribuciones.Name = "RV_distribuciones";
            this.RV_distribuciones.ServerReport.BearerToken = null;
            this.RV_distribuciones.Size = new System.Drawing.Size(800, 450);
            this.RV_distribuciones.TabIndex = 0;
            this.RV_distribuciones.Load += new System.EventHandler(this.RV_distribuciones_Load);
            // 
            // INFOdistribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_distribuciones);
            this.Name = "INFOdistribucion";
            this.Text = "INFOdistribucion";
            this.Load += new System.EventHandler(this.INFOdistribucion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_distribuciones;
    }
}