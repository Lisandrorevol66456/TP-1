namespace TP_PAV_3K02.REPORTES.rep_publicidad
{
    partial class INFO_publicidadVigente
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
            this.RV_publicidades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.publicidades_DataSet = new TP_PAV_3K02.REPORTES.rep_publicidad.publicidades_DataSet();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new TP_PAV_3K02.REPORTES.rep_publicidad.publicidades_DataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.publicidades_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RV_publicidades
            // 
            this.RV_publicidades.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "tabla_publicidad_vigente";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.RV_publicidades.LocalReport.DataSources.Add(reportDataSource1);
            this.RV_publicidades.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_publicidad.Report_publicidadvigente.rdlc";
            this.RV_publicidades.Location = new System.Drawing.Point(0, 0);
            this.RV_publicidades.Name = "RV_publicidades";
            this.RV_publicidades.ServerReport.BearerToken = null;
            this.RV_publicidades.Size = new System.Drawing.Size(800, 450);
            this.RV_publicidades.TabIndex = 0;
            // 
            // publicidades_DataSet
            // 
            this.publicidades_DataSet.DataSetName = "publicidades_DataSet";
            this.publicidades_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.publicidades_DataSet;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // INFO_publicidadVigente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_publicidades);
            this.Name = "INFO_publicidadVigente";
            this.Text = "Publicidades vigentes";
            this.Load += new System.EventHandler(this.INFO_publicidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicidades_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_publicidades;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private publicidades_DataSet publicidades_DataSet;
        private publicidades_DataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}