namespace TP_PAV_3K02.REPORTES.rep_suscriptores
{
    partial class INFO_suscriptores
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
            this.RV_suscrip = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_suscrip
            // 
            this.RV_suscrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_suscrip.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_suscriptores.Reporteinforme.rdlc";
            this.RV_suscrip.Location = new System.Drawing.Point(0, 0);
            this.RV_suscrip.Name = "RV_suscrip";
            this.RV_suscrip.ServerReport.BearerToken = null;
            this.RV_suscrip.Size = new System.Drawing.Size(800, 450);
            this.RV_suscrip.TabIndex = 0;
            // 
            // INFO_suscriptores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_suscrip);
            this.Name = "INFO_suscriptores";
            this.Text = "INFO_suscriptores";
            this.Load += new System.EventHandler(this.INFO_suscriptores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_suscrip;
    }
}