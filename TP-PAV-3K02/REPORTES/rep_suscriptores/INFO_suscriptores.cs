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

namespace TP_PAV_3K02.REPORTES.rep_suscriptores
{
    public partial class INFO_suscriptores : Form
    {
        public INFO_suscriptores()
        {
            InitializeComponent();
        }

        private void INFO_suscriptores_Load(object sender, EventArgs e)
        {
            this.RV_suscrip.RefreshReport();
            var adapter = new datasetConjuntoDeDatosTableAdapters.DataTable1TableAdapter();
            var d = new datasetConjuntoDeDatos.DataTable1DataTable();
            adapter.Fill(d);

            var ds = new ReportDataSource("TABLA", (DataTable)d);

            RV_suscrip.LocalReport.DataSources.Clear();
            RV_suscrip.LocalReport.DataSources.Add(ds);
            
            this.RV_suscrip.RefreshReport();
        }
    }
}
