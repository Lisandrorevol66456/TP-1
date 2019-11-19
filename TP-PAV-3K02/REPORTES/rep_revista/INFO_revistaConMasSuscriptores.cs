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
    public partial class INFO_revistaConMasSuscriptores : Form
    {
        public INFO_revistaConMasSuscriptores()
        {
            InitializeComponent();
        }

        private void INFO_revistaConMasSuscriptores_Load(object sender, EventArgs e)
        {

            this.RV_revistaConMasSuscriptores.RefreshReport();
            var adapter = new revistaConMasSuscriptoresDataSetTableAdapters.RevistasTableAdapter();
            var d = new revistaConMasSuscriptoresDataSet.RevistasDataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("tabla_revistaConMasSuscriptores", (DataTable)d);
            RV_revistaConMasSuscriptores.LocalReport.DataSources.Clear();
            RV_revistaConMasSuscriptores.LocalReport.DataSources.Add(ds);

            this.RV_revistaConMasSuscriptores.RefreshReport();
        }
    }
}
