namespace TP_PAV_3K02.REPORTES.rep_empresas
{
    partial class INFO_empresaConMasPublicidad
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
            this.RV_empresaConMasPublicidad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmpresaConMasPublicidad_DataSet = new TP_PAV_3K02.REPORTES.rep_empresas.EmpresaConMasPublicidad_DataSet();
            this.Detalle_PublicidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Detalle_PublicidadTableAdapter = new TP_PAV_3K02.REPORTES.rep_empresas.EmpresaConMasPublicidad_DataSetTableAdapters.Detalle_PublicidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaConMasPublicidad_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_PublicidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RV_empresaConMasPublicidad
            // 
            this.RV_empresaConMasPublicidad.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Tabla_empresasConMasPublicidad";
            reportDataSource1.Value = this.Detalle_PublicidadBindingSource;
            this.RV_empresaConMasPublicidad.LocalReport.DataSources.Add(reportDataSource1);
            this.RV_empresaConMasPublicidad.LocalReport.ReportEmbeddedResource = "TP_PAV_3K02.REPORTES.rep_empresas.Report_empresaConMasPublicidad.rdlc";
            this.RV_empresaConMasPublicidad.Location = new System.Drawing.Point(0, 0);
            this.RV_empresaConMasPublicidad.Name = "RV_empresaConMasPublicidad";
            this.RV_empresaConMasPublicidad.ServerReport.BearerToken = null;
            this.RV_empresaConMasPublicidad.Size = new System.Drawing.Size(800, 450);
            this.RV_empresaConMasPublicidad.TabIndex = 0;
            // 
            // EmpresaConMasPublicidad_DataSet
            // 
            this.EmpresaConMasPublicidad_DataSet.DataSetName = "EmpresaConMasPublicidad_DataSet";
            this.EmpresaConMasPublicidad_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Detalle_PublicidadBindingSource
            // 
            this.Detalle_PublicidadBindingSource.DataMember = "Detalle_Publicidad";
            this.Detalle_PublicidadBindingSource.DataSource = this.EmpresaConMasPublicidad_DataSet;
            // 
            // Detalle_PublicidadTableAdapter
            // 
            this.Detalle_PublicidadTableAdapter.ClearBeforeFill = true;
            // 
            // INFO_empresaConMasPublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RV_empresaConMasPublicidad);
            this.Name = "INFO_empresaConMasPublicidad";
            this.Text = "Empresa Con Más Publicidad";
            this.Load += new System.EventHandler(this.INFO_empresaConMasPublicidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaConMasPublicidad_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_PublicidadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_empresaConMasPublicidad;
        private System.Windows.Forms.BindingSource Detalle_PublicidadBindingSource;
        private EmpresaConMasPublicidad_DataSet EmpresaConMasPublicidad_DataSet;
        private EmpresaConMasPublicidad_DataSetTableAdapters.Detalle_PublicidadTableAdapter Detalle_PublicidadTableAdapter;
    }
}