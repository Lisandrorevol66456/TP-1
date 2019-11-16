using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.Repositorios;
using TP_PAV_3K02.Utils;
using TP_PAV_3K02.Modelos;

namespace TP_PAV_3K02.Modulos
{
    public partial class Publicidades : Form
    {

        EmpresasRepositorio _empresaRepo;
        RevistasRepositorio _revistaRepo;
        PublicidadRepositorio _publicidadRepo;
        ValidateTextBox v;
        public Publicidades()
        {
            InitializeComponent();
            _empresaRepo = new EmpresasRepositorio();
            _revistaRepo = new RevistasRepositorio();
            _publicidadRepo = new PublicidadRepositorio();
            v = new ValidateTextBox();
        }

        private void Publicidad_Load(object sender, EventArgs e)
        {
            CargarRevistas();
            CargarEmpresas();
            CargarMontos();
            ActualizarPublicidades(CMB_empresa.SelectedValue.ToString());

        }

        private void CargarEmpresas()
        {
            var empresa = _empresaRepo.ObtenerEmpresa();
            CMB_empresa.ValueMember = "cuit_Empresa";
            CMB_empresa.DisplayMember = "nombre";
            CMB_empresa.DataSource = empresa;
        }

        private void CargarRevistas()
        {
            var revista = _revistaRepo.ObtenerRevistasDT();
            CMB_Revista.ValueMember = "cod_Interno";
            CMB_Revista.DisplayMember = "nombre";
            CMB_Revista.DataSource = revista;
        }

        private void CargarMontos()
        {
            var monto = _revistaRepo.ObtenerMontosDT();
            CMB_monto.ValueMember = "ID_precio";
            CMB_monto.DisplayMember = "valor_precio";
            CMB_monto.DataSource = monto;
        }

        private void ActualizarPublicidades(string cuit)
        {

            DGV_publicidades.Rows.Clear();
            //var cuit = CMB_empresa.SelectedIndex;
            var publicidad = _publicidadRepo.ObtenerPublicidadporcuitDT(cuit.ToString()).Rows;
            var filas = new List<DataGridViewRow>();

            foreach (DataRow publi in publicidad)
            {
                if (publi.HasErrors)
                    continue;

                var fila = new string[]
                {
                    publi.ItemArray[0].ToString(),
                    publi.ItemArray[1].ToString(),
                    publi.ItemArray[2].ToString(),
                    publi.ItemArray[3].ToString(),
                    publi.ItemArray[4].ToString(),
                    publi.ItemArray[5].ToString(),

                };

                DGV_publicidades.Rows.Add(fila);

            }
        }

        private void CMB_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CMB_empresa.Items.Count != 0)
            {
                ActualizarPublicidades(CMB_empresa.SelectedIndex.ToString());


            }
            else
            {
               
                DGV_publicidades.DataSource = null;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var publi = new Publicidad();
            publi.cuit_Empresa = long.Parse(CMB_empresa.SelectedValue.ToString());
            publi.fecha_desde = dtp_desde.Value;
            publi.fecha_hasta = dtp_hasta.Value;
            publi.ID_revista = int.Parse(CMB_Revista.SelectedValue.ToString());
            publi.monto = int.Parse(CMB_monto.SelectedValue.ToString());

            if (!publi.fechadesdevalida())
            {
                if (!publi.fechahastavalida())
                {
                    MessageBox.Show("Fecha invalida");
                }

            }
            if (_publicidadRepo.Guardar(publi))
            {
                MessageBox.Show("Se registro con exito");
                ActualizarPublicidades(CMB_empresa.SelectedValue.ToString());
            }

        }
    }
}
