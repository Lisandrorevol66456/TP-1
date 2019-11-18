using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K02.REPORTES.rep_empresas
{
    public partial class INFO_empresaConMasPublicidad : Form
    {
        public INFO_empresaConMasPublicidad()
        {
            InitializeComponent();
        }

        private void INFO_empresaConMasPublicidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'EmpresaConMasPublicidad_DataSet.Detalle_Publicidad' Puede moverla o quitarla según sea necesario.
            this.Detalle_PublicidadTableAdapter.Fill(this.EmpresaConMasPublicidad_DataSet.Detalle_Publicidad);
            this.RV_empresaConMasPublicidad.RefreshReport();
            var adapter = new EmpresaConMasPublicidad_DataSetTableAdapters.Detalle_PublicidadTableAdapter();
            var d = new EmpresaConMasPublicidad_DataSet.Detalle_PublicidadDataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("Tabla_empresasConMasPublicidad", (DataTable)d);

            RV_empresaConMasPublicidad.LocalReport.DataSources.Clear();
            RV_empresaConMasPublicidad.LocalReport.DataSources.Add(ds);
            this.RV_empresaConMasPublicidad.RefreshReport();
        }
    }
}
