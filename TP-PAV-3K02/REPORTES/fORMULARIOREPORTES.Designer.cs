namespace TP_PAV_3K02.REPORTES
{
    partial class fORMULARIOREPORTES
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetConjuntoDeDatos = new TP_PAV_3K02.REPORTES.datasetConjuntoDeDatos();
            this.rvFORMREPOR = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new TP_PAV_3K02.REPORTES.datasetConjuntoDeDatosTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetConjuntoDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.datasetConjuntoDeDatos;
            // 
            // datasetConjuntoDeDatos
            // 
            this.datasetConjuntoDeDatos.DataSetName = "datasetConjuntoDeDatos";
            this.datasetConjuntoDeDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvFORMREPOR
            // 
            this.rvFORMREPOR.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "TABLA";
            reportDataSource3.Value = this.DataTable1BindingSource;
            this.rvFORMREPOR.LocalReport.DataSources.Add(reportDataSource3);
            this.rvFORMREPOR.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.Reporteinforme.rdlc";
            this.rvFORMREPOR.Location = new System.Drawing.Point(0, 0);
            this.rvFORMREPOR.Name = "rvFORMREPOR";
            this.rvFORMREPOR.ServerReport.BearerToken = null;
            this.rvFORMREPOR.Size = new System.Drawing.Size(800, 450);
            this.rvFORMREPOR.TabIndex = 0;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // fORMULARIOREPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvFORMREPOR);
            this.Name = "fORMULARIOREPORTES";
            this.Text = "fORMULARIOREPORTES";
            this.Load += new System.EventHandler(this.fORMULARIOREPORTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetConjuntoDeDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFORMREPOR;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private datasetConjuntoDeDatos datasetConjuntoDeDatos;
        private datasetConjuntoDeDatosTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}