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

namespace TP_PAV_3K02.REPORTES.rep_distribuidores
{
    public partial class INFO_distribuidores : Form
    {
        public INFO_distribuidores()
        {
            InitializeComponent();
        }

        private void INFO_distribuidores_Load(object sender, EventArgs e)
        {
            
            this.RV_distribuidores.RefreshReport();
            var adapter = new distribuidores_DataSetTableAdapters.DistribuidoresTableAdapter();
            var d = new distribuidores_DataSet.DistribuidoresDataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("tabla_distribuidores", (DataTable)d);
            RV_distribuidores.LocalReport.DataSources.Clear();
            RV_distribuidores.LocalReport.DataSources.Add(ds);
            this.RV_distribuidores.RefreshReport();


        }
    }
}
