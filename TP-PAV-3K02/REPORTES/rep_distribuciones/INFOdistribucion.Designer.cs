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
            this.TXTcuit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RV_distribuciones
            // 
            this.RV_distribuciones.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_distribuciones.Reportdistribucion.rdlc";
            this.RV_distribuciones.Location = new System.Drawing.Point(0, 43);
            this.RV_distribuciones.Name = "RV_distribuciones";
            this.RV_distribuciones.ServerReport.BearerToken = null;
            this.RV_distribuciones.Size = new System.Drawing.Size(800, 408);
            this.RV_distribuciones.TabIndex = 0;
            this.RV_distribuciones.Load += new System.EventHandler(this.RV_distribuciones_Load);
            // 
            // TXTcuit
            // 
            this.TXTcuit.Location = new System.Drawing.Point(174, 16);
            this.TXTcuit.Name = "TXTcuit";
            this.TXTcuit.Size = new System.Drawing.Size(100, 20);
            this.TXTcuit.TabIndex = 1;
            this.TXTcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarsolonumeros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CUIT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // INFOdistribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTcuit);
            this.Controls.Add(this.RV_distribuciones);
            this.Name = "INFOdistribucion";
            this.Text = "INFOdistribucion";
            this.Load += new System.EventHandler(this.INFOdistribucion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_distribuciones;
        private System.Windows.Forms.TextBox TXTcuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}