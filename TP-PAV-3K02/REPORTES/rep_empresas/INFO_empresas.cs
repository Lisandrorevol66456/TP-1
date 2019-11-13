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
    public partial class INFO_empresas : Form
    {
        public INFO_empresas()
        {
            InitializeComponent();
        }

        private void INFO_empresas_Load(object sender, EventArgs e)
        {
            
        this.RV_empresas.RefreshReport();
        var adapter = new Empresas_DataSetTableAdapters.EmpresasTableAdapter();
        var d = new Empresas_DataSet.EmpresasDataTable();
            
        adapter.Fill(d);
            
        var ds = new ReportDataSource("tabla_empresas", (DataTable)d);

        RV_empresas.LocalReport.DataSources.Clear();
        RV_empresas.LocalReport.DataSources.Add(ds);
        this.RV_empresas.RefreshReport();
            
            
        }
    }
}
