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

namespace TP_PAV_3K02.REPORTES.rep_suscripcion
{
    public partial class INFO_planesMasElegidos : Form
    {
        public INFO_planesMasElegidos()
        {
            InitializeComponent();
        }

        private void INFO_planesMasElegidos_Load(object sender, EventArgs e)
        {
            this.RV_planesMasElegidos.RefreshReport();
            var adapter = new PlanesMasElegidos_DataSetTableAdapters.PlanesTableAdapter();
            var d = new PlanesMasElegidos_DataSet.PlanesDataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("tabla_planesmasElegidos", (DataTable)d);
            RV_planesMasElegidos.LocalReport.DataSources.Clear();
            RV_planesMasElegidos.LocalReport.DataSources.Add(ds);
            this.RV_planesMasElegidos.RefreshReport();
        }
    }
}
