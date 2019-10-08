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
using TP_PAV_3K02.Utils;

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
        string suscriptorLOC;
        string suscriptorPROV;
        ValidateTextBox v;

        public EditarSuscriptor()
        {
            InitializeComponent();
            
        }

        public EditarSuscriptor(string suscriptorDOC, string prov, string loc)
        {
            InitializeComponent();
            _suscriptoresRepositorio = new SuscriptoresRepositorio();
            _tipodocumentoRepositorio = new TipoDocumentoRepositorio();
            _provinciasRepositorio = new ProvinciasRepositorio();
            _localidadesRepositorio = new LocalidadesRepositorio();
            _BD = new Editorial_BD();
            suscrip = _suscriptoresRepositorio.ObtenerSuscriptor(suscriptorDOC);
            suscriptorLOC = loc;
            suscriptorPROV =prov;

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
            comboProvincias.SelectedValue = int.Parse(suscriptorPROV);
            ComboLocalidades.SelectedValue = int.Parse(suscriptorLOC);
            TXTnombre.Text = suscrip.nombre;
            TXTapellido.Text = suscrip.apellido;
            TXTcalle.Text = suscrip.calle;
            TXTnroDoc.Text = suscrip.nroDoc.ToString();
            TXTnumero.Text = suscrip.numero.ToString();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            suscrip.nombre = TXTnombre.Text;

            suscrip.apellido = TXTapellido.Text;

            suscrip.calle = TXTcalle.Text;

            suscrip.cod_TipoDoc = int.Parse(comboTipodoc.SelectedValue.ToString());

            suscrip.cod_Provincia = int.Parse(comboProvincias.SelectedValue.ToString());
            suscrip.cod_Localidad = int.Parse(ComboLocalidades.SelectedValue.ToString());



            if (!suscrip.NombreValido())
            {
                MessageBox.Show("Nombre Invalido");
                return;
            }

            if (!suscrip.ApellidoValido())
            {
                MessageBox.Show("Apellido Invalido");
                return;
            }

            if (!suscrip.CalleValido())
            {
                MessageBox.Show("Calle Invalida");
                return;
            }


            if (!suscrip.NroDocValido(TXTnroDoc.Text.ToString()))
            {

                MessageBox.Show("Documento Invalido");
                return;

            }

            suscrip.nroDoc = long.Parse(TXTnroDoc.Text);

            if (!suscrip.NumeroValido(TXTnumero.Text.ToString()))
            {
                MessageBox.Show("Numero Invalido");
                return;
            }

            suscrip.numero = long.Parse(TXTnumero.Text);



            if (_suscriptoresRepositorio.Actualizar(suscrip,TXTnroDoc.Text.ToString()))
            {
                MessageBox.Show("Se actualizó con éxito");
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

        private void ValidarLetras(object sender, KeyPressEventArgs e)
        {
            v.validateSoloLetras(sender,e);
        }

        private void ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            v.ValidateSoloNumeros(sender,e);
        }

       
    }
}

