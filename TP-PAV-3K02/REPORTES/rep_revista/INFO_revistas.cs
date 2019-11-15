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
using TP_PAV_3K02.REPORTES.rep_revista;


namespace TP_PAV_3K02.REPORTES.rep_revista
{
    public partial class INFO_revistas : Form
    {
        public INFO_revistas()
        {
            InitializeComponent();
        }

        private void INFO_revistas_Load(object sender, EventArgs e)
        {
            this.RV_revistas.RefreshReport();
            
            var adapt = new Revistas_DataSetTableAdapters.DataTable1TableAdapter();
            var da = new Revistas_DataSet.DataTable1DataTable();
            adapt.Fill(da);

            var ds = new ReportDataSource("tabla_revistas", (DataTable) da);

            RV_revistas.LocalReport.DataSources.Clear();
            RV_revistas.LocalReport.DataSources.Add(ds);
            this.RV_revistas.RefreshReport();
            
        }
    }
}
