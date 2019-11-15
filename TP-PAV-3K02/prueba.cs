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
using TP_PAV_3K02.REPORTES.rep_suscriptores;

namespace TP_PAV_3K02
{
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();
        }

        private void prueba_Load(object sender, EventArgs e)
        {
            var adapte = new REPORTES.rep_suscriptores.datasetConjuntoDeDatosTableAdapters.DataTable1TableAdapter();
            var dd = new datasetConjuntoDeDatos.DataTable1DataTable();
            adapte.Fill(dd);

            var ds = new ReportDataSource("tabla12", (DataTable)dd);
            rv_prueba.LocalReport.DataSources.Clear();
            rv_prueba.LocalReport.DataSources.Add(ds);
            this.rv_prueba.RefreshReport();
        }
    }
}
