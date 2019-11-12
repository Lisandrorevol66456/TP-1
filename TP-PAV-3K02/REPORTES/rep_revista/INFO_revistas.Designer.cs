namespace TP_PAV_3K02.REPORTES.rep_revista
{
    partial class INFO_revistas
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
            this.RV_revistas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_revistas
            // 
            this.RV_revistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_revistas.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_revista.Report_revistas.rdlc";
            this.RV_revistas.Location = new System.Drawing.Point(0, 0);
            this.RV_revistas.Name = "RV_revistas";
            this.RV_revistas.ServerReport.BearerToken = null;
            this.RV_revistas.Size = new System.Drawing.Size(800, 450);
            this.RV_revistas.TabIndex = 0;
            // 
            // INFO_revistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_revistas);
            this.Name = "INFO_revistas";
            this.Text = "INFO_revistas";
            this.Load += new System.EventHandler(this.INFO_revistas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_revistas;
    }
}