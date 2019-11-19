namespace TP_PAV_3K02.REPORTES.rep_revista
{
    partial class INFO_revistaConMasSuscriptores
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
            this.RV_revistaConMasSuscriptores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_revistaConMasSuscriptores
            // 
            this.RV_revistaConMasSuscriptores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_revistaConMasSuscriptores.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_revista.Report_revistaConMasSuscriptores.rdlc";
            this.RV_revistaConMasSuscriptores.Location = new System.Drawing.Point(0, 0);
            this.RV_revistaConMasSuscriptores.Name = "RV_revistaConMasSuscriptores";
            this.RV_revistaConMasSuscriptores.ServerReport.BearerToken = null;
            this.RV_revistaConMasSuscriptores.Size = new System.Drawing.Size(800, 450);
            this.RV_revistaConMasSuscriptores.TabIndex = 0;
            // 
            // INFO_revistaConMasSuscriptores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_revistaConMasSuscriptores);
            this.Name = "INFO_revistaConMasSuscriptores";
            this.Text = "INFO_revistaConMasSuscriptores";
            this.Load += new System.EventHandler(this.INFO_revistaConMasSuscriptores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_revistaConMasSuscriptores;
    }
}