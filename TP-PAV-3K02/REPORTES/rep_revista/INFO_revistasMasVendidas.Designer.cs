namespace TP_PAV_3K02.REPORTES.rep_revista
{
    partial class INFO_revistasMasVendidas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RV_revistasMasVendidas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RevistasMasVendidasDataSet = new TP_PAV_3K02.REPORTES.rep_revista.RevistasMasVendidasDataSet();
            this.RevistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RevistasTableAdapter = new TP_PAV_3K02.REPORTES.rep_revista.RevistasMasVendidasDataSetTableAdapters.RevistasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RevistasMasVendidasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevistasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RV_revistasMasVendidas
            // 
            this.RV_revistasMasVendidas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "tabla_revistaMasVendida";
            reportDataSource1.Value = this.RevistasBindingSource;
            this.RV_revistasMasVendidas.LocalReport.DataSources.Add(reportDataSource1);
            this.RV_revistasMasVendidas.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_revista.Report_revistaMasVendida.rdlc";
            this.RV_revistasMasVendidas.Location = new System.Drawing.Point(0, 0);
            this.RV_revistasMasVendidas.Name = "RV_revistasMasVendidas";
            this.RV_revistasMasVendidas.ServerReport.BearerToken = null;
            this.RV_revistasMasVendidas.Size = new System.Drawing.Size(800, 450);
            this.RV_revistasMasVendidas.TabIndex = 0;
            // 
            // RevistasMasVendidasDataSet
            // 
            this.RevistasMasVendidasDataSet.DataSetName = "RevistasMasVendidasDataSet";
            this.RevistasMasVendidasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RevistasBindingSource
            // 
            this.RevistasBindingSource.DataMember = "Revistas";
            this.RevistasBindingSource.DataSource = this.RevistasMasVendidasDataSet;
            // 
            // RevistasTableAdapter
            // 
            this.RevistasTableAdapter.ClearBeforeFill = true;
            // 
            // INFO_revistasMasVendidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_revistasMasVendidas);
            this.Name = "INFO_revistasMasVendidas";
            this.Text = "INFO_revistasMasVendidas";
            this.Load += new System.EventHandler(this.INFO_revistasMasVendidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RevistasMasVendidasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevistasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_revistasMasVendidas;
        private System.Windows.Forms.BindingSource RevistasBindingSource;
        private RevistasMasVendidasDataSet RevistasMasVendidasDataSet;
        private RevistasMasVendidasDataSetTableAdapters.RevistasTableAdapter RevistasTableAdapter;
    }
}