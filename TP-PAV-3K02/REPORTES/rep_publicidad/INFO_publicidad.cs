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

namespace TP_PAV_3K02.REPORTES.rep_publicidad
{
    public partial class INFO_publicidadVigente : Form
    {
        public INFO_publicidadVigente()
        {
            InitializeComponent();
        }

        private void INFO_publicidad_Load(object sender, EventArgs e)
        {
            this.RV_publicidades.RefreshReport();
            var adapter = new publicidades_DataSetTableAdapters.DataTable1TableAdapter();
            var d = new publicidades_DataSet.DataTable1DataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("tabla_publicidad_vigente", (DataTable)d);
            RV_publicidades.LocalReport.DataSources.Clear();
            RV_publicidades.LocalReport.DataSources.Add(ds);


            this.RV_publicidades.RefreshReport();
        }
    }
}
