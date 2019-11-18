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

namespace TP_PAV_3K02.REPORTES.rep_revista
{
    public partial class INFO_revistasMasVendidas : Form
    {
        public INFO_revistasMasVendidas()
        {
            InitializeComponent();
        }

        private void INFO_revistasMasVendidas_Load(object sender, EventArgs e)
        {

            this.RV_revistasMasVendidas.RefreshReport();
            var adapter = new RevistasMasVendidasDataSetTableAdapters.RevistasTableAdapter();
            var d = new RevistasMasVendidasDataSet.RevistasDataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("tabla_revistaMasVendida", (DataTable)d);

            RV_revistasMasVendidas.LocalReport.DataSources.Clear();
            RV_revistasMasVendidas.LocalReport.DataSources.Add(ds);
            this.RV_revistasMasVendidas.RefreshReport();
        }
    }
}
