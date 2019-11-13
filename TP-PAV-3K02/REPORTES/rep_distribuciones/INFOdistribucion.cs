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
using TP_PAV_3K02.Utils;

namespace TP_PAV_3K02.REPORTES.rep_distri
{
    public partial class INFOdistribucion : Form
    {
        DistribuidoresRepositorio _distribuidoresRepositorio;
        DistribucionesRepositorio _distribucionesRepositorio;
        
        
        Distribucion distribucion;
        ValidateTextBox v;


        public INFOdistribucion()
        {
            InitializeComponent();
            
            
        }
        public INFOdistribucion(string cuit)
        {
            InitializeComponent();
            v = new ValidateTextBox();
            _distribuidoresRepositorio = new DistribuidoresRepositorio();
            _distribucionesRepositorio = new DistribucionesRepositorio();
            distribucion = _distribucionesRepositorio.ObtenerdistPorcuit(cuit);

        }

        private void INFOdistribucion_Load(object sender, EventArgs e)
        {
            TXTcuit.Text = distribucion.Cuit_dist.ToString();


            this.RV_distribuciones.RefreshReport();

            var adapter = new rep_distribuciones.dsitribuciones_DataSetTableAdapters.DataTable1TableAdapter();
            var data = new rep_distribuciones.dsitribuciones_DataSet.DataTable1DataTable();
            ////// obtengo datos a mostrar  

            data = adapter.GetData(decimal.Parse(distribucion.Cuit_dist.ToString()));
            var ds = new ReportDataSource("tabla_distribucion", (DataTable)data);
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
            var adapter = new rep_distribuciones.dsitribuciones_DataSetTableAdapters.DataTable1TableAdapter();
            var data = new rep_distribuciones.dsitribuciones_DataSet.DataTable1DataTable();
            ////// obtengo datos a mostrar  
            
            data = adapter.GetData(decimal.Parse(TXTcuit.Text));
            var ds = new ReportDataSource("tabla_distribucion", (DataTable)data);

            RV_distribuciones.LocalReport.DataSources.Clear();
            ////// envio este parametro al reporte
            RV_distribuciones.LocalReport.DataSources.Add(ds);

            this.RV_distribuciones.RefreshReport();
        }

        private void validarsolonumeros(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender, e);
        }
    }
}
