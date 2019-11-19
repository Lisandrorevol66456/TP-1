using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K02.BaseDatos;
using TP_PAV_3K02.Modelos;
using TP_PAV_3K02.Repositorios;
using TP_PAV_3K02.Utils;

namespace TP_PAV_3K02.Modulos
{
    public partial class EditarRevista : Form
    {
        FrecuenciaPublicacionRepositorio _frecuenciaPublicacionRepositorio;
        RubrosRepositorio _rubrosRepositorio;
        RevistasRepositorio _revistasRepositorio;
        ValidateTextBox v;
        Editorial_BD _BD;
        string revistaRub;
        string revistaFrec;
        string fechaRev;
        Revista revist;

        public EditarRevista(string codRevista, string frecuenciaRevista , string rubroRevista, string fecha)
        {
            InitializeComponent();
            _BD = new Editorial_BD();
            _revistasRepositorio = new RevistasRepositorio();
            _frecuenciaPublicacionRepositorio = new FrecuenciaPublicacionRepositorio();
            _rubrosRepositorio = new RubrosRepositorio();
            v = new ValidateTextBox();
            revist = _revistasRepositorio.ObtenerRevistas(codRevista);
            revistaFrec = frecuenciaRevista;
            revistaRub = rubroRevista;
            fechaRev = fecha;



        }

        public void ActualizarFrecuencia()
        {
            var frecuencia_Publi = _frecuenciaPublicacionRepositorio.ObtenerFrecuenciaPublicacionDT();
            cmbFrecuencia.ValueMember = "cod_Frecuencia";
            cmbFrecuencia.DisplayMember = "nombre";
            cmbFrecuencia.DataSource = frecuencia_Publi;


        }


        public void ActualizarRubro()
        {
            var rubros = _rubrosRepositorio.ObtenerRubrosDT();
            cmbRubro.ValueMember = "cod_Rubro";
            cmbRubro.DisplayMember = "nombre";
            cmbRubro.DataSource = rubros;
        }

    

       

        private void EditarRevista_Load(object sender, EventArgs e)
        {
            ActualizarFrecuencia();
            ActualizarRubro();
            txtcodigoInterno.Text = revist.cod_Interno.ToString();
            txtnombre.Text = revist.nombre;
            dtpFechaInicio.Text = fechaRev;
            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var revist = new Revista();
            revist.nombre = txtnombre.Text;
            revist.cod_frecPublic = int.Parse(cmbFrecuencia.SelectedValue.ToString());
            revist.cod_rubro = int.Parse(cmbRubro.SelectedValue.ToString());
            revist.fechaInicio = dtpFechaInicio.Value;


            if (!revist.NombreValido())
            {
                MessageBox.Show("Nombre Invalido");
                return;
            }



            if(!revist.CodValido(txtcodigoInterno.Text.ToString()))
            {

                MessageBox.Show("Codigo Invalido");
                return;

            }
            revist.cod_Interno = int.Parse(txtcodigoInterno.Text.ToString());

            if(!revist.fechavalida())
            {
                MessageBox.Show("La fecha ingresada no es valida");
                return;
            }


            if (_revistasRepositorio.Actualizar(revist , txtcodigoInterno.Text.ToString()))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();//Libera los recursos

            }

        }
    }
}

