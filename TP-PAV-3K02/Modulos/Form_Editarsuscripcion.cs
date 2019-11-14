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

namespace TP_PAV_3K02.Modulos
{
    public partial class Form_Editarsuscripcion : Form
    {
        PlanesRepositorio _planesrepo;
        SuscripcionesRepositorios _suscripcionesRepo;
        Suscripcion suscripcion;
        public Form_Editarsuscripcion()
        {
            InitializeComponent();
            
        }
        public Form_Editarsuscripcion(string codint)
        {
            InitializeComponent();
            _planesrepo = new PlanesRepositorio();
            _suscripcionesRepo = new SuscripcionesRepositorios();
            suscripcion = _suscripcionesRepo.Obtenerporcodint(codint);
        }


        private void Form_Editarsuscripcion_Load(object sender, EventArgs e)
        {
            CargarCombo();
            TXTcodint.Text = suscripcion.cod_int.ToString();
        }

        private void CargarCombo()
        {
            var plan = _planesrepo.obtenerPlanes();
            cmbPlanes.ValueMember = "cod_Plan";
            cmbPlanes.DisplayMember = "nombre";
            cmbPlanes.DataSource = plan;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tnAdd_Click(object sender, EventArgs e)
        {
            var suscri = new Suscripcion();
            suscri.cod_int = int.Parse(TXTcodint.Text);
            suscri.nro_doc = suscripcion.nro_doc;
            suscri.fecha_inicio = DTPfechainicio.Value;
            suscri.fecha_fin = DTPfechainicio.Value.AddYears(1);
            suscri.doc_plan = int.Parse(cmbPlanes.SelectedValue.ToString());
            if (!suscri.fechavalida())
            {
                MessageBox.Show("Fecha no valida");
            }
            if (_suscripcionesRepo.Actualizar(suscri, suscri.cod_int.ToString()))
            {
                MessageBox.Show("Actualizado con exito");
                this.Dispose();
            }
        }
    }
}
