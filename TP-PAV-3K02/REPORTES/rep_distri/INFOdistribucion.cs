using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Repositorios;

namespace TP_PAV_3K02.REPORTES.rep_distri
{
    public partial class INFOdistribucion : Form
    {
        
        public INFOdistribucion()
        {
            InitializeComponent();
            
        }
       
        private void INFOdistribucion_Load(object sender, EventArgs e)
        {
           
            
            this.RV_distribuciones.RefreshReport();

            var adapter = new dsitribuciones_DataSetTableAdapters.DataTable1TableAdapter();
            var d = new dsitribuciones_DataSet.DataTable1DataTable();
            //d = adapter.GetData(decimal.Parse(TXTcuit.Text));

            var ds = new ReportDataSource("tabla_distribucion", (DataTable)d);
            RV_distribuciones.LocalReport.DataSources.Clear();
            RV_distribuciones.LocalReport.DataSources.Add(ds);
            this.RV_distribuciones.RefreshReport();

        }

        private void RV_distribuciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            this.RV_distribuciones.RefreshReport();
            var adapter = new dsitribuciones_DataSetTableAdapters.DataTable1TableAdapter();
            var data = new dsitribuciones_DataSet.DataTable1DataTable();
            ////// obtengo datos a mostrar  
            data = adapter.GetData(decimal.Parse(TXTcuit.Text));
            var ds = new ReportDataSource("tabla_distribucion", (DataTable)data);

            RV_distribuciones.LocalReport.DataSources.Clear();
            ////// envio este parametro al reporte
            RV_distribuciones.LocalReport.DataSources.Add(ds);

            this.RV_distribuciones.RefreshReport();
        }
    }
}
