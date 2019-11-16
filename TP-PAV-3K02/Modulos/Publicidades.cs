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
            CMB_monto.SelectedIndex = -1;
            CMB_Revista.SelectedIndex = -1;
            CMB_empresa.SelectedIndex = -1;
            btnAceptar.Enabled = false;
            BTN_ver.Enabled = false;
            BTN_filtrar.Enabled = false;
            labelMENSAJE.Visible = true;
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
            CMB_monto.ValueMember = "valor_precio";
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
                btnAceptar.Enabled = true;
                BTN_ver.Enabled = true;
                BTN_filtrar.Enabled = true;
                labelMENSAJE.Visible = false;


            }
            else
            {
               
                //DGV_publicidades.DataSource = null;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var publi = new Publicidad();
            publi.cuit_Empresa = long.Parse(CMB_empresa.SelectedValue.ToString());
            publi.fecha_desde = dtp_desde.Value;
            publi.fecha_hasta = dtp_hasta.Value;


            if (!publi.fechadesdevalida())
            {
                MessageBox.Show("Fecha invalida");
                return; }

                if (!publi.fechahastavalida())
                {
                    MessageBox.Show("Fecha invalida");
                    return;
                }

            
            if(CMB_Revista.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una revista");
                return;
            }
            if (CMB_monto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el monto de la publicidad");
                return;
            }
            publi.ID_revista = int.Parse(CMB_Revista.SelectedValue.ToString());
            publi.monto = int.Parse(CMB_monto.SelectedValue.ToString());
            if (_publicidadRepo.Guardar(publi))
            {
                MessageBox.Show("Se registro con exito");
                ActualizarPublicidades(CMB_empresa.SelectedValue.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarPublicidades(CMB_empresa.SelectedValue.ToString());
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            dtp_desde.Value = DateTime.Today;
            dtp_hasta.Value = DateTime.Today;
            CMB_empresa.SelectedIndex = -1;
            CMB_monto.SelectedIndex = -1;
            CMB_Revista.SelectedIndex = -1;
            btnAceptar.Enabled = false;
            BTN_ver.Enabled = false;
            BTN_filtrar.Enabled = false;
            labelMENSAJE.Visible = true;

        }

        private void BTN_filtrar_Click(object sender, EventArgs e)
        {
            DGV_publicidades.Rows.Clear();
            var cuit = CMB_empresa.SelectedValue;
            var publicidad = _publicidadRepo.ObtenerPublicidadporcuityfechaDT(cuit.ToString(),dtpfiltrodesde.Value.ToString("yyyy-MM-dd"),dtpfiltrohasta.Value.ToString("yyyy-MM-dd")).Rows;
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
    }
    
}
