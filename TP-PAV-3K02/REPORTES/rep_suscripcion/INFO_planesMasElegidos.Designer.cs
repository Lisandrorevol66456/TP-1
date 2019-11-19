namespace TP_PAV_3K02.REPORTES.rep_suscripcion
{
    partial class INFO_planesMasElegidos
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
            this.RV_planesMasElegidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_planesMasElegidos
            // 
            this.RV_planesMasElegidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_planesMasElegidos.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_suscripcion.Report_planesMasElegidos.rdlc";
            this.RV_planesMasElegidos.Location = new System.Drawing.Point(0, 0);
            this.RV_planesMasElegidos.Name = "RV_planesMasElegidos";
            this.RV_planesMasElegidos.ServerReport.BearerToken = null;
            this.RV_planesMasElegidos.Size = new System.Drawing.Size(686, 450);
            this.RV_planesMasElegidos.TabIndex = 0;
            // 
            // INFO_planesMasElegidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.RV_planesMasElegidos);
            this.Name = "INFO_planesMasElegidos";
            this.Text = "INFO_planesMasElegidos";
            this.Load += new System.EventHandler(this.INFO_planesMasElegidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_planesMasElegidos;
    }
}