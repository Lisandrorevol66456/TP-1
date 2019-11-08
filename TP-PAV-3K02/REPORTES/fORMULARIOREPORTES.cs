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

namespace TP_PAV_3K02.REPORTES
{
    public partial class fORMULARIOREPORTES : Form
    {
        public fORMULARIOREPORTES()
        {
            InitializeComponent();
        }

        private void fORMULARIOREPORTES_Load(object sender, EventArgs e)
        {
            this.rvFORMREPOR.RefreshReport();

            var adapter = new datasetConjuntoDeDatosTableAdapters.DataTable1TableAdapter();
            var d = new datasetConjuntoDeDatos.DataTable1DataTable();
            adapter.Fill(d);

            var ds = new ReportDataSource("TABLA", (DataTable) d);
            rvFORMREPOR.LocalReport.DataSources.Clear();
            rvFORMREPOR.LocalReport.DataSources.Add(ds);

            this.rvFORMREPOR.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }
    }
}
