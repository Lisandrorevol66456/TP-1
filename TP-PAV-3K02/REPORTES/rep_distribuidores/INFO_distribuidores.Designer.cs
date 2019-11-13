namespace TP_PAV_3K02.REPORTES.rep_distribuidores
{
    partial class INFO_distribuidores
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
            this.RV_distribuidores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.distribuidores_DataSet = new TP_PAV_3K02.REPORTES.rep_distribuidores.distribuidores_DataSet();
            this.DistribuidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DistribuidoresTableAdapter = new TP_PAV_3K02.REPORTES.rep_distribuidores.distribuidores_DataSetTableAdapters.DistribuidoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidores_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistribuidoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RV_distribuidores
            // 
            this.RV_distribuidores.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "tabla_distribuidores";
            reportDataSource1.Value = this.DistribuidoresBindingSource;
            this.RV_distribuidores.LocalReport.DataSources.Add(reportDataSource1);
            this.RV_distribuidores.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_distribuidores.Report_distribuidores.rdlc";
            this.RV_distribuidores.Location = new System.Drawing.Point(0, 0);
            this.RV_distribuidores.Name = "RV_distribuidores";
            this.RV_distribuidores.ServerReport.BearerToken = null;
            this.RV_distribuidores.Size = new System.Drawing.Size(800, 450);
            this.RV_distribuidores.TabIndex = 0;
            // 
            // distribuidores_DataSet
            // 
            this.distribuidores_DataSet.DataSetName = "distribuidores_DataSet";
            this.distribuidores_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DistribuidoresBindingSource
            // 
            this.DistribuidoresBindingSource.DataMember = "Distribuidores";
            this.DistribuidoresBindingSource.DataSource = this.distribuidores_DataSet;
            // 
            // DistribuidoresTableAdapter
            // 
            this.DistribuidoresTableAdapter.ClearBeforeFill = true;
            // 
            // INFO_distribuidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_distribuidores);
            this.Name = "INFO_distribuidores";
            this.Text = "INFO_distribuidores";
            this.Load += new System.EventHandler(this.INFO_distribuidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distribuidores_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistribuidoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_distribuidores;
        private System.Windows.Forms.BindingSource DistribuidoresBindingSource;
        private distribuidores_DataSet distribuidores_DataSet;
        private distribuidores_DataSetTableAdapters.DistribuidoresTableAdapter DistribuidoresTableAdapter;
    }
}