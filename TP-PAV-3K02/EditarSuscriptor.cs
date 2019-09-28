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
using TP_PAV_3K02.BaseDatos;
namespace TP_PAV_3K02
{
    public partial class EditarSuscriptor : Form
    {
        SuscriptoresRepositorio _suscriptoresRepositorio;
        TipoDocumentoRepositorio _tipodocumentoRepositorio;
        ProvinciasRepositorio _provinciasRepositorio;
        LocalidadesRepositorio _localidadesRepositorio;
        Editorial_BD _BD;
        Suscriptor suscrip;
        public EditarSuscriptor()
        {
            InitializeComponent();
            _suscriptoresRepositorio = new SuscriptoresRepositorio();

        }
            public EditarSuscriptor(string suscriptorDOC)
            {
                InitializeComponent();
                _suscriptoresRepositorio = new SuscriptoresRepositorio();
                suscrip = _suscriptoresRepositorio.ObtenerSuscriptor(suscriptorDOC);
            }

            //cargar combos Tipo Documento
        private void ActualizarCombo()
        {
        //combo Tipo DNI
        var tip_documentos = _tipodocumentoRepositorio.ObetenerTiposDocumentosDT();
        comboTipodoc.ValueMember = "cod_TipoDoc";
        comboTipodoc.DisplayMember = "nombre";
        comboTipodoc.DataSource = tip_documentos;

        }

        //cargar combos de provincia
        private void ActualizarProvi()
        {
            var provi = _provinciasRepositorio.ObtenerProvinciasDT();
            comboProvincias.ValueMember = "cod_provincia";
            comboProvincias.DisplayMember = "nombre";
            comboProvincias.DataSource = provi;


        }

        //cargar combos de localidades (recibe un codigo de provincia)
        private void ActualizarLocalidad(string provincia)
        {

            var localidad = _localidadesRepositorio.ObtenerLocalidadesDT(provincia);
            ComboLocalidades.ValueMember = "cod_Localidad";
            ComboLocalidades.DisplayMember = "nombre";
            ComboLocalidades.DataSource = localidad;



        }

        private void EditarSuscriptor_Load(object sender, EventArgs e)
        {
            ActualizarCombo();
            comboTipodoc.SelectedIndex = 0;
            ActualizarProvi();
            comboProvincias.SelectedIndex = 6;

            TXTnombre.Text = suscrip.nombre;
            TXTapellido.Text = suscrip.apellido;
            TXTcalle.Text = suscrip.calle;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var suscriptor = new Suscriptor();

            suscriptor.nombre = TXTnombre.Text;

            suscriptor.apellido = TXTapellido.Text;

            suscriptor.calle = TXTcalle.Text;

            suscriptor.cod_TipoDoc = int.Parse(comboTipodoc.SelectedValue.ToString());

            suscriptor.cod_Provincia = int.Parse(comboProvincias.SelectedValue.ToString());
            suscriptor.cod_Localidad = int.Parse(ComboLocalidades.SelectedValue.ToString());



            if (!suscriptor.NombreValido())
            {
                MessageBox.Show("Nombre Invalido");
                return;
            }

            if (!suscriptor.ApellidoValido())
            {
                MessageBox.Show("Apellido Invalido");
                return;
            }

            if (!suscriptor.CalleValido())
            {
                MessageBox.Show("Calle Invalida");
                return;
            }


            if (!suscriptor.NroDocValido(TXTnroDoc.Text.ToString()))
            {

                MessageBox.Show("Documento Invalido");
                return;

            }

            suscriptor.nroDoc = long.Parse(TXTnroDoc.Text);

            if (!suscriptor.NumeroValido(TXTnumero.Text.ToString()))
            {
                MessageBox.Show("Numero Invalido");
                return;
            }

            suscriptor.numero = long.Parse(TXTnumero.Text);



            if (_suscriptoresRepositorio.Actualizar(suscriptor))
            {
                MessageBox.Show("Se registro con éxito");
                this.Dispose();//Libera los recursos

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProvincias.Items.Count != 0)
            {
                ActualizarLocalidad(comboProvincias.SelectedValue.ToString());

            }
            else
            {
                ComboLocalidades.DataSource = null;
                
            }
        }
    }
}

