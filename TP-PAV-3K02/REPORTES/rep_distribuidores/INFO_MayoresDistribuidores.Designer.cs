namespace TP_PAV_3K02.REPORTES.rep_distribuidores
{
    partial class INFO_MayoresDistribuidores
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
            this.RV_mayoresDistribuidores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_mayoresDistribuidores
            // 
            this.RV_mayoresDistribuidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_mayoresDistribuidores.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_distribuidores.Report_mayorDistribuidor.rdlc";
            this.RV_mayoresDistribuidores.Location = new System.Drawing.Point(0, 0);
            this.RV_mayoresDistribuidores.Name = "RV_mayoresDistribuidores";
            this.RV_mayoresDistribuidores.ServerReport.BearerToken = null;
            this.RV_mayoresDistribuidores.Size = new System.Drawing.Size(800, 450);
            this.RV_mayoresDistribuidores.TabIndex = 0;
            // 
            // INFO_MayoresDistribuidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_mayoresDistribuidores);
            this.Name = "INFO_MayoresDistribuidores";
            this.Text = "INFO_MayoresDistribuidores";
            this.Load += new System.EventHandler(this.INFO_MayoresDistribuidores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_mayoresDistribuidores;
    }
}