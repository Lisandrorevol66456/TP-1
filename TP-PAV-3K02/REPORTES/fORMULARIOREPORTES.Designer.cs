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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvFORMREPOR = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datasetConjuntoDeDatos = new TP_PAV_3K02.REPORTES.datasetConjuntoDeDatos();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new TP_PAV_3K02.REPORTES.datasetConjuntoDeDatosTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datasetConjuntoDeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvFORMREPOR
            // 
            this.rvFORMREPOR.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TABLA";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rvFORMREPOR.LocalReport.DataSources.Add(reportDataSource1);
            this.rvFORMREPOR.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.Reporteinforme.rdlc";
            this.rvFORMREPOR.Location = new System.Drawing.Point(0, 0);
            this.rvFORMREPOR.Name = "rvFORMREPOR";
            this.rvFORMREPOR.ServerReport.BearerToken = null;
            this.rvFORMREPOR.Size = new System.Drawing.Size(800, 450);
            this.rvFORMREPOR.TabIndex = 0;
            // 
            // datasetConjuntoDeDatos
            // 
            this.datasetConjuntoDeDatos.DataSetName = "datasetConjuntoDeDatos";
            this.datasetConjuntoDeDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.datasetConjuntoDeDatos;
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
            ((System.ComponentModel.ISupportInitialize)(this.datasetConjuntoDeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFORMREPOR;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private datasetConjuntoDeDatos datasetConjuntoDeDatos;
        private datasetConjuntoDeDatosTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}