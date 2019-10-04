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
using TP_PAV_3K02.Utils;
using TP_PAV_3K02.Repositorios;

namespace TP_PAV_3K02.Modulos
{
    public partial class Revistas : Form
    {
        FrecuenciaPublicacionRepositorio _frecuenciaPublicacionRepositorio;
        RubrosRepositorio _rubrosRepositorio;
        RevistasRepositorio _revistasRepositorio;
        ValidateTextBox v;
        Editorial_BD _BD;


        public Revistas()
        {
            InitializeComponent();
            _BD = new Editorial_BD();
            v = new ValidateTextBox();
            _rubrosRepositorio = new RubrosRepositorio();
            _revistasRepositorio = new RevistasRepositorio();
            _frecuenciaPublicacionRepositorio = new FrecuenciaPublicacionRepositorio();

        }

        private void ActualizarFrecuenciaPublicacion()
        {
            var frecuencia_Publi = _frecuenciaPublicacionRepositorio.ObtenerFrecuenciaPublicacionDT();
            cmbFrecuencia.ValueMember = "cod_Frecuencia";
            cmbFrecuencia.DisplayMember = "nombre";
            cmbFrecuencia.DataSource = frecuencia_Publi;

        }

        private void Revista_Load(object sender, EventArgs e)
        {

        }
    }
}
