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
    public partial class INFO_MayoresDistribuidores : Form
    {
        public INFO_MayoresDistribuidores()
        {
            InitializeComponent();
        }

        private void INFO_MayoresDistribuidores_Load(object sender, EventArgs e)
        {
            this.RV_mayoresDistribuidores.RefreshReport();
            var adapter = new MayoresDistribuidores_DataSetTableAdapters.DistribucionesTableAdapter();
            var d = new MayoresDistribuidores_DataSet.DistribucionesDataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("tabla_mayorDistribuidor", (DataTable)d);
            RV_mayoresDistribuidores.LocalReport.DataSources.Clear();
            RV_mayoresDistribuidores.LocalReport.DataSources.Add(ds);
            this.RV_mayoresDistribuidores.RefreshReport();
        }
    }
}
