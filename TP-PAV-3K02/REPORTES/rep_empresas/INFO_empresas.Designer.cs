namespace TP_PAV_3K02.REPORTES.rep_empresas
{
    partial class INFO_empresas
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
            this.RV_empresas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_empresas
            // 
            this.RV_empresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_empresas.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_empresas.Report_Empresa.rdlc";
            this.RV_empresas.Location = new System.Drawing.Point(0, 0);
            this.RV_empresas.Name = "RV_empresas";
            this.RV_empresas.ServerReport.BearerToken = null;
            this.RV_empresas.Size = new System.Drawing.Size(800, 450);
            this.RV_empresas.TabIndex = 0;
            // 
            // INFO_empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_empresas);
            this.Name = "INFO_empresas";
            this.Text = "INFO_empresas";
            this.Load += new System.EventHandler(this.INFO_empresas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_empresas;
    }
}