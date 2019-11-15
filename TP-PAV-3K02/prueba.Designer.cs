namespace TP_PAV_3K02
{
    partial class prueba
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
            this.rv_prueba = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_prueba
            // 
            this.rv_prueba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_prueba.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.Report_prueba.rdlc";
            this.rv_prueba.Location = new System.Drawing.Point(0, 0);
            this.rv_prueba.Name = "rv_prueba";
            this.rv_prueba.ServerReport.BearerToken = null;
            this.rv_prueba.Size = new System.Drawing.Size(800, 450);
            this.rv_prueba.TabIndex = 0;
            // 
            // prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rv_prueba);
            this.Name = "prueba";
            this.Text = "prueba";
            this.Load += new System.EventHandler(this.prueba_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_prueba;
    }
}