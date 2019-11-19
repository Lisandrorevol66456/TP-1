namespace TP_PAV_3K02.REPORTES.rep_suscripciones
{
    partial class INFO_suscripciones
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
            this.RV_suscripciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_suscripciones
            // 
            this.RV_suscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_suscripciones.Location = new System.Drawing.Point(0, 0);
            this.RV_suscripciones.Name = "RV_suscripciones";
            this.RV_suscripciones.ServerReport.BearerToken = null;
            this.RV_suscripciones.Size = new System.Drawing.Size(800, 450);
            this.RV_suscripciones.TabIndex = 0;
            // 
            // INFO_suscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_suscripciones);
            this.Name = "INFO_suscripciones";
            this.Text = "INFO_suscripciones";
            this.Load += new System.EventHandler(this.INFO_suscripciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_suscripciones;
    }
}